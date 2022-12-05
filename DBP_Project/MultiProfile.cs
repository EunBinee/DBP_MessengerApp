using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_Project
{
    public partial class MultiProfile : Form
    {
        int Selectnumber = 0; //체크박스 이름 뒤에 붙을 번호
        int multiProfileIndex = 0;
        string file = "default.jpg"; //파일명

        public MultiProfile()
        {
            InitializeComponent();

            //시작할때 모든 정보 넣기

            GeMultiPrifilerInfo();
        }

        //시작할때 모든 정보를 넣는다.
        void GeMultiPrifilerInfo()
        {
            multiProfileIndex = User_info.GetInstance().MultiProfileIndex;
            if (multiProfileIndex == User_info.GetInstance().myMultiProfileList.Count)
            {
                //새로 만드는 멀티 프로필이면!?

                //기본 이미지로 가야함.
                textBox_NickName.Text = User_info.GetInstance().NickName;

                pictureBox_Photo.ImageLocation = "http://15.164.218.208/forDB/" + file;
                pictureBox_Photo.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                //새로 만드는 멀티 프로필이 아니라면?!

                textBox_NickName.Text = User_info.GetInstance().myMultiProfileList[multiProfileIndex].NickName;
                pictureBox_Photo.ImageLocation = "http://15.164.218.208/forDB/" + User_info.GetInstance().myMultiProfileList[multiProfileIndex].ProfilePic;
                pictureBox_Photo.SizeMode = PictureBoxSizeMode.Zoom;

                file = User_info.GetInstance().myMultiProfileList[multiProfileIndex].ProfilePic;


                //멀티프로필 설정된 사람들.
                for (int i = 0; i < User_info.GetInstance().multiProfileEmployee[multiProfileIndex].Count; i++)
                {
                    CheckBox checkBox = new CheckBox();

                    checkBox.Name = "CheckBox_multiProfileEmployee_" + Selectnumber;
                    //Selectnumber : 체크박스 이름 뒤에 붙을 번호
                    string multiEmployeeName = "";
                    for (int j = 0; j < User_info.GetInstance().employees.Count; j++)
                    {
                        if (User_info.GetInstance().employees[j].ID == User_info.GetInstance().multiProfileEmployee[multiProfileIndex][i])
                        {
                            multiEmployeeName = User_info.GetInstance().employees[j].Name;
                        }

                    }
                    //체크박스 안 내용은 멀티프로필을 건 직원의 사원번호와 이름

                    checkBox.Text = multiEmployeeName + ",(" + User_info.GetInstance().multiProfileEmployee[multiProfileIndex][i] + ")";
                    checkBox.Width = 240;
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
                    for(int k= 0;k<User_info.GetInstance().multiProfileEmployee[j].Count;k++)
                    {
                        if (User_info.GetInstance().employees[i].ID == User_info.GetInstance().multiProfileEmployee[j][k])
                        {
                            canSetCombo = false;
                        }
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
            if(comboBox_AddMultiEmployee.SelectedIndex != -1)
            {
                CheckBox checkBox = new CheckBox();

                checkBox.Name = "CheckBox_multiProfileEmployee_" + Selectnumber;
                checkBox.Width = 240;


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
            bool checkPicture = false;
            string newFileName = "default.jpg";
            //DB에 저장 및 UserInfo의 multiProfileEmployee 변경


            List<string> multiProfileEmployeeList = new List<string>();
            if (multiProfileIndex == User_info.GetInstance().myMultiProfileList.Count)
            {
                //만약 값이 없는 경우 ==> 새로 만든 멀티 프로필일 경우

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
                                //딱 한번 사진 이름 변경
                                if (!checkPicture)
                                {
                                    checkPicture = true;
                                    //사진 
                                    if (file != "default.jpg")
                                    {

                                        Client.GetInstance().PhotoConnect();

                                        //profilePic
                                        newFileName = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".jpg";

                                        var data = Encoding.UTF8.GetBytes(newFileName);
                                        Client.GetInstance().SendByte(data);

                                        int bufferCapacity = 1024;
                                        using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
                                        {
                                            byte[] buf = new byte[bufferCapacity];
                                            int c;

                                            while ((c = fs.Read(buf, 0, buf.Length)) > 0)
                                            {
                                                Client.GetInstance().SendByte(buf);
                                            }
                                        }
                                        Client.GetInstance().PhotoClose();

                                        file = newFileName;
                                    }

                                }

                                //myMultiProfileList
                                User_info.GetInstance().myMultiProfileList.Add(new MultiProfile_Class(User_info.GetInstance().ID, textBox_NickName.Text, file));

                                useMultiProfile = true;
                            }

                            string textBoxName = ((CheckBox)control).Text;
                            //( 와 )를 삭제
                            textBoxName = textBoxName.Replace("(", "");
                            textBoxName = textBoxName.Replace(")", "");

                            //자른다.  :  [0]이 이름 , [1]이 아이디
                            string[] multiProfileArray = textBoxName.Split(',');

                            multiProfileEmployeeList.Add(multiProfileArray[1]);

                            string query = "INSERT INTO `talk`.`MultiProfile` (`doMultiProfile_Id`, `user_id`, `nickname`, `profilePic`) VALUES('" + User_info.GetInstance().ID + "', '" + multiProfileArray[1] + "', '" + textBox_NickName.Text + "','" + file + "' '');";
                            Query.GetInstance().RunQuery(query);

                        }
                    }
                }
                User_info.GetInstance().multiProfileEmployee.Add(multiProfileEmployeeList);


                //나의 멀티 프로필을 저장한다.
                if (useMultiProfile)
                {
                    this.Close();
                }
                else if (!useMultiProfile)
                {
                    this.Close();
                }
            }
            else
            {
                //값이 있는 경우 ==>원래 있는 값일 경우

                string curNickName = User_info.GetInstance().myMultiProfileList[multiProfileIndex].NickName;
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
                                //딱 한번 사진 이름 변경
                                if (!checkPicture)
                                {
                                    checkPicture = true;
                                    //사진 
                                    if ((file != "default.jpg") && file != User_info.GetInstance().myMultiProfileList[multiProfileIndex].ProfilePic)
                                    {

                                        Client.GetInstance().PhotoConnect();

                                        //profilePic
                                        newFileName = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".jpg";

                                        var data = Encoding.UTF8.GetBytes(newFileName);
                                        Client.GetInstance().SendByte(data);

                                        int bufferCapacity = 1024;
                                        using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
                                        {
                                            byte[] buf = new byte[bufferCapacity];
                                            int c;

                                            while ((c = fs.Read(buf, 0, buf.Length)) > 0)
                                            {
                                                Client.GetInstance().SendByte(buf);
                                            }
                                        }
                                        Client.GetInstance().PhotoClose();

                                        file = newFileName;
                                    }

                                }

                                //myMultiProfileList
                                User_info.GetInstance().myMultiProfileList[multiProfileIndex].ID = User_info.GetInstance().ID;
                                User_info.GetInstance().myMultiProfileList[multiProfileIndex].NickName = textBox_NickName.Text;
                                User_info.GetInstance().myMultiProfileList[multiProfileIndex].ProfilePic = file;

                                string query_ = "DELETE FROM `talk`.`MultiProfile` WHERE  `doMultiProfile_Id` = '" + User_info.GetInstance().ID + "' and `nickname` = '" + curNickName + "'";
                                Query.GetInstance().RunQuery(query_);


                                useMultiProfile = true;
                            }

                            string textBoxName = ((CheckBox)control).Text;
                            //( 와 )를 삭제
                            textBoxName = textBoxName.Replace("(", "");
                            textBoxName = textBoxName.Replace(")", "");

                            //자른다.  :  [0]이 이름 , [1]이 아이디
                            string[] multiProfileArray = textBoxName.Split(',');

                            multiProfileEmployeeList.Add(multiProfileArray[1]);

                            string query = "INSERT INTO `talk`.`MultiProfile` (`doMultiProfile_Id`, `user_id`, `nickname`, `profilePic`) VALUES('" + User_info.GetInstance().ID + "', '" + multiProfileArray[1] + "', '" + textBox_NickName.Text + "','" + file + "' '');";
                            Query.GetInstance().RunQuery(query);

                        }
                    }
                }
                //User_info.GetInstance().multiProfileEmployee.Add(multiProfileEmployeeList);
                User_info.GetInstance().multiProfileEmployee[multiProfileIndex].Clear();
                User_info.GetInstance().multiProfileEmployee[multiProfileIndex]=multiProfileEmployeeList;
                //나의 멀티 프로필을 저장한다.
                if (useMultiProfile)
                {
                    this.Close();
                }
                else if (!useMultiProfile)
                {
                    //값이 존재하면 지워준다.
                    string query_ = "DELETE FROM `talk`.`MultiProfile` WHERE  `doMultiProfile_Id` = '" + User_info.GetInstance().ID + "' and `nickname` = '" + curNickName + "'";
                    Query.GetInstance().RunQuery(query_);

                    this.Close();
                }
            }
        }

        //사진 등록
        private void button_photo_Button_Click(object sender, EventArgs e)
        {

            OpenFileDialog FD = new OpenFileDialog();
            FD.DefaultExt = "jpg";
            FD.Filter = "Images Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.png";

            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //사진 파일을 가지고 옵니다.
                file = FD.FileName; //파일명
                string[] fileName = FD.SafeFileName.Split('.'); //파일명
                string fileName_c = fileName[0];
                //확인용 메세지 박스

                //사진 입력
                pictureBox_Photo.Image = Image.FromFile(file);
                pictureBox_Photo.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }
    }
}

