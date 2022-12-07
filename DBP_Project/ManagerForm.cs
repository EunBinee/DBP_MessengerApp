using MySql.Data.MySqlClient;
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
    public partial class ManagerForm : Form
    {
        String strConn = "Server =15.164.218.208;" + "database = talk; uid = dbp; pwd = dbp; Charset=utf8;";

        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strConn))
            {
                connection.Open();
                String SelectQuery = "select * from UserListTable"; // 조회
                MySqlCommand cmd = new MySqlCommand(SelectQuery, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if (Int32.Parse(rdr["role"].ToString()) == 2)
                    {
                        UserSelectBox.Items.Add(rdr["id"].ToString());
                    }
                }
                connection.Close();
            }
        }

        private void Btn_Move_UserManager(object sender, EventArgs e)
        {
            this.Visible = false;
            UserManagerForm usermanagerForm = new UserManagerForm();
            usermanagerForm.ShowDialog();
        }

        private void Btn_Search_By_Time(object sender, EventArgs e)
        {
            string From_time = FromTimePicker.Value.ToString("yyyy/MM/dd HH:mm:ss");
            string To_time = ToTimePicker.Value.ToString("yyyy/MM/dd HH:mm:ss");

            using (MySqlConnection connection = new MySqlConnection(strConn))
            {
                connection.Open();
                String Query = String.Format("SELECT * FROM ChatMsg WHERE send_time BETWEEN '{0}' AND '{1}';", From_time, To_time);
                MySqlCommand cmd = new MySqlCommand(Query, connection);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                
                DataTable dt = new DataTable();
                da.Fill(dt);

                Manager_Screen.DataSource = dt;
                connection.Close();
            }
        }

        private void Btn_Search_Keyword(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strConn))
            {
                connection.Open();
                String Query = String.Format("select * from ChatMsg where data like '%{0}%';",KeyWord_TextBox.Text);
                MySqlCommand cmd = new MySqlCommand(Query, connection);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                Manager_Screen.DataSource = dt;

                connection.Close();
            }
        }

        private void Btn_Search_User(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strConn))
            {
                connection.Open();
                String Query = String.Format("select * from talk.ChatMsg where sender_ID = '{0}' OR recv_ID = '{0}';",UserSelectBox.SelectedItem.ToString());
                MySqlCommand cmd = new MySqlCommand(Query, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                Manager_Screen.DataSource = dt;

                connection.Close();
            }
        }

        private void Btn_Lookup_Department(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strConn))
            {
                connection.Open();
                String Query = String.Format("select * from departmentList;");


                MySqlCommand cmd = new MySqlCommand(Query,connection);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                Manager_Screen.DataSource = dt;

                MySqlDataReader rdr = cmd.ExecuteReader();
            }
        }

        private void Btn_Panel_On(object sender, EventArgs e)
        {
            addDepartmentPanel.Location = new Point(20, 20);
            addDepartmentPanel.Visible = true;
            Add_Team_Panel.Visible = false;
            ChangeDepartmentPanel.Visible = false;
            ChangeTeamPanel.Visible = false;
            addDepartmentPanel.BringToFront();
        }

        private void Btn_Panel_Off(object sender, EventArgs e)
        {
            addDepartmentPanel.Visible = false;
            Add_Department_Text.Text = "";
            Add_Team_Text.Text = "";
        }

        private void Btn_Add_Department(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strConn))
            {
                int count = 1;
                int chk = 0;
                int Row = 0;
                connection.Open();
                String SelectQuery = "select * from departmentList"; // 조회
                String InsertQuery = "";
                MySqlCommand cmd = new MySqlCommand(SelectQuery, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) {
                    if (rdr["departmentName"].ToString() == Add_Department_Text.Text) {
                        chk = 1;
                        count = Int32.Parse(rdr["departmentID"].ToString());
                        break;
                    }
                    count = Int32.Parse(rdr["departmentID"].ToString());
                    Row = Int32.Parse(rdr["Row_num"].ToString());
                }
                connection.Close();

                if (chk == 1)
                {
                    InsertQuery = String.Format("insert into departmentList values ({0}, {1},'{2}','{3}')",
                                Row + 1,count.ToString(), Add_Department_Text.Text, Add_Team_Text.Text);
                    connection.Open();
                    cmd = new MySqlCommand(InsertQuery, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return;
                }

                count++;
                InsertQuery = String.Format("insert into departmentList values ({0}, {1},'{2}','{3}')",
                                Row + 1, count.ToString(), Add_Department_Text.Text, Add_Team_Text.Text);
                connection.Open();
                cmd = new MySqlCommand(InsertQuery, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            addDepartmentPanel.Visible = false;
            Btn_Lookup_Department(null, null);
            Add_Department_Text.Text = "";
            Add_Team_Text.Text = "";
        }

        private void Btn_Manage_UserDepartment(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeDepartmentPanel.Visible = false;
            textBox1.Text = "";
            DepartmentComboBox.SelectedIndex = -1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeTeamPanel.Visible = false;
            ChangeTeamPanel_Team_Info.SelectedIndex = -1;
            ChangeTeamPanel_TextBox.Text = "";
        }

        private void Change_Team_Click(object sender, EventArgs e)
        {

            ChangeTeamPanel.Location = new Point(20, 20);
            addDepartmentPanel.Visible = false;
            Add_Team_Panel.Visible = false;
            ChangeDepartmentPanel.Visible = false;
            ChangeTeamPanel.Visible = true;
            ChangeTeamPanel_Department_Info.Items.Clear();
            ChangeTeamPanel_Team_Info.Items.Clear();

            ChangeTeamPanel_Department_Info.SelectedIndex = -1;
            ChangeTeamPanel_Team_Info.SelectedIndex = -1;
            ChangeTeamPanel_TextBox.Text = "";

            List<String> list = new List<string>();
            List<String> list2 = new List<string>();

            using (MySqlConnection connection = new MySqlConnection(strConn))
            {
                connection.Open();
                String SelectQuery = "select * from departmentList"; // 조회
                MySqlCommand cmd = new MySqlCommand(SelectQuery, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    list2.Add(rdr["departmentName"].ToString());
                }
                list2 = list2.Distinct().ToList();

                ChangeTeamPanel_Department_Info.Items.AddRange(list2.ToArray());
                connection.Close();
            }
        }

        private void Change_Department_Click(object sender, EventArgs e)
        {

            ChangeDepartmentPanel.Location = new Point(20, 20);
            addDepartmentPanel.Visible = false;
            Add_Team_Panel.Visible = false;
            ChangeDepartmentPanel.Visible = true;
            ChangeTeamPanel.Visible = false;

            DepartmentComboBox.Items.Clear();
            List<String> list = new List<String>();
            using (MySqlConnection connection = new MySqlConnection(strConn))
            {
                connection.Open();
                String SelectQuery = "select * from departmentList"; // 조회
                MySqlCommand cmd = new MySqlCommand(SelectQuery, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(rdr["departmentName"].ToString());
                }
                list = list.Distinct().ToList();
                DepartmentComboBox.Items.AddRange(list.ToArray());
                connection.Close();
            }
        }

        private void Change_Department_Info_Click(object sender, EventArgs e) // 부서정보 변경
        {
            using (MySqlConnection connection = new MySqlConnection(strConn))
            {
                connection.Open();
                String Query = String.Format("update departmentList set departmentName = '{0}' where departmentName = '{1}';"
                    ,textBox1.Text,DepartmentComboBox.SelectedItem.ToString());
                MySqlCommand cmd = new MySqlCommand(Query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                Query = String.Format("update UserDepartment set departmentName = '{0}' where departmentName = '{1}';"
                    ,textBox1.Text,DepartmentComboBox.SelectedItem.ToString());
                cmd = new MySqlCommand(Query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            Btn_Lookup_Department(null, null);
            ChangeDepartmentPanel.Visible = false;
            DepartmentComboBox.SelectedIndex = -1;
            textBox1.Text = "";
        }

        private void Change_Team_Info_Click(object sender, EventArgs e) // 팀정보 변경
        {
            using (MySqlConnection connection = new MySqlConnection(strConn))
            {
                connection.Open();
                String Query = String.Format("update departmentList set teamName = '{0}' where teamName = '{1}' and departmentName = '{2}';"
                    , ChangeTeamPanel_TextBox.Text, ChangeTeamPanel_Team_Info.SelectedItem.ToString(), ChangeTeamPanel_Department_Info.SelectedItem.ToString());
                MySqlCommand cmd = new MySqlCommand(Query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                Query = String.Format("update UserDepartment set teamName = '{0}' where teamName = '{1}' and departmentName = '{2}';"
                    , ChangeTeamPanel_TextBox.Text, ChangeTeamPanel_Team_Info.SelectedItem.ToString(), ChangeTeamPanel_Department_Info.SelectedItem.ToString());
                cmd = new MySqlCommand(Query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            Btn_Lookup_Department(null, null);
            ChangeTeamPanel.Visible = false;
            ChangeTeamPanel_Team_Info.SelectedItem = -1;
            ChangeTeamPanel_TextBox.Text = "";
        }

        private void Add_Team_Click(object sender, EventArgs e)
        {
            Add_Team_Panel.Location = new Point(20, 20);
            addDepartmentPanel.Visible = false;
            Add_Team_Panel.Visible = true;
            ChangeDepartmentPanel.Visible = false;
            ChangeTeamPanel.Visible = false;

            Add_Team_ComboBox.Items.Clear();
            List<String> list = new List<string>();
            using (MySqlConnection connection = new MySqlConnection(strConn))
            {
                connection.Open();
                String SelectQuery = "select * from departmentList"; // 조회
                MySqlCommand cmd = new MySqlCommand(SelectQuery, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(rdr["DepartmentName"].ToString());
                }
                list = list.Distinct().ToList();
                Add_Team_ComboBox.Items.AddRange(list.ToArray());
                connection.Close();
            }
        }

        private void Btn_Add_Team_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strConn))
            {
                int count = 1;
                int chk = 0;
                int Row = 0;
                connection.Open();
                String SelectQuery = "select * from departmentList"; // 조회
                String InsertQuery = "";
                MySqlCommand cmd = new MySqlCommand(SelectQuery, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    if (rdr["teamName"].ToString() == Add_Team_TextBox.Text) {
                        if (rdr["departmentName"].ToString() == Add_Team_ComboBox.SelectedItem.ToString())
                        {
                            MessageBox.Show("이미 존재하는 팀명입니다!");
                            chk = 1;
                        }
                    }
                    count = Int32.Parse(rdr["departmentID"].ToString());
                    Row = Int32.Parse(rdr["Row_num"].ToString());
                }

                connection.Close();

                if (chk == 0)
                {
                    InsertQuery = String.Format("insert into departmentList values ({0}, {1},'{2}','{3}')",
                                    Row + 1, count.ToString(),Add_Team_ComboBox.SelectedItem.ToString(),Add_Team_TextBox.Text); // 요기수정
                    connection.Open();
                    cmd = new MySqlCommand(InsertQuery, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }

            using (MySqlConnection connection = new MySqlConnection(strConn))
            {
                Add_Team_Panel.Visible = false;
                connection.Open();
                String Query = String.Format("SELECT * FROM talk.departmentList;");
                MySqlCommand cmd = new MySqlCommand(Query, connection);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                Manager_Screen.DataSource = dt;
                connection.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Team_Panel.Visible = false;
        }

        private void ChangeTeamPanel_Department_Info_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeTeamPanel_Team_Info.Items.Clear();
            using (MySqlConnection connection = new MySqlConnection(strConn))
            {
                connection.Open();
                string Query = String.Format("select * from departmentList where departmentName = '{0}'",ChangeTeamPanel_Department_Info.SelectedItem.ToString());
                MySqlCommand cmd = new MySqlCommand(Query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ChangeTeamPanel_Team_Info.Items.Add(rdr["teamName"].ToString());
                }
                connection.Close();
            }
        }

        private void SearchLog_By_User_Click(object sender, EventArgs e)
        {
            if(UserSelectBox.SelectedIndex == -1) {
                MessageBox.Show("유저를 선택 해주세요.");
                return;
            }
            string q = $"SELECT * FROM LogInHistory Where userId = '{UserSelectBox.SelectedItem.ToString()}'";
            DataTable dt = Query.GetInstance().RunQuery(q);
            Manager_Screen.DataSource = dt;
        }
    }
}
