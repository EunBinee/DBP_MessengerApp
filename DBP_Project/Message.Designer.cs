namespace DBP_Project
{
    partial class Message
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sendTimeLabel = new System.Windows.Forms.Label();
            this.msgBox = new System.Windows.Forms.Label();
            this.backPanel = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.senderName = new System.Windows.Forms.Label();
            this.senderImg = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.공지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senderImg)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // sendTimeLabel
            // 
            this.sendTimeLabel.AutoSize = true;
            this.sendTimeLabel.Location = new System.Drawing.Point(386, 30);
            this.sendTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sendTimeLabel.Name = "sendTimeLabel";
            this.sendTimeLabel.Size = new System.Drawing.Size(96, 18);
            this.sendTimeLabel.TabIndex = 3;
            this.sendTimeLabel.Text = "오전 12:00";
            this.sendTimeLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // msgBox
            // 
            this.msgBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.msgBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.msgBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.msgBox.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.msgBox.Location = new System.Drawing.Point(3, 3);
            this.msgBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(343, 360);
            this.msgBox.TabIndex = 2;
            this.msgBox.Text = "안녕하세요";
            // 
            // backPanel
            // 
            this.backPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.backPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.backPanel.Controls.Add(this.linkLabel1);
            this.backPanel.Controls.Add(this.msgBox);
            this.backPanel.Controls.Add(this.pictureBox1);
            this.backPanel.Location = new System.Drawing.Point(121, 54);
            this.backPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(350, 364);
            this.backPanel.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(4, 3);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(85, 18);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // senderName
            // 
            this.senderName.AutoSize = true;
            this.senderName.Font = new System.Drawing.Font("굴림", 13F);
            this.senderName.Location = new System.Drawing.Point(124, 22);
            this.senderName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.senderName.Name = "senderName";
            this.senderName.Size = new System.Drawing.Size(85, 26);
            this.senderName.TabIndex = 1;
            this.senderName.Text = "label1";
            // 
            // senderImg
            // 
            this.senderImg.BackColor = System.Drawing.SystemColors.ControlDark;
            this.senderImg.Location = new System.Drawing.Point(14, 15);
            this.senderImg.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.senderImg.Name = "senderImg";
            this.senderImg.Size = new System.Drawing.Size(91, 96);
            this.senderImg.TabIndex = 0;
            this.senderImg.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.삭제ToolStripMenuItem,
            this.공지ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 68);
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(120, 32);
            this.삭제ToolStripMenuItem.Text = "삭제";
            this.삭제ToolStripMenuItem.Click += new System.EventHandler(this.삭제ToolStripMenuItem_Click);
            // 
            // 공지ToolStripMenuItem
            // 
            this.공지ToolStripMenuItem.Name = "공지ToolStripMenuItem";
            this.공지ToolStripMenuItem.Size = new System.Drawing.Size(120, 32);
            this.공지ToolStripMenuItem.Text = "공지";
            this.공지ToolStripMenuItem.Click += new System.EventHandler(this.공지ToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DBP_Project.Properties.Resources.check;
            this.pictureBox2.Location = new System.Drawing.Point(343, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.sendTimeLabel);
            this.Controls.Add(this.senderName);
            this.Controls.Add(this.senderImg);
            this.Controls.Add(this.backPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Message";
            this.Size = new System.Drawing.Size(514, 454);
            this.Load += new System.EventHandler(this.Message_Load);
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senderImg)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label sendTimeLabel;
        private System.Windows.Forms.Label msgBox;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Label senderName;
        private System.Windows.Forms.PictureBox senderImg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 공지ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
