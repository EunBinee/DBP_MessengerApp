
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
            this.Save_Change = new System.Windows.Forms.Button();
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
            this.label3 = new System.Windows.Forms.Label();
            this.teamBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.departmentBox = new System.Windows.Forms.ComboBox();
            this.Add_Department = new System.Windows.Forms.Button();
            this.Lookup_Department = new System.Windows.Forms.Button();
            this.Move_UserManager = new System.Windows.Forms.Button();
            this.addDepartmentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Manager_Screen)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addDepartmentPanel
            // 
            this.addDepartmentPanel.Controls.Add(this.button4);
            this.addDepartmentPanel.Controls.Add(this.Add_Info);
            this.addDepartmentPanel.Controls.Add(this.Add_Team_Text);
            this.addDepartmentPanel.Controls.Add(this.label5);
            this.addDepartmentPanel.Controls.Add(this.Add_Department_Text);
            this.addDepartmentPanel.Controls.Add(this.label4);
            this.addDepartmentPanel.Location = new System.Drawing.Point(88, 41);
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
            this.Manager_Screen.Size = new System.Drawing.Size(480, 339);
            this.Manager_Screen.TabIndex = 13;
            // 
            // Save_Change
            // 
            this.Save_Change.Location = new System.Drawing.Point(352, 366);
            this.Save_Change.Name = "Save_Change";
            this.Save_Change.Size = new System.Drawing.Size(138, 35);
            this.Save_Change.TabIndex = 7;
            this.Save_Change.Text = "변경사항 저장";
            this.Save_Change.UseVisualStyleBackColor = true;
            this.Save_Change.Click += new System.EventHandler(this.Btn_Change_Save);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Search_By_User);
            this.groupBox2.Controls.Add(this.Search_By_Keyword);
            this.groupBox2.Controls.Add(this.User_TextBox);
            this.groupBox2.Controls.Add(this.KeyWord_TextBox);
            this.groupBox2.Controls.Add(this.ToTimePicker);
            this.groupBox2.Controls.Add(this.FromTimePicker);
            this.groupBox2.Controls.Add(this.Search_By_Date);
            this.groupBox2.Location = new System.Drawing.Point(505, 11);
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
            this.Search_By_User.Location = new System.Drawing.Point(78, 222);
            this.Search_By_User.Name = "Search_By_User";
            this.Search_By_User.Size = new System.Drawing.Size(114, 25);
            this.Search_By_User.TabIndex = 21;
            this.Search_By_User.Text = "사용자별 검색";
            this.Search_By_User.UseVisualStyleBackColor = true;
            this.Search_By_User.Click += new System.EventHandler(this.Btn_Search_User);
            // 
            // Search_By_Keyword
            // 
            this.Search_By_Keyword.Location = new System.Drawing.Point(78, 161);
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
            this.ToTimePicker.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.ToTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToTimePicker.Location = new System.Drawing.Point(14, 69);
            this.ToTimePicker.Name = "ToTimePicker";
            this.ToTimePicker.Size = new System.Drawing.Size(200, 25);
            this.ToTimePicker.TabIndex = 17;
            // 
            // FromTimePicker
            // 
            this.FromTimePicker.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.FromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromTimePicker.Location = new System.Drawing.Point(14, 39);
            this.FromTimePicker.Name = "FromTimePicker";
            this.FromTimePicker.Size = new System.Drawing.Size(200, 25);
            this.FromTimePicker.TabIndex = 16;
            // 
            // Search_By_Date
            // 
            this.Search_By_Date.Location = new System.Drawing.Point(78, 99);
            this.Search_By_Date.Name = "Search_By_Date";
            this.Search_By_Date.Size = new System.Drawing.Size(114, 25);
            this.Search_By_Date.TabIndex = 13;
            this.Search_By_Date.Text = "시간별 검색";
            this.Search_By_Date.UseVisualStyleBackColor = true;
            this.Search_By_Date.Click += new System.EventHandler(this.Btn_Search_By_Time);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.teamBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.departmentBox);
            this.groupBox1.Controls.Add(this.Add_Department);
            this.groupBox1.Controls.Add(this.Lookup_Department);
            this.groupBox1.Location = new System.Drawing.Point(496, 287);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(242, 119);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "부서";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "팀명";
            // 
            // teamBox
            // 
            this.teamBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teamBox.FormattingEnabled = true;
            this.teamBox.Location = new System.Drawing.Point(98, 57);
            this.teamBox.Name = "teamBox";
            this.teamBox.Size = new System.Drawing.Size(95, 23);
            this.teamBox.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "부서명";
            // 
            // departmentBox
            // 
            this.departmentBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentBox.FormattingEnabled = true;
            this.departmentBox.Location = new System.Drawing.Point(98, 29);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(95, 23);
            this.departmentBox.TabIndex = 21;
            // 
            // Add_Department
            // 
            this.Add_Department.Location = new System.Drawing.Point(14, 86);
            this.Add_Department.Name = "Add_Department";
            this.Add_Department.Size = new System.Drawing.Size(93, 25);
            this.Add_Department.TabIndex = 20;
            this.Add_Department.Text = "부서 추가";
            this.Add_Department.UseVisualStyleBackColor = true;
            this.Add_Department.Click += new System.EventHandler(this.Btn_Panel_On);
            // 
            // Lookup_Department
            // 
            this.Lookup_Department.Location = new System.Drawing.Point(114, 86);
            this.Lookup_Department.Name = "Lookup_Department";
            this.Lookup_Department.Size = new System.Drawing.Size(121, 25);
            this.Lookup_Department.TabIndex = 14;
            this.Lookup_Department.Text = "전체 부서 조회";
            this.Lookup_Department.UseVisualStyleBackColor = true;
            this.Lookup_Department.Click += new System.EventHandler(this.Btn_Lookup_Department);
            // 
            // Move_UserManager
            // 
            this.Move_UserManager.Location = new System.Drawing.Point(10, 362);
            this.Move_UserManager.Name = "Move_UserManager";
            this.Move_UserManager.Size = new System.Drawing.Size(90, 35);
            this.Move_UserManager.TabIndex = 20;
            this.Move_UserManager.Text = "유저관리";
            this.Move_UserManager.UseVisualStyleBackColor = true;
            this.Move_UserManager.Click += new System.EventHandler(this.Btn_Move_UserManager);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 412);
            this.Controls.Add(this.Move_UserManager);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Save_Change);
            this.Controls.Add(this.addDepartmentPanel);
            this.Controls.Add(this.Manager_Screen);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.addDepartmentPanel.ResumeLayout(false);
            this.addDepartmentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Manager_Screen)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button Save_Change;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox teamBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox departmentBox;
        private System.Windows.Forms.Button Add_Department;
        private System.Windows.Forms.Button Lookup_Department;
        private System.Windows.Forms.Button Move_UserManager;
    }
}