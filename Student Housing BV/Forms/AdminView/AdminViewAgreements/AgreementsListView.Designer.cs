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
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            agreementBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridDisplayAllAgreements).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agreementBindingSource).BeginInit();
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
            btnAddAgreement.Text = "New Houserule";
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
            dataGridDisplayAllAgreements.Columns.AddRange(new DataGridViewColumn[] { titleDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            dataGridDisplayAllAgreements.DataSource = agreementBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridDisplayAllAgreements.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridDisplayAllAgreements.Location = new Point(77, 113);
            dataGridDisplayAllAgreements.Margin = new Padding(2, 1, 2, 1);
            dataGridDisplayAllAgreements.MultiSelect = false;
            dataGridDisplayAllAgreements.Name = "dataGridDisplayAllAgreements";
            dataGridDisplayAllAgreements.ReadOnly = true;
            dataGridDisplayAllAgreements.RowHeadersWidth = 82;
            dataGridViewCellStyle2.Padding = new Padding(0, 5, 0, 5);
            dataGridDisplayAllAgreements.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridDisplayAllAgreements.RowTemplate.Height = 41;
            dataGridDisplayAllAgreements.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDisplayAllAgreements.Size = new Size(582, 297);
            dataGridDisplayAllAgreements.TabIndex = 4;
            dataGridDisplayAllAgreements.CellDoubleClick += dataGridDisplayAllAgreements_CellDoubleClick;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.FillWeight = 30F;
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // agreementBindingSource
            // 
            agreementBindingSource.DataSource = typeof(Agreement);
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
            Text = "HouseruleListView";
            ((System.ComponentModel.ISupportInitialize)dataGridDisplayAllAgreements).EndInit();
            ((System.ComponentModel.ISupportInitialize)agreementBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBackToAdminView;
        private Button btnAddAgreement;
        private DataGridView dataGridDisplayAllAgreements;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private BindingSource agreementBindingSource;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}