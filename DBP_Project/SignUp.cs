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
    public partial class SignUp : Form
    {
        string canUseIdText = "사용할 수 있는 아이디입니다.";
        string dupIdText = "이미 있는 사원번호입니다.";

        string PasswordTex_di = "비밀번호가 다릅니다.";
        string PasswordText = "비밀번호가 같습니다.";

        public SignUp()
        {
            InitializeComponent();
            label_DupNumber.Text = "";
        }

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
                    if(label_Password.Text == PasswordText)
                    {
                        // 4. 비밀번호 암호화 해서 저장


                        //-----------------------------------------------------------------
                        //다하면  SignUp_DB();
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

        private void button_photo_Button_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //사진 파일을 가지고 옵니다.
                string file = FD.FileName; //파일명
                string[] fileName = FD.SafeFileName.Split('.'); //파일명
                string fileName_c = fileName[0];
                //확인용 메세지 박스
                MessageBox.Show(file);
                MessageBox.Show(fileName[0]);
                MessageBox.Show(fileName[1]);

                //사진 입력
                pictureBox_Photo.Image = Image.FromFile(file);
                pictureBox_Photo.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

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


        public bool ForeachPanelControls()
        {
            //패널안에 있는 control들을 확인
            // 값이 비었는지 확인
            bool notEmpty = false;
            foreach(Control control in flowLayoutPanel2.Controls)
            {
                if (control is Panel)
                {
                    //만약 Panel이면
                    foreach(Control contr in control.Controls)
                    {
                        if(contr is TextBox)
                        {
                            if(contr.Text == "")
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
                    }
                    if(comboBox_Department.Text == "" || comboBox_team.Text == "")
                    {
                        notEmpty = false;
                    }
                }
            }
            return notEmpty;
        }

        public bool DuplicateID()
        {
            //0이 중복되는 것 1이 중복안되는 것
            bool isDup = false;  
            string query = "select(Case When '" + textBox_Number.Text + "' = id Then 0 else 1 End) as '중복' From `UserListTable`; ";
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

        public void SignUp_DB()
        {
            //DB에 회원정보를 저장


        }



        private void button1_Click(object sender, EventArgs e)
        {
            //중복 확인
            bool isDup = DuplicateID();
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
    }
}