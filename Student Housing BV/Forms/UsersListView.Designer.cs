namespace Student_Housing_BV.Forms
{
    partial class UsersListView
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
            btnAddUser = new Button();
            btnBackToAdminView = new Button();
            lbDisplayAllUsers = new ListBox();
            SuspendLayout();
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(986, 108);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(150, 78);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnBackToAdminView
            // 
            btnBackToAdminView.Location = new Point(190, 108);
            btnBackToAdminView.Name = "btnBackToAdminView";
            btnBackToAdminView.Size = new Size(150, 78);
            btnBackToAdminView.TabIndex = 1;
            btnBackToAdminView.Text = "Back";
            btnBackToAdminView.UseVisualStyleBackColor = true;
            btnBackToAdminView.Click += btnBackToAdminView_Click;
            // 
            // lbDisplayAllUsers
            // 
            lbDisplayAllUsers.FormattingEnabled = true;
            lbDisplayAllUsers.ItemHeight = 32;
            lbDisplayAllUsers.Location = new Point(190, 243);
            lbDisplayAllUsers.Name = "lbDisplayAllUsers";
            lbDisplayAllUsers.Size = new Size(946, 644);
            lbDisplayAllUsers.TabIndex = 2;
            // 
            // UsersListView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 982);
            Controls.Add(lbDisplayAllUsers);
            Controls.Add(btnBackToAdminView);
            Controls.Add(btnAddUser);
            Name = "UsersListView";
            Text = "UsersListView";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddUser;
        private Button btnBackToAdminView;
        private ListBox lbDisplayAllUsers;
    }
}