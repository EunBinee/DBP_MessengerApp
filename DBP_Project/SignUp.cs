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
    public partial class SignUp : Form
    {
        string file = ""; //파일명

        string canUseIdText = "사용할 수 있는 아이디입니다.";
        string dupIdText = "이미 있는 사원번호입니다.";

        string PasswordTex_di = "비밀번호가 다릅니다.";
        string PasswordText = "비밀번호가 같습니다.";

        
        DataTable dt_Depart;    //부서를 담고있는 dt
        string cur_Depart = "";          //현재 선택된 부서



        public SignUp()
        {
            InitializeComponent();
            label_DupNumber.Text = "";

            AddComboBox();
        }


        private void AddComboBox()
        {
            //comboBox2.Items.Add("회사원");
            //id를 저장한다.
            //읽을 때마다 preID와 값이 같은지 확인
            //만약 같지않다면, preID에 값을 넣어주고, 부서 콤보박스와 팀콤보박스의 값을 바꿔준다.
            //같다면 팀 콤보박스의 값만 바꿔준다.


            int preId=0; //이전 부서 ID

            string query = "SELECT * FROM talk.departmentList;";
            dt_Depart = new DataTable();
            dt_Depart = Query.GetInstance().RunQuery(query);

            foreach (DataRow row in dt_Depart.Rows)
            {
                int id = int.Parse(row["departmentId"].ToString());

                if (preId != id) //부서가 같다면 팀 콤보박스의 값만 바꿔준다.
                {
                    preId = id;

                    string depart = row["departmentName"].ToString();
                    // string team = row["teamName"].ToString();

                    comboBox_Department.Items.Add(depart);
                    // comboBox_team.Items.Add(team);
                }

            }
        }

        //등록하기 버튼
        private void SignUp_Button_Click(object sender, EventArgs e)
        {

            //회원가입 버튼을 눌렀을 때, 확인 할 것
            // 1. 비어있는 칸이 있는지
            //foreach문으로 control중 텍스트 박스에 빈곳이 있는지 확인, 사진 등록도 했는지 확인
            bool notEmpty;
            bool isDup;

            notEmpty = ForeachPanelControls();

            if(notEmpty)  //모든 칸이 채워져있음
            {
                if (label_DupNumber.Text == canUseIdText)   //중복이 없음
                {
                    // 3. 재입력한 비밀번호가 같은지
                    if (label_Password.Text == PasswordText)
                    {
                        // 4. 비밀번호 암호화 해서 저장
                        string password_Encryption = Password_Encryption();  //암호화된 비밀번호

                        string address = textBox_address2.Text + ", " + textBox_address3.Text;


                        //-----------------------------------------------------------------
                        //다하면  SignUp_DB();
                        SignUp_DB(textBox_Number.Text, password_Encryption, textBox_Name.Text, "2", textBox_address1.Text, address, textBox_NickName.Text, file);

                        this.Hide();
                        LogIn login = new LogIn();
                        login.ShowDialog();
                        this.Close();   //회원가입을 하면 창 닫힘
                    }
                    else
                    {
                        MessageBox.Show("비밀번호가 다릅니다. 다시 입력해주세요.");
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
                MessageBox.Show("빈 칸이 있습니다.");
            }

        }
        
        //사진 등록 버튼
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
                MessageBox.Show(file);
                MessageBox.Show(fileName[0]);
                MessageBox.Show(fileName[1]);

                //사진 입력
                pictureBox_Photo.Image = Image.FromFile(file);
                pictureBox_Photo.SizeMode = PictureBoxSizeMode.Zoom;
                MessageBox.Show(file);
            }
        }

        //우편번호 찾기 버튼
        private void button_addressButton_Click(object sender, EventArgs e)
        {
            //우편번호 찾기
            Address address = new Address();
            address.ShowDialog();

            // 창이 닫히면 반환값을 반환한다.
            if (address.gstrZipCode != "")
            {
                textBox_address1.Text = address.gstrZipCode;
                textBox_address2.Text = address.gstrAddress1;
            }

            address = null;
        }

        //중복 확인 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            //중복 확인
            if( textBox_Number.Text !="")
            {
                bool isDup = DuplicateID(textBox_Number.Text);
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

        //비밀번호 재입력할때 제대로 적었는지 
        private void textBox_Password_re_TextChanged(object sender, EventArgs e)
        { 
            if(textBox_Password_re.Text=="")
            {
                label_Password.Text = "";
            }
            else if (textBox_Password.Text != textBox_Password_re.Text)
            {
                label_Password.Text = PasswordTex_di;
                label_Password.ForeColor = Color.Red;
            }
            else if(textBox_Password.Text == textBox_Password_re.Text)
            {
                label_Password.Text = PasswordText;
                label_Password.ForeColor = Color.Blue;
            }
        }


        //회원가입할때 덜 적은 TextBox와 ComboBox가 있는지 확인
        public bool ForeachPanelControls()
        {
            //패널안에 있는 control들을 확인
            // 값이 비었는지 확인
            bool notEmpty = false;
            bool Stop = false;
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                if (Stop)
                    break;
                if (control is Panel)
                {
                    //만약 Panel이면
                    foreach (Control contr in control.Controls)
                    {
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
                    }
                    if (comboBox_Department.Text == "" || comboBox_team.Text == "")
                    {
                        notEmpty = false;
                    }
                }
            }
            return notEmpty;
        }

        //중복되는 아이디가 있는지 체크
        public bool DuplicateID(string ID)
        {
            //0이 중복되는 것 1이 중복안되는 것
            bool isDup = false;
            string query = "select(Case When '" + ID + "' = id Then 0 else 1 End) as '중복' From `UserListTable`; ";
            DataTable dt = new DataTable();
            dt = Query.GetInstance().RunQuery(query);
            // MessageBox.Show(query);
            foreach (DataRow row in dt.Rows)
            {

                int DupID = int.Parse(row["중복"].ToString());
                if (DupID == 0)
                {
                    //MessageBox.Show(DupID.ToString());
                    isDup = true;
                    break;
                }
                else
                {
                    //MessageBox.Show(DupID.ToString());
                    isDup = false;
                }
            }

            return isDup;
        }

        //비밀번호 암호화
        private string Password_Encryption()
        {
            //암호화
            string result = Sha265.GetInstance().SHA256_password(textBox_Password.Text);
            MessageBox.Show(result);
            return result;
        }

        //DB에 정보를 올린다.
        public void SignUp_DB(string id, string password, string name, string admin, string zipCode, string address, string nickname, string profilePic)
        {
            Client.GetInstance().PhotoConnect();

            //profilePic
            string newFileName = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".jpg";

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


            //DB에 회원정보를 저장->UserListTable
            string query = "INSERT INTO `talk`.`UserListTable` (`id`, `password`, `name`, `role`, `zipCode`, `userAddr`, `nickName`, `profilePic`) " +
                "VALUES ('" + id + "', '" + password + "', '" + name + "', '" + admin + "', '" + zipCode + "', '" + address + "', '" + nickname + "', '" + newFileName + "');";

            Query.GetInstance().RunQuery(query);

            query = "INSERT INTO `talk`.`UserDepartment` (`departmentId`, `userId`, `departmentName`, `teamName`) " +
                "VALUES ('" + (comboBox_Department.SelectedIndex + 1).ToString() + "', '" + id + "', '"
                + comboBox_Department.SelectedItem.ToString() + "', '" + comboBox_team.SelectedItem.ToString() + "');";
            Query.GetInstance().RunQuery(query);
        }


        private void comboBox_team_Click(object sender, EventArgs e)
        {
        
            //부서 콤보박스에 값이 들어가있는 경우, 바꾸기
            if(cur_Depart != comboBox_Department.SelectedItem.ToString())
            {
                //부서 선택이 바뀌었으니, 갱신해줘야함.
                cur_Depart = comboBox_Department.SelectedItem.ToString();
                foreach (DataRow row in dt_Depart.Rows)
                {
                    string department = row["departmentName"].ToString();


                    if (department == comboBox_Department.SelectedItem.ToString())
                    {
                        //만약 부서가 같다면
                        string team = row["teamName"].ToString();
                        comboBox_team.Items.Add(team);
                    }

                }
            }
          
        }


        private void comboBox_Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cur_Depart != comboBox_Department.SelectedItem.ToString())
            {
                
                comboBox_team.Items.Clear();
                comboBox_team.Text = "";
            }
        }

    }
}