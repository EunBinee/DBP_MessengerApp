﻿
namespace DBP_Project
{
    partial class UserManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagerForm));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.teamComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.recentLogIn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.recentLogOut = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.blockDepartmentList = new System.Windows.Forms.ListBox();
            this.blockChatList = new System.Windows.Forms.ListBox();
            this.blockDepartmentLabel = new System.Windows.Forms.Label();
            this.blockChatLabel = new System.Windows.Forms.Label();
            this.blockComboBox1 = new System.Windows.Forms.ComboBox();
            this.blockChatBox = new System.Windows.Forms.ComboBox();
            this.blockAddBtn1 = new System.Windows.Forms.Button();
            this.addBlockChatBtn = new System.Windows.Forms.Button();
            this.blockDeleteBtn1 = new System.Windows.Forms.Button();
            this.deleteBlockChatBtn = new System.Windows.Forms.Button();
            this.blockDepartmentPanel = new System.Windows.Forms.Panel();
            this.blockUserPanel = new System.Windows.Forms.Panel();
            this.blockUserBtn = new System.Windows.Forms.Button();
            this.userBlockLabel = new System.Windows.Forms.Label();
            this.blockUserList = new System.Windows.Forms.ListBox();
            this.blockUserBox = new System.Windows.Forms.ComboBox();
            this.deleteBlockUserBtn = new System.Windows.Forms.Button();
            this.addBlockUserBtn = new System.Windows.Forms.Button();
            this.blockDepartmentBtn = new System.Windows.Forms.Button();
            this.blockChatPanel = new System.Windows.Forms.Panel();
            this.searchUserPanel = new System.Windows.Forms.Panel();
            this.userSearchLabel = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.blockDepartmentPanel.SuspendLayout();
            this.blockUserPanel.SuspendLayout();
            this.blockChatPanel.SuspendLayout();
            this.searchUserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.searchBtn);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.searchBox);
            this.groupBox3.Location = new System.Drawing.Point(21, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 82);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // searchBtn
            // 
            this.searchBtn.ForeColor = System.Drawing.Color.Black;
            this.searchBtn.Location = new System.Drawing.Point(150, 39);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(63, 25);
            this.searchBtn.TabIndex = 12;
            this.searchBtn.Text = "검색";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.serachBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "유저검색";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(22, 39);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(121, 25);
            this.searchBox.TabIndex = 10;
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(121, 133);
            this.userBox.Margin = new System.Windows.Forms.Padding(2);
            this.userBox.Name = "userBox";
            this.userBox.ReadOnly = true;
            this.userBox.Size = new System.Drawing.Size(120, 25);
            this.userBox.TabIndex = 19;
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(121, 159);
            this.departmentComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(120, 23);
            this.departmentComboBox.TabIndex = 20;
            this.departmentComboBox.SelectedIndexChanged += new System.EventHandler(this.departmentComboBox_SelectedIndexChanged);
            // 
            // teamComboBox
            // 
            this.teamComboBox.FormattingEnabled = true;
            this.teamComboBox.Location = new System.Drawing.Point(121, 188);
            this.teamComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.teamComboBox.Name = "teamComboBox";
            this.teamComboBox.Size = new System.Drawing.Size(120, 23);
            this.teamComboBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "사용자";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "부서";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "팀";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "최근 로그인";
            // 
            // recentLogIn
            // 
            this.recentLogIn.Font = new System.Drawing.Font("Nirmala UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentLogIn.Location = new System.Drawing.Point(121, 217);
            this.recentLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.recentLogIn.Name = "recentLogIn";
            this.recentLogIn.ReadOnly = true;
            this.recentLogIn.Size = new System.Drawing.Size(130, 23);
            this.recentLogIn.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 247);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "최근 로그아웃";
            // 
            // recentLogOut
            // 
            this.recentLogOut.Font = new System.Drawing.Font("Nirmala UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentLogOut.Location = new System.Drawing.Point(121, 245);
            this.recentLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.recentLogOut.Name = "recentLogOut";
            this.recentLogOut.ReadOnly = true;
            this.recentLogOut.Size = new System.Drawing.Size(130, 23);
            this.recentLogOut.TabIndex = 27;
            // 
            // saveBtn
            // 
            this.saveBtn.ForeColor = System.Drawing.Color.Black;
            this.saveBtn.Location = new System.Drawing.Point(43, 280);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(205, 37);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "변경사항 저장";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // blockDepartmentList
            // 
            this.blockDepartmentList.FormattingEnabled = true;
            this.blockDepartmentList.ItemHeight = 15;
            this.blockDepartmentList.Location = new System.Drawing.Point(25, 75);
            this.blockDepartmentList.Margin = new System.Windows.Forms.Padding(2);
            this.blockDepartmentList.Name = "blockDepartmentList";
            this.blockDepartmentList.Size = new System.Drawing.Size(297, 139);
            this.blockDepartmentList.TabIndex = 29;
            this.blockDepartmentList.SelectedIndexChanged += new System.EventHandler(this.blockDepartmentList_SelectedIndexChanged);
            // 
            // blockChatList
            // 
            this.blockChatList.FormattingEnabled = true;
            this.blockChatList.ItemHeight = 15;
            this.blockChatList.Location = new System.Drawing.Point(24, 75);
            this.blockChatList.Margin = new System.Windows.Forms.Padding(2);
            this.blockChatList.Name = "blockChatList";
            this.blockChatList.Size = new System.Drawing.Size(298, 139);
            this.blockChatList.TabIndex = 30;
            this.blockChatList.SelectedIndexChanged += new System.EventHandler(this.blockChatList_SelectedIndexChanged);
            // 
            // blockDepartmentLabel
            // 
            this.blockDepartmentLabel.AutoSize = true;
            this.blockDepartmentLabel.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockDepartmentLabel.Location = new System.Drawing.Point(22, 13);
            this.blockDepartmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blockDepartmentLabel.Name = "blockDepartmentLabel";
            this.blockDepartmentLabel.Size = new System.Drawing.Size(203, 25);
            this.blockDepartmentLabel.TabIndex = 31;
            this.blockDepartmentLabel.Text = "보기 차단 ( 부서 차단 )";
            // 
            // blockChatLabel
            // 
            this.blockChatLabel.AutoSize = true;
            this.blockChatLabel.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockChatLabel.ForeColor = System.Drawing.Color.White;
            this.blockChatLabel.Location = new System.Drawing.Point(21, 13);
            this.blockChatLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blockChatLabel.Name = "blockChatLabel";
            this.blockChatLabel.Size = new System.Drawing.Size(93, 25);
            this.blockChatLabel.TabIndex = 32;
            this.blockChatLabel.Text = "채팅 차단";
            // 
            // blockComboBox1
            // 
            this.blockComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blockComboBox1.FormattingEnabled = true;
            this.blockComboBox1.Location = new System.Drawing.Point(25, 47);
            this.blockComboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.blockComboBox1.Name = "blockComboBox1";
            this.blockComboBox1.Size = new System.Drawing.Size(120, 23);
            this.blockComboBox1.TabIndex = 33;
            // 
            // blockChatBox
            // 
            this.blockChatBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blockChatBox.FormattingEnabled = true;
            this.blockChatBox.Location = new System.Drawing.Point(23, 42);
            this.blockChatBox.Margin = new System.Windows.Forms.Padding(2);
            this.blockChatBox.Name = "blockChatBox";
            this.blockChatBox.Size = new System.Drawing.Size(120, 23);
            this.blockChatBox.TabIndex = 34;
            // 
            // blockAddBtn1
            // 
            this.blockAddBtn1.ForeColor = System.Drawing.Color.Black;
            this.blockAddBtn1.Location = new System.Drawing.Point(152, 45);
            this.blockAddBtn1.Name = "blockAddBtn1";
            this.blockAddBtn1.Size = new System.Drawing.Size(63, 25);
            this.blockAddBtn1.TabIndex = 13;
            this.blockAddBtn1.Text = "추가";
            this.blockAddBtn1.UseVisualStyleBackColor = true;
            this.blockAddBtn1.Click += new System.EventHandler(this.blockAddBtn1_Click);
            // 
            // addBlockChatBtn
            // 
            this.addBlockChatBtn.Location = new System.Drawing.Point(151, 40);
            this.addBlockChatBtn.Name = "addBlockChatBtn";
            this.addBlockChatBtn.Size = new System.Drawing.Size(63, 25);
            this.addBlockChatBtn.TabIndex = 35;
            this.addBlockChatBtn.Text = "추가";
            this.addBlockChatBtn.UseVisualStyleBackColor = true;
            this.addBlockChatBtn.Click += new System.EventHandler(this.addBlockChatBtn_Click);
            // 
            // blockDeleteBtn1
            // 
            this.blockDeleteBtn1.ForeColor = System.Drawing.Color.Black;
            this.blockDeleteBtn1.Location = new System.Drawing.Point(221, 45);
            this.blockDeleteBtn1.Name = "blockDeleteBtn1";
            this.blockDeleteBtn1.Size = new System.Drawing.Size(63, 25);
            this.blockDeleteBtn1.TabIndex = 36;
            this.blockDeleteBtn1.Text = "삭제";
            this.blockDeleteBtn1.UseVisualStyleBackColor = true;
            this.blockDeleteBtn1.Click += new System.EventHandler(this.blockDeleteBtn1_Click);
            // 
            // deleteBlockChatBtn
            // 
            this.deleteBlockChatBtn.Location = new System.Drawing.Point(220, 40);
            this.deleteBlockChatBtn.Name = "deleteBlockChatBtn";
            this.deleteBlockChatBtn.Size = new System.Drawing.Size(63, 25);
            this.deleteBlockChatBtn.TabIndex = 37;
            this.deleteBlockChatBtn.Text = "삭제";
            this.deleteBlockChatBtn.UseVisualStyleBackColor = true;
            this.deleteBlockChatBtn.Click += new System.EventHandler(this.deleteBlockChatBtn_Click);
            // 
            // blockDepartmentPanel
            // 
            this.blockDepartmentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.blockDepartmentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blockDepartmentPanel.Controls.Add(this.blockUserPanel);
            this.blockDepartmentPanel.Controls.Add(this.blockDepartmentBtn);
            this.blockDepartmentPanel.Controls.Add(this.blockDepartmentLabel);
            this.blockDepartmentPanel.Controls.Add(this.blockDepartmentList);
            this.blockDepartmentPanel.Controls.Add(this.blockComboBox1);
            this.blockDepartmentPanel.Controls.Add(this.blockDeleteBtn1);
            this.blockDepartmentPanel.Controls.Add(this.blockAddBtn1);
            this.blockDepartmentPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.blockDepartmentPanel.Location = new System.Drawing.Point(322, 17);
            this.blockDepartmentPanel.Name = "blockDepartmentPanel";
            this.blockDepartmentPanel.Size = new System.Drawing.Size(387, 240);
            this.blockDepartmentPanel.TabIndex = 39;
            // 
            // blockUserPanel
            // 
            this.blockUserPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.blockUserPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blockUserPanel.Controls.Add(this.blockUserBtn);
            this.blockUserPanel.Controls.Add(this.userBlockLabel);
            this.blockUserPanel.Controls.Add(this.blockUserList);
            this.blockUserPanel.Controls.Add(this.blockUserBox);
            this.blockUserPanel.Controls.Add(this.deleteBlockUserBtn);
            this.blockUserPanel.Controls.Add(this.addBlockUserBtn);
            this.blockUserPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.blockUserPanel.Location = new System.Drawing.Point(-1, -1);
            this.blockUserPanel.Name = "blockUserPanel";
            this.blockUserPanel.Size = new System.Drawing.Size(387, 240);
            this.blockUserPanel.TabIndex = 40;
            this.blockUserPanel.Visible = false;
            // 
            // blockUserBtn
            // 
            this.blockUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.blockUserBtn.FlatAppearance.BorderSize = 0;
            this.blockUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blockUserBtn.Image = ((System.Drawing.Image)(resources.GetObject("blockUserBtn.Image")));
            this.blockUserBtn.Location = new System.Drawing.Point(326, 9);
            this.blockUserBtn.Name = "blockUserBtn";
            this.blockUserBtn.Size = new System.Drawing.Size(46, 45);
            this.blockUserBtn.TabIndex = 38;
            this.blockUserBtn.UseVisualStyleBackColor = false;
            this.blockUserBtn.Click += new System.EventHandler(this.blockUserBtn_Click);
            // 
            // userBlockLabel
            // 
            this.userBlockLabel.AllowDrop = true;
            this.userBlockLabel.AutoSize = true;
            this.userBlockLabel.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBlockLabel.Location = new System.Drawing.Point(22, 13);
            this.userBlockLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userBlockLabel.Name = "userBlockLabel";
            this.userBlockLabel.Size = new System.Drawing.Size(222, 25);
            this.userBlockLabel.TabIndex = 31;
            this.userBlockLabel.Text = "보기 차단 ( 사용자 차단 )";
            // 
            // blockUserList
            // 
            this.blockUserList.FormattingEnabled = true;
            this.blockUserList.ItemHeight = 15;
            this.blockUserList.Location = new System.Drawing.Point(25, 75);
            this.blockUserList.Margin = new System.Windows.Forms.Padding(2);
            this.blockUserList.Name = "blockUserList";
            this.blockUserList.Size = new System.Drawing.Size(297, 139);
            this.blockUserList.TabIndex = 29;
            this.blockUserList.SelectedIndexChanged += new System.EventHandler(this.blockUserList_SelectedIndexChanged);
            // 
            // blockUserBox
            // 
            this.blockUserBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blockUserBox.FormattingEnabled = true;
            this.blockUserBox.Location = new System.Drawing.Point(25, 47);
            this.blockUserBox.Margin = new System.Windows.Forms.Padding(2);
            this.blockUserBox.Name = "blockUserBox";
            this.blockUserBox.Size = new System.Drawing.Size(120, 23);
            this.blockUserBox.TabIndex = 33;
            // 
            // deleteBlockUserBtn
            // 
            this.deleteBlockUserBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBlockUserBtn.Location = new System.Drawing.Point(221, 45);
            this.deleteBlockUserBtn.Name = "deleteBlockUserBtn";
            this.deleteBlockUserBtn.Size = new System.Drawing.Size(63, 25);
            this.deleteBlockUserBtn.TabIndex = 36;
            this.deleteBlockUserBtn.Text = "삭제";
            this.deleteBlockUserBtn.UseVisualStyleBackColor = true;
            this.deleteBlockUserBtn.Click += new System.EventHandler(this.deleteBlockUserBtn_Click);
            // 
            // addBlockUserBtn
            // 
            this.addBlockUserBtn.ForeColor = System.Drawing.Color.Black;
            this.addBlockUserBtn.Location = new System.Drawing.Point(152, 45);
            this.addBlockUserBtn.Name = "addBlockUserBtn";
            this.addBlockUserBtn.Size = new System.Drawing.Size(63, 25);
            this.addBlockUserBtn.TabIndex = 13;
            this.addBlockUserBtn.Text = "추가";
            this.addBlockUserBtn.UseVisualStyleBackColor = true;
            this.addBlockUserBtn.Click += new System.EventHandler(this.addBlockUserBtn_Click);
            // 
            // blockDepartmentBtn
            // 
            this.blockDepartmentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.blockDepartmentBtn.FlatAppearance.BorderSize = 0;
            this.blockDepartmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blockDepartmentBtn.Image = ((System.Drawing.Image)(resources.GetObject("blockDepartmentBtn.Image")));
            this.blockDepartmentBtn.Location = new System.Drawing.Point(326, 9);
            this.blockDepartmentBtn.Name = "blockDepartmentBtn";
            this.blockDepartmentBtn.Size = new System.Drawing.Size(46, 45);
            this.blockDepartmentBtn.TabIndex = 38;
            this.blockDepartmentBtn.UseVisualStyleBackColor = false;
            this.blockDepartmentBtn.Click += new System.EventHandler(this.blockDepartmentBtn_Click);
            // 
            // blockChatPanel
            // 
            this.blockChatPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.blockChatPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blockChatPanel.Controls.Add(this.blockChatList);
            this.blockChatPanel.Controls.Add(this.blockChatLabel);
            this.blockChatPanel.Controls.Add(this.blockChatBox);
            this.blockChatPanel.Controls.Add(this.deleteBlockChatBtn);
            this.blockChatPanel.Controls.Add(this.addBlockChatBtn);
            this.blockChatPanel.Location = new System.Drawing.Point(322, 263);
            this.blockChatPanel.Name = "blockChatPanel";
            this.blockChatPanel.Size = new System.Drawing.Size(387, 232);
            this.blockChatPanel.TabIndex = 37;
            // 
            // searchUserPanel
            // 
            this.searchUserPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.searchUserPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchUserPanel.Controls.Add(this.userSearchLabel);
            this.searchUserPanel.Controls.Add(this.groupBox3);
            this.searchUserPanel.Controls.Add(this.userBox);
            this.searchUserPanel.Controls.Add(this.departmentComboBox);
            this.searchUserPanel.Controls.Add(this.teamComboBox);
            this.searchUserPanel.Controls.Add(this.saveBtn);
            this.searchUserPanel.Controls.Add(this.label1);
            this.searchUserPanel.Controls.Add(this.label6);
            this.searchUserPanel.Controls.Add(this.label2);
            this.searchUserPanel.Controls.Add(this.recentLogOut);
            this.searchUserPanel.Controls.Add(this.label4);
            this.searchUserPanel.Controls.Add(this.label5);
            this.searchUserPanel.Controls.Add(this.recentLogIn);
            this.searchUserPanel.ForeColor = System.Drawing.Color.White;
            this.searchUserPanel.Location = new System.Drawing.Point(12, 17);
            this.searchUserPanel.Name = "searchUserPanel";
            this.searchUserPanel.Size = new System.Drawing.Size(293, 337);
            this.searchUserPanel.TabIndex = 38;
            // 
            // userSearchLabel
            // 
            this.userSearchLabel.AllowDrop = true;
            this.userSearchLabel.AutoSize = true;
            this.userSearchLabel.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSearchLabel.Location = new System.Drawing.Point(16, 13);
            this.userSearchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userSearchLabel.Name = "userSearchLabel";
            this.userSearchLabel.Size = new System.Drawing.Size(112, 25);
            this.userSearchLabel.TabIndex = 39;
            this.userSearchLabel.Text = "사용자 조회";
            // 
            // UserManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(730, 500);
            this.Controls.Add(this.searchUserPanel);
            this.Controls.Add(this.blockChatPanel);
            this.Controls.Add(this.blockDepartmentPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserManagerForm";
            this.Text = "UserManagerForm";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.blockDepartmentPanel.ResumeLayout(false);
            this.blockDepartmentPanel.PerformLayout();
            this.blockUserPanel.ResumeLayout(false);
            this.blockUserPanel.PerformLayout();
            this.blockChatPanel.ResumeLayout(false);
            this.blockChatPanel.PerformLayout();
            this.searchUserPanel.ResumeLayout(false);
            this.searchUserPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.ComboBox teamComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox recentLogIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox recentLogOut;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ListBox blockDepartmentList;
        private System.Windows.Forms.ListBox blockChatList;
        private System.Windows.Forms.Label blockDepartmentLabel;
        private System.Windows.Forms.Label blockChatLabel;
        private System.Windows.Forms.ComboBox blockComboBox1;
        private System.Windows.Forms.ComboBox blockChatBox;
        private System.Windows.Forms.Button blockAddBtn1;
        private System.Windows.Forms.Button addBlockChatBtn;
        private System.Windows.Forms.Button blockDeleteBtn1;
        private System.Windows.Forms.Button deleteBlockChatBtn;
        private System.Windows.Forms.Panel blockDepartmentPanel;
        private System.Windows.Forms.Panel blockChatPanel;
        private System.Windows.Forms.Panel searchUserPanel;
        private System.Windows.Forms.Button blockDepartmentBtn;
        private System.Windows.Forms.Panel blockUserPanel;
        private System.Windows.Forms.Button blockUserBtn;
        private System.Windows.Forms.Label userBlockLabel;
        private System.Windows.Forms.ListBox blockUserList;
        private System.Windows.Forms.ComboBox blockUserBox;
        private System.Windows.Forms.Button deleteBlockUserBtn;
        private System.Windows.Forms.Button addBlockUserBtn;
        private System.Windows.Forms.Label userSearchLabel;
    }
}