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
            dataGridDisplayAllUsers = new DataGridView();
            userBindingSource = new BindingSource(components);
            isAdminDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridDisplayAllUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(546, 51);
            btnAddUser.Margin = new Padding(2, 1, 2, 1);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(81, 37);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnBackToAdminView
            // 
            btnBackToAdminView.Location = new Point(102, 51);
            btnBackToAdminView.Margin = new Padding(2, 1, 2, 1);
            btnBackToAdminView.Name = "btnBackToAdminView";
            btnBackToAdminView.Size = new Size(81, 37);
            btnBackToAdminView.TabIndex = 1;
            btnBackToAdminView.Text = "Back";
            btnBackToAdminView.UseVisualStyleBackColor = true;
            btnBackToAdminView.Click += btnBackToAdminView_Click;
            // 
            // dataGridDisplayAllUsers
            // 
            dataGridDisplayAllUsers.AllowUserToResizeColumns = false;
            dataGridDisplayAllUsers.AllowUserToResizeRows = false;
            dataGridDisplayAllUsers.AutoGenerateColumns = false;
            dataGridDisplayAllUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDisplayAllUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridDisplayAllUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDisplayAllUsers.Columns.AddRange(new DataGridViewColumn[] { userIDDataGridViewTextBoxColumn, userNameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, isAdminDataGridViewCheckBoxColumn });
            dataGridDisplayAllUsers.DataSource = userBindingSource;
            dataGridDisplayAllUsers.Location = new Point(77, 113);
            dataGridDisplayAllUsers.Margin = new Padding(2, 1, 2, 1);
            dataGridDisplayAllUsers.MultiSelect = false;
            dataGridDisplayAllUsers.Name = "dataGridDisplayAllUsers";
            dataGridDisplayAllUsers.ReadOnly = true;
            dataGridDisplayAllUsers.RowHeadersWidth = 82;
            dataGridDisplayAllUsers.RowTemplate.Height = 41;
            dataGridDisplayAllUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDisplayAllUsers.Size = new Size(582, 297);
            dataGridDisplayAllUsers.TabIndex = 3;
            dataGridDisplayAllUsers.CellDoubleClick += dataGridDisplayAllUsers_CellDoubleClick;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Classes.User);
            // 
            // isAdminDataGridViewCheckBoxColumn
            // 
            isAdminDataGridViewCheckBoxColumn.DataPropertyName = "IsAdmin";
            isAdminDataGridViewCheckBoxColumn.HeaderText = "IsAdmin";
            isAdminDataGridViewCheckBoxColumn.Name = "isAdminDataGridViewCheckBoxColumn";
            isAdminDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UsersListView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(740, 435);
            Controls.Add(dataGridDisplayAllUsers);
            Controls.Add(btnBackToAdminView);
            Controls.Add(btnAddUser);
            Margin = new Padding(2, 1, 2, 1);
            Name = "UsersListView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UsersListView";
            ((System.ComponentModel.ISupportInitialize)dataGridDisplayAllUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddUser;
        private Button btnBackToAdminView;
        private DataGridView dataGridDisplayAllUsers;
        private BindingSource userBindingSource;
        private DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isAdminDataGridViewCheckBoxColumn;
    }
}