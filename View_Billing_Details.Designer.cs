namespace Transport_mgmt
{
    partial class View_Billing_Details
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
            this.CANCEL = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.billNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfLoadingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeOfLoadingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeOfUnloadingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightInMatrictoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratePerMatrictoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advanceAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transport_Mgmt_SystemDataSet14 = new Transport_mgmt.Transport_Mgmt_SystemDataSet14();
            this.billing_DetailTableAdapter = new Transport_mgmt.Transport_Mgmt_SystemDataSet14TableAdapters.Billing_DetailTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet14)).BeginInit();
            this.SuspendLayout();
            // 
            // CANCEL
            // 
            this.CANCEL.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCEL.ForeColor = System.Drawing.Color.Orange;
            this.CANCEL.Location = new System.Drawing.Point(291, 323);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(144, 36);
            this.CANCEL.TabIndex = 3;
            this.CANCEL.Text = "CANCEL";
            this.CANCEL.UseVisualStyleBackColor = true;
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
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
            this.vehicleIDDataGridViewTextBoxColumn,
            this.partyIDDataGridViewTextBoxColumn,
            this.dateOfLoadingDataGridViewTextBoxColumn,
            this.placeOfLoadingDataGridViewTextBoxColumn,
            this.placeOfUnloadingDataGridViewTextBoxColumn,
            this.weightInMatrictoneDataGridViewTextBoxColumn,
            this.ratePerMatrictoneDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.advanceAmountDataGridViewTextBoxColumn,
            this.balanceAmountDataGridViewTextBoxColumn,
            this.billStatusDataGridViewTextBoxColumn,
            this.materialDescriptionDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.billingDetailBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(31, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(688, 238);
            this.dataGridView1.TabIndex = 2;
            // 
            // billNoDataGridViewTextBoxColumn
            // 
            this.billNoDataGridViewTextBoxColumn.DataPropertyName = "Bill_No";
            this.billNoDataGridViewTextBoxColumn.HeaderText = "Bill_No";
            this.billNoDataGridViewTextBoxColumn.Name = "billNoDataGridViewTextBoxColumn";
            this.billNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_ID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "Vehicle_ID";
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            this.vehicleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partyIDDataGridViewTextBoxColumn
            // 
            this.partyIDDataGridViewTextBoxColumn.DataPropertyName = "Party_ID";
            this.partyIDDataGridViewTextBoxColumn.HeaderText = "Party_ID";
            this.partyIDDataGridViewTextBoxColumn.Name = "partyIDDataGridViewTextBoxColumn";
            this.partyIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfLoadingDataGridViewTextBoxColumn
            // 
            this.dateOfLoadingDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Loading";
            this.dateOfLoadingDataGridViewTextBoxColumn.HeaderText = "Date_Of_Loading";
            this.dateOfLoadingDataGridViewTextBoxColumn.Name = "dateOfLoadingDataGridViewTextBoxColumn";
            this.dateOfLoadingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placeOfLoadingDataGridViewTextBoxColumn
            // 
            this.placeOfLoadingDataGridViewTextBoxColumn.DataPropertyName = "Place_Of_Loading";
            this.placeOfLoadingDataGridViewTextBoxColumn.HeaderText = "Place_Of_Loading";
            this.placeOfLoadingDataGridViewTextBoxColumn.Name = "placeOfLoadingDataGridViewTextBoxColumn";
            this.placeOfLoadingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placeOfUnloadingDataGridViewTextBoxColumn
            // 
            this.placeOfUnloadingDataGridViewTextBoxColumn.DataPropertyName = "Place_Of_Unloading";
            this.placeOfUnloadingDataGridViewTextBoxColumn.HeaderText = "Place_Of_Unloading";
            this.placeOfUnloadingDataGridViewTextBoxColumn.Name = "placeOfUnloadingDataGridViewTextBoxColumn";
            this.placeOfUnloadingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightInMatrictoneDataGridViewTextBoxColumn
            // 
            this.weightInMatrictoneDataGridViewTextBoxColumn.DataPropertyName = "Weight_In_Matrictone";
            this.weightInMatrictoneDataGridViewTextBoxColumn.HeaderText = "Weight_In_Matrictone";
            this.weightInMatrictoneDataGridViewTextBoxColumn.Name = "weightInMatrictoneDataGridViewTextBoxColumn";
            this.weightInMatrictoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ratePerMatrictoneDataGridViewTextBoxColumn
            // 
            this.ratePerMatrictoneDataGridViewTextBoxColumn.DataPropertyName = "Rate_Per_Matrictone";
            this.ratePerMatrictoneDataGridViewTextBoxColumn.HeaderText = "Rate_Per_Matrictone";
            this.ratePerMatrictoneDataGridViewTextBoxColumn.Name = "ratePerMatrictoneDataGridViewTextBoxColumn";
            this.ratePerMatrictoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "Total_Amount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "Total_Amount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // advanceAmountDataGridViewTextBoxColumn
            // 
            this.advanceAmountDataGridViewTextBoxColumn.DataPropertyName = "Advance_Amount";
            this.advanceAmountDataGridViewTextBoxColumn.HeaderText = "Advance_Amount";
            this.advanceAmountDataGridViewTextBoxColumn.Name = "advanceAmountDataGridViewTextBoxColumn";
            this.advanceAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // balanceAmountDataGridViewTextBoxColumn
            // 
            this.balanceAmountDataGridViewTextBoxColumn.DataPropertyName = "Balance_Amount";
            this.balanceAmountDataGridViewTextBoxColumn.HeaderText = "Balance_Amount";
            this.balanceAmountDataGridViewTextBoxColumn.Name = "balanceAmountDataGridViewTextBoxColumn";
            this.balanceAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billStatusDataGridViewTextBoxColumn
            // 
            this.billStatusDataGridViewTextBoxColumn.DataPropertyName = "Bill_Status";
            this.billStatusDataGridViewTextBoxColumn.HeaderText = "Bill_Status";
            this.billStatusDataGridViewTextBoxColumn.Name = "billStatusDataGridViewTextBoxColumn";
            this.billStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialDescriptionDataGridViewTextBoxColumn
            // 
            this.materialDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Material_Description";
            this.materialDescriptionDataGridViewTextBoxColumn.HeaderText = "Material_Description";
            this.materialDescriptionDataGridViewTextBoxColumn.Name = "materialDescriptionDataGridViewTextBoxColumn";
            this.materialDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billingDetailBindingSource
            // 
            this.billingDetailBindingSource.DataMember = "Billing_Detail";
            this.billingDetailBindingSource.DataSource = this.transport_Mgmt_SystemDataSet14;
            // 
            // transport_Mgmt_SystemDataSet14
            // 
            this.transport_Mgmt_SystemDataSet14.DataSetName = "Transport_Mgmt_SystemDataSet14";
            this.transport_Mgmt_SystemDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billing_DetailTableAdapter
            // 
            this.billing_DetailTableAdapter.ClearBeforeFill = true;
            // 
            // View_Billing_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 405);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "View_Billing_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Billing_Details";
            this.Load += new System.EventHandler(this.View_Billing_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet14)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Transport_Mgmt_SystemDataSet14 transport_Mgmt_SystemDataSet14;
        private System.Windows.Forms.BindingSource billingDetailBindingSource;
        private Transport_Mgmt_SystemDataSet14TableAdapters.Billing_DetailTableAdapter billing_DetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn billNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfLoadingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeOfLoadingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeOfUnloadingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightInMatrictoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratePerMatrictoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn advanceAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}