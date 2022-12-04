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
    public partial class Profil : Form
    {
        public string loginUser = "";
        public string targetID = "";
        private string roomId = "";

        public Profil()
        {
            InitializeComponent();
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void Profil_MouseDown(object sender, MouseEventArgs e) // 마우스로 폼 움직이는 함수
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Profil_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Profil_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void OpenChatRoomBtn_Click(object sender, EventArgs e)
        {
            string q = $"SELECT blockType FROM BlockInfo WHERE userID = '{loginUser}' AND blockUserId = '{targetID}'";
            DataTable dt = Query.GetInstance().RunQuery(q);

            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("채팅방 오픈");
                string check = $"SELECT room_ID FROM talk.ChatRoom WHERE (`user1` = '{loginUser}' AND `user2` = '{targetID}') OR (`user1` = '{targetID}' AND `user2` = '{loginUser}');";
                DataTable dt2 = Query.GetInstance().RunQuery(check);

                // 방이 없다면 생성
                if (dt2.Rows.Count == 0)
                {
                    string query = $"INSERT INTO `talk`.`ChatRoom` (`user1`, `user2`, `notice`) VALUES ('{loginUser}', '{targetID}', '0');";
                    Query.GetInstance().RunQuery(query);

                    check = $"SELECT room_ID FROM talk.ChatRoom WHERE (`user1` = '{loginUser}' AND `user2` = '{targetID}');";
                    dt2 = Query.GetInstance().RunQuery(check);
                }

                Client.GetInstance().AddNewChatRoom(targetID,dt2.Rows[0][0].ToString());
                this.Close();

            }
            else
            {
                MessageBox.Show("채팅권한이 없습니다.");
            }
        }

        private void Profil_Load(object sender, EventArgs e)
        {
            //프로필 시작 처리
            string q = "SELECT name, profilePic FROM UserListTable WHERE id = '" + targetID + "'";
            DataTable dt = Query.GetInstance().RunQuery(q);

            label1.Text = "이름: " + dt.Rows[0]["name"].ToString();
            pictureBox1.ImageLocation = "http://15.164.218.208/forDB/" + dt.Rows[0]["profilePic"];

            this.Location = new Point(240, 60);
            
            //즐겨찾기 처리
            q = "SELECT * FROM test_Favorite WHERE user_id = '" + loginUser + "' and target_id = '" + targetID + "'";
            dt = Query.GetInstance().RunQuery(q);
            if(dt.Rows.Count > 0)
            {
                FavoriteCheckBox.CheckState = CheckState.Checked;
            }
            else
            {
                FavoriteCheckBox.CheckState = CheckState.Unchecked;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FavoriteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(FavoriteCheckBox.Checked == true)
            {
                string q = "SELECT * FROM test_Favorite WHERE user_id = '" + loginUser + "' and target_id = '" + targetID + "'";
                DataTable dt = Query.GetInstance().RunQuery(q);
                if (dt.Rows.Count < 1)
                {
                    q = "INSERT INTO test_Favorite (user_id, target_id) VALUES ('" + loginUser + "','" + targetID + "')";
                    Query.GetInstance().RunQuery(q);
                }
            }
            else
            {
                string q = "SELECT * FROM test_Favorite WHERE user_id = '" + loginUser + "' and target_id = '" + targetID + "'";
                DataTable dt = Query.GetInstance().RunQuery(q);
                if (dt.Rows.Count >= 1)
                {
                    string a = dt.Rows[0]["idx"].ToString();
                    q = "DELETE FROM test_Favorite WHERE idx = '" + a +"'";
                    Query.GetInstance().RunQuery(q);
                }
            }
        }


        /*public new void Show()
        {
            
        }*/
    }
}
