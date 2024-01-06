namespace Student_Housing_BV.Forms.AdminView.AdminViewAgreements
{
    partial class EditAgreementView
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
            tbAgreementDescription = new TextBox();
            tbAgreementTitle = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnDeleteAgreement = new Button();
            btnSaveAgreement = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(224, 224, 224);
            groupBox1.Controls.Add(tbAgreementDescription);
            groupBox1.Controls.Add(tbAgreementTitle);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnDeleteAgreement);
            groupBox1.Controls.Add(btnSaveAgreement);
            groupBox1.Location = new Point(109, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 320);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Edit agreement";
            // 
            // tbAgreementDescription
            // 
            tbAgreementDescription.Location = new Point(252, 105);
            tbAgreementDescription.Multiline = true;
            tbAgreementDescription.Name = "tbAgreementDescription";
            tbAgreementDescription.Size = new Size(182, 123);
            tbAgreementDescription.TabIndex = 15;
            // 
            // tbAgreementTitle
            // 
            tbAgreementTitle.Location = new Point(252, 58);
            tbAgreementTitle.Name = "tbAgreementTitle";
            tbAgreementTitle.Size = new Size(182, 23);
            tbAgreementTitle.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 109);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 13;
            label2.Text = "Description:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 62);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 12;
            label1.Text = "Title:";
            // 
            // btnDeleteAgreement
            // 
            btnDeleteAgreement.BackColor = Color.FromArgb(255, 192, 192);
            btnDeleteAgreement.Location = new Point(58, 254);
            btnDeleteAgreement.Margin = new Padding(2, 1, 2, 1);
            btnDeleteAgreement.Name = "btnDeleteAgreement";
            btnDeleteAgreement.Size = new Size(145, 29);
            btnDeleteAgreement.TabIndex = 11;
            btnDeleteAgreement.Text = "Delete";
            btnDeleteAgreement.UseVisualStyleBackColor = false;
            btnDeleteAgreement.Click += btnDeleteAgreement_Click;
            // 
            // btnSaveAgreement
            // 
            btnSaveAgreement.BackColor = Color.FromArgb(192, 255, 192);
            btnSaveAgreement.Location = new Point(319, 254);
            btnSaveAgreement.Margin = new Padding(2, 1, 2, 1);
            btnSaveAgreement.Name = "btnSaveAgreement";
            btnSaveAgreement.Size = new Size(145, 29);
            btnSaveAgreement.TabIndex = 10;
            btnSaveAgreement.Text = "Save Agreement";
            btnSaveAgreement.UseVisualStyleBackColor = false;
            btnSaveAgreement.Click += btnSaveAgreement_Click;
            // 
            // EditAgreementView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(740, 435);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "EditAgreementView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditAgreementView";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbAgreementDescription;
        private TextBox tbAgreementTitle;
        private Label label2;
        private Label label1;
        private Button btnDeleteAgreement;
        private Button btnSaveAgreement;
    }
}