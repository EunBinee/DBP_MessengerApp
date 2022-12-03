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
    public partial class MultiProfile : Form
    {
        int Selectnumber = 0; //체크박스 이름 뒤에 붙을 번호
        public MultiProfile()
        {
            InitializeComponent();

            //시작할때 모든 정보 넣기

            GeMultiPrifilerInfo();
        }

        //시작할때 모든 정보를 넣는다.
        void GeMultiPrifilerInfo()
        {
            if (User_info.GetInstance().MyMultiProfile.NickName == "" && User_info.GetInstance().MyMultiProfile.ProfilePic == "")
            {
                //만약 둘 다 빈칸이면 멀티프로필을 설정 안한 것이다.
                if (User_info.GetInstance().multiProfileEmployee.Count == 0)
                {
                    //그리고 만약 아무도 설정을 안했다면.. 기본 이미지로 가야함.
                    textBox_NickName.Text = User_info.GetInstance().NickName;
                    //pictureBox_Photo.Image = User_info.GetInstance().ProfilePic;
                }

            }
            else
            {
                //처음 이미지 변경
                //pictureBox_Photo.Image =
                //닉네임 변경
                textBox_NickName.Text = User_info.GetInstance().MyMultiProfile.NickName;

                //멀티프로필 설정된 사람들.
                for (int i = 0; i < User_info.GetInstance().multiProfileEmployee.Count; i++)
                {
                    CheckBox checkBox = new CheckBox();

                    checkBox.Name = "CheckBox_multiProfileEmployee_" + Selectnumber;
                    //Selectnumber : 체크박스 이름 뒤에 붙을 번호
                    string multiEmployeeName = "";
                    for (int j = 0; j < User_info.GetInstance().employees.Count; j++)
                    {
                        if (User_info.GetInstance().employees[j].ID == User_info.GetInstance().multiProfileEmployee[i])
                        {
                            multiEmployeeName = User_info.GetInstance().employees[j].Name;
                        }

                    }
                    //체크박스 안 내용은 멀티프로필을 건 직원의 사원번호와 이름

                    checkBox.Text = multiEmployeeName + ",(" + User_info.GetInstance().multiProfileEmployee[i] + ")";
                    checkBox.Width = 250;
                    checkBox.Checked = true;

                    flowLayoutPanel_MultiProfile.Controls.Add(checkBox);
                    Selectnumber++; //체크박스 이름 뒤에 붙을 번호
                }

            }
            //----------------------------------------------------------------------------------------------------------------------------------------------------------
            //콤보 박스 변경 (현재 내가 멀티프로필 걸어둔 사람들 빼고)
            comboBox_AddMultiEmployee.Items.Clear();

            for (int i = 0; i < User_info.GetInstance().employees.Count; i++)
            {
                bool canSetCombo = true;
                for (int j = 0; j < User_info.GetInstance().multiProfileEmployee.Count; j++)
                {
                    if (User_info.GetInstance().employees[i].ID == User_info.GetInstance().multiProfileEmployee[j])
                    {
                        canSetCombo = false;
                    }
                }

                if (canSetCombo)
                {
                    string employee = User_info.GetInstance().employees[i].Name + ",(" + User_info.GetInstance().employees[i].ID + ")";
                    comboBox_AddMultiEmployee.Items.Add(employee);
                }
            }

        }

        //추가 버튼
        private void button_addMultiEmployee_Click(object sender, EventArgs e)
        {
            if (comboBox_AddMultiEmployee.SelectedItem.ToString() != "")
            {
                CheckBox checkBox = new CheckBox();

                checkBox.Name = "CheckBox_multiProfileEmployee_" + Selectnumber;
                checkBox.Width = 250;


                checkBox.Text = comboBox_AddMultiEmployee.SelectedItem.ToString();

                checkBox.Checked = true;

                flowLayoutPanel_MultiProfile.Controls.Add(checkBox);

                Selectnumber++; //체크박스 이름 뒤에 붙을 번호

                SetComboBox();
            }
        }

        //추가버튼을 눌러서 값을 추가하면, 그 추가한 값을 콤보박스에서 제외한다.
        void SetComboBox()
        {
            int index = comboBox_AddMultiEmployee.SelectedIndex;
            comboBox_AddMultiEmployee.Items.RemoveAt(index);
            comboBox_AddMultiEmployee.SelectedItem = "";
        }


        //변경 버튼
        private void Change_Button_Click(object sender, EventArgs e)
        {

            bool useMultiProfile = false; //멀티 프로필을 사용하는지 여부

            //DB에 저장 및 UserInfo의 multiProfileEmployee 변경
            foreach (Control control in flowLayoutPanel_MultiProfile.Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Checked)
                    {
                        //만약 체크되어있다면, DB에 올리기
                        //그리고 UserInfo의 값도 변경

                        if (!useMultiProfile)
                        {
                            if (User_info.GetInstance().multiProfileEmployee.Count > 0) 
                            {
                                //값이 존재하면 지워준다.
                                string query_ = "DELETE FROM `talk`.`MultiProfile` WHERE  `doMultiProfile_Id` = '" + User_info.GetInstance().ID + "'";
                                Query.GetInstance().RunQuery(query_);
                            }

                            User_info.GetInstance().multiProfileEmployee.Clear();
                            useMultiProfile = true;
                        }


                        string textBoxName = ((CheckBox)control).Text;
                        //( 와 )를 삭제
                        textBoxName = textBoxName.Replace("(", "");
                        textBoxName = textBoxName.Replace(")", "");

                        //자른다.  :  [0]이 이름 , [1]이 아이디
                        string[] multiProfileArray = textBoxName.Split(',');


                        User_info.GetInstance().multiProfileEmployee.Add(multiProfileArray[1]);

                        string query = "INSERT INTO `talk`.`MultiProfile` (`doMultiProfile_Id`, `user_id`, `nickname`, `profilePic`) VALUES('" + User_info.GetInstance().ID + "', '" + multiProfileArray[1] + "', '" + textBox_NickName.Text + "', '');";
                        Query.GetInstance().RunQuery(query);
                        
                    }
                }
            }

            //나의 멀티 프로필을 저장한다.
            if (useMultiProfile)
            {
                User_info.GetInstance().SetMyMultiProfile(textBox_NickName.Text, "");

                MessageBox.Show("변경완료!");
            }
        }


    }
}
