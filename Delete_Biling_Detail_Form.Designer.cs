namespace Transport_mgmt
{
    partial class Delete_Biling_Detail_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Vehicle_ID = new System.Windows.Forms.TextBox();
            this.Bill_No = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.DELETE = new System.Windows.Forms.Button();
            this.CLEAR = new System.Windows.Forms.Button();
            this.CANCEL = new System.Windows.Forms.Button();
            this.DATA_VIEW = new System.Windows.Forms.Button();
            this.transport_Mgmt_SystemDataSet23 = new Transport_mgmt.Transport_Mgmt_SystemDataSet23();
            this.billingDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billing_DetailTableAdapter = new Transport_mgmt.Transport_Mgmt_SystemDataSet23TableAdapters.Billing_DetailTableAdapter();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Vehicle_ID);
            this.groupBox1.Controls.Add(this.Bill_No);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details__:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Vehicle_ID
            // 
            this.Vehicle_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehicle_ID.Location = new System.Drawing.Point(205, 85);
            this.Vehicle_ID.Name = "Vehicle_ID";
            this.Vehicle_ID.Size = new System.Drawing.Size(100, 22);
            this.Vehicle_ID.TabIndex = 3;
            this.Vehicle_ID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Vehicle_ID_MouseClick_1);
            // 
            // Bill_No
            // 
            this.Bill_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_No.Location = new System.Drawing.Point(205, 37);
            this.Bill_No.Name = "Bill_No";
            this.Bill_No.Size = new System.Drawing.Size(100, 22);
            this.Bill_No.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vehicle_ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill_No :";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
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
            this.dataGridView1.DataSource = this.billingDetailBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(61, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 165);
            this.dataGridView1.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.PeachPuff;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(287, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(287, 32);
            this.label14.TabIndex = 14;
            this.label14.Text = "Billing_Detail_Form : ..-";
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DELETE.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETE.Location = new System.Drawing.Point(468, 105);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(88, 29);
            this.DELETE.TabIndex = 15;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // CLEAR
            // 
            this.CLEAR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CLEAR.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLEAR.Location = new System.Drawing.Point(598, 105);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(88, 29);
            this.CLEAR.TabIndex = 16;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.UseVisualStyleBackColor = false;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // CANCEL
            // 
            this.CANCEL.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CANCEL.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCEL.Location = new System.Drawing.Point(538, 157);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(88, 29);
            this.CANCEL.TabIndex = 17;
            this.CANCEL.Text = "CANCEL";
            this.CANCEL.UseVisualStyleBackColor = false;
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
            // 
            // DATA_VIEW
            // 
            this.DATA_VIEW.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DATA_VIEW.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATA_VIEW.Location = new System.Drawing.Point(340, 234);
            this.DATA_VIEW.Name = "DATA_VIEW";
            this.DATA_VIEW.Size = new System.Drawing.Size(136, 29);
            this.DATA_VIEW.TabIndex = 18;
            this.DATA_VIEW.Text = "Refresh";
            this.DATA_VIEW.UseVisualStyleBackColor = false;
            this.DATA_VIEW.Click += new System.EventHandler(this.DATA_VIEW_Click);
            // 
            // transport_Mgmt_SystemDataSet23
            // 
            this.transport_Mgmt_SystemDataSet23.DataSetName = "Transport_Mgmt_SystemDataSet23";
            this.transport_Mgmt_SystemDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billingDetailBindingSource
            // 
            this.billingDetailBindingSource.DataMember = "Billing_Detail";
            this.billingDetailBindingSource.DataSource = this.transport_Mgmt_SystemDataSet23;
            // 
            // billing_DetailTableAdapter
            // 
            this.billing_DetailTableAdapter.ClearBeforeFill = true;
            // 
            // billNoDataGridViewTextBoxColumn
            // 
            this.billNoDataGridViewTextBoxColumn.DataPropertyName = "Bill_No";
            this.billNoDataGridViewTextBoxColumn.HeaderText = "Bill_No";
            this.billNoDataGridViewTextBoxColumn.Name = "billNoDataGridViewTextBoxColumn";
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_ID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "Vehicle_ID";
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            // 
            // partyIDDataGridViewTextBoxColumn
            // 
            this.partyIDDataGridViewTextBoxColumn.DataPropertyName = "Party_ID";
            this.partyIDDataGridViewTextBoxColumn.HeaderText = "Party_ID";
            this.partyIDDataGridViewTextBoxColumn.Name = "partyIDDataGridViewTextBoxColumn";
            // 
            // dateOfLoadingDataGridViewTextBoxColumn
            // 
            this.dateOfLoadingDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Loading";
            this.dateOfLoadingDataGridViewTextBoxColumn.HeaderText = "Date_Of_Loading";
            this.dateOfLoadingDataGridViewTextBoxColumn.Name = "dateOfLoadingDataGridViewTextBoxColumn";
            // 
            // placeOfLoadingDataGridViewTextBoxColumn
            // 
            this.placeOfLoadingDataGridViewTextBoxColumn.DataPropertyName = "Place_Of_Loading";
            this.placeOfLoadingDataGridViewTextBoxColumn.HeaderText = "Place_Of_Loading";
            this.placeOfLoadingDataGridViewTextBoxColumn.Name = "placeOfLoadingDataGridViewTextBoxColumn";
            // 
            // placeOfUnloadingDataGridViewTextBoxColumn
            // 
            this.placeOfUnloadingDataGridViewTextBoxColumn.DataPropertyName = "Place_Of_Unloading";
            this.placeOfUnloadingDataGridViewTextBoxColumn.HeaderText = "Place_Of_Unloading";
            this.placeOfUnloadingDataGridViewTextBoxColumn.Name = "placeOfUnloadingDataGridViewTextBoxColumn";
            // 
            // weightInMatrictoneDataGridViewTextBoxColumn
            // 
            this.weightInMatrictoneDataGridViewTextBoxColumn.DataPropertyName = "Weight_In_Matrictone";
            this.weightInMatrictoneDataGridViewTextBoxColumn.HeaderText = "Weight_In_Matrictone";
            this.weightInMatrictoneDataGridViewTextBoxColumn.Name = "weightInMatrictoneDataGridViewTextBoxColumn";
            // 
            // ratePerMatrictoneDataGridViewTextBoxColumn
            // 
            this.ratePerMatrictoneDataGridViewTextBoxColumn.DataPropertyName = "Rate_Per_Matrictone";
            this.ratePerMatrictoneDataGridViewTextBoxColumn.HeaderText = "Rate_Per_Matrictone";
            this.ratePerMatrictoneDataGridViewTextBoxColumn.Name = "ratePerMatrictoneDataGridViewTextBoxColumn";
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "Total_Amount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "Total_Amount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            // 
            // advanceAmountDataGridViewTextBoxColumn
            // 
            this.advanceAmountDataGridViewTextBoxColumn.DataPropertyName = "Advance_Amount";
            this.advanceAmountDataGridViewTextBoxColumn.HeaderText = "Advance_Amount";
            this.advanceAmountDataGridViewTextBoxColumn.Name = "advanceAmountDataGridViewTextBoxColumn";
            // 
            // balanceAmountDataGridViewTextBoxColumn
            // 
            this.balanceAmountDataGridViewTextBoxColumn.DataPropertyName = "Balance_Amount";
            this.balanceAmountDataGridViewTextBoxColumn.HeaderText = "Balance_Amount";
            this.balanceAmountDataGridViewTextBoxColumn.Name = "balanceAmountDataGridViewTextBoxColumn";
            // 
            // billStatusDataGridViewTextBoxColumn
            // 
            this.billStatusDataGridViewTextBoxColumn.DataPropertyName = "Bill_Status";
            this.billStatusDataGridViewTextBoxColumn.HeaderText = "Bill_Status";
            this.billStatusDataGridViewTextBoxColumn.Name = "billStatusDataGridViewTextBoxColumn";
            // 
            // materialDescriptionDataGridViewTextBoxColumn
            // 
            this.materialDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Material_Description";
            this.materialDescriptionDataGridViewTextBoxColumn.HeaderText = "Material_Description";
            this.materialDescriptionDataGridViewTextBoxColumn.Name = "materialDescriptionDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // Delete_Biling_Detail_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(850, 466);
            this.Controls.Add(this.DATA_VIEW);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Delete_Biling_Detail_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete_Biling_Detail_Form";
            this.Load += new System.EventHandler(this.Delete_Biling_Detail_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingDetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.Button DATA_VIEW;
        private System.Windows.Forms.TextBox Vehicle_ID;
        private System.Windows.Forms.TextBox Bill_No;
        private Transport_Mgmt_SystemDataSet23 transport_Mgmt_SystemDataSet23;
        private System.Windows.Forms.BindingSource billingDetailBindingSource;
        private Transport_Mgmt_SystemDataSet23TableAdapters.Billing_DetailTableAdapter billing_DetailTableAdapter;
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