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
    public partial class Chat : Form
    {
        private string myID = "temp";
        private string yourID = "test";
        public Chat()
        {
            InitializeComponent();
        }

        private void Chat_Load(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 내가 메세지 전송
            if (msgInput.Text == "")
                return;

            Message msg = new Message(msgInput.Text);
            msg.SetMyMsg();

            Query.GetInstance().RunQuery("INSERT INTO `talk`.`ChatMsg` (`sender_ID`, `recv_ID`, `data`) VALUES ('temp', 'test', '" + msgInput.Text + "');");

            msgInput.Text = "";

            flowLayoutPanel1.Controls.Add(msg);
            flowLayoutPanel1.ScrollControlIntoView(msg);
            flowLayoutPanel1.Width = panel3.ClientSize.Width + SystemInformation.VerticalScrollBarWidth;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 상대가 메세지 전송
            Message msg = new Message(msgInput.Text);

            flowLayoutPanel1.Controls.Add(msg);
            flowLayoutPanel1.ScrollControlIntoView(msg);
            flowLayoutPanel1.Width = panel3.ClientSize.Width + SystemInformation.VerticalScrollBarWidth;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = Query.GetInstance().RunQuery("SELECT `peer` FROM talk.UserListTable WHERE `id` = '"+ yourID +"';");
            string data = "1" + dt.Rows[0][0].ToString();
            Client.GetInstance().SendMsg(data);

        }
    }
}
