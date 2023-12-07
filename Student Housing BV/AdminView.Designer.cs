namespace Student_Housing_BV
{
    partial class AdminView
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
            SuspendLayout();
            // 
            // btnViewUsers
            // 
            btnViewUsers.Location = new Point(172, 225);
            btnViewUsers.Name = "btnViewUsers";
            btnViewUsers.Size = new Size(432, 243);
            btnViewUsers.TabIndex = 0;
            btnViewUsers.Text = "Users";
            btnViewUsers.UseVisualStyleBackColor = true;
            btnViewUsers.Click += btnViewUsers_Click;
            // 
            // btnViewTasks
            // 
            btnViewTasks.Location = new Point(807, 225);
            btnViewTasks.Name = "btnViewTasks";
            btnViewTasks.Size = new Size(432, 243);
            btnViewTasks.TabIndex = 1;
            btnViewTasks.Text = "Tasks";
            btnViewTasks.UseVisualStyleBackColor = true;
            // 
            // btnViewAgreements
            // 
            btnViewAgreements.Location = new Point(172, 616);
            btnViewAgreements.Name = "btnViewAgreements";
            btnViewAgreements.Size = new Size(432, 243);
            btnViewAgreements.TabIndex = 2;
            btnViewAgreements.Text = "Agreements";
            btnViewAgreements.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(807, 616);
            button4.Name = "button4";
            button4.Size = new Size(432, 243);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // AdminView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(button4);
            Controls.Add(btnViewAgreements);
            Controls.Add(btnViewTasks);
            Controls.Add(btnViewUsers);
            Margin = new Padding(6);
            Name = "AdminView";
            Text = "AdminView";
            ResumeLayout(false);
        }

        #endregion

        private Button btnViewUsers;
        private Button btnViewTasks;
        private Button btnViewAgreements;
        private Button button4;
    }
}