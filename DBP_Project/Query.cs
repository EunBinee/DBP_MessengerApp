using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DBP_Project
{
    class Query
    {
        private static Query instance = new Query();
        string query = "";

        private Query()
        {

        }

        public static Query GetInstance()
        {
            return instance;
        }
        
        public DataTable RunQuery(string q = "")
        {
            if (q == "")
                query = "SELECT NOW();";
            query = q;

            DataTable dt = new DataTable();
            string strConn = ConfigManager.GetInstance().GetConnString();
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                dt.Load(rdr);
            }

            return dt;
        }
    }
}
