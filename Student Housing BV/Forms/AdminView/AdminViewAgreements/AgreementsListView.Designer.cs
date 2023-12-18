namespace Student_Housing_BV.Forms.AdminView.AdminViewAgreements
{
    partial class AgreementsListView
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
            components = new System.ComponentModel.Container();
            btnBackToAdminView = new Button();
            btnAddAgreement = new Button();
            agreementBindingSource = new BindingSource(components);
            dataGridDisplayAllAgreements = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)agreementBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDisplayAllAgreements).BeginInit();
            SuspendLayout();
            // 
            // btnBackToAdminView
            // 
            btnBackToAdminView.Location = new Point(102, 51);
            btnBackToAdminView.Margin = new Padding(2, 1, 2, 1);
            btnBackToAdminView.Name = "btnBackToAdminView";
            btnBackToAdminView.Size = new Size(81, 37);
            btnBackToAdminView.TabIndex = 3;
            btnBackToAdminView.Text = "Back";
            btnBackToAdminView.UseVisualStyleBackColor = true;
            btnBackToAdminView.Click += btnBackToAdminView_Click;
            // 
            // btnAddAgreement
            // 
            btnAddAgreement.Location = new Point(521, 51);
            btnAddAgreement.Margin = new Padding(2, 1, 2, 1);
            btnAddAgreement.Name = "btnAddAgreement";
            btnAddAgreement.Size = new Size(114, 37);
            btnAddAgreement.TabIndex = 2;
            btnAddAgreement.Text = "New Agreement";
            btnAddAgreement.UseVisualStyleBackColor = true;
            btnAddAgreement.Click += btnAddAgreement_Click;
            // 
            // agreementBindingSource
            // 
            agreementBindingSource.DataSource = typeof(Classes.Agreement);
            // 
            // dataGridDisplayAllAgreements
            // 
            dataGridDisplayAllAgreements.AllowUserToResizeColumns = false;
            dataGridDisplayAllAgreements.AllowUserToResizeRows = false;
            dataGridDisplayAllAgreements.AutoGenerateColumns = false;
            dataGridDisplayAllAgreements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDisplayAllAgreements.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridDisplayAllAgreements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDisplayAllAgreements.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            dataGridDisplayAllAgreements.DataSource = agreementBindingSource;
            dataGridDisplayAllAgreements.Location = new Point(77, 113);
            dataGridDisplayAllAgreements.Margin = new Padding(2, 1, 2, 1);
            dataGridDisplayAllAgreements.MultiSelect = false;
            dataGridDisplayAllAgreements.Name = "dataGridDisplayAllAgreements";
            dataGridDisplayAllAgreements.ReadOnly = true;
            dataGridDisplayAllAgreements.RowHeadersWidth = 82;
            dataGridDisplayAllAgreements.RowTemplate.Height = 41;
            dataGridDisplayAllAgreements.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDisplayAllAgreements.Size = new Size(582, 297);
            dataGridDisplayAllAgreements.TabIndex = 4;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.FillWeight = 25F;
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.FillWeight = 50F;
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AgreementsListView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(740, 435);
            Controls.Add(dataGridDisplayAllAgreements);
            Controls.Add(btnBackToAdminView);
            Controls.Add(btnAddAgreement);
            Name = "AgreementsListView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgreementsListView";
            ((System.ComponentModel.ISupportInitialize)agreementBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDisplayAllAgreements).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBackToAdminView;
        private Button btnAddAgreement;
        private BindingSource agreementBindingSource;
        private DataGridView dataGridDisplayAllAgreements;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}