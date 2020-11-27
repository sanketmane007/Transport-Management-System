namespace Transport_mgmt
{
    partial class View_Voucher_Details
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
            this.voucherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vOUCHERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transport_Mgmt_SystemDataSet15 = new Transport_mgmt.Transport_Mgmt_SystemDataSet15();
            this.vOUCHERTableAdapter = new Transport_mgmt.Transport_Mgmt_SystemDataSet15TableAdapters.VOUCHERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOUCHERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet15)).BeginInit();
            this.SuspendLayout();
            // 
            // CANCEL
            // 
            this.CANCEL.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCEL.ForeColor = System.Drawing.Color.Orange;
            this.CANCEL.Location = new System.Drawing.Point(292, 323);
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
            this.voucherIDDataGridViewTextBoxColumn,
            this.voucherNoDataGridViewTextBoxColumn,
            this.voucherDateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.voucherNameDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.empIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.vOUCHERBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(32, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(688, 238);
            this.dataGridView1.TabIndex = 2;
            // 
            // voucherIDDataGridViewTextBoxColumn
            // 
            this.voucherIDDataGridViewTextBoxColumn.DataPropertyName = "Voucher_ID";
            this.voucherIDDataGridViewTextBoxColumn.HeaderText = "Voucher_ID";
            this.voucherIDDataGridViewTextBoxColumn.Name = "voucherIDDataGridViewTextBoxColumn";
            this.voucherIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // voucherNoDataGridViewTextBoxColumn
            // 
            this.voucherNoDataGridViewTextBoxColumn.DataPropertyName = "Voucher_No";
            this.voucherNoDataGridViewTextBoxColumn.HeaderText = "Voucher_No";
            this.voucherNoDataGridViewTextBoxColumn.Name = "voucherNoDataGridViewTextBoxColumn";
            this.voucherNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // voucherDateDataGridViewTextBoxColumn
            // 
            this.voucherDateDataGridViewTextBoxColumn.DataPropertyName = "Voucher_Date";
            this.voucherDateDataGridViewTextBoxColumn.HeaderText = "Voucher_Date";
            this.voucherDateDataGridViewTextBoxColumn.Name = "voucherDateDataGridViewTextBoxColumn";
            this.voucherDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // voucherNameDataGridViewTextBoxColumn
            // 
            this.voucherNameDataGridViewTextBoxColumn.DataPropertyName = "Voucher_Name";
            this.voucherNameDataGridViewTextBoxColumn.HeaderText = "Voucher_Name";
            this.voucherNameDataGridViewTextBoxColumn.Name = "voucherNameDataGridViewTextBoxColumn";
            this.voucherNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vOUCHERBindingSource
            // 
            this.vOUCHERBindingSource.DataMember = "VOUCHER";
            this.vOUCHERBindingSource.DataSource = this.transport_Mgmt_SystemDataSet15;
            // 
            // transport_Mgmt_SystemDataSet15
            // 
            this.transport_Mgmt_SystemDataSet15.DataSetName = "Transport_Mgmt_SystemDataSet15";
            this.transport_Mgmt_SystemDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vOUCHERTableAdapter
            // 
            this.vOUCHERTableAdapter.ClearBeforeFill = true;
            // 
            // View_Voucher_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(752, 404);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "View_Voucher_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Voucher_Details";
            this.Load += new System.EventHandler(this.View_Voucher_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOUCHERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet15)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Transport_Mgmt_SystemDataSet15 transport_Mgmt_SystemDataSet15;
        private System.Windows.Forms.BindingSource vOUCHERBindingSource;
        private Transport_Mgmt_SystemDataSet15TableAdapters.VOUCHERTableAdapter vOUCHERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}