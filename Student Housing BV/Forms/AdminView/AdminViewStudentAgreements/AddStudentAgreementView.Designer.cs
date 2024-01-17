namespace Student_Housing_BV.Forms.AdminView.AdminViewStudentAgreements
{
    partial class AddStudentAgreementView
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
            panel1 = new Panel();
            btnSaveStudentAgreement = new Button();
            btnBack = new Button();
            panel2 = new Panel();
            tbDescription = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            btnAddStudent = new Button();
            panel4 = new Panel();
            label2 = new Label();
            flowPanelDisplayUsers = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSaveStudentAgreement);
            panel1.Controls.Add(btnBack);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(740, 71);
            panel1.TabIndex = 1;
            // 
            // btnSaveStudentAgreement
            // 
            btnSaveStudentAgreement.Location = new Point(561, 17);
            btnSaveStudentAgreement.Name = "btnSaveStudentAgreement";
            btnSaveStudentAgreement.Size = new Size(79, 36);
            btnSaveStudentAgreement.TabIndex = 1;
            btnSaveStudentAgreement.Text = "Add";
            btnSaveStudentAgreement.UseVisualStyleBackColor = true;
            btnSaveStudentAgreement.Click += btnSaveStudentAgreement_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(100, 17);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(79, 36);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(tbDescription);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 364);
            panel2.TabIndex = 2;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(12, 45);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(260, 274);
            tbDescription.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(97, 19);
            label1.TabIndex = 0;
            label1.Text = "Description";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(btnAddStudent);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(288, 357);
            panel3.Name = "panel3";
            panel3.Size = new Size(452, 78);
            panel3.TabIndex = 4;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.Silver;
            btnAddStudent.Location = new Point(157, 20);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(138, 39);
            btnAddStudent.TabIndex = 0;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(288, 71);
            panel4.Name = "panel4";
            panel4.Size = new Size(452, 42);
            panel4.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(0, 14);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 1;
            label2.Text = "Students";
            // 
            // flowPanelDisplayUsers
            // 
            flowPanelDisplayUsers.BackColor = Color.FromArgb(224, 224, 224);
            flowPanelDisplayUsers.Dock = DockStyle.Fill;
            flowPanelDisplayUsers.Location = new Point(288, 113);
            flowPanelDisplayUsers.Name = "flowPanelDisplayUsers";
            flowPanelDisplayUsers.Size = new Size(452, 244);
            flowPanelDisplayUsers.TabIndex = 5;
            // 
            // AddStudentAgreementView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(740, 435);
            Controls.Add(flowPanelDisplayUsers);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddStudentAgreementView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudentAAgreementView";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnBack;
        private Button btnSaveStudentAgreement;
        private Panel panel2;
        private TextBox tbDescription;
        private Label label1;
        private Panel panel3;
        private Button btnAddStudent;
        private Panel panel4;
        private FlowLayoutPanel flowPanelDisplayUsers;
        private Label label2;
    }
}