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
    public partial class InfoChange : Form
    {
        //비밀 번호의 경우, 만약 비번을 옳게 쳤다면.. 아래이 재입력칸이 활성화 되도록

        public InfoChange()
        {
            //회원 정보 변경을 하는 폼
            InitializeComponent();
            GetUserInfo();
        }

        //회원의 정보를 TEXTBOX에 넣어준다.
        public void GetUserInfo()
        {
           
            // 사진 읽기
            string query = "SELECT profilePic FROM talk.UserListTable WHERE id = '" + User_info.GetInstance().ID + "'";
            DataTable dt = Query.GetInstance().RunQuery(query);
            string filename = dt.Rows[0][0].ToString();

            if (filename != "")
            {
                pictureBox.ImageLocation = "http://15.164.218.208/forDB/" + filename;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }


            textBox_Name.Text = User_info.GetInstance().Name;
            textBox_NickName.Text = User_info.GetInstance().NickName;
            textBox_Number.Text = User_info.GetInstance().ID;

            //비번은 패스

            textBox_address1.Text = User_info.GetInstance().ZipCode;
            string[] address = User_info.GetInstance().Address.Split(new string[] { ", " }, StringSplitOptions.None);
            textBox_address2.Text = address[0];
            textBox_address3.Text = address[1];
        }



        private void button_PasswordCheck_Click(object sender, EventArgs e)
        {
            //비밀 번호 변경시 현재 비밀 번호가 맞는지 확인
            SignUp signUp = new SignUp();

            string result = Sha265.GetInstance().SHA256_password(textBox_curPassword.Text);

            string cur_Password = User_info.GetInstance().Password;

            if (cur_Password == result)
            {
                //현재 비밀번호가 맞다면?
                label_passwordRight.Text = "비밀번호가 맞습니다.";
                textBox_Password.BackColor = SystemColors.Window;
                textBox_Password.Enabled = true;
                textBox_Password_re.BackColor = SystemColors.Window;
                textBox_Password_re.Enabled = true;
            }
            else
            {
                label_passwordRight.Text = "비밀번호가 틀립니다.";
            }
        }

        private void checkBox_ChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            //비밀번호를 바꿀지 여부

            if(checkBox_ChangePassword.Checked)
            {
                //체크됐으면
                textBox_curPassword.Enabled = true;
                textBox_curPassword.BackColor = SystemColors.Window;
            }
            else
            {
                textBox_curPassword.Text = "";
                textBox_curPassword.BackColor = SystemColors.ControlLight;
                textBox_curPassword.Enabled = false;

                textBox_Password.Text = "";
                textBox_Password.BackColor = SystemColors.ControlLight;
                textBox_Password.Enabled = false;

                textBox_Password_re.Text = "";
                textBox_Password_re.BackColor = SystemColors.ControlLight;
                textBox_Password_re.Enabled = false;
            }
        }
    }
}
