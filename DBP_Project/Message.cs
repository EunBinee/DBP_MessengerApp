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
        public Message(Chat chat,string str)
        {
            InitializeComponent();
            this.chat = chat;
            this.msgBox.Text = str;
            this.msgBox.AutoSize = true;
            this.msgBox.MaximumSize = new Size(240, 0);
        }
        public Message()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Message_Load(object sender, EventArgs e)
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
            chat.notice_set(1,2);
            // 룸넘버, 챗넘버 받아와서 공지로 등록
            chat.notice_view();
            //chat.notice_view(this.msgBox.Text);
        }
        public void SetData(string name, string time)
        {
            senderName.Text = name;
            sendTimeLabel.Text = time;
        }

    }
}
