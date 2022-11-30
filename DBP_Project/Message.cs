using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_Project
{
    public partial class Message : UserControl
    {
        private Chat chat;
        public string link;
        public Message()
        {
            InitializeComponent();
        }
        public Message(Chat chat,string str, bool isFile = false)
        {
            InitializeComponent();
            this.chat = chat;
            this.msgBox.Text = str;
            this.msgBox.AutoSize = true;
            this.msgBox.MaximumSize = new Size(240, 0);
            SetSize();

            if (isFile == true)
                SetLink(str);
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Message_Load(object sender, EventArgs e)
        {
        }

        private void SetSize()
        {
            int size = (msgBox.Text.Length / 35) - 1;
            this.Size = new Size(this.Size.Width, (120 + 25 * size));   
        }

        public void SetDefault()
        {
            this.senderImg.Visible = true;
            this.senderName.Visible = true;
            backPanel.Location = new Point(90, 36);
            sendTimeLabel.Location = new Point(270, 20);
        }
        public void SetMyMsg()
        {
            this.senderImg.Visible = false;
            this.senderName.Visible = false;
            backPanel.Location = new Point(110, 36);
            sendTimeLabel.Location = new Point(290, 20);
            msgBox.BackColor = SystemColors.Info;
            backPanel.BackColor = SystemColors.Info;

        }

        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void 공지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = this.msgBox.Text;
            DataTable dt = Query.GetInstance().RunQuery("Select id from ChatMsg where data = '" + str + "'");
            int chatID = Convert.ToInt32(dt.Rows[0][0]);
            chat.notice_set(chatID);
            chat.notice_view();
        }
        public void SetData(string name, string time)
        {
            senderName.Text = name;
            sendTimeLabel.Text = time;
        }
        public void SetSenderImg(string str)
        {
            senderImg.ImageLocation = str;
        }
        public void SetImageMsg(string str)
        {
            pictureBox1.ImageLocation = str;
            pictureBox1.Visible = true;
            msgBox.Visible = false;
        }

        public void SetLink(string str)
        {
            linkLabel1.Visible = true;
            linkLabel1.Text = str;
            link = "http://15.164.218.208/forDB/" + str;
            msgBox.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(link);
        }
    }
}
