namespace Student_Housing_BV.Forms.AdminView.AdminViewAgreements
{
    partial class AddAgreementView
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
            tbNewAgreementDescription = new TextBox();
            tbNewAgreementTitle = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnBack = new Button();
            btnAddAgreement = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(224, 224, 224);
            groupBox1.Controls.Add(tbNewAgreementDescription);
            groupBox1.Controls.Add(tbNewAgreementTitle);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnBack);
            groupBox1.Controls.Add(btnAddAgreement);
            groupBox1.Location = new Point(104, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 320);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "New houserule";
            // 
            // tbNewAgreementDescription
            // 
            tbNewAgreementDescription.Location = new Point(252, 105);
            tbNewAgreementDescription.Multiline = true;
            tbNewAgreementDescription.Name = "tbNewAgreementDescription";
            tbNewAgreementDescription.Size = new Size(182, 123);
            tbNewAgreementDescription.TabIndex = 15;
            // 
            // tbNewAgreementTitle
            // 
            tbNewAgreementTitle.Location = new Point(252, 58);
            tbNewAgreementTitle.Name = "tbNewAgreementTitle";
            tbNewAgreementTitle.Size = new Size(182, 23);
            tbNewAgreementTitle.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 108);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 13;
            label2.Text = "Description:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 61);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 12;
            label1.Text = "Title:";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(58, 254);
            btnBack.Margin = new Padding(2, 1, 2, 1);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(145, 29);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnAddAgreement
            // 
            btnAddAgreement.Location = new Point(319, 254);
            btnAddAgreement.Margin = new Padding(2, 1, 2, 1);
            btnAddAgreement.Name = "btnAddAgreement";
            btnAddAgreement.Size = new Size(145, 29);
            btnAddAgreement.TabIndex = 10;
            btnAddAgreement.Text = "Add Houserule";
            btnAddAgreement.UseVisualStyleBackColor = true;
            btnAddAgreement.Click += btnAddAgreement_Click;
            // 
            // AddAgreementView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(740, 435);
            Controls.Add(groupBox1);
            Name = "AddAgreementView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddHouseruleView";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnBack;
        private Button btnAddAgreement;
        private TextBox tbNewAgreementDescription;
        private TextBox tbNewAgreementTitle;
        private Label label2;
        private Label label1;
    }
}