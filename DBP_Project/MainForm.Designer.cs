
namespace DBP_Project
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.Move_Admin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MainFormPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.toManagerForm = new System.Windows.Forms.Button();
            this.toUserMangerForm = new System.Windows.Forms.Button();
            this.Tray_Icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Context_TrayIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Context_TrayIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.logOutBtn);
            this.panel1.Controls.Add(this.Move_Admin);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 550);
            this.panel1.TabIndex = 0;
            // 
            // logOutBtn
            // 
            this.logOutBtn.FlatAppearance.BorderSize = 0;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.logOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logOutBtn.Image")));
            this.logOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutBtn.Location = new System.Drawing.Point(31, 464);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(186, 42);
            this.logOutBtn.TabIndex = 1;
            this.logOutBtn.Text = "Logout";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // Move_Admin
            // 
            this.Move_Admin.FlatAppearance.BorderSize = 0;
            this.Move_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Move_Admin.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Move_Admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Move_Admin.Image = ((System.Drawing.Image)(resources.GetObject("Move_Admin.Image")));
            this.Move_Admin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Move_Admin.Location = new System.Drawing.Point(25, 306);
            this.Move_Admin.Name = "Move_Admin";
            this.Move_Admin.Size = new System.Drawing.Size(186, 42);
            this.Move_Admin.TabIndex = 1;
            this.Move_Admin.Text = "Admin";
            this.Move_Admin.UseVisualStyleBackColor = true;
            this.Move_Admin.Click += new System.EventHandler(this.Move_Admin_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(29, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Chatting";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(29, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tree Chart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MainFormPanel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.name_label);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 173);
            this.panel2.TabIndex = 0;
            // 
            // MainFormPanel
            // 
            this.MainFormPanel.Location = new System.Drawing.Point(230, 0);
            this.MainFormPanel.Name = "MainFormPanel";
            this.MainFormPanel.Size = new System.Drawing.Size(724, 538);
            this.MainFormPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(72, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 3;
            // 
            // name_label
            // 
            this.name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.name_label.Location = new System.Drawing.Point(72, 118);
            this.name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(93, 18);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "User Name";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DBP_Project.Properties.Resources._default;
            this.pictureBox1.Location = new System.Drawing.Point(75, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button6.Location = new System.Drawing.Point(908, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 28);
            this.button6.TabIndex = 1;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // toManagerForm
            // 
            this.toManagerForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toManagerForm.Image = ((System.Drawing.Image)(resources.GetObject("toManagerForm.Image")));
            this.toManagerForm.Location = new System.Drawing.Point(258, 464);
            this.toManagerForm.Name = "toManagerForm";
            this.toManagerForm.Size = new System.Drawing.Size(61, 44);
            this.toManagerForm.TabIndex = 40;
            this.toManagerForm.UseVisualStyleBackColor = true;
            this.toManagerForm.Visible = false;
            this.toManagerForm.Click += new System.EventHandler(this.toManagerForm_Click);
            // 
            // toUserMangerForm
            // 
            this.toUserMangerForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toUserMangerForm.Image = ((System.Drawing.Image)(resources.GetObject("toUserMangerForm.Image")));
            this.toUserMangerForm.Location = new System.Drawing.Point(258, 464);
            this.toUserMangerForm.Name = "toUserMangerForm";
            this.toUserMangerForm.Size = new System.Drawing.Size(61, 44);
            this.toUserMangerForm.TabIndex = 39;
            this.toUserMangerForm.UseVisualStyleBackColor = true;
            this.toUserMangerForm.Visible = false;
            this.toUserMangerForm.Click += new System.EventHandler(this.toUserMangerForm_Click);
            // 
            // Tray_Icon
            // 
            this.Tray_Icon.Icon = ((System.Drawing.Icon)(resources.GetObject("Tray_Icon.Icon")));
            this.Tray_Icon.Text = "notifyIcon1";
            this.Tray_Icon.Visible = true;
            this.Tray_Icon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Tray_Icon_MouseDoubleClick);
            // 
            // Context_TrayIcon
            // 
            this.Context_TrayIcon.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Context_TrayIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.Context_TrayIcon.Name = "contextMenuStrip1";
            this.Context_TrayIcon.Size = new System.Drawing.Size(211, 80);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.showToolStripMenuItem.Text = "show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.Location = new System.Drawing.Point(859, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 28);
            this.button3.TabIndex = 42;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.toManagerForm);
            this.Controls.Add(this.toUserMangerForm);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Context_TrayIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button Move_Admin;
        // private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel MainFormPanel;
        //private System.Windows.Forms.Button Button_UserInfo_Change;
        //private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button toUserMangerForm;
        private System.Windows.Forms.Button toManagerForm;
        private System.Windows.Forms.NotifyIcon Tray_Icon;
        private System.Windows.Forms.ContextMenuStrip Context_TrayIcon;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button3;
    }
}