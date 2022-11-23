﻿using System;
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
        public static string myID = "temp";
        private static string yourID = "test";
        public static Chat instance;
        public Chat()
        {
            instance = this;
            InitializeComponent();
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            MessageBox.Show("대화내용을 불러옵니다.");
            LoadChatByRoomId(1);
        }

        // 메세지 전송 버튼 클릭
        private void button5_Click(object sender, EventArgs e)
        {
            // 입력한 메세지가 없다면 리턴
            if (msgInput.Text == "")
                return;

            string time = ConfigManager.GetInstance().GetTimeNow();

            // 메세지를 DB에 저장
            Query.GetInstance().RunQuery("INSERT INTO `talk`.`ChatMsg` (`sender_ID`, `recv_ID`, `data`,`send_time`) " +
                "VALUES ('"+myID+"', '"+yourID+"', '" + msgInput.Text + "','" + time + "');");

            // TCP를 통해 수신자에게 알림 + 비로그인시 예외처리 해야함
            DataTable dt = Query.GetInstance().RunQuery("SELECT `peer` FROM talk.UserListTable WHERE `id` = '" + yourID + "';");
            string data = "1" + dt.Rows[0][0].ToString();
            Client.GetInstance().SendMsg(data);

            // 메세지를 폼에 등록 및 초기화
            SendMsg(msgInput.Text,time);
        }

        private void SendMsg(string text,string time)
        {
            Message msg = new Message(text);
            msg.SetMyMsg();
            msg.SetData("", time);
            msgInput.Text = "";
            flowLayoutPanel1.Controls.Add(msg);
            flowLayoutPanel1.ScrollControlIntoView(msg);
            flowLayoutPanel1.Width = panel3.ClientSize.Width + SystemInformation.VerticalScrollBarWidth;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RecieveMsg();
        }

        private void DrawMsg(string text,string name, string time)
        {
            Message msg = new Message(text);
            msg.SetData(name, time);
            flowLayoutPanel1.Controls.Add(msg);
            flowLayoutPanel1.ScrollControlIntoView(msg);
        }

        // TCP를 통해 메세지를 받았을 때 호출
        public void RecieveMsg()
        {
            // 송신자로부터 알림 받음
            DataTable dt = Query.GetInstance().RunQuery("SELECT `data`,`sender_ID`,`send_time` FROM talk.ChatMsg WHERE `sender_ID` = '" + yourID + "' AND `recv_ID` = '" + myID + "' AND `read_check` = '1';");
            //UPDATE `talk`.`ChatMsg` SET `read_check` = '0' WHERE (`id` = '14');

            // 상대가 전송한 메세지 폼에 그리기
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // 메세지 읽음 표시
                string text = dt.Rows[i][0].ToString();
                string id = dt.Rows[i][1].ToString();
                string time = dt.Rows[i][2].ToString();

                Query.GetInstance().RunQuery("UPDATE `talk`.`ChatMsg` SET `read_check` = '0' WHERE `sender_ID` = '" + yourID + "' AND `recv_ID` = '" + myID + "';"); //' AND (`id` = '" + id +"'

                // 상대가 전송한 메세지
                DrawMsg(text, id, time);
            }

            flowLayoutPanel1.Width = panel3.ClientSize.Width + SystemInformation.VerticalScrollBarWidth;
        }



        // 해당 방 메세지 전부 로드
        public void LoadChatByRoomId(int roomId)
        {
            // 송신자로부터 알림 받음
            DataTable dt = Query.GetInstance().RunQuery("SELECT `data`,`sender_ID`,`send_time` FROM talk.ChatMsg WHERE `room_ID` = '" + roomId + "';");

            // 상대가 전송한 메세지 폼에 그리기
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // 메세지 읽음 표시
                string text = dt.Rows[i][0].ToString();
                string id = dt.Rows[i][1].ToString();
                string time = dt.Rows[i][2].ToString();

                Query.GetInstance().RunQuery("UPDATE `talk`.`ChatMsg` SET `read_check` = '0' WHERE `sender_ID` = '" + yourID + "' AND `recv_ID` = '" + myID + "';"); //' AND (`id` = '" + id +"'

                // 내가 보낸 메시제리면
                if(myID == id)
                {
                    SendMsg(text,time);
                }
                else if(yourID == id) // 내가 받은 메세지라면
                {
                    DrawMsg(text, id, time);
                }
            }

            flowLayoutPanel1.Width = panel3.ClientSize.Width + SystemInformation.VerticalScrollBarWidth;
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
