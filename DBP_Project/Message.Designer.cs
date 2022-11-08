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
            this.sendTimeLabel = new System.Windows.Forms.Label();
            this.msgBox = new System.Windows.Forms.RichTextBox();
            this.backPanel = new System.Windows.Forms.Panel();
            this.senderName = new System.Windows.Forms.Label();
            this.senderImg = new System.Windows.Forms.PictureBox();
            this.backPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.senderImg)).BeginInit();
            this.SuspendLayout();
            // 
            // sendTimeLabel
            // 
            this.sendTimeLabel.AutoSize = true;
            this.sendTimeLabel.Location = new System.Drawing.Point(270, 20);
            this.sendTimeLabel.Name = "sendTimeLabel";
            this.sendTimeLabel.Size = new System.Drawing.Size(61, 12);
            this.sendTimeLabel.TabIndex = 3;
            this.sendTimeLabel.Text = "오전 12:00";
            this.sendTimeLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // msgBox
            // 
            this.msgBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.msgBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.msgBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msgBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.msgBox.DetectUrls = false;
            this.msgBox.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.msgBox.HideSelection = false;
            this.msgBox.Location = new System.Drawing.Point(3, 3);
            this.msgBox.Name = "msgBox";
            this.msgBox.ReadOnly = true;
            this.msgBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.msgBox.Size = new System.Drawing.Size(239, 33);
            this.msgBox.TabIndex = 2;
            this.msgBox.Text = "안녕하세요";
            // 
            // backPanel
            // 
            this.backPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.backPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.backPanel.Controls.Add(this.msgBox);
            this.backPanel.Location = new System.Drawing.Point(85, 36);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(245, 38);
            this.backPanel.TabIndex = 4;
            // 
            // senderName
            // 
            this.senderName.AutoSize = true;
            this.senderName.Font = new System.Drawing.Font("굴림", 13F);
            this.senderName.Location = new System.Drawing.Point(87, 15);
            this.senderName.Name = "senderName";
            this.senderName.Size = new System.Drawing.Size(54, 18);
            this.senderName.TabIndex = 1;
            this.senderName.Text = "label1";
            // 
            // senderImg
            // 
            this.senderImg.BackColor = System.Drawing.SystemColors.ControlDark;
            this.senderImg.Location = new System.Drawing.Point(10, 10);
            this.senderImg.Margin = new System.Windows.Forms.Padding(10);
            this.senderImg.Name = "senderImg";
            this.senderImg.Size = new System.Drawing.Size(64, 64);
            this.senderImg.TabIndex = 0;
            this.senderImg.TabStop = false;
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.sendTimeLabel);
            this.Controls.Add(this.senderName);
            this.Controls.Add(this.senderImg);
            this.Name = "Message";
            this.Size = new System.Drawing.Size(360, 98);
            this.Load += new System.EventHandler(this.Message_Load);
            this.backPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.senderImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label sendTimeLabel;
        private System.Windows.Forms.RichTextBox msgBox;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Label senderName;
        private System.Windows.Forms.PictureBox senderImg;
    }
}
