namespace Student_Housing_BV.Forms.AdminView.AdminViewAgreements
{
    partial class AgreementsListView
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
            btnAddAgreement = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnBackToAdminView
            // 
            btnBackToAdminView.Location = new Point(132, 66);
            btnBackToAdminView.Margin = new Padding(2, 1, 2, 1);
            btnBackToAdminView.Name = "btnBackToAdminView";
            btnBackToAdminView.Size = new Size(81, 37);
            btnBackToAdminView.TabIndex = 3;
            btnBackToAdminView.Text = "Back";
            btnBackToAdminView.UseVisualStyleBackColor = true;
            // 
            // btnAddAgreement
            // 
            btnAddAgreement.Location = new Point(545, 66);
            btnAddAgreement.Margin = new Padding(2, 1, 2, 1);
            btnAddAgreement.Name = "btnAddAgreement";
            btnAddAgreement.Size = new Size(114, 37);
            btnAddAgreement.TabIndex = 2;
            btnAddAgreement.Text = "New Agreement";
            btnAddAgreement.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(94, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(613, 295);
            dataGridView1.TabIndex = 4;
            // 
            // AgreementsListView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnBackToAdminView);
            Controls.Add(btnAddAgreement);
            Name = "AgreementsListView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgreementsListView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBackToAdminView;
        private Button btnAddAgreement;
        private DataGridView dataGridView1;
    }
}