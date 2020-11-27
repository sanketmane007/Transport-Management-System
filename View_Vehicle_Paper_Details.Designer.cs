namespace Transport_mgmt
{
    partial class View_Vehicle_Paper_Details
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
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insuranceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUCDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fitnessDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permitDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permitTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vEHICLEPAPERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transport_Mgmt_SystemDataSet16 = new Transport_mgmt.Transport_Mgmt_SystemDataSet16();
            this.vEHICLE_PAPERTableAdapter = new Transport_mgmt.Transport_Mgmt_SystemDataSet16TableAdapters.VEHICLE_PAPERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEPAPERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // CANCEL
            // 
            this.CANCEL.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCEL.ForeColor = System.Drawing.Color.Orange;
            this.CANCEL.Location = new System.Drawing.Point(283, 321);
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
            this.vehicleIDDataGridViewTextBoxColumn,
            this.vehicleNumberDataGridViewTextBoxColumn,
            this.insuranceDateDataGridViewTextBoxColumn,
            this.pUCDateDataGridViewTextBoxColumn,
            this.fitnessDateDataGridViewTextBoxColumn,
            this.taxDateDataGridViewTextBoxColumn,
            this.permitDateDataGridViewTextBoxColumn,
            this.permitTypeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.vEHICLEPAPERBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(23, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(688, 238);
            this.dataGridView1.TabIndex = 2;
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_ID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "Vehicle_ID";
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            this.vehicleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleNumberDataGridViewTextBoxColumn
            // 
            this.vehicleNumberDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Number";
            this.vehicleNumberDataGridViewTextBoxColumn.HeaderText = "Vehicle_Number";
            this.vehicleNumberDataGridViewTextBoxColumn.Name = "vehicleNumberDataGridViewTextBoxColumn";
            this.vehicleNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // insuranceDateDataGridViewTextBoxColumn
            // 
            this.insuranceDateDataGridViewTextBoxColumn.DataPropertyName = "Insurance_Date";
            this.insuranceDateDataGridViewTextBoxColumn.HeaderText = "Insurance_Date";
            this.insuranceDateDataGridViewTextBoxColumn.Name = "insuranceDateDataGridViewTextBoxColumn";
            this.insuranceDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pUCDateDataGridViewTextBoxColumn
            // 
            this.pUCDateDataGridViewTextBoxColumn.DataPropertyName = "PUC_Date";
            this.pUCDateDataGridViewTextBoxColumn.HeaderText = "PUC_Date";
            this.pUCDateDataGridViewTextBoxColumn.Name = "pUCDateDataGridViewTextBoxColumn";
            this.pUCDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fitnessDateDataGridViewTextBoxColumn
            // 
            this.fitnessDateDataGridViewTextBoxColumn.DataPropertyName = "Fitness_Date";
            this.fitnessDateDataGridViewTextBoxColumn.HeaderText = "Fitness_Date";
            this.fitnessDateDataGridViewTextBoxColumn.Name = "fitnessDateDataGridViewTextBoxColumn";
            this.fitnessDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxDateDataGridViewTextBoxColumn
            // 
            this.taxDateDataGridViewTextBoxColumn.DataPropertyName = "Tax_Date";
            this.taxDateDataGridViewTextBoxColumn.HeaderText = "Tax_Date";
            this.taxDateDataGridViewTextBoxColumn.Name = "taxDateDataGridViewTextBoxColumn";
            this.taxDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // permitDateDataGridViewTextBoxColumn
            // 
            this.permitDateDataGridViewTextBoxColumn.DataPropertyName = "Permit_Date";
            this.permitDateDataGridViewTextBoxColumn.HeaderText = "Permit_Date";
            this.permitDateDataGridViewTextBoxColumn.Name = "permitDateDataGridViewTextBoxColumn";
            this.permitDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // permitTypeDataGridViewTextBoxColumn
            // 
            this.permitTypeDataGridViewTextBoxColumn.DataPropertyName = "Permit_Type";
            this.permitTypeDataGridViewTextBoxColumn.HeaderText = "Permit_Type";
            this.permitTypeDataGridViewTextBoxColumn.Name = "permitTypeDataGridViewTextBoxColumn";
            this.permitTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vEHICLEPAPERBindingSource
            // 
            this.vEHICLEPAPERBindingSource.DataMember = "VEHICLE_PAPER";
            this.vEHICLEPAPERBindingSource.DataSource = this.transport_Mgmt_SystemDataSet16;
            // 
            // transport_Mgmt_SystemDataSet16
            // 
            this.transport_Mgmt_SystemDataSet16.DataSetName = "Transport_Mgmt_SystemDataSet16";
            this.transport_Mgmt_SystemDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vEHICLE_PAPERTableAdapter
            // 
            this.vEHICLE_PAPERTableAdapter.ClearBeforeFill = true;
            // 
            // View_Vehicle_Paper_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(734, 400);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "View_Vehicle_Paper_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Vehicle_Paper_Details";
            this.Load += new System.EventHandler(this.View_Vehicle_Paper_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEPAPERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet16)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Transport_Mgmt_SystemDataSet16 transport_Mgmt_SystemDataSet16;
        private System.Windows.Forms.BindingSource vEHICLEPAPERBindingSource;
        private Transport_Mgmt_SystemDataSet16TableAdapters.VEHICLE_PAPERTableAdapter vEHICLE_PAPERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insuranceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUCDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fitnessDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permitTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}