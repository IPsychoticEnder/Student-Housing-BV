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
            btnBackToAdminView = new Button();
            btnAddTask = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(77, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(582, 297);
            dataGridView1.TabIndex = 4;
            // 
            // TaskListView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnBackToAdminView);
            Controls.Add(btnAddTask);
            Name = "TaskListView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskListView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBackToAdminView;
        private Button btnAddTask;
        private DataGridView dataGridView1;
    }
}