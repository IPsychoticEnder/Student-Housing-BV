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
            panel1 = new Panel();
            btnExitProgram = new Button();
            lblTitleOfProduct = new Label();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            tbLoginUserID = new TextBox();
            tbLoginUserPassword = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnLogin = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 41, 78);
            panel1.Controls.Add(btnExitProgram);
            panel1.Controls.Add(lblTitleOfProduct);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 59);
            panel1.TabIndex = 3;
            // 
            // btnExitProgram
            // 
            btnExitProgram.BackColor = Color.Red;
            btnExitProgram.Cursor = Cursors.Hand;
            btnExitProgram.FlatStyle = FlatStyle.Flat;
            btnExitProgram.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnExitProgram.ForeColor = Color.White;
            btnExitProgram.Location = new Point(798, 17);
            btnExitProgram.Name = "btnExitProgram";
            btnExitProgram.Size = new Size(50, 24);
            btnExitProgram.TabIndex = 4;
            btnExitProgram.Text = "Close";
            btnExitProgram.UseVisualStyleBackColor = false;
            btnExitProgram.Click += btnExitProgram_Click;
            // 
            // lblTitleOfProduct
            // 
            lblTitleOfProduct.AutoSize = true;
            lblTitleOfProduct.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleOfProduct.ForeColor = Color.White;
            lblTitleOfProduct.Location = new Point(12, 15);
            lblTitleOfProduct.Name = "lblTitleOfProduct";
            lblTitleOfProduct.Size = new Size(277, 28);
            lblTitleOfProduct.TabIndex = 3;
            lblTitleOfProduct.Text = "Student Housing B.V.";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(860, 473);
            panel2.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(224, 224, 224);
            groupBox1.Controls.Add(tbLoginUserID);
            groupBox1.Controls.Add(tbLoginUserPassword);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Location = new Point(275, 104);
            groupBox1.Margin = new Padding(2, 1, 2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 1, 2, 1);
            groupBox1.Size = new Size(311, 267);
            groupBox1.TabIndex = 1;
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
            tbLoginUserID.Text = "admin";
            // 
            // tbLoginUserPassword
            // 
            tbLoginUserPassword.Location = new Point(98, 96);
            tbLoginUserPassword.Margin = new Padding(2, 1, 2, 1);
            tbLoginUserPassword.Name = "tbLoginUserPassword";
            tbLoginUserPassword.Size = new Size(153, 23);
            tbLoginUserPassword.TabIndex = 4;
            tbLoginUserPassword.Text = "ADMIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 96);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 56);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 1;
            label1.Text = "User Name:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(188, 212, 222);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(101, 210);
            btnLogin.Margin = new Padding(2, 1, 2, 1);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(105, 32);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(75, 82, 103);
            ClientSize = new Size(860, 532);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnExitProgram;
        private Label lblTitleOfProduct;
        private Panel panel2;
        private GroupBox groupBox1;
        private TextBox tbLoginUserID;
        private TextBox tbLoginUserPassword;
        private Label label2;
        private Label label1;
        private Button btnLogin;
    }
}