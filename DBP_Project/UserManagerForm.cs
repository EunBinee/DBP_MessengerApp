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
    public partial class UserManagerForm : Form
    {
 
        public UserManagerForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchName = searchBox.Text;
            string searchByNameQuery = $"SELECT * FROM Department Left outer Join LogInHistory on Department.userId = LogInHistory.userId where Department.userId = '{searchName}'";
         
            if(searchName == "") // 아무런 id도 입력하지않고 검색을 누른경우
            {
                MessageBox.Show("검색할 이름을 입력해주세요.");
            }
            else
            {
                DataTable userInfoDataTable = Query.GetInstance().RunQuery(searchByNameQuery);
                if(userInfoDataTable.Rows.Count <= 0) // 만약 DB에 해당 ID의 유저 정보가 없다면
                {
                    MessageBox.Show("일치하는 사용자가 없습니다.");
                }
                else
                {
                    userBox.Text = userInfoDataTable.Rows[0]["userId"].ToString();
                    departmentComboBox.Text = userInfoDataTable.Rows[0]["departmentName"].ToString();
                    teamComboBox.Text = userInfoDataTable.Rows[0]["teamName"].ToString();
                    recentLogIn.Text = userInfoDataTable.Rows[0]["LoginTime"].ToString();
                    recentLogOut.Text = userInfoDataTable.Rows[0]["LogOutTime"].ToString();
                    
                }
            }
        }
    }
}
