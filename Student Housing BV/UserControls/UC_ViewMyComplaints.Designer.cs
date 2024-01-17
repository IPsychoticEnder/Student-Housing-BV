namespace Student_Housing_BV.UserControls
{
    partial class UC_ViewMyComplaints
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
            FlowpanelDisplayComplaints = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // FlowpanelDisplayComplaints
            // 
            FlowpanelDisplayComplaints.AutoScroll = true;
            FlowpanelDisplayComplaints.Dock = DockStyle.Fill;
            FlowpanelDisplayComplaints.Location = new Point(0, 0);
            FlowpanelDisplayComplaints.Name = "FlowpanelDisplayComplaints";
            FlowpanelDisplayComplaints.Size = new Size(860, 436);
            FlowpanelDisplayComplaints.TabIndex = 0;
            // 
            // UC_ViewMyComplaints
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FlowpanelDisplayComplaints);
            Name = "UC_ViewMyComplaints";
            Size = new Size(860, 436);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel FlowpanelDisplayComplaints;
    }
}
