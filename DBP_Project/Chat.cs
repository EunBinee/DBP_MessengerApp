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
        public static string myID = "cor";
        private static string yourID = "test";
        public string roomID = "2";
        public static Chat instance;
        public Chat()
        {
            instance = this;
            InitializeComponent();
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            MessageBox.Show("대화내용을 불러옵니다.");
            LoadChatByRoomId(roomID);
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

            // TCP를 통해 수신자에게 알림
            SendToSignal();

            // 메세지를 폼에 등록 및 초기화
            SendMsg(msgInput.Text,time);
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

            // TCP를 통해 수신자에게 알림
            SendToSignal();
            SendJpg(text,time);
        }
        public void SendJpg(string text, string time)
        {
            Message msg = new Message();
            msg.SetData("", time);
            msg.SetMyMsg();
            msg.SetImageMsg("http://15.164.218.208/forDB/" + text);
            msgInput.Text = "";
            flowLayoutPanel1.Controls.Add(msg);
            flowLayoutPanel1.ScrollControlIntoView(msg);
            flowLayoutPanel1.Width = panel3.ClientSize.Width + SystemInformation.VerticalScrollBarWidth;
        }
        private void SendMsg(string text, string time,bool isFile = false)
        {
            Message msg = new Message(text,isFile);
            msg.SetMyMsg();
            msg.SetData("", time);
            msgInput.Text = "";
            flowLayoutPanel1.Controls.Add(msg);
            flowLayoutPanel1.ScrollControlIntoView(msg);
            flowLayoutPanel1.Width = panel3.ClientSize.Width + SystemInformation.VerticalScrollBarWidth;
        }

        private void DrawMsg(string text,string name, string time,bool isFile = false)
        {
            Message msg = new Message(text,isFile);
            msg.SetData(name, time);
            flowLayoutPanel1.Controls.Add(msg);
            flowLayoutPanel1.ScrollControlIntoView(msg);
        }

        private void DrawJpg(string text, string name, string time)
        {
            Message msg = new Message();
            msg.SetData(name, time);
            msg.SetImageMsg("http://15.164.218.208/forDB/" + text);
            flowLayoutPanel1.Controls.Add(msg);
            flowLayoutPanel1.ScrollControlIntoView(msg);
        }

        // TCP를 통해 메세지를 받았을 때 호출
        public void RecieveMsg()
        {
            // 송신자로부터 알림 받음
            DataTable dt = Query.GetInstance().RunQuery("SELECT `data`,`sender_ID`,`send_time`,`isImg` FROM talk.ChatMsg WHERE `sender_ID` = '" + yourID + "' AND `recv_ID` = '" + myID + "' AND `read_check` = '1';");
            //UPDATE `talk`.`ChatMsg` SET `read_check` = '0' WHERE (`id` = '14');

            // 상대가 전송한 메세지 폼에 그리기
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // 메세지 읽음 표시
                string text = dt.Rows[i][0].ToString();
                string id = dt.Rows[i][1].ToString();
                string time = dt.Rows[i][2].ToString();
                string isImg = dt.Rows[i][3].ToString();

                Query.GetInstance().RunQuery("UPDATE `talk`.`ChatMsg` SET `read_check` = '0' WHERE `sender_ID` = '" + yourID + "' AND `recv_ID` = '" + myID + "';"); //' AND (`id` = '" + id +"'

                // 상대가 전송한 메세지
                if (isImg == "1")
                    DrawJpg(text, id, time);
                else if(isImg == "2")
                {
                    DrawMsg(text, id, time,true);
                }
                else
                    DrawMsg(text, id, time);
            }

            flowLayoutPanel1.Width = panel3.ClientSize.Width + SystemInformation.VerticalScrollBarWidth;
        }

        // 해당 방 메세지 전부 로드
        public void LoadChatByRoomId(string roomId)
        {
            // 송신자로부터 알림 받음
            DataTable dt = Query.GetInstance().RunQuery("SELECT `data`,`sender_ID`,`send_time`,`isImg` FROM talk.ChatMsg WHERE `room_ID` = '" + roomId + "';");

            // 상대가 전송한 메세지 폼에 그리기
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // 메세지 읽음 표시
                string text = dt.Rows[i][0].ToString();
                string id = dt.Rows[i][1].ToString();
                string time = dt.Rows[i][2].ToString();
                string isImg = dt.Rows[i][3].ToString();

                Query.GetInstance().RunQuery("UPDATE `talk`.`ChatMsg` SET `read_check` = '0' WHERE `sender_ID` = '" + yourID + "' AND `recv_ID` = '" + myID + "';"); //' AND (`id` = '" + id +"'

                // 내가 보낸 메시제리면
                if(myID == id)
                {
                    if(isImg == "1")
                    {
                        SendJpg(text, time);
                    }
                    else if (isImg == "2")
                    {
                        SendMsg(text, time, true);
                    }
                    else
                        SendMsg(text, time);
                }
                else if(yourID == id) // 내가 받은 메세지라면
                {
                    if (isImg == "1")
                    {
                        DrawJpg(text,id, time);
                    }
                    else if (isImg == "2")
                    {
                        DrawMsg(text, id, time, true);
                    }
                    else
                        DrawMsg(text, id, time);
                }
            }

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
                    msgInput.Text = filename;

                    string newFileName = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".jpg";

                    string time = ConfigManager.GetInstance().GetTimeNow();
                    // 메세지를 DB에 저장
                    Query.GetInstance().RunQuery("INSERT INTO `talk`.`ChatMsg` (`room_ID`, `sender_ID`, `recv_ID`, `data`,`send_time`,`isImg`) " +
                        "VALUES ('" + roomID + "', '" + myID + "', '" + yourID + "', '" + newFileName + "','" + time + "','1');");

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
                    SendJpg(newFileName, time);
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
                    msgInput.Text = filename;

                    string newFileName = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".zip";

                    string time = ConfigManager.GetInstance().GetTimeNow();

                    // 메세지를 DB에 저장
                    Query.GetInstance().RunQuery("INSERT INTO `talk`.`ChatMsg` (`room_ID`, `sender_ID`, `recv_ID`, `data`,`send_time`,`isImg`) " +
                        "VALUES ('" + roomID + "', '" + myID + "', '" + yourID + "', '" + newFileName + "','" + time + "','2');");

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
                    SendMsg(newFileName, time,true);
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

        private void Chat_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Query.GetInstance().RunQuery("UPDATE `talk`.`UserListTable` SET `peer` = '00000' WHERE (`id` = '" + myID + "');");
            MessageBox.Show("FormClose");
        }
    }
}
