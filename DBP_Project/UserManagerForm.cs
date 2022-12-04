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

        private void getDepartmentList() // 전체 부서 리스트 받아오기
        {
            string getDepartmentInfoQuery = "select distinct departmentName from departmentList";
            DataTable departmentInfoTable = Query.GetInstance().RunQuery(getDepartmentInfoQuery);

            departmentComboBox.Items.Clear();
            blockComboBox1.Items.Clear();

            foreach (DataRow row in departmentInfoTable.Rows)
            {
                departmentComboBox.Items.Add(row["departmentName"].ToString());
                blockComboBox1.Items.Add(row["departmentName"].ToString());
            }
        }

        private void getUserList() // 전체 유저 리스트 받아오기
        {
            string getUserListQuery = "SELECT id from UserListTable order by id";
            DataTable userListTable = Query.GetInstance().RunQuery(getUserListQuery);

            blockChatBox.Items.Clear();
            blockUserBox.Items.Clear();
            
            foreach (DataRow row in userListTable.Rows)
            {
                blockChatBox.Items.Add(row["id"].ToString());
                blockUserBox.Items.Add(row["id"].ToString());
            }
        }

        private void serachBtn_Click(object sender, EventArgs e) // 유저 검색 버튼을 눌렀을 경우
        {
            string searchName = searchBox.Text;
            string searchByNameQuery = $"SELECT * FROM UserDepartment Left outer Join LogInHistory on UserDepartment.userId = LogInHistory.userId where UserDepartment.userId = '{searchName}'";

            if (searchName == "") // 아무런 id도 입력하지않고 검색을 누른경우
            {
                MessageBox.Show("검색할 이름을 입력해주세요.");
                return;
            }

            DataTable userInfoDataTable = Query.GetInstance().RunQuery(searchByNameQuery);

            if (userInfoDataTable.Rows.Count <= 0) // 만약 DB에 해당 ID의 유저 정보가 없다면
            {
                MessageBox.Show("일치하는 사용자가 없습니다.");
                return;
            }
            
            getDepartmentList();

            userBox.Text = userInfoDataTable.Rows[0]["userId"].ToString();
            departmentComboBox.SelectedIndex = departmentComboBox.FindString(userInfoDataTable.Rows[0]["departmentName"].ToString());
            teamComboBox.SelectedIndex = teamComboBox.FindString(userInfoDataTable.Rows[0]["teamName"].ToString());
            recentLogIn.Text = userInfoDataTable.Rows[0]["LoginTime"].ToString();
            recentLogOut.Text = userInfoDataTable.Rows[0]["LogOutTime"].ToString();

            getBlockDepartmentListByUid(userBox.Text);
            getBlockChatListByUid(userBox.Text);
            getBlockUserListByUid(userBox.Text);
            getUserList();
        }

        private void departmentComboBox_SelectedIndexChanged(object sender, EventArgs e) // 사용자 부서 콤보 박스 인덱스 변경시
        {
            string currentDepartment = departmentComboBox.SelectedItem.ToString();
            string getTeamInfoQuery = $"select distinct teamName from departmentList where departmentName = '{currentDepartment}'";
            DataTable teamInfoTable = Query.GetInstance().RunQuery(getTeamInfoQuery);
            teamComboBox.Items.Clear();
            teamComboBox.Text = "";
            foreach (DataRow row in teamInfoTable.Rows)
            {
                teamComboBox.Items.Add(row["teamName"].ToString());
            }
        }

        private void saveBtn_Click(object sender, EventArgs e) // 변경사항 저장 버튼 눌렀을 경우
        {
            if (departmentComboBox.SelectedItem == null)  // 예외처리
                MessageBox.Show("소속 부서를 선택해주세요");
            else if (teamComboBox.SelectedItem == null)
                MessageBox.Show("소속 팀을 선택해주세요");
            else
            {
                string currentUserId = userBox.Text; // 사용자의 부서와 팀 정상적으로 선택하면 DB에 업데이트
                string currentDepartment = departmentComboBox.SelectedItem.ToString();
                string getDepartmentIdQuery = $"SELECT distinct departmentId FROM talk.departmentList where departmentName = '{currentDepartment}'";
                int currentDepartmentId =Convert.ToInt32(Query.GetInstance().RunQuery(getDepartmentIdQuery).Rows[0]["departmentId"]);
                string currentTeam = teamComboBox.SelectedItem.ToString();
                string saveInfoQuery = $"UPDATE UserDepartment SET departmentId = {currentDepartmentId}, departmentName = '{currentDepartment}', teamName = '{currentTeam}' where userId = '{currentUserId}'";
                Query.GetInstance().RunQuery(saveInfoQuery);
            }
        }

        private void getBlockDepartmentListByUid(string currentUserId) // UserId로 차단 부서 정보 받아오는 쿼리 실행
        {
            string getBlockDepartmentQuery = $"SELECT blockDepartment FROM BlockInfo where userId = '{currentUserId}' and blockDepartment is not null;";
            DataTable blockDepartmentTable = Query.GetInstance().RunQuery(getBlockDepartmentQuery);

            blockDepartmentList.Items.Clear();

            foreach (DataRow row in blockDepartmentTable.Rows)
            {
                blockDepartmentList.Items.Add(row["blockDepartment"].ToString());
            }
        }

        private void blockAddBtn1_Click(object sender, EventArgs e) // 차단 부서에 새로운 부서 추가
        {
            if (userBox.Text == "") // 사용자 조회를 하지 않고 부서 추가 하는 경우 예외 처리
            {
                MessageBox.Show("사용자를 먼저 검색해 주세요");
                return;
            }

            if (blockComboBox1.SelectedItem == null) // 차단할 부서를 선택하지 않고 차단부서 추가를 누른경우 예외 처리
            {
                MessageBox.Show("보기를 차단할 부서를 선택해 주세요");
                return;
            }

            string currentUserId = userBox.Text;
            string seletctedDepartment = blockComboBox1.SelectedItem.ToString();
            if (blockDepartmentList.Items.Contains(seletctedDepartment)) // 이미 차단 목록에 있는 부서를 다시 차단하려는 경우 예외 처리
                MessageBox.Show("이미 차단한 부서입니다.");
            else
            {
                // 정상적으로 차단할 부서를 추가한경우 차단테이블 추가 DB 쿼리 실행
                string updateBlockListQuery = $"insert into BlockInfo(userId, blockDepartment) Value('{currentUserId}', '{seletctedDepartment}')";
                Query.GetInstance().RunQuery(updateBlockListQuery);

                getBlockDepartmentListByUid(userBox.Text);
            }
        }

        private void blockDeleteBtn1_Click(object sender, EventArgs e) // 차단 부서 제거 버튼 눌렀을 경우
        {
            if (blockComboBox1.SelectedItem == null)
                MessageBox.Show("차단목록에서 삭제할 부서를 선택해주세요");
            else
            {
                string currentUserId = userBox.Text;
                string selectedDepartment = blockComboBox1.SelectedItem.ToString();
                if(blockDepartmentList.FindString(selectedDepartment) == -1)
                {
                    MessageBox.Show("현재 차단목록에 존재하지않는 부서입니다.");
                    return;
                }
                string deleteBlockDepartmentQuery = $"delete from BlockInfo where userId = '{currentUserId}' and blockDepartment = '{selectedDepartment}'";
                Query.GetInstance().RunQuery(deleteBlockDepartmentQuery);
                getBlockDepartmentListByUid(userBox.Text);
            }
        }

        private void blockDepartmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (blockDepartmentList.SelectedItem == null)
                return;
            string selectedDepartment = blockDepartmentList.SelectedItem.ToString();
            blockComboBox1.SelectedIndex = blockComboBox1.FindString(selectedDepartment);
        }

        private void getBlockChatListByUid(string currentUserId) // UserId로 DB에서 채팅 차단 정보를 가져오는 함수
        {
            string getBlockChatListQuery = $"SELECT blockUserId FROM BlockInfo where userId = '{currentUserId}' and blockType = 2;";
            DataTable blockChatTable = Query.GetInstance().RunQuery(getBlockChatListQuery);

            blockChatList.Items.Clear();

            foreach (DataRow row in blockChatTable.Rows)
            {
                blockChatList.Items.Add(row["blockUserId"].ToString());
            }
        }

        private void addBlockChatBtn_Click(object sender, EventArgs e) // 채팅 차단하고자하는 사용자 추가하는 버튼
        {
            if (userBox.Text == "")
            {
                MessageBox.Show("사용자를 먼저 검색해 주세요");
                return;
            }

            if (blockChatBox.SelectedItem == null)
            {
                MessageBox.Show("채팅을 차단할 사용자ID를 선택해주세요");
                return;
            }

            string currentUserId = userBox.Text;
            string selectedUserId = blockChatBox.SelectedItem.ToString();
            if (blockChatList.Items.Contains(selectedUserId))
                MessageBox.Show("이미 차단한 사용자ID입니다.");
            else
            {
                string updateBlockListQuery = $"insert into BlockInfo(userId, blockUserId, blockType) Value('{currentUserId}', '{selectedUserId}', 2)";
                Query.GetInstance().RunQuery(updateBlockListQuery);

                getBlockChatListByUid(userBox.Text);
            }
        }

        private void deleteBlockChatBtn_Click(object sender, EventArgs e) // 채팅 차단 목록에 추가되어있는 유저 삭제 하는 버튼
        {
            if (blockChatBox.SelectedItem == null)
                MessageBox.Show("차단목록에서 삭제할 사용자ID를 선택해주세요");

            else
            {
                string currentUserId = userBox.Text;
                string selectedUserId = blockChatBox.SelectedItem.ToString();
                if (blockChatList.FindString(selectedUserId) == -1)
                {
                    MessageBox.Show("현재 차단목록에 존재하지않는 유저ID입니다.");
                    return;
                }
                string deleteBlockChatQuery = $"delete from BlockInfo where userId = '{currentUserId}' and blockuserId = '{selectedUserId}' and blockType = 2";
                Query.GetInstance().RunQuery(deleteBlockChatQuery);
                getBlockChatListByUid(userBox.Text);
            }
        }

        private void blockChatList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (blockChatList.SelectedItem == null)
                return;
            string selectedUserId = blockChatList.SelectedItem.ToString();
            blockChatBox.SelectedIndex = blockChatBox.FindString(selectedUserId);
        }

        private void getBlockUserListByUid(string currentUserId) // UserId로 사용자 보기 차단 리스트를 가져오는 함수
        {
            string getBlockUserListQuery = $"SELECT blockUserId FROM BlockInfo where userId = '{currentUserId}' and blockType = 1;";
            DataTable blockUserTable = Query.GetInstance().RunQuery(getBlockUserListQuery);

            blockUserList.Items.Clear();

            foreach (DataRow row in blockUserTable.Rows)
            {
                blockUserList.Items.Add(row["blockUserId"].ToString());
            }
        }

        private void addBlockUserBtn_Click(object sender, EventArgs e) // 보기 차단 유저 추가 버튼
        {
            if (userBox.Text == "")
            {
                MessageBox.Show("사용자를 먼저 검색해 주세요");
                return;
            }

            if (blockUserBox.SelectedItem == null)
            {
                MessageBox.Show("보기를 차단할 사용자ID를 선택해주세요");
                return;
            }

            string currentUserId = userBox.Text;
            string selectedUserId = blockUserBox.SelectedItem.ToString();
            if (blockUserList.Items.Contains(selectedUserId))
                MessageBox.Show("이미 차단한 사용자ID입니다.");
            else
            {
                string updateBlockListQuery = $"insert into BlockInfo(userId, blockUserId, blockType) Value('{currentUserId}', '{selectedUserId}', 1)";
                Query.GetInstance().RunQuery(updateBlockListQuery);

                getBlockUserListByUid(userBox.Text);
            }
        }

        private void deleteBlockUserBtn_Click(object sender, EventArgs e) // 보기 차단 유저 삭제
        {
            if (blockUserBox.SelectedItem == null)
                MessageBox.Show("보기차단목록에서 삭제할 사용자ID를 선택해주세요");
            else
            {
                string currentUserId = userBox.Text;
                string selectedUserId = blockUserBox.SelectedItem.ToString();
                if (blockUserList.FindString(selectedUserId) == -1)
                {
                    MessageBox.Show("현재 보기차단목록에 존재하지않는 유저ID입니다.");
                    return;
                }
                string deleteBlockChatQuery = $"delete from BlockInfo where userId = '{currentUserId}' and blockuserId = '{selectedUserId}' and blockType = 1";
                Query.GetInstance().RunQuery(deleteBlockChatQuery);
                getBlockUserListByUid(userBox.Text);
            }
        }

        private void blockUserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (blockUserList.SelectedItem == null)
                return;
            string selectedUserId = blockUserList.SelectedItem.ToString();
            blockUserBox.SelectedIndex = blockUserBox.FindString(selectedUserId);
        }

        private void blockDepartmentBtn_Click(object sender, EventArgs e)
        {
            blockUserPanel.Visible = true;
        }

        private void blockUserBtn_Click(object sender, EventArgs e)
        {
            blockUserPanel.Visible = false;
        }
    }
}
