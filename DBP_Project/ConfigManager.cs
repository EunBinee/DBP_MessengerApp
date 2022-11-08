using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBP_Project
{
    class ConfigManager
    {
        private static ConfigManager instance = new ConfigManager();
        private string strConn = "Server=15.164.218.208; Database=talk; Uid=dbp; Pwd=dbp; Charset=utf8;";

        private ConfigManager()
        {

        }

        public static ConfigManager GetInstance()
        {
            return instance;
        }

        public string GetConnString()
        {
            return strConn;
        }
    }
}
