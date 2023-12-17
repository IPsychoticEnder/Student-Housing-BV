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
            components = new System.ComponentModel.Container();
            btnAddUser = new Button();
            btnBackToAdminView = new Button();
            dtgridDisplayAllUsers = new DataGridView();
            userIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isAdminDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            userBindingSource1 = new BindingSource(components);
            handleUsersBindingSource = new BindingSource(components);
            userBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dtgridDisplayAllUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)handleUsersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
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
            // dtgridDisplayAllUsers
            // 
            dtgridDisplayAllUsers.AllowUserToResizeColumns = false;
            dtgridDisplayAllUsers.AllowUserToResizeRows = false;
            dtgridDisplayAllUsers.AutoGenerateColumns = false;
            dtgridDisplayAllUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgridDisplayAllUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dtgridDisplayAllUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgridDisplayAllUsers.Columns.AddRange(new DataGridViewColumn[] { userIDDataGridViewTextBoxColumn, userNameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, isAdminDataGridViewCheckBoxColumn });
            dtgridDisplayAllUsers.DataSource = userBindingSource1;
            dtgridDisplayAllUsers.Location = new Point(124, 239);
            dtgridDisplayAllUsers.MultiSelect = false;
            dtgridDisplayAllUsers.Name = "dtgridDisplayAllUsers";
            dtgridDisplayAllUsers.ReadOnly = true;
            dtgridDisplayAllUsers.RowHeadersWidth = 82;
            dtgridDisplayAllUsers.RowTemplate.Height = 41;
            dtgridDisplayAllUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgridDisplayAllUsers.Size = new Size(1080, 634);
            dtgridDisplayAllUsers.TabIndex = 3;
            dtgridDisplayAllUsers.CellDoubleClick += dtgridDisplayAllUsers_CellDoubleClick;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            userIDDataGridViewTextBoxColumn.HeaderText = "userID";
            userIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            userNameDataGridViewTextBoxColumn.DataPropertyName = "userName";
            userNameDataGridViewTextBoxColumn.HeaderText = "userName";
            userNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            passwordDataGridViewTextBoxColumn.HeaderText = "password";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 10;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // isAdminDataGridViewCheckBoxColumn
            // 
            isAdminDataGridViewCheckBoxColumn.DataPropertyName = "isAdmin";
            isAdminDataGridViewCheckBoxColumn.HeaderText = "isAdmin";
            isAdminDataGridViewCheckBoxColumn.MinimumWidth = 10;
            isAdminDataGridViewCheckBoxColumn.Name = "isAdminDataGridViewCheckBoxColumn";
            isAdminDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // userBindingSource1
            // 
            userBindingSource1.DataSource = typeof(Classes.User);
            // 
            // handleUsersBindingSource
            // 
            handleUsersBindingSource.DataSource = typeof(Classes.HandleUsers);
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Classes.User);
            // 
            // UsersListView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1374, 929);
            Controls.Add(dtgridDisplayAllUsers);
            Controls.Add(btnBackToAdminView);
            Controls.Add(btnAddUser);
            Name = "UsersListView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UsersListView";
            ((System.ComponentModel.ISupportInitialize)dtgridDisplayAllUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)handleUsersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddUser;
        private Button btnBackToAdminView;
        private DataGridView dtgridDisplayAllUsers;
        private BindingSource userBindingSource;
        private BindingSource handleUsersBindingSource;
        private BindingSource userBindingSource1;
        private DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isAdminDataGridViewCheckBoxColumn;
    }
}