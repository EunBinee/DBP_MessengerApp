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
        UserManagerForm userManagerForm = new UserManagerForm();
        ManagerForm managerForm = new ManagerForm();

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


            managerForm.TopLevel = false;
            managerForm.Show();
            this.Controls.Add(managerForm);
            managerForm.StartPosition = FormStartPosition.Manual;
            managerForm.Location = new Point(230, 50);

            userManagerForm.TopLevel = false;
            userManagerForm.Show();
            this.Controls.Add(userManagerForm);
            userManagerForm.StartPosition = FormStartPosition.Manual;
            userManagerForm.Location = new Point(230, 50);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cf.Hide();
            managerForm.Hide();
            userManagerForm.Hide();
            tf.Show();
            toUserMangerForm.Hide();
            toManagerForm.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tf.Hide();
            managerForm.Hide();
            userManagerForm.Hide();
            cf.Show();
            toUserMangerForm.Hide();
            toManagerForm.Hide();
        }

        private void Move_Admin_Click(object sender, EventArgs e)
        {
            tf.Hide();
            cf.Hide();
            userManagerForm.Hide();
            managerForm.Show();
            toUserMangerForm.Show();
            toManagerForm.Hide();
            // this.Visible = false;
            // ManagerForm ShowmanagerForm = new ManagerForm();
            // ShowmanagerForm.ShowDialog();
        }


        private void toUserMangerForm_Click(object sender, EventArgs e)
        {
            managerForm.Hide();
            userManagerForm.Show();
            toUserMangerForm.Hide();
            toManagerForm.Show();
        }

        private void toManagerForm_Click(object sender, EventArgs e)
        {
            userManagerForm.Hide();
            managerForm.Show();
            toUserMangerForm.Show();
            toManagerForm.Hide();
        }
        // private void adminBtn_Click(object sender, EventArgs e)
        // {
        //     tf.Hide();
        //     cf.Hide();

        //     userManagerForm.TopLevel = false;
        //     userManagerForm.Show();
        //     this.Controls.Add(userManagerForm);
        //     userManagerForm.StartPosition = FormStartPosition.Manual;
        //     userManagerForm.Location = new Point(230, 35);
        // }
    }
}
