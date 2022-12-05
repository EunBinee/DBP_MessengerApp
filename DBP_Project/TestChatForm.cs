using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_Project
{
    public partial class TestChatForm : Form
    {
        private string loginUser = "";
        private int roomCount = 0;
        public static TestChatForm instance;

        // Thread myThread = new Thread(ChatListLoad);
        public TestChatForm()
        {
            instance = this;
            loginUser = User_info.GetInstance().ID;
            InitializeComponent();
        }

        private void TestChatForm_Load(object sender, EventArgs e)
        {
            //채팅방 목록 쿼리 받은 후, 반복문
            ChatLoad();
            //ThreadParam tp = new ThreadParam(loginUser, roomCount);
            //myThread.Start(tp);
        }

        public void ChatLoad()
        {
            flowLayoutPanel1.Controls.Clear();
            
            string q = $"SELECT * FROM ChatRoom WHERE user1 = '{loginUser}' OR user2 = '{loginUser}'";
            DataTable dt = Query.GetInstance().RunQuery(q);

            roomCount = dt.Rows.Count;
            foreach (DataRow dr in dt.Rows)
            {
                bool isRoom = false;
                for (int i = 0; i < User_info.GetInstance().employees.Count; i++)
                {
                    if((User_info.GetInstance().employees[i].ID == dr["user1"].ToString()||
                        User_info.GetInstance().employees[i].ID == dr["user2"].ToString()) && 
                        User_info.GetInstance().employees[i].Btype == "0")
                    {
                        isRoom = true;
                    }
                }
                string roomId = "";
                string targetID = "";
                if (dr["user1"].ToString() == loginUser)
                {
                    roomId = dr["room_ID"].ToString();
                    targetID = dr["user2"].ToString();
                }
                else if (dr["user2"].ToString() == loginUser)
                {
                    roomId = dr["room_ID"].ToString();
                    targetID = dr["user1"].ToString();
                }
                if (isRoom)
                {
                    ChatPanel ch = new ChatPanel(loginUser, targetID, roomId);
                    flowLayoutPanel1.Controls.Add(ch);
                }         
            }
        }

        private static void ChatListLoad(object obj)
        {
            ThreadParam tp = obj as ThreadParam;
            bool loop = true;
            while (loop)
            {
                string q = $"SELECT * FROM ChatRoom WHERE user1 = '{tp.loginUser}' OR user2 = '{tp.loginUser}'";
                DataTable dt = Query.GetInstance().RunQuery(q);

                if(tp.roomCount < dt.Rows.Count)
                {
                    loop = false;
                }
            }
        }

        /*
         * db 테이블 중 채팅방 목록 table을 만들어
         * 그 목록을 받고 채팅방 목록 리스트 구현
         * 
         * 그 후 그부분을 클릭하면 채팅방 오픈
         */
    }

    class ThreadParam
    {
        public string loginUser;
        public int roomCount;
        public ThreadParam(string num1, int num2)
        {
            this.loginUser = num1; this.roomCount = num2;
        }
    }
}
