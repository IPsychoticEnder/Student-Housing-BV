namespace Student_Housing_BV
{
    partial class AdminViewMainPage
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
            btnViewUsers = new Button();
            btnViewTasks = new Button();
            btnViewAgreements = new Button();
            button4 = new Button();
            lbWelcomeUser = new Label();
            btnLogOut = new Button();
            SuspendLayout();
            // 
            // btnViewUsers
            // 
            btnViewUsers.Location = new Point(93, 85);
            btnViewUsers.Margin = new Padding(2, 1, 2, 1);
            btnViewUsers.Name = "btnViewUsers";
            btnViewUsers.Size = new Size(233, 114);
            btnViewUsers.TabIndex = 0;
            btnViewUsers.Text = "Users";
            btnViewUsers.UseVisualStyleBackColor = true;
            btnViewUsers.Click += btnViewUsers_Click;
            // 
            // btnViewTasks
            // 
            btnViewTasks.Location = new Point(417, 85);
            btnViewTasks.Margin = new Padding(2, 1, 2, 1);
            btnViewTasks.Name = "btnViewTasks";
            btnViewTasks.Size = new Size(233, 114);
            btnViewTasks.TabIndex = 1;
            btnViewTasks.Text = "Tasks";
            btnViewTasks.UseVisualStyleBackColor = true;
            btnViewTasks.Click += btnViewTasks_Click;
            // 
            // btnViewAgreements
            // 
            btnViewAgreements.Location = new Point(93, 269);
            btnViewAgreements.Margin = new Padding(2, 1, 2, 1);
            btnViewAgreements.Name = "btnViewAgreements";
            btnViewAgreements.Size = new Size(233, 114);
            btnViewAgreements.TabIndex = 2;
            btnViewAgreements.Text = "Agreements";
            btnViewAgreements.UseVisualStyleBackColor = true;
            btnViewAgreements.Click += btnViewAgreements_Click;
            // 
            // button4
            // 
            button4.Location = new Point(417, 269);
            button4.Margin = new Padding(2, 1, 2, 1);
            button4.Name = "button4";
            button4.Size = new Size(233, 114);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // lbWelcomeUser
            // 
            lbWelcomeUser.Anchor = AnchorStyles.None;
            lbWelcomeUser.AutoSize = true;
            lbWelcomeUser.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            lbWelcomeUser.ForeColor = Color.White;
            lbWelcomeUser.Location = new Point(269, 28);
            lbWelcomeUser.Margin = new Padding(2, 0, 2, 0);
            lbWelcomeUser.Name = "lbWelcomeUser";
            lbWelcomeUser.Size = new Size(0, 37);
            lbWelcomeUser.TabIndex = 4;
            lbWelcomeUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(13, 13);
            btnLogOut.Margin = new Padding(2, 1, 2, 1);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(63, 25);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "Logout";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // AdminViewMainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(740, 435);
            Controls.Add(btnLogOut);
            Controls.Add(lbWelcomeUser);
            Controls.Add(button4);
            Controls.Add(btnViewAgreements);
            Controls.Add(btnViewTasks);
            Controls.Add(btnViewUsers);
            Name = "AdminViewMainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnViewUsers;
        private Button btnViewTasks;
        private Button btnViewAgreements;
        private Button button4;
        private Label lbWelcomeUser;
        private Button btnLogOut;
    }
}