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
    public partial class TestChatForm : Form
    {
        private string loginUser = "cor";
        public TestChatForm()
        {
            //loginUser = User_Info.GetInstance().ID;
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TestChatForm_Load(object sender, EventArgs e)
        {
            //채팅방 목록 쿼리 받은 후, 반복문
            // ChatPanel ch = new ChatPanel(loginUser, targetId);

        }

        /*
         * db 테이블 중 채팅방 목록 table을 만들어
         * 그 목록을 받고 채팅방 목록 리스트 구현
         * 
         * 그 후 그부분을 클릭하면 채팅방 오픈
         */
    }
}
