﻿using System;
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

        //처음 시작시 ==> 회원의 정보를 TEXTBOX에 넣어준다.
        public void GetUserInfo()
        {


            textBox_name.Text = User_info.GetInstance().Name;
            textBox_nickname.Text = User_info.GetInstance().NickName;
            textBox_number.Text = User_info.GetInstance().ID;

            //비번은 패스

            textBox_address1.Text = User_info.GetInstance().ZipCode;
            string[] address = User_info.GetInstance().Address.Split(new string[] { ", " }, StringSplitOptions.None);
            textBox_address2.Text = address[0];
            textBox_address3.Text = address[1];
        }



        //정보변경
        private void ChangeInfo_Btn_Click(object sender, EventArgs e)
        {

            bool notEmpty = ForeachPanelControls();

            if (notEmpty)  //빈칸이 없음
            {

                MessageBox.Show("빈 칸이 없어요~.");

            }
            else
            {
                //빈 칸이 있음
                MessageBox.Show("빈 칸이 있습니다. 빈 칸을 채워주세요.");
            }

        }

        //회원가입할때 덜 적은 TextBox와 ComboBox가 있는지 확인
        public bool ForeachPanelControls()
        {
            //패널안에 있는 control들을 확인
            // 값이 비었는지 확인
            bool notEmpty = false;

            foreach (Control control in flowLayoutPanel.Controls)
            {
                if (control is Panel)
                {
                    //만약 Panel이면
                    foreach (Control contr in control.Controls)
                    {
                        if (contr is TextBox)
                        {
                            MessageBox.Show(contr.Text);

                            if (contr.Text == "")
                            {
                                //만약 하나라도 안적혀 있다면..
                                notEmpty = false;
                                break;
                            }
                            else
                            {
                                notEmpty = true;
                            }
                        }

                        if (contr is GroupBox)
                        {
                            //만약에 그룹 박스라면.. 
                            foreach (Control controlGroupBox in contr.Controls)
                            {



                            }
                        }
                        
                    }
                }
            }
            return notEmpty;
        }

        //비밀번호를 바꿀지 여부 (체크박스)
        private void checkBox_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Password.Checked)
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

                textBox_ChangePass.Text = "";
                textBox_ChangePass.BackColor = SystemColors.ControlLight;
                textBox_ChangePass.Enabled = false;

                textBox_ChangePass_re.Text = "";
                textBox_ChangePass_re.BackColor = SystemColors.ControlLight;
                textBox_ChangePass_re.Enabled = false;
            }
        }

        //비밀 번호 변경시 현재 비밀 번호가 맞는지 확인
        private void passwordCheck_Btn_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();

            string result = Sha265.GetInstance().SHA256_password(textBox_curPassword.Text);

            string cur_Password = User_info.GetInstance().Password;

            if (cur_Password == result)
            {
                //현재 비밀번호가 맞다면?
                label_passwordRight.Text = "비밀번호가 맞습니다.";
                textBox_ChangePass.BackColor = SystemColors.Window;
                textBox_ChangePass.Enabled = true;
                textBox_ChangePass_re.BackColor = SystemColors.Window;
                textBox_ChangePass_re.Enabled = true;
            }
            else
            {
                label_passwordRight.Text = "비밀번호가 틀립니다.";
            }
        }


    }
}
