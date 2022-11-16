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

        private void label_SignUp_Click(object sender, EventArgs e)
        {
            //회원가입 label
            //모달: 위에 창을 새로 띄웠다면, 아래화면을 건드릴수없음
            SignUp signUpForm = new SignUp();
            signUpForm.ShowDialog();//모달 하는 방법

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
                GoMainForm();
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
            MessageBox.Show(result);
            return result;
        }

        //메인폼으로 이동
        private void GoMainForm()
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();//모달 하는 방법

            this.Hide();
        }


    }
}
