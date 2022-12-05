using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DBP_Project
{
    public partial class Chat : Form
    {
        // 내 ID와 상대의 ID
        public string myID;
        public string yourID;
        public string roomID = "2";
        public int yourPeer = 0;

        public static Chat instance;

        public Notice notice = new Notice();
        public int notice_chat = 0;
        List<Message> messages = new List<Message>(); 
        public Chat()
        {
            instance = this;
            InitializeComponent();
            if (notice_chat != 0)   //공지가 있으면
            {
                notice_view();
            }
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            myID = User_info.GetInstance().ID;
            DataTable dt = Query.GetInstance().RunQuery("SELECT peer from talk.UserListTable WHERE id = '" + yourID + "';");
            yourPeer = Int32.Parse(dt.Rows[0][0].ToString());

            LoadChatByRoomId(roomID);
            //Client.GetInstance().StartReadChk();

        }

        // 메세지 전송 버튼 클릭
        private void button5_Click(object sender, EventArgs e)
        {
            // 입력한 메세지가 없다면 리턴
            if (msgInput.Text == "")
                return;

            string time = ConfigManager.GetInstance().GetTimeNow();

            // 메세지를 DB에 저장
            Query.GetInstance().RunQuery("INSERT INTO `talk`.`ChatMsg` (`room_ID`,`sender_ID`, `recv_ID`, `data`,`send_time`) " +
                "VALUES ('"+ roomID + "', '"+myID+"', '"+yourID+"', '" + msgInput.Text + "','" + time + "');");
            DataTable dt_last_id = Query.GetInstance().RunQuery("select last_insert_id();");
            int chatId = Convert.ToInt32(dt_last_id.Rows[0][0]);

            // TCP를 통해 수신자에게 알림
            SendToSignal();

            // 메세지를 폼에 등록 및 초기화
            SendMsg(chatId,msgInput.Text,time);

            TestChatForm.getInstance().ChatLoad();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 이모티콘
            Emoticon emoticon = new Emoticon();
            emoticon.chat = this;
            emoticon.ShowDialog();

        }
        public void SendEmo(string text)
        {
            string time = ConfigManager.GetInstance().GetTimeNow();

            // 메세지를 DB에 저장
            Query.GetInstance().RunQuery("INSERT INTO `talk`.`ChatMsg` (`room_ID`, `sender_ID`, `recv_ID`, `data`,`send_time`,`isImg`) " +
                "VALUES ('" + roomID + "', '" + myID + "', '" + yourID + "', '" + text + "','" + time + "','1');");
            DataTable dt_last_id = Query.GetInstance().RunQuery("select last_insert_id();");
            int chatId = Convert.ToInt32(dt_last_id.Rows[0][0]);

            // TCP를 통해 수신자에게 알림
            SendToSignal();
            SendJpg(chatId,text,time);
        }
        public void SendJpg(int chatId,string text, string time)
        {
            Message msg = new Message(this, chatId, text);
            msg.SetData(time);
            msg.SetMyMsg();
            msg.SetImageMsg("http://15.164.218.208/forDB/" + text);
            messages.Add(msg);
            msgInput.Text = "";
            flowLayoutPanel1.Controls.Add(msg);
            flowLayoutPanel1.ScrollControlIntoView(msg);
            flowLayoutPanel1.Width = panel3.ClientSize.Width + SystemInformation.VerticalScrollBarWidth;
        }
        private void SendMsg(int chatId, string text, string time,bool isFile = false)
        {
            Message msg = new Message(this, chatId, text,isFile);
            msg.SetMyMsg();
            msg.SetData(time);

            messages.Add(msg);
            msgInput.Text = "";
            flowLayoutPanel1.Controls.Add(msg);
            flowLayoutPanel1.ScrollControlIntoView(msg);
            flowLayoutPanel1.Width = panel3.ClientSize.Width + SystemInformation.VerticalScrollBarWidth;
        }

        private void DrawMsg(int chatId, string text,string name, string time,bool isFile = false)
        {
            Message msg = new Message(this, chatId, text,isFile);
            msg.SetData(time);
            msg.SetSenderImg(yourID);

            messages.Add(msg);
            flowLayoutPanel1.Controls.Add(msg);
            flowLayoutPanel1.ScrollControlIntoView(msg);
        }

        private void DrawJpg(int chatId, string text, string name, string time)
        {
            Message msg = new Message(this, chatId, text);
            msg.SetData(time);
            msg.SetImageMsg("http://15.164.218.208/forDB/" + text);
            msg.SetSenderImg(yourID);

            messages.Add(msg);
            flowLayoutPanel1.Controls.Add(msg);
            flowLayoutPanel1.ScrollControlIntoView(msg);
        }

        // TCP를 통해 메세지를 받았을 때 호출
        public void RecieveMsg(string str)
        {
            if ((str.Equals(yourPeer.ToString())))
                return;

            // 송신자로부터 알림 받음
            DataTable dt = Query.GetInstance().RunQuery("SELECT `id`,`data`,`sender_ID`,`send_time`,`isImg` FROM talk.ChatMsg WHERE `sender_ID` = '" + yourID + "' AND `recv_ID` = '" + myID + "' AND `read_check` = '1';");

            // 상대가 전송한 메세지 폼에 그리기
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // 메세지 읽음 표시
                int chatId = Convert.ToInt32(dt.Rows[i][0]);
                string text = dt.Rows[i][1].ToString();
                string id = dt.Rows[i][2].ToString();
                string time = dt.Rows[i][3].ToString();
                string isImg = dt.Rows[i][4].ToString();

                // 상대가 전송한 메세지
                if (isImg == "1")
                    DrawJpg(chatId, text, id, time);
                else if(isImg == "2")
                {
                    DrawMsg(chatId, text, id, time,true);
                }
                else
                    DrawMsg(chatId, text, id, time);
            }
            Query.GetInstance().RunQuery("UPDATE `talk`.`ChatMsg` SET `read_check` = '0' WHERE `sender_ID` = '" + yourID + "' AND `recv_ID` = '" + myID + "';"); //' AND (`id` = '" + id +"'
            SendToReadSignal();

            for (int i = 0; i < messages.Count; i++)
            {
                messages[i].SetRead();
            }

            Query.GetInstance().RunQuery("UPDATE `talk`.`ChatMsg` SET `read_check` = '0' WHERE `sender_ID` = '" + yourID + "' AND `recv_ID` = '" + myID + "';"); //' AND (`id` = '" + id +"'
            SendToReadSignal();

            flowLayoutPanel1.Width = panel3.ClientSize.Width + SystemInformation.VerticalScrollBarWidth;
        }
        // TCP를 통해 읽음확인
        public void RecieveReadChk(string str)
        {
            if ((str.Equals(yourPeer.ToString())))
                return;

            for (int i = 0; i < messages.Count; i++)
            {
                messages[i].SetRead();
            }
        }

        // 해당 방 메세지 전부 로드
        public void LoadChatByRoomId(string roomId)
        {
            // 송신자로부터 알림 받음
            DataTable dt = Query.GetInstance().RunQuery("SELECT `id`,`data`,`sender_ID`,`send_time`,`isImg` FROM talk.ChatMsg WHERE `room_ID` = '" + roomId + "';");

            // 상대가 전송한 메세지 폼에 그리기
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // 메세지 읽음 표시
                int chatId = Convert.ToInt32(dt.Rows[i][0]);
                string text = dt.Rows[i][1].ToString();
                string id = dt.Rows[i][2].ToString();
                string time = dt.Rows[i][3].ToString();
                string isImg = dt.Rows[i][4].ToString();

                // 내가 보낸 메시제리면
                if (myID == id)
                {
                    if(isImg == "1")
                    {
                        SendJpg(chatId,text, time);
                    }
                    else if (isImg == "2")
                    {
                        SendMsg(chatId,text, time, true);
                    }
                    else
                        SendMsg(chatId,text, time);
                }
                else if(yourID == id) // 내가 받은 메세지라면
                {
                    if (isImg == "1")
                    {
                        DrawJpg(chatId,text, id, time);
                    }
                    else if (isImg == "2")
                    {
                        DrawMsg(chatId,text, id, time, true);
                    }
                    else
                        DrawMsg(chatId,text, id, time);
                }
            }
            Query.GetInstance().RunQuery("UPDATE `talk`.`ChatMsg` SET `read_check` = '0' WHERE `sender_ID` = '" + yourID + "' AND `recv_ID` = '" + myID + "';");
            SendToReadSignal();


            Query.GetInstance().RunQuery("UPDATE `talk`.`ChatMsg` SET `read_check` = '0' WHERE `sender_ID` = '" + yourID + "' AND `recv_ID` = '" + myID + "';");
            SendToReadSignal();

            flowLayoutPanel1.Width = panel3.ClientSize.Width + SystemInformation.VerticalScrollBarWidth;
        }

        public void FindMsg(string str)
        {
            // 송신자로부터 알림 받음
            DataTable dt = Query.GetInstance().RunQuery("SELECT `data`,`sender_ID`,`send_time` FROM talk.ChatMsg WHERE `room_ID` = '"+roomID+"' AND `data` like '%"+str+"%';");

            // 상대가 전송한 메세지 폼에 그리기
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // 메세지 읽음 표시
                string text = dt.Rows[i][0].ToString();
                string id = dt.Rows[i][1].ToString();
                string time = dt.Rows[i][2].ToString();
                string findInfo = "보낸 사람 : " + id + "\n보낸 시간 : " + time + "\n메세지 : " + text;

                MessageBox.Show(findInfo);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = "jpg";
            openFile.Filter = "Images Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.png";
            openFile.ShowDialog();
            if (openFile.FileNames.Length > 0)
            {
                foreach (string filename in openFile.FileNames)
                {
                    Client.GetInstance().PhotoConnect();

                    string newFileName = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".jpg";

                    string time = ConfigManager.GetInstance().GetTimeNow();
                    // 메세지를 DB에 저장
                    Query.GetInstance().RunQuery("INSERT INTO `talk`.`ChatMsg` (`room_ID`, `sender_ID`, `recv_ID`, `data`,`send_time`,`isImg`) " +
                        "VALUES ('" + roomID + "', '" + myID + "', '" + yourID + "', '" + newFileName + "','" + time + "','1');");
                    DataTable dt_last_id = Query.GetInstance().RunQuery("select last_insert_id();");
                    int chatId = Convert.ToInt32(dt_last_id.Rows[0][0]);

                    // TCP를 통해 수신자에게 알림
                    SendToSignal();

                    var data = Encoding.UTF8.GetBytes(newFileName);
                    Client.GetInstance().SendByte(data);

                    int bufferCapacity = 1024;
                    using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
                    {
                        byte[] buf = new byte[bufferCapacity];
                        int c;

                        while ((c = fs.Read(buf, 0, buf.Length)) > 0)
                        {
                            Client.GetInstance().SendByte(buf);
                        }
                    }

                    // 메세지를 폼에 등록 및 초기화
                    SendJpg(chatId,newFileName, time);
                    Client.GetInstance().PhotoClose();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = "zip";
            openFile.Filter = "Zip Files|*.zip;*.rar";

            openFile.ShowDialog();
            if (openFile.FileNames.Length > 0)
            {
                foreach (string filename in openFile.FileNames)
                {
                    Client.GetInstance().PhotoConnect();

                    string newFileName = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".zip";

                    string time = ConfigManager.GetInstance().GetTimeNow();

                    // 메세지를 DB에 저장
                    Query.GetInstance().RunQuery("INSERT INTO `talk`.`ChatMsg` (`room_ID`, `sender_ID`, `recv_ID`, `data`,`send_time`,`isImg`) " +
                        "VALUES ('" + roomID + "', '" + myID + "', '" + yourID + "', '" + newFileName + "','" + time + "','2');");
                    DataTable dt_last_id = Query.GetInstance().RunQuery("select last_insert_id();");
                    int chatId = Convert.ToInt32(dt_last_id.Rows[0][0]);

                    // TCP를 통해 수신자에게 알림
                    SendToSignal();

                    var data = Encoding.UTF8.GetBytes(newFileName);
                    Client.GetInstance().SendByte(data);

                    int bufferCapacity = 1024;
                    using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
                    {
                        byte[] buf = new byte[bufferCapacity];
                        int c;

                        while ((c = fs.Read(buf, 0, buf.Length)) > 0)
                        {
                            Client.GetInstance().SendByte(buf);
                        }
                    }

                    // 메세지를 폼에 등록 및 초기화
                    SendMsg(chatId,newFileName, time,true);
                    Client.GetInstance().PhotoClose();
                }
            }
        }

        void SendToSignal()
        {
            // TCP를 통해 수신자에게 알림 + 비로그인시 예외처리
            DataTable dt = Query.GetInstance().RunQuery("SELECT `peer` FROM talk.UserListTable WHERE `id` = '" + yourID + "';");
            if (dt.Rows[0][0].ToString() != "00000")
            {
                string trig = "1" + dt.Rows[0][0].ToString();
                Client.GetInstance().SendMsg(trig);
            }
        }
        void SendToReadSignal()
        {
            // TCP를 통해 수신자에게 알림 + 비로그인시 예외처리
            DataTable dt = Query.GetInstance().RunQuery("SELECT `peer` FROM talk.UserListTable WHERE `id` = '" + yourID + "';");
            if (dt.Rows[0][0].ToString() != "00000")
            {
                string trig = "2" + dt.Rows[0][0].ToString();
                Client.GetInstance().SendReadChk(trig);
            }
        }

        private void Chat_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            //Query.GetInstance().RunQuery("UPDATE `talk`.`UserListTable` SET `peer` = '00000' WHERE (`id` = '" + myID + "');");
        }
        

        private void trackBar1_ValueChanged(object sender, EventArgs e)  //투명도
        {
            this.Opacity = (trackBar1.Value) * 0.01;
        }

        private void button1_Click(object sender, EventArgs e)  //채팅방 z-index 고정
        {
            if (this.TopMost)
                this.TopMost = false;
            else
                this.TopMost = true;

        }

        public void notice_view()  //공지 보기
        {
            if (this.Controls.Contains(notice) )
            {
                this.Controls.Remove(notice);
            }
            string str = "";
            DataTable dt = Query.GetInstance().RunQuery("SELECT data FROM talk.ChatMsg WHERE id = (SELECT notice FROM talk.ChatRoom WHERE room_ID = "+ roomID +");"); 
            if(dt.Rows.Count == 0 || notice_chat == 0)
            {
                return;
            }
            str = dt.Rows[0][0].ToString();
            notice.setText(str);
            this.Controls.Add(notice);
            notice.Location = flowLayoutPanel1.Location;
            notice.BringToFront();

            flowLayoutPanel1.Width = panel3.ClientSize.Width + SystemInformation.VerticalScrollBarWidth;
        }

        public void notice_set(int chatId)  //공지 설정
        {
            Query.GetInstance().RunQuery("UPDATE talk.ChatRoom SET notice = "+chatId+" WHERE room_ID = "+roomID+";");
            this.notice_chat = chatId;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FindMsg(msgInput.Text);
        }
    }
}
