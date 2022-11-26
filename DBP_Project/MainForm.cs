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
    public partial class MainForm : Form
    {
        TestTreeForm tf = new TestTreeForm();
        TestChatForm cf = new TestChatForm();

        public MainForm()
        {
            InitializeComponent();
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void FormMain_MouseDown(object sender, MouseEventArgs e) // 마우스로 폼 움직이는 함수
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void button6_Click(object sender, EventArgs e) // 우상단 종료버튼 눌렀을때 종료
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tf.TopLevel = false;
            tf.Show();
            this.Controls.Add(tf);
            tf.StartPosition = FormStartPosition.Manual;
            tf.Location = new Point(230, 50);

            cf.TopLevel = false;
            cf.Show();
            this.Controls.Add(cf);
            cf.StartPosition = FormStartPosition.Manual;
            cf.Location = new Point(230, 50);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cf.Hide();
            tf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tf.Hide();
            cf.Show();
        }

        private void Button_UserInfo_Change_Click(object sender, EventArgs e)
        {
            //회원 정보 변경 버튼

            InfoChange userInfoChange = new InfoChange();
            userInfoChange.ShowDialog();
        }
    }
}
