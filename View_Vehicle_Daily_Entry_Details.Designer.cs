namespace Transport_mgmt
{
    partial class View_Vehicle_Daily_Entry_Details
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
            this.entryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.challanNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.containerNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endingPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advancePayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleDailyEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transport_Mgmt_SystemDataSet19 = new Transport_mgmt.Transport_Mgmt_SystemDataSet19();
            this.vehicle_Daily_EntryTableAdapter = new Transport_mgmt.Transport_Mgmt_SystemDataSet19TableAdapters.Vehicle_Daily_EntryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDailyEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet19)).BeginInit();
            this.SuspendLayout();
            // 
            // CANCEL
            // 
            this.CANCEL.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCEL.ForeColor = System.Drawing.Color.Orange;
            this.CANCEL.Location = new System.Drawing.Point(285, 320);
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
            this.entryIDDataGridViewTextBoxColumn,
            this.vehicleIDDataGridViewTextBoxColumn,
            this.challanNoDataGridViewTextBoxColumn,
            this.containerNoDataGridViewTextBoxColumn,
            this.partyIDDataGridViewTextBoxColumn,
            this.routeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.startingPlaceDataGridViewTextBoxColumn,
            this.endingPlaceDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.advancePayDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.vehicleDailyEntryBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(25, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(688, 238);
            this.dataGridView1.TabIndex = 2;
            // 
            // entryIDDataGridViewTextBoxColumn
            // 
            this.entryIDDataGridViewTextBoxColumn.DataPropertyName = "Entry_ID";
            this.entryIDDataGridViewTextBoxColumn.HeaderText = "Entry_ID";
            this.entryIDDataGridViewTextBoxColumn.Name = "entryIDDataGridViewTextBoxColumn";
            this.entryIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_ID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "Vehicle_ID";
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            this.vehicleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // challanNoDataGridViewTextBoxColumn
            // 
            this.challanNoDataGridViewTextBoxColumn.DataPropertyName = "Challan_No";
            this.challanNoDataGridViewTextBoxColumn.HeaderText = "Challan_No";
            this.challanNoDataGridViewTextBoxColumn.Name = "challanNoDataGridViewTextBoxColumn";
            this.challanNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // containerNoDataGridViewTextBoxColumn
            // 
            this.containerNoDataGridViewTextBoxColumn.DataPropertyName = "Container_No";
            this.containerNoDataGridViewTextBoxColumn.HeaderText = "Container_No";
            this.containerNoDataGridViewTextBoxColumn.Name = "containerNoDataGridViewTextBoxColumn";
            this.containerNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partyIDDataGridViewTextBoxColumn
            // 
            this.partyIDDataGridViewTextBoxColumn.DataPropertyName = "Party_ID";
            this.partyIDDataGridViewTextBoxColumn.HeaderText = "Party_ID";
            this.partyIDDataGridViewTextBoxColumn.Name = "partyIDDataGridViewTextBoxColumn";
            this.partyIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // startingPlaceDataGridViewTextBoxColumn
            // 
            this.startingPlaceDataGridViewTextBoxColumn.DataPropertyName = "Starting_Place";
            this.startingPlaceDataGridViewTextBoxColumn.HeaderText = "Starting_Place";
            this.startingPlaceDataGridViewTextBoxColumn.Name = "startingPlaceDataGridViewTextBoxColumn";
            this.startingPlaceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endingPlaceDataGridViewTextBoxColumn
            // 
            this.endingPlaceDataGridViewTextBoxColumn.DataPropertyName = "Ending_Place";
            this.endingPlaceDataGridViewTextBoxColumn.HeaderText = "Ending_Place";
            this.endingPlaceDataGridViewTextBoxColumn.Name = "endingPlaceDataGridViewTextBoxColumn";
            this.endingPlaceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // advancePayDataGridViewTextBoxColumn
            // 
            this.advancePayDataGridViewTextBoxColumn.DataPropertyName = "Advance_Pay";
            this.advancePayDataGridViewTextBoxColumn.HeaderText = "Advance_Pay";
            this.advancePayDataGridViewTextBoxColumn.Name = "advancePayDataGridViewTextBoxColumn";
            this.advancePayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleDailyEntryBindingSource
            // 
            this.vehicleDailyEntryBindingSource.DataMember = "Vehicle_Daily_Entry";
            this.vehicleDailyEntryBindingSource.DataSource = this.transport_Mgmt_SystemDataSet19;
            // 
            // transport_Mgmt_SystemDataSet19
            // 
            this.transport_Mgmt_SystemDataSet19.DataSetName = "Transport_Mgmt_SystemDataSet19";
            this.transport_Mgmt_SystemDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicle_Daily_EntryTableAdapter
            // 
            this.vehicle_Daily_EntryTableAdapter.ClearBeforeFill = true;
            // 
            // View_Vehicle_Daily_Entry_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(739, 399);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "View_Vehicle_Daily_Entry_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Vehicle_Daily_Entries";
            this.Load += new System.EventHandler(this.View_Vehicle_Daily_Entry_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDailyEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet19)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Transport_Mgmt_SystemDataSet19 transport_Mgmt_SystemDataSet19;
        private System.Windows.Forms.BindingSource vehicleDailyEntryBindingSource;
        private Transport_Mgmt_SystemDataSet19TableAdapters.Vehicle_Daily_EntryTableAdapter vehicle_Daily_EntryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn challanNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn containerNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingPlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endingPlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn advancePayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
    }
}