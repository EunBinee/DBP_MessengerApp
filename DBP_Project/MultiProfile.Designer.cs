
namespace DBP_Project
{
    partial class MultiProfile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_Photo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_photo_Button = new System.Windows.Forms.Button();
            this.textBox_NickName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Change_Button = new System.Windows.Forms.Button();
            this.button_addMultiEmployee = new System.Windows.Forms.Button();
            this.flowLayoutPanel_MultiProfile = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox_AddMultiEmployee = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Photo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 70);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label1.Font = new System.Drawing.Font("한컴산뜻돋움", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(127, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "멀티프로필 수정";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1, 70);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(430, 580);
            this.flowLayoutPanel2.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.pictureBox_Photo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button_photo_Button);
            this.panel2.Controls.Add(this.textBox_NickName);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 269);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox_Photo
            // 
            this.pictureBox_Photo.Image = global::DBP_Project.Properties.Resources._default;
            this.pictureBox_Photo.Location = new System.Drawing.Point(115, 26);
            this.pictureBox_Photo.Name = "pictureBox_Photo";
            this.pictureBox_Photo.Size = new System.Drawing.Size(150, 150);
            this.pictureBox_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Photo.TabIndex = 1;
            this.pictureBox_Photo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("한컴산뜻돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label3.Location = new System.Drawing.Point(38, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "닉네임";
            // 
            // button_photo_Button
            // 
            this.button_photo_Button.BackColor = System.Drawing.SystemColors.Window;
            this.button_photo_Button.Font = new System.Drawing.Font("한컴산뜻돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_photo_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button_photo_Button.Location = new System.Drawing.Point(271, 137);
            this.button_photo_Button.Name = "button_photo_Button";
            this.button_photo_Button.Size = new System.Drawing.Size(60, 39);
            this.button_photo_Button.TabIndex = 2;
            this.button_photo_Button.Text = "등록";
            this.button_photo_Button.UseVisualStyleBackColor = false;
            this.button_photo_Button.Click += new System.EventHandler(this.button_photo_Button_Click);
            // 
            // textBox_NickName
            // 
            this.textBox_NickName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_NickName.Location = new System.Drawing.Point(113, 205);
            this.textBox_NickName.Name = "textBox_NickName";
            this.textBox_NickName.Size = new System.Drawing.Size(216, 25);
            this.textBox_NickName.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.Change_Button);
            this.panel3.Controls.Add(this.button_addMultiEmployee);
            this.panel3.Controls.Add(this.flowLayoutPanel_MultiProfile);
            this.panel3.Controls.Add(this.comboBox_AddMultiEmployee);
            this.panel3.Location = new System.Drawing.Point(3, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 438);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("한컴산뜻돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label2.Location = new System.Drawing.Point(51, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "멀티프로필을 적용할 사원";
            // 
            // Change_Button
            // 
            this.Change_Button.BackColor = System.Drawing.SystemColors.Window;
            this.Change_Button.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Change_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Change_Button.Location = new System.Drawing.Point(86, 340);
            this.Change_Button.Name = "Change_Button";
            this.Change_Button.Size = new System.Drawing.Size(214, 59);
            this.Change_Button.TabIndex = 24;
            this.Change_Button.Text = "변경";
            this.Change_Button.UseVisualStyleBackColor = false;
            this.Change_Button.Click += new System.EventHandler(this.Change_Button_Click);
            // 
            // button_addMultiEmployee
            // 
            this.button_addMultiEmployee.Location = new System.Drawing.Point(271, 260);
            this.button_addMultiEmployee.Name = "button_addMultiEmployee";
            this.button_addMultiEmployee.Size = new System.Drawing.Size(75, 23);
            this.button_addMultiEmployee.TabIndex = 4;
            this.button_addMultiEmployee.Text = "추가";
            this.button_addMultiEmployee.UseVisualStyleBackColor = true;
            this.button_addMultiEmployee.Click += new System.EventHandler(this.button_addMultiEmployee_Click);
            // 
            // flowLayoutPanel_MultiProfile
            // 
            this.flowLayoutPanel_MultiProfile.AutoScroll = true;
            this.flowLayoutPanel_MultiProfile.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_MultiProfile.Location = new System.Drawing.Point(52, 59);
            this.flowLayoutPanel_MultiProfile.Name = "flowLayoutPanel_MultiProfile";
            this.flowLayoutPanel_MultiProfile.Size = new System.Drawing.Size(294, 189);
            this.flowLayoutPanel_MultiProfile.TabIndex = 0;
            this.flowLayoutPanel_MultiProfile.WrapContents = false;
            // 
            // comboBox_AddMultiEmployee
            // 
            this.comboBox_AddMultiEmployee.FormattingEnabled = true;
            this.comboBox_AddMultiEmployee.Location = new System.Drawing.Point(52, 261);
            this.comboBox_AddMultiEmployee.Name = "comboBox_AddMultiEmployee";
            this.comboBox_AddMultiEmployee.Size = new System.Drawing.Size(201, 23);
            this.comboBox_AddMultiEmployee.TabIndex = 3;
            // 
            // MultiProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 649);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Name = "MultiProfile";
            this.Text = "MultiProfile";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Photo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Change_Button;
        private System.Windows.Forms.PictureBox pictureBox_Photo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_photo_Button;
        private System.Windows.Forms.TextBox textBox_NickName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_addMultiEmployee;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_MultiProfile;
        private System.Windows.Forms.ComboBox comboBox_AddMultiEmployee;
        private System.Windows.Forms.Label label2;
    }
}