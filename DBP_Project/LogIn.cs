using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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


        //로그인 버튼
        private void button_LogIn_Click(object sender, EventArgs e)
        {
            //로그인 버튼
            //사원 번호와 비밀 번호(암호화 시킨후) User테이블에 있는지 비교

            bool successLogIn = false;

            string curId = textBox_Number.Text;    //입력한 id
            string curPassword = Password_Encryption(); //입력한 password

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



        }
        

    }
}
