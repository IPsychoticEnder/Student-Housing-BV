namespace Student_Housing_BV.Forms.AdminView.AdminViewTasks
{
    partial class EditTaskView
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
            cmboxSelectUser = new ComboBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            cbSaturdayInput = new CheckBox();
            cbFridayInput = new CheckBox();
            cbThursdayInput = new CheckBox();
            cbWednesdayInput = new CheckBox();
            cbTuesdayInput = new CheckBox();
            cbMondayInput = new CheckBox();
            tbTaskDescription = new TextBox();
            tbTaskTitle = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnDeleteTask = new Button();
            btnSaveTask = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(224, 224, 224);
            groupBox1.Controls.Add(cmboxSelectUser);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(tbTaskDescription);
            groupBox1.Controls.Add(tbTaskTitle);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnDeleteTask);
            groupBox1.Controls.Add(btnSaveTask);
            groupBox1.Location = new Point(104, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 320);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Edit Task";
            // 
            // cmboxSelectUser
            // 
            cmboxSelectUser.FormattingEnabled = true;
            cmboxSelectUser.Location = new Point(123, 212);
            cmboxSelectUser.Name = "cmboxSelectUser";
            cmboxSelectUser.Size = new Size(189, 23);
            cmboxSelectUser.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 212);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 17;
            label3.Text = "Assigned User:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbSaturdayInput);
            groupBox2.Controls.Add(cbFridayInput);
            groupBox2.Controls.Add(cbThursdayInput);
            groupBox2.Controls.Add(cbWednesdayInput);
            groupBox2.Controls.Add(cbTuesdayInput);
            groupBox2.Controls.Add(cbMondayInput);
            groupBox2.ForeColor = SystemColors.ControlText;
            groupBox2.Location = new Point(318, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(164, 202);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Due date";
            // 
            // cbSaturdayInput
            // 
            cbSaturdayInput.AutoSize = true;
            cbSaturdayInput.Location = new Point(6, 150);
            cbSaturdayInput.Name = "cbSaturdayInput";
            cbSaturdayInput.Size = new Size(72, 19);
            cbSaturdayInput.TabIndex = 5;
            cbSaturdayInput.Text = "Saturday";
            cbSaturdayInput.UseVisualStyleBackColor = true;
            // 
            // cbFridayInput
            // 
            cbFridayInput.AutoSize = true;
            cbFridayInput.Location = new Point(6, 125);
            cbFridayInput.Name = "cbFridayInput";
            cbFridayInput.Size = new Size(58, 19);
            cbFridayInput.TabIndex = 4;
            cbFridayInput.Text = "Friday";
            cbFridayInput.UseVisualStyleBackColor = true;
            // 
            // cbThursdayInput
            // 
            cbThursdayInput.AutoSize = true;
            cbThursdayInput.Location = new Point(6, 100);
            cbThursdayInput.Name = "cbThursdayInput";
            cbThursdayInput.Size = new Size(74, 19);
            cbThursdayInput.TabIndex = 3;
            cbThursdayInput.Text = "Thursday";
            cbThursdayInput.UseVisualStyleBackColor = true;
            // 
            // cbWednesdayInput
            // 
            cbWednesdayInput.AutoSize = true;
            cbWednesdayInput.Location = new Point(6, 75);
            cbWednesdayInput.Name = "cbWednesdayInput";
            cbWednesdayInput.Size = new Size(87, 19);
            cbWednesdayInput.TabIndex = 2;
            cbWednesdayInput.Text = "Wednesday";
            cbWednesdayInput.UseVisualStyleBackColor = true;
            // 
            // cbTuesdayInput
            // 
            cbTuesdayInput.AutoSize = true;
            cbTuesdayInput.Location = new Point(6, 50);
            cbTuesdayInput.Name = "cbTuesdayInput";
            cbTuesdayInput.Size = new Size(69, 19);
            cbTuesdayInput.TabIndex = 1;
            cbTuesdayInput.Text = "Tuesday";
            cbTuesdayInput.UseVisualStyleBackColor = true;
            // 
            // cbMondayInput
            // 
            cbMondayInput.AutoSize = true;
            cbMondayInput.Location = new Point(6, 25);
            cbMondayInput.Name = "cbMondayInput";
            cbMondayInput.Size = new Size(70, 19);
            cbMondayInput.TabIndex = 0;
            cbMondayInput.Text = "Monday";
            cbMondayInput.UseVisualStyleBackColor = true;
            // 
            // tbTaskDescription
            // 
            tbTaskDescription.Location = new Point(123, 89);
            tbTaskDescription.Multiline = true;
            tbTaskDescription.Name = "tbTaskDescription";
            tbTaskDescription.Size = new Size(189, 113);
            tbTaskDescription.TabIndex = 15;
            // 
            // tbTaskTitle
            // 
            tbTaskTitle.Location = new Point(123, 58);
            tbTaskTitle.Name = "tbTaskTitle";
            tbTaskTitle.Size = new Size(189, 23);
            tbTaskTitle.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 89);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 13;
            label2.Text = "Description:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 58);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 12;
            label1.Text = "Name:";
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.BackColor = Color.FromArgb(255, 192, 192);
            btnDeleteTask.Location = new Point(36, 274);
            btnDeleteTask.Margin = new Padding(2, 1, 2, 1);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(145, 29);
            btnDeleteTask.TabIndex = 11;
            btnDeleteTask.Text = "Delete";
            btnDeleteTask.UseVisualStyleBackColor = false;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // btnSaveTask
            // 
            btnSaveTask.BackColor = Color.FromArgb(192, 255, 192);
            btnSaveTask.Location = new Point(337, 274);
            btnSaveTask.Margin = new Padding(2, 1, 2, 1);
            btnSaveTask.Name = "btnSaveTask";
            btnSaveTask.Size = new Size(145, 29);
            btnSaveTask.TabIndex = 10;
            btnSaveTask.Text = "Save Task";
            btnSaveTask.UseVisualStyleBackColor = false;
            btnSaveTask.Click += btnSaveTask_Click;
            // 
            // EditTaskView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(740, 435);
            Controls.Add(groupBox1);
            Name = "EditTaskView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditTaskView";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmboxSelectUser;
        private Label label3;
        private GroupBox groupBox2;
        private CheckBox cbSaturdayInput;
        private CheckBox cbFridayInput;
        private CheckBox cbThursdayInput;
        private CheckBox cbWednesdayInput;
        private CheckBox cbTuesdayInput;
        private CheckBox cbMondayInput;
        private TextBox tbTaskDescription;
        private TextBox tbTaskTitle;
        private Label label2;
        private Label label1;
        private Button btnDeleteTask;
        private Button btnSaveTask;
    }
}