
namespace DBP_Project
{
    partial class Profil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProfilLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.OpenChatRoomBtn = new System.Windows.Forms.Button();
            this.FavoriteCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(124, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ProfilLabel
            // 
            this.ProfilLabel.AutoSize = true;
            this.ProfilLabel.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ProfilLabel.Location = new System.Drawing.Point(120, 19);
            this.ProfilLabel.Name = "ProfilLabel";
            this.ProfilLabel.Size = new System.Drawing.Size(73, 21);
            this.ProfilLabel.TabIndex = 1;
            this.ProfilLabel.Text = "프로필";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "이름:";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button6.Location = new System.Drawing.Point(279, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 28);
            this.button6.TabIndex = 3;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // OpenChatRoomBtn
            // 
            this.OpenChatRoomBtn.Location = new System.Drawing.Point(104, 239);
            this.OpenChatRoomBtn.Name = "OpenChatRoomBtn";
            this.OpenChatRoomBtn.Size = new System.Drawing.Size(101, 35);
            this.OpenChatRoomBtn.TabIndex = 4;
            this.OpenChatRoomBtn.Text = "채팅방 입장";
            this.OpenChatRoomBtn.UseVisualStyleBackColor = true;
            this.OpenChatRoomBtn.Click += new System.EventHandler(this.OpenChatRoomBtn_Click);
            // 
            // FavoriteCheckBox
            // 
            this.FavoriteCheckBox.AutoSize = true;
            this.FavoriteCheckBox.Location = new System.Drawing.Point(12, 24);
            this.FavoriteCheckBox.Name = "FavoriteCheckBox";
            this.FavoriteCheckBox.Size = new System.Drawing.Size(72, 16);
            this.FavoriteCheckBox.TabIndex = 5;
            this.FavoriteCheckBox.Text = "즐겨찾기";
            this.FavoriteCheckBox.UseVisualStyleBackColor = true;
            this.FavoriteCheckBox.CheckedChanged += new System.EventHandler(this.FavoriteCheckBox_CheckedChanged);
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 306);
            this.Controls.Add(this.FavoriteCheckBox);
            this.Controls.Add(this.OpenChatRoomBtn);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProfilLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profil";
            this.Text = "Profil";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Profil_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Profil_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Profil_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Profil_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ProfilLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button OpenChatRoomBtn;
        private System.Windows.Forms.CheckBox FavoriteCheckBox;
    }
}