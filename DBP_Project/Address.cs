using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;

namespace DBP_Project
{

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Address : Form
    {
        private WebBrowser webBrowser1 = new WebBrowser();  //동적으로 웹브라우저 생성
        public string gstrZipCode = "";
        public string gstrAddress1 = "";

        public Address()
        {
            webBrowser1.Dock = DockStyle.Fill;
            Controls.Add(webBrowser1);

            InitializeComponent();
        }

        private void Address_Load(object sender, EventArgs e)
        {
            //webBrowser1.AllowWebBrowserDrop = false;
            //  webBrowser1.IsWebBrowserContextMenuEnabled = false;
            // webBrowser1.WebBrowserShortcutsEnabled = false;
            webBrowser1.Navigate("http://15.164.218.208/test.html");

            webBrowser1.ObjectForScripting = this;
        }

        public void CallForm(object sZipCode, object sAddress1)
        {
            try
            {
                gstrZipCode = (string)sZipCode;
                gstrAddress1 = (string)sAddress1;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



    }
}
