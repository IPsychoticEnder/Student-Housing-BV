namespace Student_Housing_BV.UserControls.Components
{
    partial class DisplayTaskComponent
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
            panel1 = new Panel();
            lblDisplayTaskName = new Label();
            panel2 = new Panel();
            lblDisplayTaskDescription = new Label();
            panel3 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDisplayTaskName);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 60);
            panel1.TabIndex = 0;
            // 
            // lblDisplayTaskName
            // 
            lblDisplayTaskName.AutoSize = true;
            lblDisplayTaskName.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDisplayTaskName.ForeColor = Color.White;
            lblDisplayTaskName.Location = new Point(30, 16);
            lblDisplayTaskName.Name = "lblDisplayTaskName";
            lblDisplayTaskName.Size = new Size(140, 28);
            lblDisplayTaskName.TabIndex = 1;
            lblDisplayTaskName.Text = "TaskName";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblDisplayTaskDescription);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(293, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(367, 60);
            panel2.TabIndex = 1;
            // 
            // lblDisplayTaskDescription
            // 
            lblDisplayTaskDescription.AutoSize = true;
            lblDisplayTaskDescription.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDisplayTaskDescription.ForeColor = Color.White;
            lblDisplayTaskDescription.Location = new Point(0, 0);
            lblDisplayTaskDescription.Name = "lblDisplayTaskDescription";
            lblDisplayTaskDescription.Size = new Size(105, 16);
            lblDisplayTaskDescription.TabIndex = 1;
            lblDisplayTaskDescription.Text = "TaskDescription";
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(660, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(190, 60);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(190, 60);
            button1.TabIndex = 0;
            button1.Text = "Complete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DisplayTaskComponent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DisplayTaskComponent";
            Size = new Size(850, 60);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDisplayTaskName;
        private Panel panel2;
        private Label lblDisplayTaskDescription;
        private Panel panel3;
        private Button button1;
    }
}
