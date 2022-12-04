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
        public string isChecked;
        public string recentId;
        public string recentPwd;

        public RecentLoginInfo()
        {
            this.isChecked = "false";
            this.recentId = "";
            this.recentPwd = "";
        }

        public RecentLoginInfo(string isChecked, string recentId, string recentPwd)
        {
            this.isChecked = isChecked;
            this.recentId = recentId;
            this.recentPwd = recentPwd;
        }

}
}
