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
    public partial class Notice : UserControl
    {
        public Notice()
        {
            InitializeComponent();
        }
        public Notice(string str)
        {
            InitializeComponent();
            this.label1.Text = str;
        }
    }
}
