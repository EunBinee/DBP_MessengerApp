
namespace DBP_Project
{
    partial class ManagerForm
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
            this.addDepartmentPanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.Add_Info = new System.Windows.Forms.Button();
            this.Add_Team_Text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Add_Department_Text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Manager_Screen = new System.Windows.Forms.DataGridView();
            this.Change_Department = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Search_By_User = new System.Windows.Forms.Button();
            this.Search_By_Keyword = new System.Windows.Forms.Button();
            this.User_TextBox = new System.Windows.Forms.TextBox();
            this.KeyWord_TextBox = new System.Windows.Forms.TextBox();
            this.ToTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Search_By_Date = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Change_Team = new System.Windows.Forms.Button();
            this.Add_Department = new System.Windows.Forms.Button();
            this.Lookup_Department = new System.Windows.Forms.Button();
            this.ChangeDepartmentPanel = new System.Windows.Forms.Panel();
            this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Change_Department_Info = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ChangeTeamPanel = new System.Windows.Forms.Panel();
            this.TeamComboBox = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.Change_Team_Info = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addDepartmentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Manager_Screen)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ChangeDepartmentPanel.SuspendLayout();
            this.ChangeTeamPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addDepartmentPanel
            // 
            this.addDepartmentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.addDepartmentPanel.Controls.Add(this.button4);
            this.addDepartmentPanel.Controls.Add(this.Add_Info);
            this.addDepartmentPanel.Controls.Add(this.Add_Team_Text);
            this.addDepartmentPanel.Controls.Add(this.label5);
            this.addDepartmentPanel.Controls.Add(this.Add_Department_Text);
            this.addDepartmentPanel.Controls.Add(this.label4);
            this.addDepartmentPanel.ForeColor = System.Drawing.Color.White;
            this.addDepartmentPanel.Location = new System.Drawing.Point(25, 50);
            this.addDepartmentPanel.Name = "addDepartmentPanel";
            this.addDepartmentPanel.Size = new System.Drawing.Size(274, 250);
            this.addDepartmentPanel.TabIndex = 18;
            this.addDepartmentPanel.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(227, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 24);
            this.button4.TabIndex = 5;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Btn_Panel_Off);
            // 
            // Add_Info
            // 
            this.Add_Info.ForeColor = System.Drawing.Color.Black;
            this.Add_Info.Location = new System.Drawing.Point(83, 183);
            this.Add_Info.Name = "Add_Info";
            this.Add_Info.Size = new System.Drawing.Size(99, 42);
            this.Add_Info.TabIndex = 4;
            this.Add_Info.Text = "추가";
            this.Add_Info.UseVisualStyleBackColor = true;
            this.Add_Info.Click += new System.EventHandler(this.Btn_Add_Department);
            // 
            // Add_Team_Text
            // 
            this.Add_Team_Text.ForeColor = System.Drawing.Color.Black;
            this.Add_Team_Text.Location = new System.Drawing.Point(54, 137);
            this.Add_Team_Text.Name = "Add_Team_Text";
            this.Add_Team_Text.Size = new System.Drawing.Size(151, 25);
            this.Add_Team_Text.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "추가할 팀명";
            // 
            // Add_Department_Text
            // 
            this.Add_Department_Text.ForeColor = System.Drawing.Color.Black;
            this.Add_Department_Text.Location = new System.Drawing.Point(54, 70);
            this.Add_Department_Text.Name = "Add_Department_Text";
            this.Add_Department_Text.Size = new System.Drawing.Size(151, 25);
            this.Add_Department_Text.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "추가할 부서명";
            // 
            // Manager_Screen
            // 
            this.Manager_Screen.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Manager_Screen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Manager_Screen.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.Manager_Screen.Location = new System.Drawing.Point(10, 11);
            this.Manager_Screen.Name = "Manager_Screen";
            this.Manager_Screen.RowHeadersWidth = 51;
            this.Manager_Screen.RowTemplate.Height = 27;
            this.Manager_Screen.Size = new System.Drawing.Size(460, 298);
            this.Manager_Screen.TabIndex = 13;
            // 
            // Change_Department
            // 
            this.Change_Department.ForeColor = System.Drawing.Color.Black;
            this.Change_Department.Location = new System.Drawing.Point(5, 70);
            this.Change_Department.Name = "Change_Department";
            this.Change_Department.Size = new System.Drawing.Size(104, 25);
            this.Change_Department.TabIndex = 7;
            this.Change_Department.Text = "부서변경";
            this.Change_Department.UseVisualStyleBackColor = true;
            this.Change_Department.Click += new System.EventHandler(this.Change_Department_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Search_By_User);
            this.groupBox2.Controls.Add(this.Search_By_Keyword);
            this.groupBox2.Controls.Add(this.User_TextBox);
            this.groupBox2.Controls.Add(this.KeyWord_TextBox);
            this.groupBox2.Controls.Add(this.ToTimePicker);
            this.groupBox2.Controls.Add(this.FromTimePicker);
            this.groupBox2.Controls.Add(this.Search_By_Date);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(476, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 270);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "대화 검색";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "사용자";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "키워드";
            // 
            // Search_By_User
            // 
            this.Search_By_User.ForeColor = System.Drawing.Color.Black;
            this.Search_By_User.Location = new System.Drawing.Point(68, 223);
            this.Search_By_User.Name = "Search_By_User";
            this.Search_By_User.Size = new System.Drawing.Size(114, 25);
            this.Search_By_User.TabIndex = 21;
            this.Search_By_User.Text = "사용자별 검색";
            this.Search_By_User.UseVisualStyleBackColor = true;
            this.Search_By_User.Click += new System.EventHandler(this.Btn_Search_User);
            // 
            // Search_By_Keyword
            // 
            this.Search_By_Keyword.ForeColor = System.Drawing.Color.Black;
            this.Search_By_Keyword.Location = new System.Drawing.Point(68, 162);
            this.Search_By_Keyword.Name = "Search_By_Keyword";
            this.Search_By_Keyword.Size = new System.Drawing.Size(114, 25);
            this.Search_By_Keyword.TabIndex = 20;
            this.Search_By_Keyword.Text = "키워드별 검색";
            this.Search_By_Keyword.UseVisualStyleBackColor = true;
            this.Search_By_Keyword.Click += new System.EventHandler(this.Btn_Search_Keyword);
            // 
            // User_TextBox
            // 
            this.User_TextBox.Location = new System.Drawing.Point(68, 192);
            this.User_TextBox.Name = "User_TextBox";
            this.User_TextBox.Size = new System.Drawing.Size(146, 25);
            this.User_TextBox.TabIndex = 19;
            // 
            // KeyWord_TextBox
            // 
            this.KeyWord_TextBox.Location = new System.Drawing.Point(68, 131);
            this.KeyWord_TextBox.Name = "KeyWord_TextBox";
            this.KeyWord_TextBox.Size = new System.Drawing.Size(146, 25);
            this.KeyWord_TextBox.TabIndex = 18;
            // 
            // ToTimePicker
            // 
            this.ToTimePicker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.ToTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToTimePicker.Location = new System.Drawing.Point(14, 69);
            this.ToTimePicker.Name = "ToTimePicker";
            this.ToTimePicker.Size = new System.Drawing.Size(200, 25);
            this.ToTimePicker.TabIndex = 17;
            // 
            // FromTimePicker
            // 
            this.FromTimePicker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.FromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromTimePicker.Location = new System.Drawing.Point(14, 39);
            this.FromTimePicker.Name = "FromTimePicker";
            this.FromTimePicker.Size = new System.Drawing.Size(200, 25);
            this.FromTimePicker.TabIndex = 16;
            // 
            // Search_By_Date
            // 
            this.Search_By_Date.ForeColor = System.Drawing.Color.Black;
            this.Search_By_Date.Location = new System.Drawing.Point(68, 100);
            this.Search_By_Date.Name = "Search_By_Date";
            this.Search_By_Date.Size = new System.Drawing.Size(114, 25);
            this.Search_By_Date.TabIndex = 13;
            this.Search_By_Date.Text = "시간별 검색";
            this.Search_By_Date.UseVisualStyleBackColor = true;
            this.Search_By_Date.Click += new System.EventHandler(this.Btn_Search_By_Time);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.Change_Team);
            this.groupBox1.Controls.Add(this.Change_Department);
            this.groupBox1.Controls.Add(this.Add_Department);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(475, 286);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(233, 115);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "부서";
            // 
            // Change_Team
            // 
            this.Change_Team.ForeColor = System.Drawing.Color.Black;
            this.Change_Team.Location = new System.Drawing.Point(122, 70);
            this.Change_Team.Name = "Change_Team";
            this.Change_Team.Size = new System.Drawing.Size(103, 25);
            this.Change_Team.TabIndex = 21;
            this.Change_Team.Text = "팀변경";
            this.Change_Team.UseVisualStyleBackColor = true;
            this.Change_Team.Click += new System.EventHandler(this.Change_Team_Click);
            // 
            // Add_Department
            // 
            this.Add_Department.ForeColor = System.Drawing.Color.Black;
            this.Add_Department.Location = new System.Drawing.Point(5, 25);
            this.Add_Department.Name = "Add_Department";
            this.Add_Department.Size = new System.Drawing.Size(220, 25);
            this.Add_Department.TabIndex = 20;
            this.Add_Department.Text = "부서 추가";
            this.Add_Department.UseVisualStyleBackColor = true;
            this.Add_Department.Click += new System.EventHandler(this.Btn_Panel_On);
            // 
            // Lookup_Department
            // 
            this.Lookup_Department.ForeColor = System.Drawing.Color.Black;
            this.Lookup_Department.Location = new System.Drawing.Point(336, 324);
            this.Lookup_Department.Name = "Lookup_Department";
            this.Lookup_Department.Size = new System.Drawing.Size(134, 39);
            this.Lookup_Department.TabIndex = 14;
            this.Lookup_Department.Text = "전체 부서 조회";
            this.Lookup_Department.UseVisualStyleBackColor = true;
            this.Lookup_Department.Click += new System.EventHandler(this.Btn_Lookup_Department);
            // 
            // ChangeDepartmentPanel
            // 
            this.ChangeDepartmentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ChangeDepartmentPanel.Controls.Add(this.DepartmentComboBox);
            this.ChangeDepartmentPanel.Controls.Add(this.button1);
            this.ChangeDepartmentPanel.Controls.Add(this.Change_Department_Info);
            this.ChangeDepartmentPanel.Controls.Add(this.textBox1);
            this.ChangeDepartmentPanel.Controls.Add(this.label3);
            this.ChangeDepartmentPanel.Controls.Add(this.label6);
            this.ChangeDepartmentPanel.ForeColor = System.Drawing.Color.White;
            this.ChangeDepartmentPanel.Location = new System.Drawing.Point(310, 50);
            this.ChangeDepartmentPanel.Name = "ChangeDepartmentPanel";
            this.ChangeDepartmentPanel.Size = new System.Drawing.Size(274, 250);
            this.ChangeDepartmentPanel.TabIndex = 20;
            this.ChangeDepartmentPanel.Visible = false;
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Location = new System.Drawing.Point(54, 62);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(151, 23);
            this.DepartmentComboBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Change_Department_Info
            // 
            this.Change_Department_Info.ForeColor = System.Drawing.Color.Black;
            this.Change_Department_Info.Location = new System.Drawing.Point(83, 183);
            this.Change_Department_Info.Name = "Change_Department_Info";
            this.Change_Department_Info.Size = new System.Drawing.Size(99, 42);
            this.Change_Department_Info.TabIndex = 4;
            this.Change_Department_Info.Text = "변경";
            this.Change_Department_Info.UseVisualStyleBackColor = true;
            this.Change_Department_Info.Click += new System.EventHandler(this.Change_Department_Info_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(54, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 25);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "변경 부서명";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "기존 부서명";
            // 
            // ChangeTeamPanel
            // 
            this.ChangeTeamPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ChangeTeamPanel.Controls.Add(this.TeamComboBox);
            this.ChangeTeamPanel.Controls.Add(this.button5);
            this.ChangeTeamPanel.Controls.Add(this.Change_Team_Info);
            this.ChangeTeamPanel.Controls.Add(this.textBox2);
            this.ChangeTeamPanel.Controls.Add(this.label7);
            this.ChangeTeamPanel.Controls.Add(this.label8);
            this.ChangeTeamPanel.ForeColor = System.Drawing.Color.White;
            this.ChangeTeamPanel.Location = new System.Drawing.Point(22, 159);
            this.ChangeTeamPanel.Name = "ChangeTeamPanel";
            this.ChangeTeamPanel.Size = new System.Drawing.Size(277, 250);
            this.ChangeTeamPanel.TabIndex = 21;
            this.ChangeTeamPanel.Visible = false;
            // 
            // TeamComboBox
            // 
            this.TeamComboBox.FormattingEnabled = true;
            this.TeamComboBox.Location = new System.Drawing.Point(54, 62);
            this.TeamComboBox.Name = "TeamComboBox";
            this.TeamComboBox.Size = new System.Drawing.Size(151, 23);
            this.TeamComboBox.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(227, 18);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 24);
            this.button5.TabIndex = 5;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Change_Team_Info
            // 
            this.Change_Team_Info.ForeColor = System.Drawing.Color.Black;
            this.Change_Team_Info.Location = new System.Drawing.Point(83, 183);
            this.Change_Team_Info.Name = "Change_Team_Info";
            this.Change_Team_Info.Size = new System.Drawing.Size(99, 42);
            this.Change_Team_Info.TabIndex = 4;
            this.Change_Team_Info.Text = "변경";
            this.Change_Team_Info.UseVisualStyleBackColor = true;
            this.Change_Team_Info.Click += new System.EventHandler(this.Change_Team_Info_Click);
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(54, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 25);
            this.textBox2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "변경 팀명";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "기존 팀명";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(712, 453);
            this.Controls.Add(this.ChangeTeamPanel);
            this.Controls.Add(this.ChangeDepartmentPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.addDepartmentPanel);
            this.Controls.Add(this.Manager_Screen);
            this.Controls.Add(this.Lookup_Department);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.addDepartmentPanel.ResumeLayout(false);
            this.addDepartmentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Manager_Screen)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ChangeDepartmentPanel.ResumeLayout(false);
            this.ChangeDepartmentPanel.PerformLayout();
            this.ChangeTeamPanel.ResumeLayout(false);
            this.ChangeTeamPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel addDepartmentPanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Add_Info;
        private System.Windows.Forms.TextBox Add_Team_Text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Add_Department_Text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Manager_Screen;
        private System.Windows.Forms.Button Change_Department;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search_By_User;
        private System.Windows.Forms.Button Search_By_Keyword;
        private System.Windows.Forms.TextBox User_TextBox;
        private System.Windows.Forms.TextBox KeyWord_TextBox;
        private System.Windows.Forms.DateTimePicker ToTimePicker;
        private System.Windows.Forms.DateTimePicker FromTimePicker;
        private System.Windows.Forms.Button Search_By_Date;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Add_Department;
        private System.Windows.Forms.Button Lookup_Department;
        private System.Windows.Forms.Panel ChangeDepartmentPanel;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Change_Department_Info;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Change_Team;
        private System.Windows.Forms.Panel ChangeTeamPanel;
        private System.Windows.Forms.ComboBox TeamComboBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Change_Team_Info;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}