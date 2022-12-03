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
    public partial class TestTreeForm : Form
    {
        private string loginUser = User_info.GetInstance().ID;
        //public TreeView tv = new TreeView();
        Profil pf = null;

        //public delegate void EventHandler(string data);

        public TestTreeForm()
        {
            //loginUser = User_info.GetInstance().id;
            InitializeComponent();
        }

        private void TestTreeForm_Load(object sender, EventArgs e)
        {
            SearchWizard.Text = "";
            SearchWord.Text = "";

            LoadTree();
            TreePanel.Controls.Add(tv);
            tv.Size = new System.Drawing.Size(600, 300);
            //TreeClickSet();
        }

        //전체 트리 생성 + 트리 초기화
        private void LoadTree()
        {
            tv.BackColor = Color.FromArgb(46, 51, 80);
            tv.ForeColor = Color.White;

            DataTable dt = Query.GetInstance().RunQuery("SELECT departmentName FROM UserDepartment, UserListTable WHERE "
                +"departmentName NOT IN (SELECT blockDepartment FROM BlockInfo WHERE userid = '" 
                + loginUser+"' AND blockDepartment IS NOT NULL) group by departmentName");
            foreach (DataRow dr in dt.Rows)
            {
                tv.Nodes.Add(dr["departmentName"].ToString());
            }

            dt = Query.GetInstance().RunQuery("SELECT departmentName, teamName FROM UserDepartment, UserListTable WHERE "
                + "departmentName NOT IN (SELECT blockDepartment FROM BlockInfo WHERE userid = '"
                + loginUser + "' AND blockDepartment IS NOT NULL) group by departmentName, teamName");
            foreach (DataRow dr in dt.Rows)
            {
                foreach(TreeNode tn in tv.Nodes)
                {
                    if (dr["departmentName"].ToString().Equals(tn.Text))
                    {
                        tn.Nodes.Add(dr["teamName"].ToString());
                    }
                }
            }

            dt = Query.GetInstance().RunQuery("SELECT l.departmentName, l.teamName, l.id, l.name, l.nickName, IFNULL(b.blockType, 0) as bType FROM" +
                "(SELECT * FROM UserDepartment, UserListTable WHERE id = userid AND NOT id = '" + loginUser + "') as l LEFT JOIN " +
                "(SELECT * FROM BlockInfo WHERE userId = '" + loginUser + "' AND blockType IS NOT NULL) as b ON l.id = b.blockUserId " +
                "WHERE l.departmentName NOT IN (SELECT blockDepartment FROM BlockInfo WHERE userid = '" + loginUser +
                "' AND blockDepartment IS NOT NULL)");
            foreach (DataRow dr in dt.Rows)
            {
                foreach (TreeNode tn in tv.Nodes)
                {
                    foreach (TreeNode ttn in tn.Nodes)
                    {
                        if (dr["teamName"].ToString().Equals(ttn.Text))
                        {
                            if (dr["bType"].ToString() != "1")
                            {
                                TreeNode ntn = new TreeNode(dr["nickName"].ToString() + "(" + dr["name"].ToString() + ")");
                                ntn.Name = dr["id"].ToString();
                                ttn.Nodes.Add(ntn);
                            }
                        }
                    }
                }
            }
            
        }

        private void FavoriteBtn_Click(object sender, EventArgs e)
        {
            tv.Nodes.Clear();

            SearchWizard.Text = "";
            SearchWord.Text = "";
            TreePanel.Controls.Clear();

            // 즐겨찾기 테이블 접근 후 즐겨찾기만 보여지게 하기
            FavoriteTreeLoad();

            TreePanel.Controls.Add(tv);
        }

        private void FavoriteTreeLoad()
        {
            DataTable dt = Query.GetInstance().RunQuery("SELECT departmentName FROM(SELECT departmentName, teamName, name, id " +
                $"FROM UserDepartment, UserListTable, (SELECT target_id FROM test_Favorite WHERE user_id = '{loginUser}') as t " +
                $"WHERE UserDepartment.userid = UserListTable.id AND UserListTable.id = t.target_id) as favorite " +
                $"WHERE departmentName NOT IN (SELECT blockDepartment FROM BlockInfo WHERE userid = '{loginUser}' AND " +
                $"blockDepartment IS NOT NULL) GROUP BY departmentName");
            if(dt.Rows.Count < 1)
            {
                MessageBox.Show("즐겨찾기가 없습니다.");
                return;
            }
            foreach (DataRow dr in dt.Rows)
            {
                tv.Nodes.Add(dr["departmentName"].ToString());
            }

            dt = Query.GetInstance().RunQuery("SELECT departmentName, teamName FROM(SELECT departmentName, teamName, name, id " +
                $"FROM UserDepartment, UserListTable, (SELECT target_id FROM test_Favorite WHERE user_id = '{loginUser}') as t " +
                $"WHERE UserDepartment.userid = UserListTable.id AND UserListTable.id = t.target_id) as favorite " +
                $"WHERE departmentName NOT IN (SELECT blockDepartment FROM BlockInfo WHERE userid = '{loginUser}' AND " +
                $"blockDepartment IS NOT NULL) GROUP BY departmentName, teamName");
            foreach (DataRow dr in dt.Rows)
            {
                foreach (TreeNode tn in tv.Nodes)
                {
                    if (dr["departmentName"].ToString().Equals(tn.Text))
                    {
                        tn.Nodes.Add(dr["teamName"].ToString());
                    }
                }
            }

            dt = Query.GetInstance().RunQuery("SELECT l.departmentName, l.teamName, l.id, l.name, l.nickName, IFNULL(b.blockType, 0) as bType FROM" +
                "(SELECT departmentName, teamName, name, nickName, id FROM(SELECT departmentName, teamName, name, nickName, id " +
                $"FROM UserDepartment, UserListTable, (SELECT target_id FROM test_Favorite WHERE user_id = '{loginUser}') as t " +
                $"WHERE UserDepartment.userid = UserListTable.id AND UserListTable.id = t.target_id) as favorite " +
                $"WHERE departmentName NOT IN (SELECT blockDepartment FROM BlockInfo WHERE userid = '{loginUser}' AND " +
                $"blockDepartment IS NOT NULL)) as l LEFT JOIN " +
                "(SELECT * FROM BlockInfo WHERE userId = '" + loginUser + "' AND blockType IS NOT NULL) as b ON l.id = b.blockUserId " +
                "WHERE l.departmentName NOT IN (SELECT blockDepartment FROM BlockInfo WHERE userid = '" + loginUser +
                "' AND blockDepartment IS NOT NULL)");
            foreach (DataRow dr in dt.Rows)
            {
                foreach (TreeNode tn in tv.Nodes)
                {
                    foreach (TreeNode ttn in tn.Nodes)
                    {
                        if (dr["teamName"].ToString().Equals(ttn.Text))
                        {
                            if (dr["bType"].ToString() != "1")
                            {
                                TreeNode ntn = new TreeNode(dr["nickName"].ToString() + "(" + dr["name"].ToString() + ")");
                                ntn.Name = dr["id"].ToString();
                                ttn.Nodes.Add(ntn);
                            }
                        }
                    }
                }
            }
        }

        private void TreeSearchBtn_Click(object sender, EventArgs e)
        {
            string wizard = SearchWizard.Text;
            string word = SearchWord.Text;
            DataTable dt;

            // 검색위저드, 검색 단어로 tree 재구성
            switch (wizard)
            {
                case "부서명":
                    dt = Query.GetInstance().RunQuery("select * from UserDepartment where departmentName like '%" + word + "%'");

                    if (dt.Rows.Count > 0)
                    {
                        tv.Nodes.Clear();
                        TreePanel.Controls.Clear();
                        SearchDepartment(wizard, word);
                        TreePanel.Controls.Add(tv);
                    }
                    else
                        MessageBox.Show("없습니다.");
                    break;

                case "ID":
                    dt = Query.GetInstance().RunQuery("select * from UserDepartment where userid like '%" + word + "%'");

                    if (dt.Rows.Count > 0)
                    {
                        tv.Nodes.Clear();
                        TreePanel.Controls.Clear();
                        SearchID(wizard, word);
                        TreePanel.Controls.Add(tv);
                    }
                    else
                        MessageBox.Show("없습니다.");
                    break;

                case "사원이름":
                    dt = Query.GetInstance().RunQuery("select * from UserDepartment, UserListTable where UserDepartment.userid = UserListTable.id and name like '%" + word + "%'");

                    if (dt.Rows.Count > 0)
                    {
                        tv.Nodes.Clear();
                        TreePanel.Controls.Clear();
                        SearchName(wizard, word);
                        TreePanel.Controls.Add(tv);
                    }
                    else
                        MessageBox.Show("없습니다.");
                    break;
                default:
                    MessageBox.Show("옳바른 위저드를 선택해주세요.");
                    break;
            }
        }

        private void SearchDepartment(string wizard, string word)
        {
            DataTable dt = Query.GetInstance().RunQuery("SELECT departmentName FROM UserDepartment, UserListTable WHERE "
                + "departmentName NOT IN (SELECT blockDepartment FROM BlockInfo WHERE userid = '"
                + loginUser + "' AND blockDepartment IS NOT NULL) AND UserListTable.id = UserDepartment.userid " +
                "AND departmentName LIKE '%"+word+"%' group by departmentName");
            foreach(DataRow dr in dt.Rows)
            {
                tv.Nodes.Add(dr["departmentName"].ToString());
            }

            dt = Query.GetInstance().RunQuery("select departmentId, departmentName, teamName from UserDepartment where departmentName like '%" + word + "%' group by departmentId, departmentName, teamName");
            foreach(DataRow dr in dt.Rows)
            {
                foreach (TreeNode tn in tv.Nodes)
                {
                    if (dr["departmentName"].ToString().Equals(tn.Text))
                    {
                        tn.Nodes.Add(dr["teamName"].ToString());
                    }
                }
            }

            dt = Query.GetInstance().RunQuery("SELECT l.departmentName, l.teamName, l.id, l.name, l.nickName, IFNULL(b.blockType, 0) as bType FROM" +
                "(SELECT * FROM UserDepartment, UserListTable WHERE id = userid AND NOT id = '" + loginUser + "') as l LEFT JOIN " +
                "(SELECT * FROM BlockInfo WHERE userId = '" + loginUser + "' AND blockType IS NOT NULL) as b ON l.id = b.blockUserId " +
                "WHERE l.departmentName NOT IN (SELECT blockDepartment FROM BlockInfo WHERE userid = '" + loginUser +
                "' AND blockDepartment IS NOT NULL)");
            foreach (DataRow dr in dt.Rows)
            {
                foreach (TreeNode tn in tv.Nodes)
                {
                    foreach (TreeNode ttn in tn.Nodes)
                    {
                        if (dr["teamName"].ToString().Equals(ttn.Text))
                        {
                            if (dr["bType"].ToString() != "1")
                            {
                                TreeNode ntn = new TreeNode(dr["nickName"].ToString() + "(" + dr["name"].ToString() + ")");
                                ntn.Name = dr["id"].ToString();
                                ttn.Nodes.Add(ntn);
                            }
                        }
                    }
                }
            }
        }

        private void SearchID(string wizard, string word)
        {
            DataTable dt = Query.GetInstance().RunQuery("SELECT departmentName FROM UserDepartment, UserListTable WHERE "
                + "departmentName NOT IN (SELECT blockDepartment FROM BlockInfo WHERE userid = '"
                + loginUser + "' AND blockDepartment IS NOT NULL) AND UserListTable.id = UserDepartment.userid " +
                "AND userid LIKE '%" + word + "%' group by departmentName");
            foreach (DataRow dr in dt.Rows)
            {
                tv.Nodes.Add(dr["departmentName"].ToString());
            }

            dt = Query.GetInstance().RunQuery("select departmentName, teamName from UserDepartment where userid like '%" + word + "%' group by departmentName, teamName");
            foreach (DataRow dr in dt.Rows)
            {
                foreach (TreeNode tn in tv.Nodes)
                {
                    if (dr["departmentName"].ToString().Equals(tn.Text))
                    {
                        tn.Nodes.Add(dr["teamName"].ToString());
                    }
                }
            }

            dt = Query.GetInstance().RunQuery("SELECT l.departmentName, l.teamName, l.id, l.name, l.nickName, IFNULL(b.blockType, 0) as bType FROM" +
                "(SELECT * FROM UserDepartment, UserListTable WHERE id = userid AND NOT id = '" + loginUser + "') as l LEFT JOIN " +
                "(SELECT * FROM BlockInfo WHERE userId = '" + loginUser + "' AND blockType IS NOT NULL) as b ON l.id = b.blockUserId " +
                "WHERE l.departmentName NOT IN (SELECT blockDepartment FROM BlockInfo WHERE userid = '" + loginUser +
                "' AND blockDepartment IS NOT NULL) AND l.id LIKE '%" + word + "%'");
            foreach (DataRow dr in dt.Rows)
            {
                foreach (TreeNode tn in tv.Nodes)
                {
                    foreach (TreeNode ttn in tn.Nodes)
                    {
                        if (dr["teamName"].ToString().Equals(ttn.Text))
                        {
                            if (dr["bType"].ToString() != "1")
                            {
                                TreeNode ntn = new TreeNode(dr["nickName"].ToString() + "(" + dr["name"].ToString() + ")");
                                ntn.Name = dr["id"].ToString();
                                ttn.Nodes.Add(ntn);
                            }
                        }
                    }
                }
            }
        }

        private void SearchName(string wizard, string word)
        {
            DataTable dt = Query.GetInstance().RunQuery("select departmentName from UserDepartment, UserListTable where UserDepartment." +
                "userid = UserListTable.id and name like '%" + word + "%' AND departmentName NOT IN " +
                "(SELECT blockDepartment FROM BlockInfo WHERE userid = '"
                + loginUser + "' AND blockDepartment IS NOT NULL) group by departmentName");
            foreach (DataRow dr in dt.Rows)
            {
                tv.Nodes.Add(dr["departmentName"].ToString());
            }

            dt = Query.GetInstance().RunQuery("select departmentId, departmentName, teamName from UserDepartment, UserListTable where UserDepartment.userid " +
                "= UserListTable.id and name like '%" + word + "%' group by departmentId, departmentName, teamName");
            foreach (DataRow dr in dt.Rows)
            {
                foreach (TreeNode tn in tv.Nodes)
                {
                    if (dr["departmentName"].ToString().Equals(tn.Text))
                    {
                        tn.Nodes.Add(dr["teamName"].ToString());
                    }
                }
            }

            dt = Query.GetInstance().RunQuery("SELECT l.departmentName, l.teamName, l.id, l.name, l.nickName, IFNULL(b.blockType, 0) as bType FROM" +
                "(SELECT * FROM UserDepartment, UserListTable WHERE id = userid AND NOT id = '" + loginUser + "') as l LEFT JOIN " +
                "(SELECT * FROM BlockInfo WHERE userId = '" + loginUser + "' AND blockType IS NOT NULL) as b ON l.id = b.blockUserId " +
                "WHERE l.departmentName NOT IN (SELECT blockDepartment FROM BlockInfo WHERE userid = '" + loginUser +
                "' AND blockDepartment IS NOT NULL) AND l.name LIKE '%" + word + "%'");
            foreach (DataRow dr in dt.Rows)
            {
                foreach (TreeNode tn in tv.Nodes)
                {
                    foreach (TreeNode ttn in tn.Nodes)
                    {
                        if (dr["teamName"].ToString().Equals(ttn.Text))
                        {
                            if (dr["bType"].ToString() != "1")
                            {
                                TreeNode ntn = new TreeNode(dr["nickName"].ToString() + "(" + dr["name"].ToString() + ")");
                                ntn.Name = dr["id"].ToString();
                                ttn.Nodes.Add(ntn);
                            }
                        }
                    }
                }
            }
        }

        private void TreeResetBtn_Click(object sender, EventArgs e)
        {
            tv.Nodes.Clear();

            SearchWizard.Text = "";
            SearchWord.Text = "";
            TreePanel.Controls.Clear();
    
            //부서와 팀, 팀원 전체가 tree로 재구성 
            LoadTree();

            TreePanel.Controls.Add(tv);
        }

        private void tv_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                tv.SelectedNode = e.Node;
            }

            if (e.Node.Level == 2)
            {
                if (pf != null)
                {
                    if (pf.targetID != "")
                        pf.Close();
                }
                pf = new Profil();
                pf.loginUser = this.loginUser;
                pf.targetID = e.Node.Name;
                pf.Show();
                
            }
        }
    }
}
