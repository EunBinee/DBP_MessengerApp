namespace DBP_Project
{
    partial class LogIn
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
            this.label_SignUp = new System.Windows.Forms.Label();
            this.button_LogIn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_SignUp
            // 
            this.label_SignUp.AutoSize = true;
            this.label_SignUp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_SignUp.Location = new System.Drawing.Point(240, 510);
            this.label_SignUp.Name = "label_SignUp";
            this.label_SignUp.Size = new System.Drawing.Size(67, 15);
            this.label_SignUp.TabIndex = 13;
            this.label_SignUp.Text = "회원가입";
            this.label_SignUp.Click += new System.EventHandler(this.label_SignUp_Click);
            // 
            // button_LogIn
            // 
            this.button_LogIn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_LogIn.Location = new System.Drawing.Point(94, 438);
            this.button_LogIn.Name = "button_LogIn";
            this.button_LogIn.Size = new System.Drawing.Size(242, 53);
            this.button_LogIn.TabIndex = 12;
            this.button_LogIn.Text = "로그인";
            this.button_LogIn.UseVisualStyleBackColor = false;
            this.button_LogIn.Click += new System.EventHandler(this.button_LogIn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("한컴산뜻돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox1.Location = new System.Drawing.Point(94, 374);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(211, 23);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "사원번호, 비밀번호 기억하기";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_Password.Location = new System.Drawing.Point(94, 319);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(242, 25);
            this.textBox_Password.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("한컴산뜻돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(90, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "비밀 번호";
            // 
            // textBox_Number
            // 
            this.textBox_Number.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_Number.Location = new System.Drawing.Point(94, 239);
            this.textBox_Number.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.Size = new System.Drawing.Size(242, 25);
            this.textBox_Number.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("한컴산뜻돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(90, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "사원 번호";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(432, 653);
            this.Controls.Add(this.label_SignUp);
            this.Controls.Add(this.button_LogIn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Number);
            this.Controls.Add(this.label1);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SignUp;
        private System.Windows.Forms.Button button_LogIn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Number;
        private System.Windows.Forms.Label label1;
    }
}