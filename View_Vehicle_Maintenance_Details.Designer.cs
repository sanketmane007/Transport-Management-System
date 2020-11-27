namespace Transport_mgmt
{
    partial class View_Vehicle_Maintenance_Details
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
            this.maintenanceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oilChangingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.halfGreasingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineWorkDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pumpWorkDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleMaintenanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transport_Mgmt_SystemDataSet17 = new Transport_mgmt.Transport_Mgmt_SystemDataSet17();
            this.vehicle_MaintenanceTableAdapter = new Transport_mgmt.Transport_Mgmt_SystemDataSet17TableAdapters.Vehicle_MaintenanceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleMaintenanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet17)).BeginInit();
            this.SuspendLayout();
            // 
            // CANCEL
            // 
            this.CANCEL.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCEL.ForeColor = System.Drawing.Color.Orange;
            this.CANCEL.Location = new System.Drawing.Point(290, 322);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(144, 36);
            this.CANCEL.TabIndex = 3;
            this.CANCEL.Text = "CANCEL";
            this.CANCEL.UseVisualStyleBackColor = true;
            this.CANCEL.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maintenanceIDDataGridViewTextBoxColumn,
            this.vehicleIDDataGridViewTextBoxColumn,
            this.vehicleNumberDataGridViewTextBoxColumn,
            this.oilChangingDateDataGridViewTextBoxColumn,
            this.halfGreasingDateDataGridViewTextBoxColumn,
            this.engineWorkDateDataGridViewTextBoxColumn,
            this.pumpWorkDateDataGridViewTextBoxColumn,
            this.extraWorkDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.vehicleMaintenanceBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(30, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(688, 238);
            this.dataGridView1.TabIndex = 2;
            // 
            // maintenanceIDDataGridViewTextBoxColumn
            // 
            this.maintenanceIDDataGridViewTextBoxColumn.DataPropertyName = "Maintenance_ID";
            this.maintenanceIDDataGridViewTextBoxColumn.HeaderText = "Maintenance_ID";
            this.maintenanceIDDataGridViewTextBoxColumn.Name = "maintenanceIDDataGridViewTextBoxColumn";
            this.maintenanceIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // oilChangingDateDataGridViewTextBoxColumn
            // 
            this.oilChangingDateDataGridViewTextBoxColumn.DataPropertyName = "Oil_Changing_Date";
            this.oilChangingDateDataGridViewTextBoxColumn.HeaderText = "Oil_Changing_Date";
            this.oilChangingDateDataGridViewTextBoxColumn.Name = "oilChangingDateDataGridViewTextBoxColumn";
            this.oilChangingDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // halfGreasingDateDataGridViewTextBoxColumn
            // 
            this.halfGreasingDateDataGridViewTextBoxColumn.DataPropertyName = "Half_Greasing_Date";
            this.halfGreasingDateDataGridViewTextBoxColumn.HeaderText = "Half_Greasing_Date";
            this.halfGreasingDateDataGridViewTextBoxColumn.Name = "halfGreasingDateDataGridViewTextBoxColumn";
            this.halfGreasingDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // engineWorkDateDataGridViewTextBoxColumn
            // 
            this.engineWorkDateDataGridViewTextBoxColumn.DataPropertyName = "Engine_Work_Date";
            this.engineWorkDateDataGridViewTextBoxColumn.HeaderText = "Engine_Work_Date";
            this.engineWorkDateDataGridViewTextBoxColumn.Name = "engineWorkDateDataGridViewTextBoxColumn";
            this.engineWorkDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pumpWorkDateDataGridViewTextBoxColumn
            // 
            this.pumpWorkDateDataGridViewTextBoxColumn.DataPropertyName = "Pump_Work_Date";
            this.pumpWorkDateDataGridViewTextBoxColumn.HeaderText = "Pump_Work_Date";
            this.pumpWorkDateDataGridViewTextBoxColumn.Name = "pumpWorkDateDataGridViewTextBoxColumn";
            this.pumpWorkDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // extraWorkDataGridViewTextBoxColumn
            // 
            this.extraWorkDataGridViewTextBoxColumn.DataPropertyName = "Extra_Work";
            this.extraWorkDataGridViewTextBoxColumn.HeaderText = "Extra_Work";
            this.extraWorkDataGridViewTextBoxColumn.Name = "extraWorkDataGridViewTextBoxColumn";
            this.extraWorkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleMaintenanceBindingSource
            // 
            this.vehicleMaintenanceBindingSource.DataMember = "Vehicle_Maintenance";
            this.vehicleMaintenanceBindingSource.DataSource = this.transport_Mgmt_SystemDataSet17;
            // 
            // transport_Mgmt_SystemDataSet17
            // 
            this.transport_Mgmt_SystemDataSet17.DataSetName = "Transport_Mgmt_SystemDataSet17";
            this.transport_Mgmt_SystemDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicle_MaintenanceTableAdapter
            // 
            this.vehicle_MaintenanceTableAdapter.ClearBeforeFill = true;
            // 
            // View_Vehicle_Maintenance_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 403);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "View_Vehicle_Maintenance_Details";
            this.Text = "View_Vehicle_Maintenance_Details";
            this.Load += new System.EventHandler(this.View_Vehicle_Maintenance_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleMaintenanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet17)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Transport_Mgmt_SystemDataSet17 transport_Mgmt_SystemDataSet17;
        private System.Windows.Forms.BindingSource vehicleMaintenanceBindingSource;
        private Transport_Mgmt_SystemDataSet17TableAdapters.Vehicle_MaintenanceTableAdapter vehicle_MaintenanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenanceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oilChangingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn halfGreasingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineWorkDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pumpWorkDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraWorkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}