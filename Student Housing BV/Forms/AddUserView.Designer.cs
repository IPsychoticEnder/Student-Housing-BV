namespace Student_Housing_BV.Forms
{
    partial class AddUserView
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnAddUser = new Button();
            cbAddUserUserAdminAccess = new CheckBox();
            tbAddUserCheckUserPassword = new TextBox();
            tbAddUserUserPassword = new TextBox();
            tbAddUserUserName = new TextBox();
            label4 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 112);
            label1.Name = "label1";
            label1.Size = new Size(137, 32);
            label1.TabIndex = 0;
            label1.Text = "User Name:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(224, 224, 224);
            groupBox1.Controls.Add(btnAddUser);
            groupBox1.Controls.Add(cbAddUserUserAdminAccess);
            groupBox1.Controls.Add(tbAddUserCheckUserPassword);
            groupBox1.Controls.Add(tbAddUserUserPassword);
            groupBox1.Controls.Add(tbAddUserUserName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(193, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(971, 683);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "New User";
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(353, 525);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(270, 62);
            btnAddUser.TabIndex = 8;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // cbAddUserUserAdminAccess
            // 
            cbAddUserUserAdminAccess.AutoSize = true;
            cbAddUserUserAdminAccess.Location = new Point(446, 341);
            cbAddUserUserAdminAccess.Name = "cbAddUserUserAdminAccess";
            cbAddUserUserAdminAccess.Size = new Size(198, 36);
            cbAddUserUserAdminAccess.TabIndex = 7;
            cbAddUserUserAdminAccess.Text = "Admin Access:";
            cbAddUserUserAdminAccess.UseVisualStyleBackColor = true;
            // 
            // tbAddUserCheckUserPassword
            // 
            tbAddUserCheckUserPassword.Location = new Point(446, 246);
            tbAddUserCheckUserPassword.Name = "tbAddUserCheckUserPassword";
            tbAddUserCheckUserPassword.Size = new Size(353, 39);
            tbAddUserCheckUserPassword.TabIndex = 6;
            // 
            // tbAddUserUserPassword
            // 
            tbAddUserUserPassword.Location = new Point(446, 174);
            tbAddUserUserPassword.Name = "tbAddUserUserPassword";
            tbAddUserUserPassword.Size = new Size(353, 39);
            tbAddUserUserPassword.TabIndex = 5;
            // 
            // tbAddUserUserName
            // 
            tbAddUserUserName.Location = new Point(446, 109);
            tbAddUserUserName.Name = "tbAddUserUserName";
            tbAddUserUserName.Size = new Size(353, 39);
            tbAddUserUserName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 249);
            label4.Name = "label4";
            label4.Size = new Size(209, 32);
            label4.TabIndex = 3;
            label4.Text = "Confirm Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 177);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // AddUserView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1374, 929);
            Controls.Add(groupBox1);
            Name = "AddUserView";
            Text = "AddUserView";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox tbAddUserUserName;
        private Label label4;
        private CheckBox cbAddUserUserAdminAccess;
        private TextBox tbAddUserCheckUserPassword;
        private TextBox tbAddUserUserPassword;
        private Button btnAddUser;
    }
}