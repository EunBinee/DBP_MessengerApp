﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_Project
{
    public partial class Message : UserControl
    {
        public Message()
        {
            InitializeComponent();
        }
        public Message(string str)
        {
            InitializeComponent();
            this.msgBox.Text = str;
            this.msgBox.AutoSize = true;
            this.msgBox.MaximumSize = new Size(240, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Message_Load(object sender, EventArgs e)
        {
            int size = (msgBox.Text.Length / 35) - 1;
            this.Size = new Size(this.Size.Width, (120 + 25 * size));   
        }

        public void SetDefault()
        {
            this.senderImg.Visible = true;
            this.senderName.Visible = true;
            backPanel.Location = new Point(90, 36);
            sendTimeLabel.Location = new Point(270, 20);
        }
        public void SetMyMsg()
        {
            this.senderImg.Visible = false;
            this.senderName.Visible = false;
            backPanel.Location = new Point(110, 36);
            sendTimeLabel.Location = new Point(290, 20);
            msgBox.BackColor = SystemColors.Info;
            backPanel.BackColor = SystemColors.Info;
        }
        public void SetData(string name, string time)
        {
            senderName.Text = name;
            sendTimeLabel.Text = time;
        }

    }
}
