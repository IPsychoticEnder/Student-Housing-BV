namespace Student_Housing_BV.UserControls.Components
{
    partial class DisplayComplaintComponent
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
            lbDisplayDate = new Label();
            lbDisplayComplaint = new Label();
            SuspendLayout();
            // 
            // lbDisplayDate
            // 
            lbDisplayDate.AutoSize = true;
            lbDisplayDate.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbDisplayDate.ForeColor = Color.White;
            lbDisplayDate.Location = new Point(14, 11);
            lbDisplayDate.Name = "lbDisplayDate";
            lbDisplayDate.Size = new Size(59, 22);
            lbDisplayDate.TabIndex = 0;
            lbDisplayDate.Text = "Date:";
            // 
            // lbDisplayComplaint
            // 
            lbDisplayComplaint.AutoSize = true;
            lbDisplayComplaint.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbDisplayComplaint.ForeColor = Color.White;
            lbDisplayComplaint.Location = new Point(14, 50);
            lbDisplayComplaint.Name = "lbDisplayComplaint";
            lbDisplayComplaint.Size = new Size(108, 16);
            lbDisplayComplaint.TabIndex = 1;
            lbDisplayComplaint.Text = "DisplayComplaint";
            // 
            // DisplayComplaintComponent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(lbDisplayComplaint);
            Controls.Add(lbDisplayDate);
            Name = "DisplayComplaintComponent";
            Size = new Size(848, 134);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDisplayDate;
        private Label lbDisplayComplaint;
    }
}
