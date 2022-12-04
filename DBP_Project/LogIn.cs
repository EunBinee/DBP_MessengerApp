using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_Project
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            validateRecentLogin();
        }

        private void validateRecentLogin() // 사원번호, 비밀번호 기억하기 체크 되어있는지 판단하는 함수
        {
            string path = Directory.GetCurrentDirectory(); // 최근 로그인 정보가 존재하는 파일의 경로
            path += "\\recentLoginInfo.txt";

            FileInfo fi = new FileInfo(path); //FileInfo.Exists로 파일 존재유무 확인

            if (fi.Exists) { // 만약 파일 존재하면 읽어오기
                Stream rs = new FileStream("recentLoginInfo.txt", FileMode.Open);
                BinaryFormatter deserializer = new BinaryFormatter();

                RecentLoginInfo des = (RecentLoginInfo)deserializer.Deserialize(rs); // 역 직렬화

                if (des.isChecked == "true") // 사원번호, 비밀번호 기억하기 체크 되어 있으면 
                {
                    checkBox1.Checked = true;
                    textBox_Number.Text = des.recentId;
                    textBox_Password.Text = des.recentPwd;
                }
                else
                {
                    checkBox1.Checked = false;
                }
                rs.Close();
            }
        }

        //회원가입 버튼
        private void label_SignUp_Click(object sender, EventArgs e)
        {
            //회원가입 label
            //모달: 위에 창을 새로 띄웠다면, 아래화면을 건드릴수없음
            this.Hide();
            SignUp signUpForm = new SignUp();
            signUpForm.ShowDialog();//모달 하는 방법
            this.Close();
        }


        private void serializeFomatter(RecentLoginInfo rli) // 파라미터에 맞게 직렬화 해주는 메소드
        {
            // 현재 로그인하려는 사원번호와 pwd를 recentLofinInfo.txt에 저장
            Stream ws = new FileStream("recentLoginInfo.txt", FileMode.Create); 
            BinaryFormatter serializer = new BinaryFormatter();

            RecentLoginInfo recentLoginInfo = rli; // RecentLoginInfo 클래스에 넣어 직렬화

            serializer.Serialize(ws, recentLoginInfo); // 직렬화 수행
            ws.Close();
        }

        //로그인 버튼
        private void button_LogIn_Click(object sender, EventArgs e)
        {
            //로그인 버튼
            //사원 번호와 비밀 번호(암호화 시킨후) User테이블에 있는지 비교

            bool successLogIn = false;

            string curId = textBox_Number.Text;    //입력한 id
            string curPassword = Password_Encryption(); //입력한 password
            string beforeEncryptionPwd = textBox_Password.Text;

            string query = "SELECT * FROM talk.UserListTable";
            DataTable dt = new DataTable();
            dt = Query.GetInstance().RunQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                string id = row["id"].ToString();
                if (id == curId)
                {
                    //만약 id가 같으면 비밀번호도 확인한다.
                    string password = row["password"].ToString();

                    if (password == curPassword)
                    {
                        //로그인 성공!
                        successLogIn = true;
                        break;
                    }
                }
            }

            if (successLogIn)
            {
                if (checkBox1.Checked) // 로그인 성공하고 사원번호, 비밀번호 기억하기 체크해둔 경우 
                    serializeFomatter(new RecentLoginInfo("true", curId, beforeEncryptionPwd));
                else 
                    serializeFomatter(new RecentLoginInfo()); // 체크 안된경우 기본생성자 객체 (false, "","") 넘겨줌

                //로그인 성공
                //폼 띄우기
                GoMainForm(curId);
            }
            else
            {
                MessageBox.Show("로그인 실패.. 사원번호와 비밀번호를 다시 입력해 주세요.");
            }
        }

        //비밀번호 암호화
        private string Password_Encryption()
        {
            //암호화
            string result = Sha265.GetInstance().SHA256_password(textBox_Password.Text);
            return result;
        }

        //메인폼으로 이동
        private void GoMainForm(string curId)
        {
            //유저 정보를 저장한다. User_info
            SaveUserInfo(curId);


            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();   //회원가입을 하면 창 닫힘
        }
        
        //유저의 정보를 User_info(싱글톤)에 저장한다
        private void SaveUserInfo(string curId)
        {
            //유저 정보를 저장한다. User_info

            string query = "SELECT * FROM talk.UserListTable WHERE `id`=" + curId;
            DataTable dt = new DataTable();
            dt = Query.GetInstance().RunQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                //만약 id가 같으면 비밀번호도 확인한다.

                User_info.GetInstance().ID = curId;                                                     //사원번호
                User_info.GetInstance().Password = row["password"].ToString();      //패스워드

                User_info.GetInstance().Name = row["name"].ToString();                      //이름
                User_info.GetInstance().NickName = row["nickName"].ToString();      //닉네임

                User_info.GetInstance().Role = int.Parse(row["role"].ToString());           //관리자 여부 1은 관리자 2는 일반 사원

                User_info.GetInstance().ZipCode = row["zipCode"].ToString();               //우편번호
                User_info.GetInstance().Address = row["userAddr"].ToString();             //주소 ( ", "로 split할 수있음)
                User_info.GetInstance().ProfilePic = row["profilePic"].ToString();            //프로필 사진
            }
            query = "SELECT * FROM talk.UserDepartment WHERE `userId`=" + curId;

            DataTable dt_depart = new DataTable();
            dt_depart = Query.GetInstance().RunQuery(query);
            User_info.GetInstance().GetWorkerInfo();

            /*
            for(int i = 0 ; i < User_info.GetInstance().employees.Count; i++)
            {
                MessageBox.Show(User_info.GetInstance().employees[i].ID + ",    " + User_info.GetInstance().employees[i].Name + ",    " + User_info.GetInstance().employees[i].Team + ",    " + User_info.GetInstance().employees[i].NickName);
            }
            */

        }
    }
}
