using Student_Housing_BV.Classes.Agreements;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnBackToAdminView = new Button();
            btnAddAgreement = new Button();
            dataGridDisplayAllAgreements = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            agreementBindingSource1 = new BindingSource(components);
            agreementBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridDisplayAllAgreements).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agreementBindingSource1).BeginInit();
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
            dataGridDisplayAllAgreements.AutoGenerateColumns = false;
            dataGridDisplayAllAgreements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDisplayAllAgreements.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridDisplayAllAgreements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDisplayAllAgreements.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            dataGridDisplayAllAgreements.DataSource = agreementBindingSource1;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridDisplayAllAgreements.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridDisplayAllAgreements.Location = new Point(143, 241);
            dataGridDisplayAllAgreements.Margin = new Padding(4, 2, 4, 2);
            dataGridDisplayAllAgreements.MultiSelect = false;
            dataGridDisplayAllAgreements.Name = "dataGridDisplayAllAgreements";
            dataGridDisplayAllAgreements.ReadOnly = true;
            dataGridDisplayAllAgreements.RowHeadersWidth = 82;
            dataGridViewCellStyle2.Padding = new Padding(0, 5, 0, 5);
            dataGridDisplayAllAgreements.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridDisplayAllAgreements.RowTemplate.Height = 41;
            dataGridDisplayAllAgreements.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDisplayAllAgreements.Size = new Size(1081, 634);
            dataGridDisplayAllAgreements.TabIndex = 4;
            dataGridDisplayAllAgreements.CellDoubleClick += dataGridDisplayAllAgreements_CellDoubleClick;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.FillWeight = 25F;
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.MinimumWidth = 10;
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.FillWeight = 50F;
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
            // agreementBindingSource1
            // 
            agreementBindingSource1.DataSource = typeof(Agreement);
            // 
            // agreementBindingSource
            // 
            agreementBindingSource.DataSource = typeof(Agreement);
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
            Margin = new Padding(6);
            Name = "AgreementsListView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgreementsListView";
            ((System.ComponentModel.ISupportInitialize)dataGridDisplayAllAgreements).EndInit();
            ((System.ComponentModel.ISupportInitialize)agreementBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)agreementBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBackToAdminView;
        private Button btnAddAgreement;
        private DataGridView dataGridDisplayAllAgreements;
        private BindingSource agreementBindingSource;
        private BindingSource agreementBindingSource1;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}