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
            groupBox1.Location = new Point(202, 123);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(971, 683);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Edit agreement";
            // 
            // tbAgreementDescription
            // 
            tbAgreementDescription.Location = new Point(468, 224);
            tbAgreementDescription.Margin = new Padding(6);
            tbAgreementDescription.Multiline = true;
            tbAgreementDescription.Name = "tbAgreementDescription";
            tbAgreementDescription.Size = new Size(335, 258);
            tbAgreementDescription.TabIndex = 15;
            // 
            // tbAgreementTitle
            // 
            tbAgreementTitle.Location = new Point(468, 124);
            tbAgreementTitle.Margin = new Padding(6);
            tbAgreementTitle.Name = "tbAgreementTitle";
            tbAgreementTitle.Size = new Size(335, 39);
            tbAgreementTitle.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 233);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 32);
            label2.TabIndex = 13;
            label2.Text = "Description:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 133);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 32);
            label1.TabIndex = 12;
            label1.Text = "Title:";
            // 
            // btnDeleteAgreement
            // 
            btnDeleteAgreement.BackColor = Color.FromArgb(255, 192, 192);
            btnDeleteAgreement.Location = new Point(108, 542);
            btnDeleteAgreement.Margin = new Padding(4, 2, 4, 2);
            btnDeleteAgreement.Name = "btnDeleteAgreement";
            btnDeleteAgreement.Size = new Size(269, 62);
            btnDeleteAgreement.TabIndex = 11;
            btnDeleteAgreement.Text = "Delete";
            btnDeleteAgreement.UseVisualStyleBackColor = false;
            btnDeleteAgreement.Click += btnDeleteAgreement_Click;
            // 
            // btnSaveAgreement
            // 
            btnSaveAgreement.BackColor = Color.FromArgb(192, 255, 192);
            btnSaveAgreement.Location = new Point(592, 542);
            btnSaveAgreement.Margin = new Padding(4, 2, 4, 2);
            btnSaveAgreement.Name = "btnSaveAgreement";
            btnSaveAgreement.Size = new Size(269, 62);
            btnSaveAgreement.TabIndex = 10;
            btnSaveAgreement.Text = "Save Agreement";
            btnSaveAgreement.UseVisualStyleBackColor = false;
            btnSaveAgreement.Click += btnSaveAgreement_Click;
            // 
            // EditAgreementView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1374, 929);
            Controls.Add(groupBox1);
            Name = "EditAgreementView";
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