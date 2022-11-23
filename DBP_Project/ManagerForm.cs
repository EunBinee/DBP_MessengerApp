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

        private void Btn_Move_UserManager(object sender, EventArgs e)
        {
            this.Visible = false;
            UserManagerForm usermanagerForm = new UserManagerForm();
            usermanagerForm.ShowDialog();
        }

        private void Btn_Search_By_Time(object sender, EventArgs e)
        {
            string From_time = FromTimePicker.Value.ToString("yyyy/MM/dd hh:mm:ss");
            string To_time = ToTimePicker.Value.ToString("yyyy/MM/dd hh:mm:ss");

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
                String Query = String.Format("select data from ChatMsg where data like '%{0}%';",KeyWord_TextBox.Text);
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
                String Query = String.Format("select * from ChatMsg where sender_ID = '{0}';", User_TextBox.Text);
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

                while (rdr.Read()) {
                    departmentBox.Items.Add(rdr["departmentName"].ToString());
                    teamBox.Items.Add(rdr["teamName"].ToString());
                }
            }
        }

        private void Btn_Panel_On(object sender, EventArgs e)
        {
            addDepartmentPanel.Visible = true;
        }

        private void Btn_Panel_Off(object sender, EventArgs e)
        {
            addDepartmentPanel.Visible = false;
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
        }

        private void Btn_Change_Save(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strConn))
            {
                connection.Open();
                String Query;
                foreach (DataGridViewRow row in Manager_Screen.Rows) {
                    if (row.Cells["Row_num"].Value == null) {
                        break;
                    }
                    int Row = Int32.Parse(row.Cells["Row_num"].Value.ToString());
                    int departmentId = Int32.Parse(row.Cells["departmentId"].Value.ToString());
                    String departmentName = row.Cells["departmentName"].Value.ToString();
                    String teamName = row.Cells["teamName"].Value.ToString();
                    Query = String.Format("update departmentList set departmentId = {0}, departmentName = '{1}', teamName = '{2}' where Row_num = {3};"
                        , departmentId, departmentName, teamName, Row);
                    MySqlCommand cmd = new MySqlCommand(Query, connection);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void Btn_Manage_UserDepartment(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(strConn))
            {
                connection.Open();
                String Query = String.Format("select * from UserDepartment;");
                MySqlCommand cmd = new MySqlCommand(Query, connection);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                Manager_Screen.DataSource = dt;

                connection.Close();
            }
        }
    }
}
