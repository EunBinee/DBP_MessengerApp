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
            label1.AutoSize = true;
            label1.MaximumSize = new Size(300, 40);
        }
        public Notice(string str)
        {
            InitializeComponent();
            this.label1.Text = str;
            label1.AutoSize = true;
            label1.MaximumSize = new Size(300,40);
        }
        public void setText(string str)
        {
            this.label1.Text = str;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
