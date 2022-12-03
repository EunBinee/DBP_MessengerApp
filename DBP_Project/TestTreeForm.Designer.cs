
namespace DBP_Project
{
    partial class TestTreeForm
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
            this.TreePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tv = new System.Windows.Forms.TreeView();
            this.TreeSearchBtn = new System.Windows.Forms.Button();
            this.TreeResetBtn = new System.Windows.Forms.Button();
            this.SearchWizard = new System.Windows.Forms.ComboBox();
            this.SearchWord = new System.Windows.Forms.TextBox();
            this.SearchWizardLabel = new System.Windows.Forms.Label();
            this.SearchWordLabel = new System.Windows.Forms.Label();
            this.FavoriteBtn = new System.Windows.Forms.Button();
            this.TreePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TreePanel
            // 
            this.TreePanel.Controls.Add(this.tv);
            this.TreePanel.Location = new System.Drawing.Point(12, 63);
            this.TreePanel.Name = "TreePanel";
            this.TreePanel.Size = new System.Drawing.Size(615, 325);
            this.TreePanel.TabIndex = 0;
            // 
            // tv
            // 
            this.tv.Location = new System.Drawing.Point(3, 3);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(121, 97);
            this.tv.TabIndex = 0;
            this.tv.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_NodeMouseClick);
            // 
            // TreeSearchBtn
            // 
            this.TreeSearchBtn.Location = new System.Drawing.Point(445, 21);
            this.TreeSearchBtn.Name = "TreeSearchBtn";
            this.TreeSearchBtn.Size = new System.Drawing.Size(117, 31);
            this.TreeSearchBtn.TabIndex = 1;
            this.TreeSearchBtn.Text = "검색";
            this.TreeSearchBtn.UseVisualStyleBackColor = true;
            this.TreeSearchBtn.Click += new System.EventHandler(this.TreeSearchBtn_Click);
            // 
            // TreeResetBtn
            // 
            this.TreeResetBtn.Location = new System.Drawing.Point(568, 27);
            this.TreeResetBtn.Name = "TreeResetBtn";
            this.TreeResetBtn.Size = new System.Drawing.Size(57, 26);
            this.TreeResetBtn.TabIndex = 2;
            this.TreeResetBtn.Text = "초기화";
            this.TreeResetBtn.UseVisualStyleBackColor = true;
            this.TreeResetBtn.Click += new System.EventHandler(this.TreeResetBtn_Click);
            // 
            // SearchWizard
            // 
            this.SearchWizard.FormattingEnabled = true;
            this.SearchWizard.Items.AddRange(new object[] {
            "부서명",
            "ID",
            "사원이름"});
            this.SearchWizard.Location = new System.Drawing.Point(131, 27);
            this.SearchWizard.Name = "SearchWizard";
            this.SearchWizard.Size = new System.Drawing.Size(129, 20);
            this.SearchWizard.TabIndex = 3;
            // 
            // SearchWord
            // 
            this.SearchWord.Location = new System.Drawing.Point(282, 26);
            this.SearchWord.Name = "SearchWord";
            this.SearchWord.Size = new System.Drawing.Size(148, 21);
            this.SearchWord.TabIndex = 4;
            // 
            // SearchWizardLabel
            // 
            this.SearchWizardLabel.AutoSize = true;
            this.SearchWizardLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SearchWizardLabel.ForeColor = System.Drawing.Color.White;
            this.SearchWizardLabel.Location = new System.Drawing.Point(131, 8);
            this.SearchWizardLabel.Name = "SearchWizardLabel";
            this.SearchWizardLabel.Size = new System.Drawing.Size(93, 16);
            this.SearchWizardLabel.TabIndex = 5;
            this.SearchWizardLabel.Text = "검색 위저드";
            // 
            // SearchWordLabel
            // 
            this.SearchWordLabel.AutoSize = true;
            this.SearchWordLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SearchWordLabel.ForeColor = System.Drawing.Color.White;
            this.SearchWordLabel.Location = new System.Drawing.Point(279, 7);
            this.SearchWordLabel.Name = "SearchWordLabel";
            this.SearchWordLabel.Size = new System.Drawing.Size(77, 16);
            this.SearchWordLabel.TabIndex = 6;
            this.SearchWordLabel.Text = "검색 단어";
            // 
            // FavoriteBtn
            // 
            this.FavoriteBtn.Location = new System.Drawing.Point(23, 14);
            this.FavoriteBtn.Name = "FavoriteBtn";
            this.FavoriteBtn.Size = new System.Drawing.Size(81, 32);
            this.FavoriteBtn.TabIndex = 7;
            this.FavoriteBtn.Text = "즐겨찾기";
            this.FavoriteBtn.UseVisualStyleBackColor = true;
            this.FavoriteBtn.Click += new System.EventHandler(this.FavoriteBtn_Click);
            // 
            // TestTreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(639, 400);
            this.Controls.Add(this.FavoriteBtn);
            this.Controls.Add(this.SearchWordLabel);
            this.Controls.Add(this.SearchWizardLabel);
            this.Controls.Add(this.SearchWord);
            this.Controls.Add(this.SearchWizard);
            this.Controls.Add(this.TreeResetBtn);
            this.Controls.Add(this.TreeSearchBtn);
            this.Controls.Add(this.TreePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TestTreeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "x";
            this.Load += new System.EventHandler(this.TestTreeForm_Load);
            this.TreePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel TreePanel;
        private System.Windows.Forms.Button TreeSearchBtn;
        private System.Windows.Forms.Button TreeResetBtn;
        private System.Windows.Forms.ComboBox SearchWizard;
        private System.Windows.Forms.TextBox SearchWord;
        private System.Windows.Forms.Label SearchWizardLabel;
        private System.Windows.Forms.Label SearchWordLabel;
        private System.Windows.Forms.Button FavoriteBtn;
        private System.Windows.Forms.TreeView tv;
    }
}