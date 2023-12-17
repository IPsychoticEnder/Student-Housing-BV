namespace Student_Housing_BV.Forms.UsersView
{
    partial class EditUserView
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
            groupBox1 = new GroupBox();
            btnDeleteUser = new Button();
            tbEditUserUserID = new TextBox();
            label3 = new Label();
            btnAddUser = new Button();
            cbEditUserUserAdminAccess = new CheckBox();
            tbEditUserUserPassword = new TextBox();
            tbEditUserUserName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(224, 224, 224);
            groupBox1.Controls.Add(btnDeleteUser);
            groupBox1.Controls.Add(tbEditUserUserID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnAddUser);
            groupBox1.Controls.Add(cbEditUserUserAdminAccess);
            groupBox1.Controls.Add(tbEditUserUserPassword);
            groupBox1.Controls.Add(tbEditUserUserName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(202, 123);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(971, 683);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Edit User";
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.FromArgb(255, 192, 192);
            btnDeleteUser.Location = new Point(112, 540);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(270, 62);
            btnDeleteUser.TabIndex = 11;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // tbEditUserUserID
            // 
            tbEditUserUserID.Location = new Point(446, 193);
            tbEditUserUserID.Name = "tbEditUserUserID";
            tbEditUserUserID.ReadOnly = true;
            tbEditUserUserID.Size = new Size(353, 39);
            tbEditUserUserID.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 196);
            label3.Name = "label3";
            label3.Size = new Size(96, 32);
            label3.TabIndex = 9;
            label3.Text = "User ID:";
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.FromArgb(192, 255, 192);
            btnAddUser.Location = new Point(574, 540);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(270, 62);
            btnAddUser.TabIndex = 8;
            btnAddUser.Text = "Save";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnEditUser_Click;
            // 
            // cbEditUserUserAdminAccess
            // 
            cbEditUserUserAdminAccess.AutoSize = true;
            cbEditUserUserAdminAccess.Location = new Point(446, 372);
            cbEditUserUserAdminAccess.Name = "cbEditUserUserAdminAccess";
            cbEditUserUserAdminAccess.Size = new Size(198, 36);
            cbEditUserUserAdminAccess.TabIndex = 7;
            cbEditUserUserAdminAccess.Text = "Admin Access:";
            cbEditUserUserAdminAccess.UseVisualStyleBackColor = true;
            // 
            // tbEditUserUserPassword
            // 
            tbEditUserUserPassword.Location = new Point(446, 276);
            tbEditUserUserPassword.Name = "tbEditUserUserPassword";
            tbEditUserUserPassword.Size = new Size(353, 39);
            tbEditUserUserPassword.TabIndex = 5;
            // 
            // tbEditUserUserName
            // 
            tbEditUserUserName.Location = new Point(446, 109);
            tbEditUserUserName.Name = "tbEditUserUserName";
            tbEditUserUserName.Size = new Size(353, 39);
            tbEditUserUserName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 279);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 1;
            label2.Text = "Password:";
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
            // EditUserView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1374, 929);
            Controls.Add(groupBox1);
            Name = "EditUserView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditUserView";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAddUser;
        private CheckBox cbEditUserUserAdminAccess;
        private TextBox tbEditUserUserPassword;
        private TextBox tbEditUserUserName;
        private Label label2;
        private Label label1;
        private TextBox tbEditUserUserID;
        private Label label3;
        private Button btnDeleteUser;
    }
}