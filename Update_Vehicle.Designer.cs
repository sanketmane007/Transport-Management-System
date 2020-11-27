namespace Transport_mgmt
{
    partial class Update_Vehicle
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
            this.SEARCH = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Route = new System.Windows.Forms.TextBox();
            this.Conductor_Name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Driver_Name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Vehicle_ID = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Permit_No = new System.Windows.Forms.TextBox();
            this.Model_No = new System.Windows.Forms.TextBox();
            this.Engine_No = new System.Windows.Forms.TextBox();
            this.Chasis_No = new System.Windows.Forms.TextBox();
            this.Trailer_No = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.UPDATE = new System.Windows.Forms.Button();
            this.CLEAR = new System.Windows.Forms.Button();
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
            this.transport_Mgmt_SystemDataSet8 = new Transport_mgmt.Transport_Mgmt_SystemDataSet8();
            this.refresh = new System.Windows.Forms.Button();
            this.vEHICLETableAdapter = new Transport_mgmt.Transport_Mgmt_SystemDataSet8TableAdapters.VEHICLETableAdapter();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // SEARCH
            // 
            this.SEARCH.BackColor = System.Drawing.Color.LightYellow;
            this.SEARCH.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH.Location = new System.Drawing.Point(193, 436);
            this.SEARCH.Name = "SEARCH";
            this.SEARCH.Size = new System.Drawing.Size(92, 31);
            this.SEARCH.TabIndex = 10;
            this.SEARCH.Text = "SEARCH";
            this.SEARCH.UseVisualStyleBackColor = false;
            this.SEARCH.Click += new System.EventHandler(this.SEARCH_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Route);
            this.panel2.Controls.Add(this.Conductor_Name);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Driver_Name);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(424, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 233);
            this.panel2.TabIndex = 9;
            // 
            // Route
            // 
            this.Route.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Route.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Route.Location = new System.Drawing.Point(224, 158);
            this.Route.Name = "Route";
            this.Route.Size = new System.Drawing.Size(100, 22);
            this.Route.TabIndex = 8;
            this.Route.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Route_KeyPress);
            // 
            // Conductor_Name
            // 
            this.Conductor_Name.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Conductor_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conductor_Name.Location = new System.Drawing.Point(224, 105);
            this.Conductor_Name.Name = "Conductor_Name";
            this.Conductor_Name.Size = new System.Drawing.Size(100, 22);
            this.Conductor_Name.TabIndex = 10;
            this.Conductor_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Conductor_Name_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Route :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Conductor_Name :";
            // 
            // Driver_Name
            // 
            this.Driver_Name.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Driver_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Driver_Name.Location = new System.Drawing.Point(224, 50);
            this.Driver_Name.Name = "Driver_Name";
            this.Driver_Name.Size = new System.Drawing.Size(100, 22);
            this.Driver_Name.TabIndex = 8;
            this.Driver_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Driver_Name_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Driver_Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vehicle_INFO-:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Vehicle_ID);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Permit_No);
            this.panel1.Controls.Add(this.Model_No);
            this.panel1.Controls.Add(this.Engine_No);
            this.panel1.Controls.Add(this.Chasis_No);
            this.panel1.Controls.Add(this.Trailer_No);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(48, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 307);
            this.panel1.TabIndex = 7;
            // 
            // Vehicle_ID
            // 
            this.Vehicle_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehicle_ID.FormattingEnabled = true;
            this.Vehicle_ID.Location = new System.Drawing.Point(221, 34);
            this.Vehicle_ID.Name = "Vehicle_ID";
            this.Vehicle_ID.Size = new System.Drawing.Size(121, 24);
            this.Vehicle_ID.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "Vehicle_ID :";
            // 
            // Permit_No
            // 
            this.Permit_No.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Permit_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Permit_No.Location = new System.Drawing.Point(221, 245);
            this.Permit_No.Name = "Permit_No";
            this.Permit_No.ReadOnly = true;
            this.Permit_No.Size = new System.Drawing.Size(113, 22);
            this.Permit_No.TabIndex = 10;
            // 
            // Model_No
            // 
            this.Model_No.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Model_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Model_No.Location = new System.Drawing.Point(221, 203);
            this.Model_No.Name = "Model_No";
            this.Model_No.ReadOnly = true;
            this.Model_No.Size = new System.Drawing.Size(113, 22);
            this.Model_No.TabIndex = 9;
            // 
            // Engine_No
            // 
            this.Engine_No.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Engine_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Engine_No.Location = new System.Drawing.Point(221, 161);
            this.Engine_No.Name = "Engine_No";
            this.Engine_No.ReadOnly = true;
            this.Engine_No.Size = new System.Drawing.Size(113, 22);
            this.Engine_No.TabIndex = 8;
            // 
            // Chasis_No
            // 
            this.Chasis_No.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Chasis_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chasis_No.Location = new System.Drawing.Point(221, 117);
            this.Chasis_No.Name = "Chasis_No";
            this.Chasis_No.ReadOnly = true;
            this.Chasis_No.Size = new System.Drawing.Size(113, 22);
            this.Chasis_No.TabIndex = 7;
            // 
            // Trailer_No
            // 
            this.Trailer_No.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Trailer_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trailer_No.Location = new System.Drawing.Point(221, 73);
            this.Trailer_No.Name = "Trailer_No";
            this.Trailer_No.ReadOnly = true;
            this.Trailer_No.Size = new System.Drawing.Size(113, 22);
            this.Trailer_No.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Permit_No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Model_No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Engine_No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chasis_No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trailer_No :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(292, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(289, 32);
            this.label11.TabIndex = 15;
            this.label11.Text = "Vehicle_INFO Form ..-:";
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(612, 90);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(147, 22);
            this.Date.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LemonChiffon;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(525, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Date :-";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(854, 624);
            this.shapeContainer1.TabIndex = 18;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 789;
            this.lineShape3.X2 = 791;
            this.lineShape3.Y1 = 139;
            this.lineShape3.Y2 = 341;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 416;
            this.lineShape2.X2 = 417;
            this.lineShape2.Y1 = 103;
            this.lineShape2.Y2 = 387;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 37;
            this.lineShape1.X2 = 38;
            this.lineShape1.Y1 = 101;
            this.lineShape1.Y2 = 385;
            // 
            // UPDATE
            // 
            this.UPDATE.BackColor = System.Drawing.Color.LightYellow;
            this.UPDATE.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATE.Location = new System.Drawing.Point(317, 436);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(92, 31);
            this.UPDATE.TabIndex = 19;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = false;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // CLEAR
            // 
            this.CLEAR.BackColor = System.Drawing.Color.LightYellow;
            this.CLEAR.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLEAR.Location = new System.Drawing.Point(438, 436);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(92, 31);
            this.CLEAR.TabIndex = 20;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.UseVisualStyleBackColor = false;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // CANCEL
            // 
            this.CANCEL.BackColor = System.Drawing.Color.LightYellow;
            this.CANCEL.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCEL.Location = new System.Drawing.Point(561, 436);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(92, 31);
            this.CANCEL.TabIndex = 21;
            this.CANCEL.Text = "CANCEL";
            this.CANCEL.UseVisualStyleBackColor = false;
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
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
            this.dataGridView1.DataSource = this.vEHICLEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(193, 473);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(526, 139);
            this.dataGridView1.TabIndex = 22;
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_ID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "Vehicle_ID";
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            // 
            // trailerNoDataGridViewTextBoxColumn
            // 
            this.trailerNoDataGridViewTextBoxColumn.DataPropertyName = "Trailer_No";
            this.trailerNoDataGridViewTextBoxColumn.HeaderText = "Trailer_No";
            this.trailerNoDataGridViewTextBoxColumn.Name = "trailerNoDataGridViewTextBoxColumn";
            // 
            // chasisNoDataGridViewTextBoxColumn
            // 
            this.chasisNoDataGridViewTextBoxColumn.DataPropertyName = "Chasis_No";
            this.chasisNoDataGridViewTextBoxColumn.HeaderText = "Chasis_No";
            this.chasisNoDataGridViewTextBoxColumn.Name = "chasisNoDataGridViewTextBoxColumn";
            // 
            // engineNoDataGridViewTextBoxColumn
            // 
            this.engineNoDataGridViewTextBoxColumn.DataPropertyName = "Engine_No";
            this.engineNoDataGridViewTextBoxColumn.HeaderText = "Engine_No";
            this.engineNoDataGridViewTextBoxColumn.Name = "engineNoDataGridViewTextBoxColumn";
            // 
            // modelNoDataGridViewTextBoxColumn
            // 
            this.modelNoDataGridViewTextBoxColumn.DataPropertyName = "Model_No";
            this.modelNoDataGridViewTextBoxColumn.HeaderText = "Model_No";
            this.modelNoDataGridViewTextBoxColumn.Name = "modelNoDataGridViewTextBoxColumn";
            // 
            // permitNoDataGridViewTextBoxColumn
            // 
            this.permitNoDataGridViewTextBoxColumn.DataPropertyName = "Permit_No";
            this.permitNoDataGridViewTextBoxColumn.HeaderText = "Permit_No";
            this.permitNoDataGridViewTextBoxColumn.Name = "permitNoDataGridViewTextBoxColumn";
            // 
            // driverNameDataGridViewTextBoxColumn
            // 
            this.driverNameDataGridViewTextBoxColumn.DataPropertyName = "Driver_Name";
            this.driverNameDataGridViewTextBoxColumn.HeaderText = "Driver_Name";
            this.driverNameDataGridViewTextBoxColumn.Name = "driverNameDataGridViewTextBoxColumn";
            // 
            // conductorNameDataGridViewTextBoxColumn
            // 
            this.conductorNameDataGridViewTextBoxColumn.DataPropertyName = "Conductor_Name";
            this.conductorNameDataGridViewTextBoxColumn.HeaderText = "Conductor_Name";
            this.conductorNameDataGridViewTextBoxColumn.Name = "conductorNameDataGridViewTextBoxColumn";
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
            // vEHICLEBindingSource
            // 
            this.vEHICLEBindingSource.DataMember = "VEHICLE";
            this.vEHICLEBindingSource.DataSource = this.transport_Mgmt_SystemDataSet8;
            // 
            // transport_Mgmt_SystemDataSet8
            // 
            this.transport_Mgmt_SystemDataSet8.DataSetName = "Transport_Mgmt_SystemDataSet8";
            this.transport_Mgmt_SystemDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.refresh.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.Black;
            this.refresh.Location = new System.Drawing.Point(102, 473);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(85, 29);
            this.refresh.TabIndex = 110;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // vEHICLETableAdapter
            // 
            this.vEHICLETableAdapter.ClearBeforeFill = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(48, 404);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(603, 21);
            this.label17.TabIndex = 111;
            this.label17.Text = "Note :-You can changes only Driver_Name,Conductor_Name and Route.";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // Update_Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 624);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SEARCH);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Update_Vehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit_Vehicle";
            this.Load += new System.EventHandler(this.Update_Vehicle_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SEARCH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Route;
        private System.Windows.Forms.TextBox Conductor_Name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Driver_Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Permit_No;
        private System.Windows.Forms.TextBox Model_No;
        private System.Windows.Forms.TextBox Engine_No;
        private System.Windows.Forms.TextBox Chasis_No;
        private System.Windows.Forms.TextBox Trailer_No;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label label12;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.ComboBox Vehicle_ID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button refresh;
        private Transport_Mgmt_SystemDataSet8 transport_Mgmt_SystemDataSet8;
        private System.Windows.Forms.BindingSource vEHICLEBindingSource;
        private Transport_Mgmt_SystemDataSet8TableAdapters.VEHICLETableAdapter vEHICLETableAdapter;
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
        private System.Windows.Forms.Label label17;

    }
}