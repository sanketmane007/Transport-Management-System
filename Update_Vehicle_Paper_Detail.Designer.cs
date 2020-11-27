namespace Transport_mgmt
{
    partial class Update_Vehicle_Paper_Detail
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
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CANCEL = new System.Windows.Forms.Button();
            this.CLEAR = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Vehicle_ID = new System.Windows.Forms.ComboBox();
            this.Permit_Type = new System.Windows.Forms.TextBox();
            this.Permit_Date = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Tax_Date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.Fitness_Date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.PUC_Date = new System.Windows.Forms.DateTimePicker();
            this.Insurance_Date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Vehicle_No = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SEARCH = new System.Windows.Forms.Button();
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
            this.transport_Mgmt_SystemDataSet11 = new Transport_mgmt.Transport_Mgmt_SystemDataSet11();
            this.refresh = new System.Windows.Forms.Button();
            this.vEHICLE_PAPERTableAdapter = new Transport_mgmt.Transport_Mgmt_SystemDataSet11TableAdapters.VEHICLE_PAPERTableAdapter();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEPAPERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(723, 76);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(192, 22);
            this.Date.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(636, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 21);
            this.label11.TabIndex = 31;
            this.label11.Text = "Date :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(289, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(366, 32);
            this.label10.TabIndex = 30;
            this.label10.Text = "Vehicle_Paper_Detail_Form... :";
            // 
            // CANCEL
            // 
            this.CANCEL.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCEL.Location = new System.Drawing.Point(723, 398);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(101, 37);
            this.CANCEL.TabIndex = 29;
            this.CANCEL.Text = "CANCEL";
            this.CANCEL.UseVisualStyleBackColor = true;
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
            // 
            // CLEAR
            // 
            this.CLEAR.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLEAR.Location = new System.Drawing.Point(723, 329);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(101, 36);
            this.CLEAR.TabIndex = 28;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.UseVisualStyleBackColor = true;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATE.Location = new System.Drawing.Point(723, 263);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(101, 36);
            this.UPDATE.TabIndex = 27;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Vehicle_ID);
            this.groupBox1.Controls.Add(this.Permit_Type);
            this.groupBox1.Controls.Add(this.Permit_Date);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Tax_Date);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Fitness_Date);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PUC_Date);
            this.groupBox1.Controls.Add(this.Insurance_Date);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Vehicle_No);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("AR JULIAN", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(54, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 446);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details...";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Vehicle_ID
            // 
            this.Vehicle_ID.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehicle_ID.FormattingEnabled = true;
            this.Vehicle_ID.Location = new System.Drawing.Point(311, 59);
            this.Vehicle_ID.Name = "Vehicle_ID";
            this.Vehicle_ID.Size = new System.Drawing.Size(121, 31);
            this.Vehicle_ID.TabIndex = 19;
            // 
            // Permit_Type
            // 
            this.Permit_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Permit_Type.Location = new System.Drawing.Point(311, 405);
            this.Permit_Type.Name = "Permit_Type";
            this.Permit_Type.ReadOnly = true;
            this.Permit_Type.Size = new System.Drawing.Size(126, 22);
            this.Permit_Type.TabIndex = 18;
            // 
            // Permit_Date
            // 
            this.Permit_Date.CalendarFont = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Permit_Date.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Permit_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Permit_Date.Location = new System.Drawing.Point(311, 355);
            this.Permit_Date.Name = "Permit_Date";
            this.Permit_Date.Size = new System.Drawing.Size(162, 22);
            this.Permit_Date.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(72, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Permit_Date :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(72, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Permit_Type :";
            // 
            // Tax_Date
            // 
            this.Tax_Date.CalendarFont = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tax_Date.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tax_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tax_Date.Location = new System.Drawing.Point(311, 307);
            this.Tax_Date.Name = "Tax_Date";
            this.Tax_Date.Size = new System.Drawing.Size(162, 22);
            this.Tax_Date.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tax_Date :";
            // 
            // Fitness_Date
            // 
            this.Fitness_Date.CalendarFont = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fitness_Date.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Fitness_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fitness_Date.Location = new System.Drawing.Point(311, 259);
            this.Fitness_Date.Name = "Fitness_Date";
            this.Fitness_Date.Size = new System.Drawing.Size(162, 22);
            this.Fitness_Date.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fitness_Date :";
            // 
            // PUC_Date
            // 
            this.PUC_Date.CalendarFont = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PUC_Date.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PUC_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PUC_Date.Location = new System.Drawing.Point(311, 212);
            this.PUC_Date.Name = "PUC_Date";
            this.PUC_Date.Size = new System.Drawing.Size(162, 22);
            this.PUC_Date.TabIndex = 10;
            // 
            // Insurance_Date
            // 
            this.Insurance_Date.CalendarFont = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insurance_Date.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Insurance_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insurance_Date.Location = new System.Drawing.Point(311, 163);
            this.Insurance_Date.Name = "Insurance_Date";
            this.Insurance_Date.Size = new System.Drawing.Size(162, 22);
            this.Insurance_Date.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "P.U.C_Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Insurance_Date :";
            // 
            // Vehicle_No
            // 
            this.Vehicle_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehicle_No.Location = new System.Drawing.Point(308, 109);
            this.Vehicle_No.Name = "Vehicle_No";
            this.Vehicle_No.ReadOnly = true;
            this.Vehicle_No.Size = new System.Drawing.Size(121, 22);
            this.Vehicle_No.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vehicle_No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle_ID :";
            // 
            // SEARCH
            // 
            this.SEARCH.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH.Location = new System.Drawing.Point(723, 176);
            this.SEARCH.Name = "SEARCH";
            this.SEARCH.Size = new System.Drawing.Size(101, 36);
            this.SEARCH.TabIndex = 33;
            this.SEARCH.Text = "SEARCH";
            this.SEARCH.UseVisualStyleBackColor = true;
            this.SEARCH.Click += new System.EventHandler(this.SEARCH_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
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
            this.dataGridView1.DataSource = this.vEHICLEPAPERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(54, 542);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 129);
            this.dataGridView1.TabIndex = 34;
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
            // insuranceDateDataGridViewTextBoxColumn
            // 
            this.insuranceDateDataGridViewTextBoxColumn.DataPropertyName = "Insurance_Date";
            this.insuranceDateDataGridViewTextBoxColumn.HeaderText = "Insurance_Date";
            this.insuranceDateDataGridViewTextBoxColumn.Name = "insuranceDateDataGridViewTextBoxColumn";
            // 
            // pUCDateDataGridViewTextBoxColumn
            // 
            this.pUCDateDataGridViewTextBoxColumn.DataPropertyName = "PUC_Date";
            this.pUCDateDataGridViewTextBoxColumn.HeaderText = "PUC_Date";
            this.pUCDateDataGridViewTextBoxColumn.Name = "pUCDateDataGridViewTextBoxColumn";
            // 
            // fitnessDateDataGridViewTextBoxColumn
            // 
            this.fitnessDateDataGridViewTextBoxColumn.DataPropertyName = "Fitness_Date";
            this.fitnessDateDataGridViewTextBoxColumn.HeaderText = "Fitness_Date";
            this.fitnessDateDataGridViewTextBoxColumn.Name = "fitnessDateDataGridViewTextBoxColumn";
            // 
            // taxDateDataGridViewTextBoxColumn
            // 
            this.taxDateDataGridViewTextBoxColumn.DataPropertyName = "Tax_Date";
            this.taxDateDataGridViewTextBoxColumn.HeaderText = "Tax_Date";
            this.taxDateDataGridViewTextBoxColumn.Name = "taxDateDataGridViewTextBoxColumn";
            // 
            // permitDateDataGridViewTextBoxColumn
            // 
            this.permitDateDataGridViewTextBoxColumn.DataPropertyName = "Permit_Date";
            this.permitDateDataGridViewTextBoxColumn.HeaderText = "Permit_Date";
            this.permitDateDataGridViewTextBoxColumn.Name = "permitDateDataGridViewTextBoxColumn";
            // 
            // permitTypeDataGridViewTextBoxColumn
            // 
            this.permitTypeDataGridViewTextBoxColumn.DataPropertyName = "Permit_Type";
            this.permitTypeDataGridViewTextBoxColumn.HeaderText = "Permit_Type";
            this.permitTypeDataGridViewTextBoxColumn.Name = "permitTypeDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // vEHICLEPAPERBindingSource
            // 
            this.vEHICLEPAPERBindingSource.DataMember = "VEHICLE_PAPER";
            this.vEHICLEPAPERBindingSource.DataSource = this.transport_Mgmt_SystemDataSet11;
            // 
            // transport_Mgmt_SystemDataSet11
            // 
            this.transport_Mgmt_SystemDataSet11.DataSetName = "Transport_Mgmt_SystemDataSet11";
            this.transport_Mgmt_SystemDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.refresh.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.Black;
            this.refresh.Location = new System.Drawing.Point(597, 542);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(85, 29);
            this.refresh.TabIndex = 110;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // vEHICLE_PAPERTableAdapter
            // 
            this.vEHICLE_PAPERTableAdapter.ClearBeforeFill = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(649, 480);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(313, 21);
            this.label17.TabIndex = 112;
            this.label17.Text = "Note :-You can changes only Dates.";
            // 
            // Update_Vehicle_Paper_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(983, 683);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SEARCH);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Update_Vehicle_Paper_Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Edit_Vehicle_Paper_Detail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEPAPERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Permit_Type;
        private System.Windows.Forms.DateTimePicker Permit_Date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker Tax_Date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Fitness_Date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker PUC_Date;
        private System.Windows.Forms.DateTimePicker Insurance_Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Vehicle_No;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SEARCH;
        private System.Windows.Forms.ComboBox Vehicle_ID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button refresh;
        private Transport_Mgmt_SystemDataSet11 transport_Mgmt_SystemDataSet11;
        private System.Windows.Forms.BindingSource vEHICLEPAPERBindingSource;
        private Transport_Mgmt_SystemDataSet11TableAdapters.VEHICLE_PAPERTableAdapter vEHICLE_PAPERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insuranceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUCDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fitnessDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permitTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label17;
    }
}