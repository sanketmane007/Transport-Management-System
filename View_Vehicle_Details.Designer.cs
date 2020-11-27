namespace Transport_mgmt
{
    partial class View_Vehicle_Details
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
            this.trailerNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chasisNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permitNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conductorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vEHICLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transport_Mgmt_SystemDataSet18 = new Transport_mgmt.Transport_Mgmt_SystemDataSet18();
            this.vEHICLETableAdapter = new Transport_mgmt.Transport_Mgmt_SystemDataSet18TableAdapters.VEHICLETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet18)).BeginInit();
            this.SuspendLayout();
            // 
            // CANCEL
            // 
            this.CANCEL.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCEL.ForeColor = System.Drawing.Color.Orange;
            this.CANCEL.Location = new System.Drawing.Point(288, 324);
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
            this.trailerNoDataGridViewTextBoxColumn,
            this.chasisNoDataGridViewTextBoxColumn,
            this.engineNoDataGridViewTextBoxColumn,
            this.modelNoDataGridViewTextBoxColumn,
            this.permitNoDataGridViewTextBoxColumn,
            this.driverNameDataGridViewTextBoxColumn,
            this.conductorNameDataGridViewTextBoxColumn,
            this.routeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.vEHICLEBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(28, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
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
            // trailerNoDataGridViewTextBoxColumn
            // 
            this.trailerNoDataGridViewTextBoxColumn.DataPropertyName = "Trailer_No";
            this.trailerNoDataGridViewTextBoxColumn.HeaderText = "Trailer_No";
            this.trailerNoDataGridViewTextBoxColumn.Name = "trailerNoDataGridViewTextBoxColumn";
            this.trailerNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chasisNoDataGridViewTextBoxColumn
            // 
            this.chasisNoDataGridViewTextBoxColumn.DataPropertyName = "Chasis_No";
            this.chasisNoDataGridViewTextBoxColumn.HeaderText = "Chasis_No";
            this.chasisNoDataGridViewTextBoxColumn.Name = "chasisNoDataGridViewTextBoxColumn";
            this.chasisNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // engineNoDataGridViewTextBoxColumn
            // 
            this.engineNoDataGridViewTextBoxColumn.DataPropertyName = "Engine_No";
            this.engineNoDataGridViewTextBoxColumn.HeaderText = "Engine_No";
            this.engineNoDataGridViewTextBoxColumn.Name = "engineNoDataGridViewTextBoxColumn";
            this.engineNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelNoDataGridViewTextBoxColumn
            // 
            this.modelNoDataGridViewTextBoxColumn.DataPropertyName = "Model_No";
            this.modelNoDataGridViewTextBoxColumn.HeaderText = "Model_No";
            this.modelNoDataGridViewTextBoxColumn.Name = "modelNoDataGridViewTextBoxColumn";
            this.modelNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // permitNoDataGridViewTextBoxColumn
            // 
            this.permitNoDataGridViewTextBoxColumn.DataPropertyName = "Permit_No";
            this.permitNoDataGridViewTextBoxColumn.HeaderText = "Permit_No";
            this.permitNoDataGridViewTextBoxColumn.Name = "permitNoDataGridViewTextBoxColumn";
            this.permitNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driverNameDataGridViewTextBoxColumn
            // 
            this.driverNameDataGridViewTextBoxColumn.DataPropertyName = "Driver_Name";
            this.driverNameDataGridViewTextBoxColumn.HeaderText = "Driver_Name";
            this.driverNameDataGridViewTextBoxColumn.Name = "driverNameDataGridViewTextBoxColumn";
            this.driverNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conductorNameDataGridViewTextBoxColumn
            // 
            this.conductorNameDataGridViewTextBoxColumn.DataPropertyName = "Conductor_Name";
            this.conductorNameDataGridViewTextBoxColumn.HeaderText = "Conductor_Name";
            this.conductorNameDataGridViewTextBoxColumn.Name = "conductorNameDataGridViewTextBoxColumn";
            this.conductorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // routeDataGridViewTextBoxColumn
            // 
            this.routeDataGridViewTextBoxColumn.DataPropertyName = "Route";
            this.routeDataGridViewTextBoxColumn.HeaderText = "Route";
            this.routeDataGridViewTextBoxColumn.Name = "routeDataGridViewTextBoxColumn";
            this.routeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vEHICLEBindingSource
            // 
            this.vEHICLEBindingSource.DataMember = "VEHICLE";
            this.vEHICLEBindingSource.DataSource = this.transport_Mgmt_SystemDataSet18;
            // 
            // transport_Mgmt_SystemDataSet18
            // 
            this.transport_Mgmt_SystemDataSet18.DataSetName = "Transport_Mgmt_SystemDataSet18";
            this.transport_Mgmt_SystemDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vEHICLETableAdapter
            // 
            this.vEHICLETableAdapter.ClearBeforeFill = true;
            // 
            // View_Vehicle_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(745, 406);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "View_Vehicle_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Vehicle_Details";
            this.Load += new System.EventHandler(this.View_Vehicle_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet18)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Transport_Mgmt_SystemDataSet18 transport_Mgmt_SystemDataSet18;
        private System.Windows.Forms.BindingSource vEHICLEBindingSource;
        private Transport_Mgmt_SystemDataSet18TableAdapters.VEHICLETableAdapter vEHICLETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trailerNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chasisNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permitNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conductorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}