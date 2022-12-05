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
    public partial class InfoChange : Form
    {
        string file = "default.jpg"; //파일명
        //비밀 번호의 경우, 만약 비번을 옳게 쳤다면.. 아래이 재입력칸이 활성화 되도록
        string canUseIdText = "사용할 수 있는 아이디입니다.";
        string dupIdText = "이미 있는 사원번호입니다.";

        string PasswordTex_di = "비밀번호가 다릅니다.";
        string PasswordText = "비밀번호가 같습니다.";
        public MainForm mainForm;

        public InfoChange()
        {
            //회원 정보 변경을 하는 폼
            InitializeComponent();
            GetUserInfo();
            SetMultiProfileComboBox();

        }

        //처음 시작시 ==> 회원의 정보를 TEXTBOX에 넣어준다.
        public void GetUserInfo()
        {
           
            // 사진 읽기
            string filename = User_info.GetInstance().ProfilePic;

            if (filename != "")
            {
                pictureBox.ImageLocation = "http://15.164.218.208/forDB/" + filename;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                file = filename;
            }

            textBox_name.Text = User_info.GetInstance().Name;
            textBox_nickname.Text = User_info.GetInstance().NickName;
            textBox_number.Text = User_info.GetInstance().ID;

            //비번은 패스

            textBox_address1.Text = User_info.GetInstance().ZipCode;
            string[] address = User_info.GetInstance().Address.Split(new string[] { ", " }, StringSplitOptions.None);
            textBox_address2.Text = address[0];
            textBox_address3.Text = address[1];
        }

        public void SetMultiProfileComboBox()
        {
            for (int i = 0; i < User_info.GetInstance().myMultiProfileList.Count; i++)
            {
                string text = "나의 " + (i + 1) + "번째 멀티프로필";
                comboBox_myMultiProfileList.Items.Add(text);
            }
        }



        //정보변경
        private void ChangeInfo_Btn_Click(object sender, EventArgs e)
        {

            bool notEmpty = ForeachPanelControls();

            if (notEmpty)  //빈칸이 없음
            {
                if (label_DupNumber.Text == canUseIdText || textBox_number.Text == User_info.GetInstance().ID)   //사원번호 중복이 없음
                {
                    string password = "";
                    if (checkBox_Password.Checked)
                    {

                        //만약 비밀 번호 변경을 하고 싶다면

                        // 3. 재입력한 비밀번호가 같은지
                        if (label_Password.Text == PasswordText)
                        {
                            // 4. 비밀번호 암호화 해서 저장
                            password = Sha265.GetInstance().SHA256_password(textBox_ChangePass.Text);  //암호화된 비밀번호
                           

                            string address = textBox_address2.Text + ", " + textBox_address3.Text;

                            Update_DB(textBox_number.Text, password, textBox_name.Text, textBox_address1.Text, address, textBox_nickname.Text, file);

                        }
                        else
                        {
                            MessageBox.Show("비밀번호가 다릅니다. 다시 입력해주세요.");
                        }
                    }
                    else
                    {
                        password = User_info.GetInstance().Password;
                        string address = textBox_address2.Text + ", " + textBox_address3.Text;

                        Update_DB(textBox_number.Text, password, textBox_name.Text, textBox_address1.Text, address, textBox_nickname.Text, file);

                    }
                }
                else if (label_DupNumber.Text == dupIdText)
                {
                    //중복 있음
                    MessageBox.Show("사원번호가 중복입니다. 다시 확인해주세요");
                    label_DupNumber.Text = "";
                }
                else if (label_DupNumber.Text == "")
                {
                    MessageBox.Show("사원번호 중복 확인을 해주세요");
                }


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
            bool Stop = false;

            bool CheckBox_Pass = false ;
            foreach (Control control in flowLayoutPanel.Controls)
            {
                if (Stop)
                    break;

                if (control is Panel)
                {
                    //만약 Panel이면
                    foreach (Control contr in control.Controls)
                    {
                        //텍스트 박스를 만난다면
                        if (contr is TextBox)
                        {
                            if (contr.Text == "")
                            {
                                //만약 하나라도 안적혀 있다면..
                                notEmpty = false;
                                Stop = true;
                                break;
                            }
                            else
                            {
                                notEmpty = true;
                            }
                        }

                        //그룹 박스를 만난다면
                        if (contr is GroupBox)
                        {
                            foreach (Control controlGroupBox in contr.Controls)
                            {
                                if(controlGroupBox is CheckBox)
                                {
                                    //만약 체크 박스가 체크가 되어있으면, 
                                    if (checkBox_Password.Checked)
                                        CheckBox_Pass = true;
                                    else
                                        CheckBox_Pass = false;



                                }

                                if (CheckBox_Pass)
                                {
                                    if (controlGroupBox is TextBox)
                                    {
                                        if (controlGroupBox.Text == "")
                                        {
                                            //만약 하나라도 안적혀 있다면..
                                            notEmpty = false;
                                            Stop = true;
                                            break;
                                        }
                                        else
                                        {
                                            notEmpty = true;
                                        }
                                    }
                                }

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
                PasswordCheckBoxFalse();
            }
        }
        //비밀번호 바꿀지 여부 체크박스 false시 나타나는 이벤트
        void PasswordCheckBoxFalse()
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


        //사원 번호 중복체크 함수
        private void DuplicateCheckBtn_Click(object sender, EventArgs e)
        {

            SignUp signUp = new SignUp();

            //중복 확인
            if (textBox_number.Text != "" && textBox_number.Text != User_info.GetInstance().ID) 
            {
                bool isDup = signUp.DuplicateID(textBox_number.Text);
                //만약 ture면 중복인거, false이면 중복이 없는 거

                if (!isDup)
                {
                    //중복이 없음
                    label_DupNumber.Text = canUseIdText;
                    label_DupNumber.ForeColor = Color.Blue;
                }
                else
                {
                    label_DupNumber.Text = dupIdText;
                    label_DupNumber.ForeColor = Color.Red;
                }
            }

        }



        //DB에 정보를 올린다. 
        public void Update_DB(string id,string password, string name, string zipCode, string address, string nickname, string profilePic)
        {
            string newFileName = "default.jpg";
            if (profilePic != "default.jpg" && profilePic != User_info.GetInstance().ProfilePic)
            {

                Client.GetInstance().PhotoConnect();

                //profilePic
                newFileName = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".jpg";

                var data = Encoding.UTF8.GetBytes(newFileName);
                Client.GetInstance().SendByte(data);

                int bufferCapacity = 1024;
                using (FileStream fs = new FileStream(profilePic, FileMode.Open, FileAccess.Read))
                {
                    byte[] buf = new byte[bufferCapacity];
                    int c;

                    while ((c = fs.Read(buf, 0, buf.Length)) > 0)
                    {
                        Client.GetInstance().SendByte(buf);
                    }
                }
                Client.GetInstance().PhotoClose();
                profilePic = newFileName;
            }

            //DB에 회원정보를 저장->UserListTable
            string query = "UPDATE `talk`.`UserListTable` SET `id` = '" + id + "',  `password` = '" + password + "', `name` = '" + name + "',  `zipCode` = '" + zipCode + "', `userAddr` = '"
                + address + "', `nickName` = '" + nickname + "', `profilePic` = '" + profilePic + "' WHERE (`id` = '" + User_info.GetInstance().ID + "');";
            Query.GetInstance().RunQuery(query);

            MessageBox.Show("변경완료");

            //부서에 있는 값도 바꾸어준다.
            query = "UPDATE `talk`.`UserDepartment` SET `userId` = '" + id + "' WHERE `userId` = '" + User_info.GetInstance().ID + "';";
            Query.GetInstance().RunQuery(query);

            //UserInfo의 값을 변경해준다.
            User_info.GetInstance().ID = id;
            User_info.GetInstance().Password = password;
            User_info.GetInstance().Name = name;
            User_info.GetInstance().NickName = nickname;

            User_info.GetInstance().ZipCode = zipCode;
            User_info.GetInstance().Address = address;
            User_info.GetInstance().ProfilePic = profilePic;


            label_passwordRight.Text = "";
            label_DupNumber.Text = "";
            label_Password.Text = "";
            checkBox_Password.Checked = false;
            PasswordCheckBoxFalse();

            mainForm.LoadProfilePic();
            this.Close();
        }


        //비밀번호 재입력시 값이 같은지
        private void textBox_ChangePass_re_TextChanged(object sender, EventArgs e)
        {
            if (textBox_ChangePass_re.Text == "")
            {
                label_Password.Text = "";
            }
            else if (textBox_ChangePass.Text != textBox_ChangePass_re.Text)
            {
                label_Password.Text = PasswordTex_di;
                label_Password.ForeColor = Color.Red;
            }
            else if (textBox_ChangePass.Text == textBox_ChangePass_re.Text)
            {
                label_Password.Text = PasswordText;
                label_Password.ForeColor = Color.Blue;
            }
        }

        //멀티프로필 폼으로 이동. //새로운 멀티 프로필 생성
        private void button_multiProfile_Click(object sender, EventArgs e)
        {
            User_info.GetInstance().MultiProfileIndex = User_info.GetInstance().myMultiProfileList.Count;
            MultiProfile multiProfileForm = new MultiProfile();
            multiProfileForm.ShowDialog();
        }


        //사진 등록 버튼
        private void photoRegis_Btn_Click(object sender, EventArgs e)
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

                //사진 입력
                pictureBox.Image = Image.FromFile(file);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void ChangeMultiP_Btn_Click(object sender, EventArgs e)
        {
            //나의 멀티 프로필 변경

            if (comboBox_myMultiProfileList.SelectedIndex == -1)
                return;


            int myMultiProfileIndex = comboBox_myMultiProfileList.SelectedIndex;
            User_info.GetInstance().MultiProfileIndex = myMultiProfileIndex;

            MultiProfile multiProfileForm = new MultiProfile();
            multiProfileForm.ShowDialog();


        }
    }
}
