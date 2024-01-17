namespace Student_Housing_BV.UserControls.Components
{
    partial class DisplayHouseRulesComponent
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
            tbDisplayRuleTitle = new TextBox();
            tbDisplayRuleDescription = new TextBox();
            SuspendLayout();
            // 
            // tbDisplayRuleTitle
            // 
            tbDisplayRuleTitle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbDisplayRuleTitle.Location = new Point(0, 0);
            tbDisplayRuleTitle.Multiline = true;
            tbDisplayRuleTitle.Name = "tbDisplayRuleTitle";
            tbDisplayRuleTitle.Size = new Size(216, 101);
            tbDisplayRuleTitle.TabIndex = 0;
            // 
            // tbDisplayRuleDescription
            // 
            tbDisplayRuleDescription.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbDisplayRuleDescription.Location = new Point(222, 0);
            tbDisplayRuleDescription.Multiline = true;
            tbDisplayRuleDescription.Name = "tbDisplayRuleDescription";
            tbDisplayRuleDescription.Size = new Size(626, 101);
            tbDisplayRuleDescription.TabIndex = 1;
            // 
            // DisplayHouseRulesComponent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbDisplayRuleDescription);
            Controls.Add(tbDisplayRuleTitle);
            Name = "DisplayHouseRulesComponent";
            Size = new Size(848, 101);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDisplayRuleTitle;
        private TextBox tbDisplayRuleDescription;
    }
}
