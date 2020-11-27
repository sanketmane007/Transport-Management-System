namespace Transport_mgmt
{
    partial class Delete_Vehicle_Daily_Entry
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
            this.Entry_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.transport_Mgmt_SystemDataSet28 = new Transport_mgmt.Transport_Mgmt_SystemDataSet28();
            this.vehicleDailyEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicle_Daily_EntryTableAdapter = new Transport_mgmt.Transport_Mgmt_SystemDataSet28TableAdapters.Vehicle_Daily_EntryTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDailyEntryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DATA_VIEW
            // 
            this.DATA_VIEW.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DATA_VIEW.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATA_VIEW.Location = new System.Drawing.Point(360, 272);
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
            this.CANCEL.Location = new System.Drawing.Point(550, 195);
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
            this.CLEAR.Location = new System.Drawing.Point(618, 143);
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
            this.DELETE.Location = new System.Drawing.Point(488, 143);
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
            this.dataGridView1.DataSource = this.vehicleDailyEntryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(84, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(732, 155);
            this.dataGridView1.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Vehicle_ID);
            this.groupBox1.Controls.Add(this.Entry_ID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(72, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 149);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details__:";
            // 
            // Vehicle_ID
            // 
            this.Vehicle_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehicle_ID.Location = new System.Drawing.Point(216, 86);
            this.Vehicle_ID.Name = "Vehicle_ID";
            this.Vehicle_ID.Size = new System.Drawing.Size(100, 22);
            this.Vehicle_ID.TabIndex = 3;
            this.Vehicle_ID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Vehicle_ID_MouseClick_1);
            // 
            // Entry_ID
            // 
            this.Entry_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entry_ID.Location = new System.Drawing.Point(216, 38);
            this.Entry_ID.Name = "Entry_ID";
            this.Entry_ID.Size = new System.Drawing.Size(100, 22);
            this.Entry_ID.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entry_ID :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(274, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(356, 32);
            this.label17.TabIndex = 31;
            this.label17.Text = "Vehicle_Daily_Entry Form ... :";
            // 
            // transport_Mgmt_SystemDataSet28
            // 
            this.transport_Mgmt_SystemDataSet28.DataSetName = "Transport_Mgmt_SystemDataSet28";
            this.transport_Mgmt_SystemDataSet28.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleDailyEntryBindingSource
            // 
            this.vehicleDailyEntryBindingSource.DataMember = "Vehicle_Daily_Entry";
            this.vehicleDailyEntryBindingSource.DataSource = this.transport_Mgmt_SystemDataSet28;
            // 
            // vehicle_Daily_EntryTableAdapter
            // 
            this.vehicle_Daily_EntryTableAdapter.ClearBeforeFill = true;
            // 
            // entryIDDataGridViewTextBoxColumn
            // 
            this.entryIDDataGridViewTextBoxColumn.DataPropertyName = "Entry_ID";
            this.entryIDDataGridViewTextBoxColumn.HeaderText = "Entry_ID";
            this.entryIDDataGridViewTextBoxColumn.Name = "entryIDDataGridViewTextBoxColumn";
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_ID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "Vehicle_ID";
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            // 
            // challanNoDataGridViewTextBoxColumn
            // 
            this.challanNoDataGridViewTextBoxColumn.DataPropertyName = "Challan_No";
            this.challanNoDataGridViewTextBoxColumn.HeaderText = "Challan_No";
            this.challanNoDataGridViewTextBoxColumn.Name = "challanNoDataGridViewTextBoxColumn";
            // 
            // containerNoDataGridViewTextBoxColumn
            // 
            this.containerNoDataGridViewTextBoxColumn.DataPropertyName = "Container_No";
            this.containerNoDataGridViewTextBoxColumn.HeaderText = "Container_No";
            this.containerNoDataGridViewTextBoxColumn.Name = "containerNoDataGridViewTextBoxColumn";
            // 
            // partyIDDataGridViewTextBoxColumn
            // 
            this.partyIDDataGridViewTextBoxColumn.DataPropertyName = "Party_ID";
            this.partyIDDataGridViewTextBoxColumn.HeaderText = "Party_ID";
            this.partyIDDataGridViewTextBoxColumn.Name = "partyIDDataGridViewTextBoxColumn";
            // 
            // routeDataGridViewTextBoxColumn
            // 
            this.routeDataGridViewTextBoxColumn.DataPropertyName = "Route";
            this.routeDataGridViewTextBoxColumn.HeaderText = "Route";
            this.routeDataGridViewTextBoxColumn.Name = "routeDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // startingPlaceDataGridViewTextBoxColumn
            // 
            this.startingPlaceDataGridViewTextBoxColumn.DataPropertyName = "Starting_Place";
            this.startingPlaceDataGridViewTextBoxColumn.HeaderText = "Starting_Place";
            this.startingPlaceDataGridViewTextBoxColumn.Name = "startingPlaceDataGridViewTextBoxColumn";
            // 
            // endingPlaceDataGridViewTextBoxColumn
            // 
            this.endingPlaceDataGridViewTextBoxColumn.DataPropertyName = "Ending_Place";
            this.endingPlaceDataGridViewTextBoxColumn.HeaderText = "Ending_Place";
            this.endingPlaceDataGridViewTextBoxColumn.Name = "endingPlaceDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // advancePayDataGridViewTextBoxColumn
            // 
            this.advancePayDataGridViewTextBoxColumn.DataPropertyName = "Advance_Pay";
            this.advancePayDataGridViewTextBoxColumn.HeaderText = "Advance_Pay";
            this.advancePayDataGridViewTextBoxColumn.Name = "advancePayDataGridViewTextBoxColumn";
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            // 
            // Delete_Vehicle_Daily_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(865, 481);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.DATA_VIEW);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Delete_Vehicle_Daily_Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete_Vehicle_Daily_Entry";
            this.Load += new System.EventHandler(this.Delete_Vehicle_Daily_Entry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDailyEntryBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Vehicle_ID;
        private System.Windows.Forms.TextBox Entry_ID;
        private Transport_Mgmt_SystemDataSet28 transport_Mgmt_SystemDataSet28;
        private System.Windows.Forms.BindingSource vehicleDailyEntryBindingSource;
        private Transport_Mgmt_SystemDataSet28TableAdapters.Vehicle_Daily_EntryTableAdapter vehicle_Daily_EntryTableAdapter;
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