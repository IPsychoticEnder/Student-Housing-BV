namespace Student_Housing_BV
{
    partial class LoginView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            tbLoginUserID = new TextBox();
            tbLoginUserPassword = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnLogin = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(224, 224, 224);
            groupBox1.Controls.Add(tbLoginUserID);
            groupBox1.Controls.Add(tbLoginUserPassword);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Location = new Point(213, 89);
            groupBox1.Margin = new Padding(2, 1, 2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 1, 2, 1);
            groupBox1.Size = new Size(311, 267);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // tbLoginUserID
            // 
            tbLoginUserID.Location = new Point(98, 57);
            tbLoginUserID.Margin = new Padding(2, 1, 2, 1);
            tbLoginUserID.Name = "tbLoginUserID";
            tbLoginUserID.Size = new Size(153, 23);
            tbLoginUserID.TabIndex = 5;
            tbLoginUserID.Text = "Aaron";
            // 
            // tbLoginUserPassword
            // 
            tbLoginUserPassword.Location = new Point(98, 96);
            tbLoginUserPassword.Margin = new Padding(2, 1, 2, 1);
            tbLoginUserPassword.Name = "tbLoginUserPassword";
            tbLoginUserPassword.Size = new Size(153, 23);
            tbLoginUserPassword.TabIndex = 4;
            tbLoginUserPassword.Text = "12345";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 98);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 58);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 1;
            label1.Text = "User Name:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(101, 210);
            btnLogin.Margin = new Padding(2, 1, 2, 1);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(105, 32);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += BtnLogin_Click;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(740, 435);
            Controls.Add(groupBox1);
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbLoginUserPassword;
        private Label label2;
        private Label label1;
        private Button btnLogin;
        private TextBox tbLoginUserID;
    }
}