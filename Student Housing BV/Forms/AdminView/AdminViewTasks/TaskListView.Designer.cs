namespace Student_Housing_BV.Forms.AdminView.AdminViewTasks
{
    partial class TaskListView
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
            btnBackToAdminView = new Button();
            btnAddTask = new Button();
            dataGridDisplayAllTasks = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dueDatesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            taskBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridDisplayAllTasks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taskBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnBackToAdminView
            // 
            btnBackToAdminView.Location = new Point(102, 51);
            btnBackToAdminView.Margin = new Padding(2, 1, 2, 1);
            btnBackToAdminView.Name = "btnBackToAdminView";
            btnBackToAdminView.Size = new Size(81, 37);
            btnBackToAdminView.TabIndex = 3;
            btnBackToAdminView.Text = "Back";
            btnBackToAdminView.UseVisualStyleBackColor = true;
            btnBackToAdminView.Click += btnBackToAdminView_Click;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(546, 51);
            btnAddTask.Margin = new Padding(2, 1, 2, 1);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(81, 37);
            btnAddTask.TabIndex = 2;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // dataGridDisplayAllTasks
            // 
            dataGridDisplayAllTasks.AllowUserToResizeColumns = false;
            dataGridDisplayAllTasks.AllowUserToResizeRows = false;
            dataGridDisplayAllTasks.AutoGenerateColumns = false;
            dataGridDisplayAllTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDisplayAllTasks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridDisplayAllTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDisplayAllTasks.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, dueDatesDataGridViewTextBoxColumn });
            dataGridDisplayAllTasks.DataSource = taskBindingSource;
            dataGridDisplayAllTasks.Location = new Point(77, 113);
            dataGridDisplayAllTasks.Margin = new Padding(2, 1, 2, 1);
            dataGridDisplayAllTasks.MultiSelect = false;
            dataGridDisplayAllTasks.Name = "dataGridDisplayAllTasks";
            dataGridDisplayAllTasks.ReadOnly = true;
            dataGridDisplayAllTasks.RowHeadersWidth = 82;
            dataGridDisplayAllTasks.RowTemplate.Height = 41;
            dataGridDisplayAllTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDisplayAllTasks.Size = new Size(582, 297);
            dataGridDisplayAllTasks.TabIndex = 4;
            dataGridDisplayAllTasks.CellDoubleClick += dataGridDisplayAllTasks_CellDoubleClick;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dueDatesDataGridViewTextBoxColumn
            // 
            dueDatesDataGridViewTextBoxColumn.DataPropertyName = "DueDates";
            dueDatesDataGridViewTextBoxColumn.HeaderText = "DueDates";
            dueDatesDataGridViewTextBoxColumn.Name = "dueDatesDataGridViewTextBoxColumn";
            dueDatesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taskBindingSource
            // 
            taskBindingSource.DataSource = typeof(Classes.Tasks.Task);
            // 
            // TaskListView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(740, 435);
            Controls.Add(dataGridDisplayAllTasks);
            Controls.Add(btnBackToAdminView);
            Controls.Add(btnAddTask);
            Name = "TaskListView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskListView";
            ((System.ComponentModel.ISupportInitialize)dataGridDisplayAllTasks).EndInit();
            ((System.ComponentModel.ISupportInitialize)taskBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBackToAdminView;
        private Button btnAddTask;
        private DataGridViewTextBoxColumn filePathDataGridViewTextBoxColumn;
        private BindingSource handleTasksBindingSource;
        private DataGridView dataGridDisplayAllTasks;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dueDatesDataGridViewTextBoxColumn;
        private BindingSource taskBindingSource;
    }
}