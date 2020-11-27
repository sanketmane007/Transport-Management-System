namespace Transport_mgmt
{
    partial class Update_Voucher_Entry
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
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.Voucher_Date = new System.Windows.Forms.DateTimePicker();
            this.Description = new System.Windows.Forms.TextBox();
            this.Voucher_No = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Emp_ID = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.TextBox();
            this.Voucher_Name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SEARCH = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.CLEAR = new System.Windows.Forms.Button();
            this.CANCEL = new System.Windows.Forms.Button();
            this.Voucher_ID = new System.Windows.Forms.ComboBox();
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
            this.transport_Mgmt_SystemDataSet12 = new Transport_mgmt.Transport_Mgmt_SystemDataSet12();
            this.refresh = new System.Windows.Forms.Button();
            this.vOUCHERTableAdapter = new Transport_mgmt.Transport_Mgmt_SystemDataSet12TableAdapters.VOUCHERTableAdapter();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOUCHERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 27;
            this.lineShape2.X2 = 29;
            this.lineShape2.Y1 = 141;
            this.lineShape2.Y2 = 318;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 469;
            this.lineShape1.X2 = 471;
            this.lineShape1.Y1 = 149;
            this.lineShape1.Y2 = 326;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape1,
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(902, 554);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 273;
            this.lineShape4.X2 = 604;
            this.lineShape4.Y1 = 80;
            this.lineShape4.Y2 = 79;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 843;
            this.lineShape3.X2 = 845;
            this.lineShape3.Y1 = 138;
            this.lineShape3.Y2 = 315;
            this.lineShape3.Click += new System.EventHandler(this.lineShape3_Click);
            // 
            // Voucher_Date
            // 
            this.Voucher_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voucher_Date.Location = new System.Drawing.Point(255, 232);
            this.Voucher_Date.Name = "Voucher_Date";
            this.Voucher_Date.Size = new System.Drawing.Size(140, 22);
            this.Voucher_Date.TabIndex = 30;
            // 
            // Description
            // 
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(255, 279);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(207, 49);
            this.Description.TabIndex = 29;
            this.Description.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Description_KeyPress);
            // 
            // Voucher_No
            // 
            this.Voucher_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voucher_No.Location = new System.Drawing.Point(255, 185);
            this.Voucher_No.Name = "Voucher_No";
            this.Voucher_No.ReadOnly = true;
            this.Voucher_No.Size = new System.Drawing.Size(119, 22);
            this.Voucher_No.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Voucher_Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Voucher_No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Voucher_ID :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LemonChiffon;
            this.label9.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(262, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(376, 30);
            this.label9.TabIndex = 39;
            this.label9.Text = "Update_Voucher_Entry_Form... :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(586, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 21);
            this.label8.TabIndex = 38;
            this.label8.Text = "Date :";
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(674, 102);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(144, 22);
            this.Date.TabIndex = 37;
            // 
            // Emp_ID
            // 
            this.Emp_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_ID.Location = new System.Drawing.Point(668, 255);
            this.Emp_ID.Name = "Emp_ID";
            this.Emp_ID.ReadOnly = true;
            this.Emp_ID.Size = new System.Drawing.Size(122, 22);
            this.Emp_ID.TabIndex = 36;
            // 
            // Amount
            // 
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(668, 211);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(122, 22);
            this.Amount.TabIndex = 35;
            // 
            // Voucher_Name
            // 
            this.Voucher_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voucher_Name.Location = new System.Drawing.Point(668, 164);
            this.Voucher_Name.Name = "Voucher_Name";
            this.Voucher_Name.ReadOnly = true;
            this.Voucher_Name.Size = new System.Drawing.Size(122, 22);
            this.Voucher_Name.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(538, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 21);
            this.label7.TabIndex = 33;
            this.label7.Text = "Emp_ID :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(538, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "Amount :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(538, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 31;
            this.label5.Text = "Name :";
            // 
            // SEARCH
            // 
            this.SEARCH.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH.Location = new System.Drawing.Point(227, 391);
            this.SEARCH.Name = "SEARCH";
            this.SEARCH.Size = new System.Drawing.Size(83, 32);
            this.SEARCH.TabIndex = 40;
            this.SEARCH.Text = "SEARCH";
            this.SEARCH.UseVisualStyleBackColor = true;
            this.SEARCH.Click += new System.EventHandler(this.SEARCH_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATE.Location = new System.Drawing.Point(362, 391);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(83, 32);
            this.UPDATE.TabIndex = 41;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // CLEAR
            // 
            this.CLEAR.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLEAR.Location = new System.Drawing.Point(485, 391);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(83, 32);
            this.CLEAR.TabIndex = 42;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.UseVisualStyleBackColor = true;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // CANCEL
            // 
            this.CANCEL.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCEL.Location = new System.Drawing.Point(616, 391);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(83, 32);
            this.CANCEL.TabIndex = 43;
            this.CANCEL.Text = "CANCEL";
            this.CANCEL.UseVisualStyleBackColor = true;
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
            // 
            // Voucher_ID
            // 
            this.Voucher_ID.FormattingEnabled = true;
            this.Voucher_ID.Location = new System.Drawing.Point(255, 138);
            this.Voucher_ID.Name = "Voucher_ID";
            this.Voucher_ID.Size = new System.Drawing.Size(121, 21);
            this.Voucher_ID.TabIndex = 44;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
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
            this.dataGridView1.DataSource = this.vOUCHERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(223, 432);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 110);
            this.dataGridView1.TabIndex = 45;
            // 
            // voucherIDDataGridViewTextBoxColumn
            // 
            this.voucherIDDataGridViewTextBoxColumn.DataPropertyName = "Voucher_ID";
            this.voucherIDDataGridViewTextBoxColumn.HeaderText = "Voucher_ID";
            this.voucherIDDataGridViewTextBoxColumn.Name = "voucherIDDataGridViewTextBoxColumn";
            // 
            // voucherNoDataGridViewTextBoxColumn
            // 
            this.voucherNoDataGridViewTextBoxColumn.DataPropertyName = "Voucher_No";
            this.voucherNoDataGridViewTextBoxColumn.HeaderText = "Voucher_No";
            this.voucherNoDataGridViewTextBoxColumn.Name = "voucherNoDataGridViewTextBoxColumn";
            // 
            // voucherDateDataGridViewTextBoxColumn
            // 
            this.voucherDateDataGridViewTextBoxColumn.DataPropertyName = "Voucher_Date";
            this.voucherDateDataGridViewTextBoxColumn.HeaderText = "Voucher_Date";
            this.voucherDateDataGridViewTextBoxColumn.Name = "voucherDateDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // voucherNameDataGridViewTextBoxColumn
            // 
            this.voucherNameDataGridViewTextBoxColumn.DataPropertyName = "Voucher_Name";
            this.voucherNameDataGridViewTextBoxColumn.HeaderText = "Voucher_Name";
            this.voucherNameDataGridViewTextBoxColumn.Name = "voucherNameDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // vOUCHERBindingSource
            // 
            this.vOUCHERBindingSource.DataMember = "VOUCHER";
            this.vOUCHERBindingSource.DataSource = this.transport_Mgmt_SystemDataSet12;
            // 
            // transport_Mgmt_SystemDataSet12
            // 
            this.transport_Mgmt_SystemDataSet12.DataSetName = "Transport_Mgmt_SystemDataSet12";
            this.transport_Mgmt_SystemDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.refresh.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.Black;
            this.refresh.Location = new System.Drawing.Point(135, 435);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(85, 29);
            this.refresh.TabIndex = 110;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // vOUCHERTableAdapter
            // 
            this.vOUCHERTableAdapter.ClearBeforeFill = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(34, 359);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(584, 21);
            this.label17.TabIndex = 112;
            this.label17.Text = "Note :-You can changes only Voucher_Date,description and Amount.";
            // 
            // Update_Voucher_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(902, 554);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Voucher_ID);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.SEARCH);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Emp_ID);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.Voucher_Name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Voucher_Date);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Voucher_No);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Update_Voucher_Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit_Voucher_Entry";
            this.Load += new System.EventHandler(this.Update_Voucher_Entry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOUCHERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.DateTimePicker Voucher_Date;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.TextBox Voucher_No;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.TextBox Emp_ID;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.TextBox Voucher_Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private System.Windows.Forms.Button SEARCH;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.ComboBox Voucher_ID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button refresh;
        private Transport_Mgmt_SystemDataSet12 transport_Mgmt_SystemDataSet12;
        private System.Windows.Forms.BindingSource vOUCHERBindingSource;
        private Transport_Mgmt_SystemDataSet12TableAdapters.VOUCHERTableAdapter vOUCHERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label17;
    }
}