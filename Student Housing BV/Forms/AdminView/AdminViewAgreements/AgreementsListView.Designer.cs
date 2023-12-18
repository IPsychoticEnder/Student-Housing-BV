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
            dataGridDisplayAllAgreements = new DataGridView();
            agreementBindingSource = new BindingSource(components);
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridDisplayAllAgreements).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agreementBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnBackToAdminView
            // 
            btnBackToAdminView.Location = new Point(189, 109);
            btnBackToAdminView.Margin = new Padding(4, 2, 4, 2);
            btnBackToAdminView.Name = "btnBackToAdminView";
            btnBackToAdminView.Size = new Size(150, 79);
            btnBackToAdminView.TabIndex = 3;
            btnBackToAdminView.Text = "Back";
            btnBackToAdminView.UseVisualStyleBackColor = true;
            btnBackToAdminView.Click += btnBackToAdminView_Click;
            // 
            // btnAddAgreement
            // 
            btnAddAgreement.Location = new Point(968, 109);
            btnAddAgreement.Margin = new Padding(4, 2, 4, 2);
            btnAddAgreement.Name = "btnAddAgreement";
            btnAddAgreement.Size = new Size(212, 79);
            btnAddAgreement.TabIndex = 2;
            btnAddAgreement.Text = "New Agreement";
            btnAddAgreement.UseVisualStyleBackColor = true;
            btnAddAgreement.Click += btnAddAgreement_Click;
            // 
            // dataGridDisplayAllAgreements
            // 
            dataGridDisplayAllAgreements.AllowUserToResizeColumns = false;
            dataGridDisplayAllAgreements.AllowUserToResizeRows = false;
            dataGridDisplayAllAgreements.AutoGenerateColumns = false;
            dataGridDisplayAllAgreements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDisplayAllAgreements.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridDisplayAllAgreements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDisplayAllAgreements.Columns.AddRange(new DataGridViewColumn[] { titleDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, iDDataGridViewTextBoxColumn });
            dataGridDisplayAllAgreements.DataSource = agreementBindingSource;
            dataGridDisplayAllAgreements.Location = new Point(143, 241);
            dataGridDisplayAllAgreements.Margin = new Padding(4, 2, 4, 2);
            dataGridDisplayAllAgreements.MultiSelect = false;
            dataGridDisplayAllAgreements.Name = "dataGridDisplayAllAgreements";
            dataGridDisplayAllAgreements.ReadOnly = true;
            dataGridDisplayAllAgreements.RowHeadersWidth = 82;
            dataGridDisplayAllAgreements.RowTemplate.Height = 41;
            dataGridDisplayAllAgreements.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDisplayAllAgreements.Size = new Size(1081, 634);
            dataGridDisplayAllAgreements.TabIndex = 4;
            // 
            // agreementBindingSource
            // 
            agreementBindingSource.DataSource = typeof(Classes.Agreement);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 10;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 10;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.MinimumWidth = 10;
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AgreementsListView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1374, 928);
            Controls.Add(dataGridDisplayAllAgreements);
            Controls.Add(btnBackToAdminView);
            Controls.Add(btnAddAgreement);
            Margin = new Padding(6, 6, 6, 6);
            Name = "AgreementsListView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgreementsListView";
            ((System.ComponentModel.ISupportInitialize)dataGridDisplayAllAgreements).EndInit();
            ((System.ComponentModel.ISupportInitialize)agreementBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBackToAdminView;
        private Button btnAddAgreement;
        private DataGridView dataGridDisplayAllAgreements;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private BindingSource agreementBindingSource;
    }
}