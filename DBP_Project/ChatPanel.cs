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
    public partial class ChatPanel : UserControl
    {
        private string loginUser;
        private string targetId;
        private string roomId;
        public ChatPanel(string loginUser, string targetId, string roomId)
        {
            this.loginUser = loginUser;
            this.targetId = targetId;
            this.roomId = roomId;
            InitializeComponent();
        }

        private void ChatPanel_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < User_info.GetInstance().employees.Count; i++)
            {
                if (User_info.GetInstance().employees[i].ID.Equals(targetId))
                {
                    //target image 넣기
                    NameLabel.Text = User_info.GetInstance().employees[i].NickName + "(" +
                        User_info.GetInstance().employees[i].Name + ")";
                    string q = $"SELECT * FROM ChatMsg WHERE room_ID = '{roomId}' AND send_time" +
                        $" IN (SELECT MAX(send_time) FROM ChatMsg WHERE room_ID = '{roomId}')";
                    //ChatMsg send_time date_format 이상으로 시간에 이상있음
                    DataTable dt = Query.GetInstance().RunQuery(q);
                    if (dt.Rows.Count <= 0)
                    {
                        LastChat.Text = "최근 대화내역 없음";
                        TimeLabel.Text = "";
                    }
                    else
                    {
                        if (dt.Rows[0]["isImg"].ToString() == "1")
                        {
                            LastChat.Text = "사진을 보냈습니다.";
                            string time = dt.Rows[0]["send_time"].ToString();
                            TimeLabel.Text = DateTime.Parse(time).ToString("t");
                        }
                        else
                        {
                            LastChat.Text = dt.Rows[0]["data"].ToString();
                            string time = dt.Rows[0]["send_time"].ToString();
                            TimeLabel.Text = DateTime.Parse(time).ToString("t");
                        }
                        //최근대화내역체크 - 체크상태(읽음), 체크아님(안읽음)
                        if (dt.Rows[0]["read_check"].ToString() == "1")
                        {
                            ReadCheck.CheckState = CheckState.Unchecked;
                        }
                        else
                        {
                            ReadCheck.CheckState = CheckState.Checked;
                        }

                    }

                }
            }
        }

        private void ChatPanel_Click(object sender, EventArgs e)
        {
            if (User_info.GetInstance().Role == 1)
            {
                MessageBox.Show("관리자는 채팅을 참여할 수 없습니다.");
            }
            else
            {
                ReadCheck.CheckState = CheckState.Checked;
                //클릭시 채팅방 오픈
                Client.GetInstance().AddNewChatRoom(this.targetId, this.roomId);
            }
        }
    }
}