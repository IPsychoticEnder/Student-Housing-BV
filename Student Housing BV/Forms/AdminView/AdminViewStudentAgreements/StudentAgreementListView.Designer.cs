namespace Student_Housing_BV.Forms.AdminView.AdminViewStudentAgreements
{
    partial class StudentAgreementListView
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
            studentAgreementBindingSource = new BindingSource(components);
            btnBackToAdminView = new Button();
            btnStudentAgreement = new Button();
            lbDisplayAllStudentAgreement = new ListBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)studentAgreementBindingSource).BeginInit();
            SuspendLayout();
            // 
            // studentAgreementBindingSource
            // 
            studentAgreementBindingSource.DataSource = typeof(Classes.StudentAgreements.StudentAgreement);
            // 
            // btnBackToAdminView
            // 
            btnBackToAdminView.Location = new Point(104, 38);
            btnBackToAdminView.Margin = new Padding(2, 1, 2, 1);
            btnBackToAdminView.Name = "btnBackToAdminView";
            btnBackToAdminView.Size = new Size(81, 37);
            btnBackToAdminView.TabIndex = 5;
            btnBackToAdminView.Text = "Back";
            btnBackToAdminView.UseVisualStyleBackColor = true;
            btnBackToAdminView.Click += btnBackToAdminView_Click;
            // 
            // btnStudentAgreement
            // 
            btnStudentAgreement.Location = new Point(528, 38);
            btnStudentAgreement.Margin = new Padding(2, 1, 2, 1);
            btnStudentAgreement.Name = "btnStudentAgreement";
            btnStudentAgreement.Size = new Size(101, 37);
            btnStudentAgreement.TabIndex = 4;
            btnStudentAgreement.Text = "Add Agreement";
            btnStudentAgreement.UseVisualStyleBackColor = true;
            btnStudentAgreement.Click += btnStudentAgreement_Click;
            // 
            // lbDisplayAllStudentAgreement
            // 
            lbDisplayAllStudentAgreement.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDisplayAllStudentAgreement.FormattingEnabled = true;
            lbDisplayAllStudentAgreement.ItemHeight = 18;
            lbDisplayAllStudentAgreement.Location = new Point(18, 125);
            lbDisplayAllStudentAgreement.Name = "lbDisplayAllStudentAgreement";
            lbDisplayAllStudentAgreement.Size = new Size(705, 292);
            lbDisplayAllStudentAgreement.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 100);
            label1.Name = "label1";
            label1.Size = new Size(204, 22);
            label1.TabIndex = 7;
            label1.Text = "Student agreements:";
            // 
            // StudentAgreementListView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(740, 435);
            Controls.Add(label1);
            Controls.Add(lbDisplayAllStudentAgreement);
            Controls.Add(btnBackToAdminView);
            Controls.Add(btnStudentAgreement);
            Name = "StudentAgreementListView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentAgreementListView";
            ((System.ComponentModel.ISupportInitialize)studentAgreementBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBackToAdminView;
        private Button btnStudentAgreement;
        private BindingSource studentAgreementBindingSource;
        private ListBox lbDisplayAllStudentAgreement;
        private Label label1;
    }
}