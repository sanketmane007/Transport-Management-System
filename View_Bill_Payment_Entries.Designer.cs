namespace Transport_mgmt
{
    partial class View_Bill_Payment_Entries
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.billNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOfCheckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfWithdrawnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transport_Mgmt_SystemDataSet13 = new Transport_mgmt.Transport_Mgmt_SystemDataSet13();
            this.CANCEL = new System.Windows.Forms.Button();
            this.bill_PaymentTableAdapter = new Transport_mgmt.Transport_Mgmt_SystemDataSet13TableAdapters.Bill_PaymentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billPaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billNoDataGridViewTextBoxColumn,
            this.partyIDDataGridViewTextBoxColumn,
            this.amountOfCheckDataGridViewTextBoxColumn,
            this.accountNoDataGridViewTextBoxColumn,
            this.checkNoDataGridViewTextBoxColumn,
            this.dateOfWithdrawnDataGridViewTextBoxColumn,
            this.bankNameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.billPaymentBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(30, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(688, 238);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // billNoDataGridViewTextBoxColumn
            // 
            this.billNoDataGridViewTextBoxColumn.DataPropertyName = "Bill_No";
            this.billNoDataGridViewTextBoxColumn.HeaderText = "Bill_No";
            this.billNoDataGridViewTextBoxColumn.Name = "billNoDataGridViewTextBoxColumn";
            this.billNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partyIDDataGridViewTextBoxColumn
            // 
            this.partyIDDataGridViewTextBoxColumn.DataPropertyName = "Party_ID";
            this.partyIDDataGridViewTextBoxColumn.HeaderText = "Party_ID";
            this.partyIDDataGridViewTextBoxColumn.Name = "partyIDDataGridViewTextBoxColumn";
            this.partyIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountOfCheckDataGridViewTextBoxColumn
            // 
            this.amountOfCheckDataGridViewTextBoxColumn.DataPropertyName = "Amount_Of_Check";
            this.amountOfCheckDataGridViewTextBoxColumn.HeaderText = "Amount_Of_Check";
            this.amountOfCheckDataGridViewTextBoxColumn.Name = "amountOfCheckDataGridViewTextBoxColumn";
            this.amountOfCheckDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountNoDataGridViewTextBoxColumn
            // 
            this.accountNoDataGridViewTextBoxColumn.DataPropertyName = "Account_No";
            this.accountNoDataGridViewTextBoxColumn.HeaderText = "Account_No";
            this.accountNoDataGridViewTextBoxColumn.Name = "accountNoDataGridViewTextBoxColumn";
            this.accountNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkNoDataGridViewTextBoxColumn
            // 
            this.checkNoDataGridViewTextBoxColumn.DataPropertyName = "Check_No";
            this.checkNoDataGridViewTextBoxColumn.HeaderText = "Check_No";
            this.checkNoDataGridViewTextBoxColumn.Name = "checkNoDataGridViewTextBoxColumn";
            this.checkNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfWithdrawnDataGridViewTextBoxColumn
            // 
            this.dateOfWithdrawnDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Withdrawn";
            this.dateOfWithdrawnDataGridViewTextBoxColumn.HeaderText = "Date_Of_Withdrawn";
            this.dateOfWithdrawnDataGridViewTextBoxColumn.Name = "dateOfWithdrawnDataGridViewTextBoxColumn";
            this.dateOfWithdrawnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bankNameDataGridViewTextBoxColumn
            // 
            this.bankNameDataGridViewTextBoxColumn.DataPropertyName = "Bank_Name";
            this.bankNameDataGridViewTextBoxColumn.HeaderText = "Bank_Name";
            this.bankNameDataGridViewTextBoxColumn.Name = "bankNameDataGridViewTextBoxColumn";
            this.bankNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billPaymentBindingSource
            // 
            this.billPaymentBindingSource.DataMember = "Bill_Payment";
            this.billPaymentBindingSource.DataSource = this.transport_Mgmt_SystemDataSet13;
            // 
            // transport_Mgmt_SystemDataSet13
            // 
            this.transport_Mgmt_SystemDataSet13.DataSetName = "Transport_Mgmt_SystemDataSet13";
            this.transport_Mgmt_SystemDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CANCEL
            // 
            this.CANCEL.BackColor = System.Drawing.Color.Transparent;
            this.CANCEL.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCEL.ForeColor = System.Drawing.Color.Orange;
            this.CANCEL.Location = new System.Drawing.Point(290, 326);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(144, 36);
            this.CANCEL.TabIndex = 1;
            this.CANCEL.Text = "CANCEL";
            this.CANCEL.UseVisualStyleBackColor = false;
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
            // 
            // bill_PaymentTableAdapter
            // 
            this.bill_PaymentTableAdapter.ClearBeforeFill = true;
            // 
            // View_Bill_Payment_Entries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(745, 404);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "View_Bill_Payment_Entries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Bill_Payment_Entries";
            this.Load += new System.EventHandler(this.View_Bill_Payment_Entries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billPaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet13)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CANCEL;
        private Transport_Mgmt_SystemDataSet13 transport_Mgmt_SystemDataSet13;
        private System.Windows.Forms.BindingSource billPaymentBindingSource;
        private Transport_Mgmt_SystemDataSet13TableAdapters.Bill_PaymentTableAdapter bill_PaymentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn billNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOfCheckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfWithdrawnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}