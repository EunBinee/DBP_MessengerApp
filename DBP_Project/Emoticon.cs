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
    public partial class Emoticon : Form
    {
        public Chat chat;
        public Emoticon()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            chat.SendEmo("emo/001.png");
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            chat.SendEmo("emo/002.png");
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            chat.SendEmo("emo/003.png");
            Close();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            chat.SendEmo("emo/004.png");
            Close();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            chat.SendEmo("emo/005.png");
            Close();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            chat.SendEmo("emo/006.png");
            Close();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            chat.SendEmo("emo/007.png");
            Close();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            chat.SendEmo("emo/008.png");
            Close();

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            chat.SendEmo("emo/009.png");
            Close();

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            chat.SendEmo("emo/010.png");
            Close();

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            chat.SendEmo("emo/011.png");
            Close();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            chat.SendEmo("emo/012.png");
            Close();

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            chat.SendEmo("emo/013.png");
            Close();

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            chat.SendEmo("emo/014.png");
            Close();

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            chat.SendEmo("emo/015.png");
            Close();

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            chat.SendEmo("emo/016.png");
            Close();

        }
    }
}
