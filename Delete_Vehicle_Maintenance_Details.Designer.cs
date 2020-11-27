namespace Transport_mgmt
{
    partial class Delete_Vehicle_Maintenance_Details
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
            this.DATA_VIEW = new System.Windows.Forms.Button();
            this.CANCEL = new System.Windows.Forms.Button();
            this.CLEAR = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Vehicle_ID = new System.Windows.Forms.TextBox();
            this.Maintenance_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.transport_Mgmt_SystemDataSet30 = new Transport_mgmt.Transport_Mgmt_SystemDataSet30();
            this.vehicleMaintenanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicle_MaintenanceTableAdapter = new Transport_mgmt.Transport_Mgmt_SystemDataSet30TableAdapters.Vehicle_MaintenanceTableAdapter();
            this.maintenanceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oilChangingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.halfGreasingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineWorkDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pumpWorkDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleMaintenanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DATA_VIEW
            // 
            this.DATA_VIEW.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DATA_VIEW.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATA_VIEW.Location = new System.Drawing.Point(318, 246);
            this.DATA_VIEW.Name = "DATA_VIEW";
            this.DATA_VIEW.Size = new System.Drawing.Size(136, 29);
            this.DATA_VIEW.TabIndex = 30;
            this.DATA_VIEW.Text = "Refresh";
            this.DATA_VIEW.UseVisualStyleBackColor = false;
            this.DATA_VIEW.Click += new System.EventHandler(this.DATA_VIEW_Click);
            // 
            // CANCEL
            // 
            this.CANCEL.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CANCEL.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCEL.Location = new System.Drawing.Point(516, 169);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(88, 29);
            this.CANCEL.TabIndex = 29;
            this.CANCEL.Text = "CANCEL";
            this.CANCEL.UseVisualStyleBackColor = false;
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
            // 
            // CLEAR
            // 
            this.CLEAR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CLEAR.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLEAR.Location = new System.Drawing.Point(576, 117);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(88, 29);
            this.CLEAR.TabIndex = 28;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.UseVisualStyleBackColor = false;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DELETE.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETE.Location = new System.Drawing.Point(446, 117);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(88, 29);
            this.DELETE.TabIndex = 27;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.dataGridView1.DataSource = this.vehicleMaintenanceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(42, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(732, 155);
            this.dataGridView1.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Vehicle_ID);
            this.groupBox1.Controls.Add(this.Maintenance_ID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 149);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details__:";
            // 
            // Vehicle_ID
            // 
            this.Vehicle_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehicle_ID.Location = new System.Drawing.Point(219, 85);
            this.Vehicle_ID.Name = "Vehicle_ID";
            this.Vehicle_ID.Size = new System.Drawing.Size(100, 22);
            this.Vehicle_ID.TabIndex = 3;
            this.Vehicle_ID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Vehicle_ID_MouseClick_1);
            // 
            // Maintenance_ID
            // 
            this.Maintenance_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maintenance_ID.Location = new System.Drawing.Point(219, 38);
            this.Maintenance_ID.Name = "Maintenance_ID";
            this.Maintenance_ID.Size = new System.Drawing.Size(100, 22);
            this.Maintenance_ID.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maintenance_ID :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Linen;
            this.label9.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(244, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(354, 30);
            this.label9.TabIndex = 31;
            this.label9.Text = "Vehicle_Maintenance_Form... :";
            // 
            // transport_Mgmt_SystemDataSet30
            // 
            this.transport_Mgmt_SystemDataSet30.DataSetName = "Transport_Mgmt_SystemDataSet30";
            this.transport_Mgmt_SystemDataSet30.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleMaintenanceBindingSource
            // 
            this.vehicleMaintenanceBindingSource.DataMember = "Vehicle_Maintenance";
            this.vehicleMaintenanceBindingSource.DataSource = this.transport_Mgmt_SystemDataSet30;
            // 
            // vehicle_MaintenanceTableAdapter
            // 
            this.vehicle_MaintenanceTableAdapter.ClearBeforeFill = true;
            // 
            // maintenanceIDDataGridViewTextBoxColumn
            // 
            this.maintenanceIDDataGridViewTextBoxColumn.DataPropertyName = "Maintenance_ID";
            this.maintenanceIDDataGridViewTextBoxColumn.HeaderText = "Maintenance_ID";
            this.maintenanceIDDataGridViewTextBoxColumn.Name = "maintenanceIDDataGridViewTextBoxColumn";
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_ID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "Vehicle_ID";
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            // 
            // vehicleNumberDataGridViewTextBoxColumn
            // 
            this.vehicleNumberDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Number";
            this.vehicleNumberDataGridViewTextBoxColumn.HeaderText = "Vehicle_Number";
            this.vehicleNumberDataGridViewTextBoxColumn.Name = "vehicleNumberDataGridViewTextBoxColumn";
            // 
            // oilChangingDateDataGridViewTextBoxColumn
            // 
            this.oilChangingDateDataGridViewTextBoxColumn.DataPropertyName = "Oil_Changing_Date";
            this.oilChangingDateDataGridViewTextBoxColumn.HeaderText = "Oil_Changing_Date";
            this.oilChangingDateDataGridViewTextBoxColumn.Name = "oilChangingDateDataGridViewTextBoxColumn";
            // 
            // halfGreasingDateDataGridViewTextBoxColumn
            // 
            this.halfGreasingDateDataGridViewTextBoxColumn.DataPropertyName = "Half_Greasing_Date";
            this.halfGreasingDateDataGridViewTextBoxColumn.HeaderText = "Half_Greasing_Date";
            this.halfGreasingDateDataGridViewTextBoxColumn.Name = "halfGreasingDateDataGridViewTextBoxColumn";
            // 
            // engineWorkDateDataGridViewTextBoxColumn
            // 
            this.engineWorkDateDataGridViewTextBoxColumn.DataPropertyName = "Engine_Work_Date";
            this.engineWorkDateDataGridViewTextBoxColumn.HeaderText = "Engine_Work_Date";
            this.engineWorkDateDataGridViewTextBoxColumn.Name = "engineWorkDateDataGridViewTextBoxColumn";
            // 
            // pumpWorkDateDataGridViewTextBoxColumn
            // 
            this.pumpWorkDateDataGridViewTextBoxColumn.DataPropertyName = "Pump_Work_Date";
            this.pumpWorkDateDataGridViewTextBoxColumn.HeaderText = "Pump_Work_Date";
            this.pumpWorkDateDataGridViewTextBoxColumn.Name = "pumpWorkDateDataGridViewTextBoxColumn";
            // 
            // extraWorkDataGridViewTextBoxColumn
            // 
            this.extraWorkDataGridViewTextBoxColumn.DataPropertyName = "Extra_Work";
            this.extraWorkDataGridViewTextBoxColumn.HeaderText = "Extra_Work";
            this.extraWorkDataGridViewTextBoxColumn.Name = "extraWorkDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // Delete_Vehicle_Maintenance_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(826, 482);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DATA_VIEW);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Delete_Vehicle_Maintenance_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete_Vehicle_Maintenance_Details";
            this.Load += new System.EventHandler(this.Delete_Vehicle_Maintenance_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleMaintenanceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DATA_VIEW;
        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Vehicle_ID;
        private System.Windows.Forms.TextBox Maintenance_ID;
        private Transport_Mgmt_SystemDataSet30 transport_Mgmt_SystemDataSet30;
        private System.Windows.Forms.BindingSource vehicleMaintenanceBindingSource;
        private Transport_Mgmt_SystemDataSet30TableAdapters.Vehicle_MaintenanceTableAdapter vehicle_MaintenanceTableAdapter;
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