using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_Project
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Client.GetInstance().StartListen();
            //Query.GetInstance().RunQuery("SELECT NOW()");
            Client.GetInstance().StartListen();
            Query.GetInstance().RunQuery("SELECT NOW()");
            //Application.Run(new LogIn());
            Application.Run(new Chat());
        }
    }
}
