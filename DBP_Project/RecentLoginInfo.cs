using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBP_Project
{
    [Serializable]
    class RecentLoginInfo
    {
        private static RecentLoginInfo instance = new RecentLoginInfo();
        //생성자
        private RecentLoginInfo()
        {

        }

        private string isChecked;
        private string recentId;
        private string recentPwd;
        private string isAutoLogin;

        public static RecentLoginInfo GetInstance()
        {
            return instance;
        }


        public void changeValue(string isChecked, string recentId, string recentPwd, string isAutoLogin)
        {
            this.isChecked = isChecked;
            this.recentId = recentId;
            this.recentPwd = recentPwd;
            this.isAutoLogin = isAutoLogin;
        }
        
        public string Check
        {
            get
            {
                return isChecked;
            }
            set
            {
                isChecked = value;
            }
        }

        public string RecentId
        {
            get
            {
                return recentId;
            }
            set
            {
                recentId = value;
            }
        }

        public string RecentPwd
        {
            get
            {
                return recentPwd;
            }
            set
            {
                recentPwd = value;
            }
        }

        public string AutoLogin
        {
            get
            {
                return isAutoLogin;
            }
            set
            {
                isAutoLogin = value;
            }
        }


    }
}
