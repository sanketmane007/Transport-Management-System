namespace Transport_mgmt
{
    partial class Update_Bill_Payment_Entry
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CANCEL = new System.Windows.Forms.Button();
            this.CLEAR = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Bill_No = new System.Windows.Forms.ComboBox();
            this.DOW = new System.Windows.Forms.DateTimePicker();
            this.Bank_Name = new System.Windows.Forms.TextBox();
            this.Ch_NO = new System.Windows.Forms.TextBox();
            this.Ac_No = new System.Windows.Forms.TextBox();
            this.AOC = new System.Windows.Forms.TextBox();
            this.Party_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.SEARCH = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.billNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOfCheckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfWithdrawnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transport_Mgmt_SystemDataSet4 = new Transport_mgmt.Transport_Mgmt_SystemDataSet4();
            this.refresh = new System.Windows.Forms.Button();
            this.bill_PaymentTableAdapter = new Transport_mgmt.Transport_Mgmt_SystemDataSet4TableAdapters.Bill_PaymentTableAdapter();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billPaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(715, 39);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 22);
            this.Date.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(627, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.RoyalBlue;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(309, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(283, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "Bill_Payment_Entry : ...";
            // 
            // CANCEL
            // 
            this.CANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCEL.Location = new System.Drawing.Point(578, 372);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(90, 34);
            this.CANCEL.TabIndex = 13;
            this.CANCEL.Text = "CANCEL";
            this.CANCEL.UseVisualStyleBackColor = true;
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
            // 
            // CLEAR
            // 
            this.CLEAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLEAR.Location = new System.Drawing.Point(467, 372);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(90, 34);
            this.CLEAR.TabIndex = 12;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.UseVisualStyleBackColor = true;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATE.Location = new System.Drawing.Point(354, 372);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(90, 34);
            this.UPDATE.TabIndex = 11;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Bill_No);
            this.panel1.Controls.Add(this.DOW);
            this.panel1.Controls.Add(this.Bank_Name);
            this.panel1.Controls.Add(this.Ch_NO);
            this.panel1.Controls.Add(this.Ac_No);
            this.panel1.Controls.Add(this.AOC);
            this.panel1.Controls.Add(this.Party_ID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Location = new System.Drawing.Point(21, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 263);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Bill_No
            // 
            this.Bill_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_No.FormattingEnabled = true;
            this.Bill_No.Location = new System.Drawing.Point(243, 27);
            this.Bill_No.Name = "Bill_No";
            this.Bill_No.Size = new System.Drawing.Size(121, 24);
            this.Bill_No.TabIndex = 16;
            // 
            // DOW
            // 
            this.DOW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DOW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOW.Location = new System.Drawing.Point(656, 106);
            this.DOW.Name = "DOW";
            this.DOW.Size = new System.Drawing.Size(200, 22);
            this.DOW.TabIndex = 15;
            // 
            // Bank_Name
            // 
            this.Bank_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bank_Name.Location = new System.Drawing.Point(286, 182);
            this.Bank_Name.Multiline = true;
            this.Bank_Name.Name = "Bank_Name";
            this.Bank_Name.ReadOnly = true;
            this.Bank_Name.Size = new System.Drawing.Size(199, 40);
            this.Bank_Name.TabIndex = 12;
            // 
            // Ch_NO
            // 
            this.Ch_NO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ch_NO.Location = new System.Drawing.Point(656, 68);
            this.Ch_NO.Name = "Ch_NO";
            this.Ch_NO.Size = new System.Drawing.Size(111, 22);
            this.Ch_NO.TabIndex = 11;
            this.Ch_NO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ch_NO_KeyPress);
            // 
            // Ac_No
            // 
            this.Ac_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ac_No.Location = new System.Drawing.Point(656, 28);
            this.Ac_No.Name = "Ac_No";
            this.Ac_No.ReadOnly = true;
            this.Ac_No.Size = new System.Drawing.Size(111, 22);
            this.Ac_No.TabIndex = 10;
            // 
            // AOC
            // 
            this.AOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AOC.Location = new System.Drawing.Point(252, 109);
            this.AOC.Name = "AOC";
            this.AOC.Size = new System.Drawing.Size(112, 22);
            this.AOC.TabIndex = 9;
            this.AOC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AOC_KeyPress);
            // 
            // Party_ID
            // 
            this.Party_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Party_ID.Location = new System.Drawing.Point(252, 68);
            this.Party_ID.Name = "Party_ID";
            this.Party_ID.ReadOnly = true;
            this.Party_ID.Size = new System.Drawing.Size(112, 22);
            this.Party_ID.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(94, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Bank_Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(430, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date_Of_Withdrawn :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(430, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Check_No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Account_No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount_Of_Check :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Party_ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill_No :";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(877, 259);
            this.shapeContainer1.TabIndex = 14;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 385;
            this.lineShape1.X2 = 386;
            this.lineShape1.Y1 = 35;
            this.lineShape1.Y2 = 127;
            // 
            // SEARCH
            // 
            this.SEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH.Location = new System.Drawing.Point(243, 372);
            this.SEARCH.Name = "SEARCH";
            this.SEARCH.Size = new System.Drawing.Size(90, 34);
            this.SEARCH.TabIndex = 17;
            this.SEARCH.Text = "SEARCH";
            this.SEARCH.UseVisualStyleBackColor = true;
            this.SEARCH.Click += new System.EventHandler(this.SEARCH_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billNoDataGridViewTextBoxColumn,
            this.partyIDDataGridViewTextBoxColumn,
            this.amountOfCheckDataGridViewTextBoxColumn,
            this.accountNoDataGridViewTextBoxColumn,
            this.checkNoDataGridViewTextBoxColumn,
            this.dateOfWithdrawnDataGridViewTextBoxColumn,
            this.bankNameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.billPaymentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(183, 413);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(582, 155);
            this.dataGridView1.TabIndex = 18;
            // 
            // billNoDataGridViewTextBoxColumn
            // 
            this.billNoDataGridViewTextBoxColumn.DataPropertyName = "Bill_No";
            this.billNoDataGridViewTextBoxColumn.HeaderText = "Bill_No";
            this.billNoDataGridViewTextBoxColumn.Name = "billNoDataGridViewTextBoxColumn";
            // 
            // partyIDDataGridViewTextBoxColumn
            // 
            this.partyIDDataGridViewTextBoxColumn.DataPropertyName = "Party_ID";
            this.partyIDDataGridViewTextBoxColumn.HeaderText = "Party_ID";
            this.partyIDDataGridViewTextBoxColumn.Name = "partyIDDataGridViewTextBoxColumn";
            // 
            // amountOfCheckDataGridViewTextBoxColumn
            // 
            this.amountOfCheckDataGridViewTextBoxColumn.DataPropertyName = "Amount_Of_Check";
            this.amountOfCheckDataGridViewTextBoxColumn.HeaderText = "Amount_Of_Check";
            this.amountOfCheckDataGridViewTextBoxColumn.Name = "amountOfCheckDataGridViewTextBoxColumn";
            // 
            // accountNoDataGridViewTextBoxColumn
            // 
            this.accountNoDataGridViewTextBoxColumn.DataPropertyName = "Account_No";
            this.accountNoDataGridViewTextBoxColumn.HeaderText = "Account_No";
            this.accountNoDataGridViewTextBoxColumn.Name = "accountNoDataGridViewTextBoxColumn";
            // 
            // checkNoDataGridViewTextBoxColumn
            // 
            this.checkNoDataGridViewTextBoxColumn.DataPropertyName = "Check_No";
            this.checkNoDataGridViewTextBoxColumn.HeaderText = "Check_No";
            this.checkNoDataGridViewTextBoxColumn.Name = "checkNoDataGridViewTextBoxColumn";
            // 
            // dateOfWithdrawnDataGridViewTextBoxColumn
            // 
            this.dateOfWithdrawnDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Withdrawn";
            this.dateOfWithdrawnDataGridViewTextBoxColumn.HeaderText = "Date_Of_Withdrawn";
            this.dateOfWithdrawnDataGridViewTextBoxColumn.Name = "dateOfWithdrawnDataGridViewTextBoxColumn";
            // 
            // bankNameDataGridViewTextBoxColumn
            // 
            this.bankNameDataGridViewTextBoxColumn.DataPropertyName = "Bank_Name";
            this.bankNameDataGridViewTextBoxColumn.HeaderText = "Bank_Name";
            this.bankNameDataGridViewTextBoxColumn.Name = "bankNameDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // billPaymentBindingSource
            // 
            this.billPaymentBindingSource.DataMember = "Bill_Payment";
            this.billPaymentBindingSource.DataSource = this.transport_Mgmt_SystemDataSet4;
            // 
            // transport_Mgmt_SystemDataSet4
            // 
            this.transport_Mgmt_SystemDataSet4.DataSetName = "Transport_Mgmt_SystemDataSet4";
            this.transport_Mgmt_SystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.refresh.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.Black;
            this.refresh.Location = new System.Drawing.Point(92, 414);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(85, 29);
            this.refresh.TabIndex = 106;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // bill_PaymentTableAdapter
            // 
            this.bill_PaymentTableAdapter.ClearBeforeFill = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(21, 338);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(533, 21);
            this.label17.TabIndex = 107;
            this.label17.Text = "Note :-You can changes only Amount_Of_Check and Check_No.";
            // 
            // Update_Bill_Payment_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(992, 611);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SEARCH);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Update_Bill_Payment_Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_Bill_Payment_Entry";
            this.Load += new System.EventHandler(this.Update_Bill_Payment_Entry_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billPaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker DOW;
        private System.Windows.Forms.TextBox Bank_Name;
        private System.Windows.Forms.TextBox Ch_NO;
        private System.Windows.Forms.TextBox Ac_No;
        private System.Windows.Forms.TextBox AOC;
        private System.Windows.Forms.TextBox Party_ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button SEARCH;
        private System.Windows.Forms.ComboBox Bill_No;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button refresh;
        private Transport_Mgmt_SystemDataSet4 transport_Mgmt_SystemDataSet4;
        private System.Windows.Forms.BindingSource billPaymentBindingSource;
        private Transport_Mgmt_SystemDataSet4TableAdapters.Bill_PaymentTableAdapter bill_PaymentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn billNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOfCheckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfWithdrawnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label17;
    }
}