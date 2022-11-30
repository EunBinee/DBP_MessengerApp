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
        public ChatPanel(string loginUser, string targetId)
        {
            this.loginUser = loginUser;
            this.targetId = targetId;
            InitializeComponent();
        }

        private void Favorite_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChatPanel_Load(object sender, EventArgs e)
        {
               
        }
        
        private void ChatPanel_Click(object sender, EventArgs e)
        {
            //클릭시 채팅방 오픈
        }

        private void LastChat_Click(object sender, EventArgs e)
        {

        }
    }
}
