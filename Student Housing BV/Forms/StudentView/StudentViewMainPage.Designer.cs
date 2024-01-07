namespace Student_Housing_BV
{
    partial class StudentViewMainPage
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
            panel1 = new Panel();
            btnLogOut = new Button();
            btnExitProgram = new Button();
            lblDisplayStudentName = new Label();
            lblTitleOfProduct = new Label();
            panel2 = new Panel();
            btnRouteToSunday = new Button();
            btnRouteToSaturday = new Button();
            btnRouteToFriday = new Button();
            btnRouteToThursday = new Button();
            btnRouteToWednesday = new Button();
            btnRouteToTuesday = new Button();
            btnRouteToMonday = new Button();
            PanelMainContent = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 41, 78);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(btnExitProgram);
            panel1.Controls.Add(lblDisplayStudentName);
            panel1.Controls.Add(lblTitleOfProduct);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 59);
            panel1.TabIndex = 2;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(224, 224, 224);
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.ForeColor = Color.Black;
            btnLogOut.Location = new Point(723, 17);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(69, 24);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnExitProgram
            // 
            btnExitProgram.BackColor = Color.Red;
            btnExitProgram.Cursor = Cursors.Hand;
            btnExitProgram.FlatStyle = FlatStyle.Flat;
            btnExitProgram.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnExitProgram.ForeColor = Color.White;
            btnExitProgram.Location = new Point(798, 17);
            btnExitProgram.Name = "btnExitProgram";
            btnExitProgram.Size = new Size(50, 24);
            btnExitProgram.TabIndex = 4;
            btnExitProgram.Text = "Close";
            btnExitProgram.UseVisualStyleBackColor = false;
            btnExitProgram.Click += btnExitProgram_Click;
            // 
            // lblDisplayStudentName
            // 
            lblDisplayStudentName.AutoSize = true;
            lblDisplayStudentName.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDisplayStudentName.ForeColor = Color.White;
            lblDisplayStudentName.Location = new Point(580, 15);
            lblDisplayStudentName.Name = "lblDisplayStudentName";
            lblDisplayStudentName.Size = new Size(0, 28);
            lblDisplayStudentName.TabIndex = 3;
            // 
            // lblTitleOfProduct
            // 
            lblTitleOfProduct.AutoSize = true;
            lblTitleOfProduct.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleOfProduct.ForeColor = Color.White;
            lblTitleOfProduct.Location = new Point(12, 15);
            lblTitleOfProduct.Name = "lblTitleOfProduct";
            lblTitleOfProduct.Size = new Size(277, 28);
            lblTitleOfProduct.TabIndex = 3;
            lblTitleOfProduct.Text = "Student Housing B.V.";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnRouteToSunday);
            panel2.Controls.Add(btnRouteToSaturday);
            panel2.Controls.Add(btnRouteToFriday);
            panel2.Controls.Add(btnRouteToThursday);
            panel2.Controls.Add(btnRouteToWednesday);
            panel2.Controls.Add(btnRouteToTuesday);
            panel2.Controls.Add(btnRouteToMonday);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(860, 44);
            panel2.TabIndex = 3;
            // 
            // btnRouteToSunday
            // 
            btnRouteToSunday.BackColor = Color.FromArgb(188, 212, 222);
            btnRouteToSunday.Cursor = Cursors.Hand;
            btnRouteToSunday.Dock = DockStyle.Left;
            btnRouteToSunday.FlatStyle = FlatStyle.Flat;
            btnRouteToSunday.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRouteToSunday.Location = new Point(738, 0);
            btnRouteToSunday.Name = "btnRouteToSunday";
            btnRouteToSunday.Size = new Size(123, 44);
            btnRouteToSunday.TabIndex = 6;
            btnRouteToSunday.Text = "Sunday";
            btnRouteToSunday.UseVisualStyleBackColor = false;
            btnRouteToSunday.Click += btnRouteToSunday_Click;
            // 
            // btnRouteToSaturday
            // 
            btnRouteToSaturday.BackColor = Color.FromArgb(188, 212, 222);
            btnRouteToSaturday.Cursor = Cursors.Hand;
            btnRouteToSaturday.Dock = DockStyle.Left;
            btnRouteToSaturday.FlatStyle = FlatStyle.Flat;
            btnRouteToSaturday.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRouteToSaturday.Location = new Point(615, 0);
            btnRouteToSaturday.Name = "btnRouteToSaturday";
            btnRouteToSaturday.Size = new Size(123, 44);
            btnRouteToSaturday.TabIndex = 5;
            btnRouteToSaturday.Text = "Saturday";
            btnRouteToSaturday.UseVisualStyleBackColor = false;
            btnRouteToSaturday.Click += btnRouteToSaturday_Click;
            // 
            // btnRouteToFriday
            // 
            btnRouteToFriday.BackColor = Color.FromArgb(188, 212, 222);
            btnRouteToFriday.Cursor = Cursors.Hand;
            btnRouteToFriday.Dock = DockStyle.Left;
            btnRouteToFriday.FlatStyle = FlatStyle.Flat;
            btnRouteToFriday.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRouteToFriday.Location = new Point(492, 0);
            btnRouteToFriday.Name = "btnRouteToFriday";
            btnRouteToFriday.Size = new Size(123, 44);
            btnRouteToFriday.TabIndex = 4;
            btnRouteToFriday.Text = "Friday";
            btnRouteToFriday.UseVisualStyleBackColor = false;
            btnRouteToFriday.Click += btnRouteToFriday_Click;
            // 
            // btnRouteToThursday
            // 
            btnRouteToThursday.BackColor = Color.FromArgb(188, 212, 222);
            btnRouteToThursday.Cursor = Cursors.Hand;
            btnRouteToThursday.Dock = DockStyle.Left;
            btnRouteToThursday.FlatStyle = FlatStyle.Flat;
            btnRouteToThursday.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRouteToThursday.Location = new Point(369, 0);
            btnRouteToThursday.Name = "btnRouteToThursday";
            btnRouteToThursday.Size = new Size(123, 44);
            btnRouteToThursday.TabIndex = 3;
            btnRouteToThursday.Text = "Thursday";
            btnRouteToThursday.UseVisualStyleBackColor = false;
            btnRouteToThursday.Click += btnRouteToThursday_Click;
            // 
            // btnRouteToWednesday
            // 
            btnRouteToWednesday.BackColor = Color.FromArgb(188, 212, 222);
            btnRouteToWednesday.Cursor = Cursors.Hand;
            btnRouteToWednesday.Dock = DockStyle.Left;
            btnRouteToWednesday.FlatStyle = FlatStyle.Flat;
            btnRouteToWednesday.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRouteToWednesday.Location = new Point(246, 0);
            btnRouteToWednesday.Name = "btnRouteToWednesday";
            btnRouteToWednesday.Size = new Size(123, 44);
            btnRouteToWednesday.TabIndex = 2;
            btnRouteToWednesday.Text = "Wednesday";
            btnRouteToWednesday.UseVisualStyleBackColor = false;
            btnRouteToWednesday.Click += btnRouteToWednesday_Click;
            // 
            // btnRouteToTuesday
            // 
            btnRouteToTuesday.BackColor = Color.FromArgb(188, 212, 222);
            btnRouteToTuesday.Cursor = Cursors.Hand;
            btnRouteToTuesday.Dock = DockStyle.Left;
            btnRouteToTuesday.FlatStyle = FlatStyle.Flat;
            btnRouteToTuesday.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRouteToTuesday.Location = new Point(123, 0);
            btnRouteToTuesday.Name = "btnRouteToTuesday";
            btnRouteToTuesday.Size = new Size(123, 44);
            btnRouteToTuesday.TabIndex = 1;
            btnRouteToTuesday.Text = "Tuesday";
            btnRouteToTuesday.UseVisualStyleBackColor = false;
            btnRouteToTuesday.Click += btnRouteToTuesday_Click;
            // 
            // btnRouteToMonday
            // 
            btnRouteToMonday.BackColor = Color.FromArgb(188, 212, 222);
            btnRouteToMonday.Cursor = Cursors.Hand;
            btnRouteToMonday.Dock = DockStyle.Left;
            btnRouteToMonday.FlatStyle = FlatStyle.Flat;
            btnRouteToMonday.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRouteToMonday.Location = new Point(0, 0);
            btnRouteToMonday.Name = "btnRouteToMonday";
            btnRouteToMonday.Size = new Size(123, 44);
            btnRouteToMonday.TabIndex = 0;
            btnRouteToMonday.Text = "Monday";
            btnRouteToMonday.UseVisualStyleBackColor = false;
            btnRouteToMonday.Click += btnRouteToMonday_Click;
            // 
            // PanelMainContent
            // 
            PanelMainContent.Dock = DockStyle.Fill;
            PanelMainContent.Location = new Point(0, 103);
            PanelMainContent.Name = "PanelMainContent";
            PanelMainContent.Size = new Size(860, 429);
            PanelMainContent.TabIndex = 4;
            // 
            // StudentViewMainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(75, 82, 103);
            ClientSize = new Size(860, 532);
            Controls.Add(PanelMainContent);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentViewMainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label lblTitleOfProduct;
        private Label lblDisplayStudentName;
        private Panel panel2;
        private Panel PanelMainContent;
        private Button btnRouteToMonday;
        private Button btnRouteToSunday;
        private Button btnRouteToSaturday;
        private Button btnRouteToFriday;
        private Button btnRouteToThursday;
        private Button btnRouteToWednesday;
        private Button btnRouteToTuesday;
        private Button btnExitProgram;
        private Button btnLogOut;
    }
}