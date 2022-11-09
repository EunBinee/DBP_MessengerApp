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
        // 내 ID와 상대의 ID
        private string myID = "temp";
        private string yourID = "test";
        public static Chat instance;
        public Chat()
        {
            instance = this;
            InitializeComponent();
        }

        private void Chat_Load(object sender, EventArgs e)
        {

        }

        // 메세지 전송 버튼 클릭
        private void button5_Click(object sender, EventArgs e)
        {
            // 입력한 메세지가 없다면 리턴
            if (msgInput.Text == "")
                return;

            // 메세지를 DB에 저장
            Query.GetInstance().RunQuery("INSERT INTO `talk`.`ChatMsg` (`sender_ID`, `recv_ID`, `data`) VALUES ('"+myID+"', '"+yourID+"', '" + msgInput.Text + "');");

            // TCP를 통해 수신자에게 알림
            DataTable dt = Query.GetInstance().RunQuery("SELECT `peer` FROM talk.UserListTable WHERE `id` = '" + yourID + "';");
            string data = "1" + dt.Rows[0][0].ToString();
            Client.GetInstance().SendMsg(data);

            // 메세지를 폼에 등록 및 초기화
            Message msg = new Message(msgInput.Text);
            msg.SetMyMsg();
            msgInput.Text = "";
            flowLayoutPanel1.Controls.Add(msg);
            flowLayoutPanel1.ScrollControlIntoView(msg);
            flowLayoutPanel1.Width = panel3.ClientSize.Width + SystemInformation.VerticalScrollBarWidth;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RecieveMsg();
        }

        // TCP를 통해 메세지를 받았을 때 호출
        public void RecieveMsg()
        {
            // 송신자로부터 알림 받음
            DataTable dt = Query.GetInstance().RunQuery("SELECT `data`,`id` FROM talk.ChatMsg WHERE `sender_ID` = '" + yourID + "' AND `recv_ID` = '" + myID + "' AND `read_check` = '1';");
            //UPDATE `talk`.`ChatMsg` SET `read_check` = '0' WHERE (`id` = '14');


            // 상대가 전송한 메세지 폼에 그리기
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // 메세지 읽음 표시
                string id = dt.Rows[i][1].ToString();
                Query.GetInstance().RunQuery("UPDATE `talk`.`ChatMsg` SET `read_check` = '0' WHERE `sender_ID` = '" + yourID + "' AND `recv_ID` = '" + myID + "' AND (`id` = '" + id +"');");

                // 상대가 전송한 메세지
                Message msg = new Message(dt.Rows[i][0].ToString());
                flowLayoutPanel1.Controls.Add(msg);
                flowLayoutPanel1.ScrollControlIntoView(msg);
            }

            flowLayoutPanel1.Width = panel3.ClientSize.Width + SystemInformation.VerticalScrollBarWidth;
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
