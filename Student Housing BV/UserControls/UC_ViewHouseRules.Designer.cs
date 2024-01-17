namespace Student_Housing_BV.UserControls
{
    partial class UC_ViewHouseRules
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
            flowpanelDisplayHouseRules = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowpanelDisplayHouseRules
            // 
            flowpanelDisplayHouseRules.AutoScroll = true;
            flowpanelDisplayHouseRules.Dock = DockStyle.Fill;
            flowpanelDisplayHouseRules.Location = new Point(0, 0);
            flowpanelDisplayHouseRules.Name = "flowpanelDisplayHouseRules";
            flowpanelDisplayHouseRules.Size = new Size(860, 436);
            flowpanelDisplayHouseRules.TabIndex = 0;
            // 
            // UC_ViewHouseRules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowpanelDisplayHouseRules);
            Name = "UC_ViewHouseRules";
            Size = new Size(860, 436);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowpanelDisplayHouseRules;
    }
}
