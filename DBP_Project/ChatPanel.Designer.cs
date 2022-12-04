
namespace DBP_Project
{
    partial class ChatPanel
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NaemLabel = new System.Windows.Forms.Label();
            this.LastChat = new System.Windows.Forms.Label();
            this.Favorite = new System.Windows.Forms.CheckBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.NumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(43, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NaemLabel
            // 
            this.NaemLabel.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NaemLabel.Location = new System.Drawing.Point(133, 28);
            this.NaemLabel.Name = "NaemLabel";
            this.NaemLabel.Size = new System.Drawing.Size(194, 19);
            this.NaemLabel.TabIndex = 1;
            this.NaemLabel.Text = "Name";
            // 
            // LastChat
            // 
            this.LastChat.Location = new System.Drawing.Point(135, 69);
            this.LastChat.Name = "LastChat";
            this.LastChat.Size = new System.Drawing.Size(192, 12);
            this.LastChat.TabIndex = 2;
            this.LastChat.Text = "last chat";
            this.LastChat.Click += new System.EventHandler(this.LastChat_Click);
            // 
            // Favorite
            // 
            this.Favorite.Location = new System.Drawing.Point(17, 41);
            this.Favorite.Name = "Favorite";
            this.Favorite.Size = new System.Drawing.Size(20, 20);
            this.Favorite.TabIndex = 3;
            this.Favorite.UseVisualStyleBackColor = true;
            this.Favorite.CheckedChanged += new System.EventHandler(this.Favorite_CheckedChanged);
            // 
            // TimeLabel
            // 
            this.TimeLabel.Font = new System.Drawing.Font("굴림", 13F);
            this.TimeLabel.Location = new System.Drawing.Point(342, 29);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(56, 19);
            this.TimeLabel.TabIndex = 4;
            this.TimeLabel.Text = "time";
            // 
            // NumLabel
            // 
            this.NumLabel.BackColor = System.Drawing.Color.Red;
            this.NumLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NumLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NumLabel.Location = new System.Drawing.Point(342, 65);
            this.NumLabel.Name = "NumLabel";
            this.NumLabel.Size = new System.Drawing.Size(44, 23);
            this.NumLabel.TabIndex = 5;
            this.NumLabel.Text = "Num";
            // 
            // ChatPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NumLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.Favorite);
            this.Controls.Add(this.LastChat);
            this.Controls.Add(this.NaemLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ChatPanel";
            this.Size = new System.Drawing.Size(439, 105);
            this.Load += new System.EventHandler(this.ChatPanel_Load);
            this.Click += new System.EventHandler(this.ChatPanel_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NaemLabel;
        private System.Windows.Forms.Label LastChat;
        private System.Windows.Forms.CheckBox Favorite;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label NumLabel;
    }
}
