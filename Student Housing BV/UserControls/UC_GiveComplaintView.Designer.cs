namespace Student_Housing_BV.UserControls
{
    partial class UC_GiveComplaintView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbComplaintDescription = new TextBox();
            label1 = new Label();
            cbbDisplayAllUsers = new ComboBox();
            label2 = new Label();
            btnPlaceComplaint = new Button();
            btnConfirmComplaint = new Button();
            lbDisplayAfterButton = new Label();
            lbDisplayComplaintInfo = new Label();
            panelDisplayComplaint = new Panel();
            panelDisplayComplaint.SuspendLayout();
            SuspendLayout();
            // 
            // tbComplaintDescription
            // 
            tbComplaintDescription.BorderStyle = BorderStyle.None;
            tbComplaintDescription.Location = new Point(26, 61);
            tbComplaintDescription.Multiline = true;
            tbComplaintDescription.Name = "tbComplaintDescription";
            tbComplaintDescription.Size = new Size(308, 247);
            tbComplaintDescription.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 39);
            label1.Name = "label1";
            label1.Size = new Size(237, 19);
            label1.TabIndex = 1;
            label1.Text = "Please describe the complaint";
            // 
            // cbbDisplayAllUsers
            // 
            cbbDisplayAllUsers.FormattingEnabled = true;
            cbbDisplayAllUsers.Location = new Point(26, 362);
            cbbDisplayAllUsers.Name = "cbbDisplayAllUsers";
            cbbDisplayAllUsers.Size = new Size(145, 23);
            cbbDisplayAllUsers.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 340);
            label2.Name = "label2";
            label2.Size = new Size(222, 19);
            label2.TabIndex = 3;
            label2.Text = "Who are you complaining to\r\n";
            // 
            // btnPlaceComplaint
            // 
            btnPlaceComplaint.BackColor = Color.FromArgb(255, 255, 192);
            btnPlaceComplaint.Cursor = Cursors.Hand;
            btnPlaceComplaint.FlatStyle = FlatStyle.Flat;
            btnPlaceComplaint.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlaceComplaint.Location = new Point(193, 362);
            btnPlaceComplaint.Name = "btnPlaceComplaint";
            btnPlaceComplaint.Size = new Size(141, 23);
            btnPlaceComplaint.TabIndex = 4;
            btnPlaceComplaint.Text = "Place complaint";
            btnPlaceComplaint.UseVisualStyleBackColor = false;
            btnPlaceComplaint.Click += btnPlaceComplaint_Click;
            // 
            // btnConfirmComplaint
            // 
            btnConfirmComplaint.BackColor = Color.FromArgb(255, 192, 192);
            btnConfirmComplaint.Cursor = Cursors.Hand;
            btnConfirmComplaint.FlatStyle = FlatStyle.Flat;
            btnConfirmComplaint.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmComplaint.Location = new Point(502, 343);
            btnConfirmComplaint.Name = "btnConfirmComplaint";
            btnConfirmComplaint.Size = new Size(203, 59);
            btnConfirmComplaint.TabIndex = 6;
            btnConfirmComplaint.Text = "Confirm Complaint";
            btnConfirmComplaint.UseVisualStyleBackColor = false;
            btnConfirmComplaint.Click += btnConfirmComplaint_Click;
            // 
            // lbDisplayAfterButton
            // 
            lbDisplayAfterButton.AutoSize = true;
            lbDisplayAfterButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDisplayAfterButton.ForeColor = Color.White;
            lbDisplayAfterButton.Location = new Point(391, 39);
            lbDisplayAfterButton.Name = "lbDisplayAfterButton";
            lbDisplayAfterButton.Size = new Size(241, 19);
            lbDisplayAfterButton.TabIndex = 7;
            lbDisplayAfterButton.Text = "Please confirm the information";
            // 
            // lbDisplayComplaintInfo
            // 
            lbDisplayComplaintInfo.AutoSize = true;
            lbDisplayComplaintInfo.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbDisplayComplaintInfo.Location = new Point(3, 0);
            lbDisplayComplaintInfo.Name = "lbDisplayComplaintInfo";
            lbDisplayComplaintInfo.Size = new Size(41, 16);
            lbDisplayComplaintInfo.TabIndex = 8;
            lbDisplayComplaintInfo.Text = "label3";
            // 
            // panelDisplayComplaint
            // 
            panelDisplayComplaint.BackColor = Color.Silver;
            panelDisplayComplaint.Controls.Add(lbDisplayComplaintInfo);
            panelDisplayComplaint.Location = new Point(391, 61);
            panelDisplayComplaint.Name = "panelDisplayComplaint";
            panelDisplayComplaint.Size = new Size(419, 247);
            panelDisplayComplaint.TabIndex = 9;
            // 
            // UC_GiveComplaintView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelDisplayComplaint);
            Controls.Add(lbDisplayAfterButton);
            Controls.Add(btnConfirmComplaint);
            Controls.Add(btnPlaceComplaint);
            Controls.Add(label2);
            Controls.Add(cbbDisplayAllUsers);
            Controls.Add(label1);
            Controls.Add(tbComplaintDescription);
            Name = "UC_GiveComplaintView";
            Size = new Size(860, 436);
            panelDisplayComplaint.ResumeLayout(false);
            panelDisplayComplaint.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbComplaintDescription;
        private Label label1;
        private ComboBox cbbDisplayAllUsers;
        private Label label2;
        private Button btnPlaceComplaint;
        private Button btnConfirmComplaint;
        private Label lbDisplayAfterButton;
        private Label lbDisplayComplaintInfo;
        private Panel panelDisplayComplaint;
    }
}
