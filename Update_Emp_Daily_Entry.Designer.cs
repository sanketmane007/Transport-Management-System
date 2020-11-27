namespace Transport_mgmt
{
    partial class Update_Emp_Daily_Entry
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
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OUT_Time = new System.Windows.Forms.DateTimePicker();
            this.IN_Time = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Emp_ID = new System.Windows.Forms.ComboBox();
            this.Today_Date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Emp_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Entry_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CANCEL = new System.Windows.Forms.Button();
            this.CLEAR = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.refresh = new System.Windows.Forms.Button();
            this.SEARCH = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.NavajoWhite;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(237, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(293, 28);
            this.label14.TabIndex = 16;
            this.label14.Text = "Emp_Daily_Entry_Form : ..-";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.OUT_Time);
            this.panel1.Controls.Add(this.IN_Time);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Emp_ID);
            this.panel1.Controls.Add(this.Today_Date);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Emp_Name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Entry_ID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(62, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 268);
            this.panel1.TabIndex = 15;
            // 
            // OUT_Time
            // 
            this.OUT_Time.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OUT_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.OUT_Time.Location = new System.Drawing.Point(582, 124);
            this.OUT_Time.Name = "OUT_Time";
            this.OUT_Time.Size = new System.Drawing.Size(100, 20);
            this.OUT_Time.TabIndex = 60;
            // 
            // IN_Time
            // 
            this.IN_Time.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IN_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.IN_Time.Location = new System.Drawing.Point(582, 68);
            this.IN_Time.Name = "IN_Time";
            this.IN_Time.Size = new System.Drawing.Size(100, 20);
            this.IN_Time.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(425, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 21);
            this.label6.TabIndex = 58;
            this.label6.Text = "OUT_Time :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 57;
            this.label5.Text = "IN_Time :";
            // 
            // Emp_ID
            // 
            this.Emp_ID.FormattingEnabled = true;
            this.Emp_ID.Location = new System.Drawing.Point(222, 99);
            this.Emp_ID.Name = "Emp_ID";
            this.Emp_ID.Size = new System.Drawing.Size(121, 21);
            this.Emp_ID.TabIndex = 56;
            // 
            // Today_Date
            // 
            this.Today_Date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Today_Date.Location = new System.Drawing.Point(219, 221);
            this.Today_Date.Name = "Today_Date";
            this.Today_Date.Size = new System.Drawing.Size(160, 20);
            this.Today_Date.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 47;
            this.label3.Text = "Today_Date :";
            // 
            // Emp_Name
            // 
            this.Emp_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Emp_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_Name.Location = new System.Drawing.Point(222, 158);
            this.Emp_Name.Name = "Emp_Name";
            this.Emp_Name.Size = new System.Drawing.Size(100, 22);
            this.Emp_Name.TabIndex = 46;
            this.Emp_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Emp_Name_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 45;
            this.label2.Text = "Emp_Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 43;
            this.label1.Text = "Emp_ID :";
            // 
            // Entry_ID
            // 
            this.Entry_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Entry_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entry_ID.Location = new System.Drawing.Point(222, 40);
            this.Entry_ID.Name = "Entry_ID";
            this.Entry_ID.Size = new System.Drawing.Size(100, 22);
            this.Entry_ID.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 41;
            this.label4.Text = "Entry_ID :";
            // 
            // CANCEL
            // 
            this.CANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCEL.Location = new System.Drawing.Point(537, 381);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(90, 33);
            this.CANCEL.TabIndex = 58;
            this.CANCEL.Text = "CANCEL";
            this.CANCEL.UseVisualStyleBackColor = true;
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
            // 
            // CLEAR
            // 
            this.CLEAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLEAR.Location = new System.Drawing.Point(410, 381);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(90, 33);
            this.CLEAR.TabIndex = 57;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.UseVisualStyleBackColor = true;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATE.Location = new System.Drawing.Point(286, 381);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(90, 33);
            this.UPDATE.TabIndex = 56;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(142, 419);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(515, 150);
            this.dataGridView1.TabIndex = 59;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.refresh.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.Black;
            this.refresh.Location = new System.Drawing.Point(51, 423);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(85, 29);
            this.refresh.TabIndex = 108;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            // 
            // SEARCH
            // 
            this.SEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH.Location = new System.Drawing.Point(165, 381);
            this.SEARCH.Name = "SEARCH";
            this.SEARCH.Size = new System.Drawing.Size(90, 33);
            this.SEARCH.TabIndex = 109;
            this.SEARCH.Text = "SEARCH";
            this.SEARCH.UseVisualStyleBackColor = true;
            this.SEARCH.Click += new System.EventHandler(this.SEARCH_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(67, 357);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(450, 21);
            this.label17.TabIndex = 110;
            this.label17.Text = "Note :-You can changes Only In_Time and OUT_Time.";
            // 
            // Update_Emp_Daily_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 613);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.SEARCH);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Name = "Update_Emp_Daily_Entry";
            this.Text = "Update_Emp_Daily_Entry";
            this.Load += new System.EventHandler(this.Update_Emp_Daily_Entry_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Emp_ID;
        private System.Windows.Forms.DateTimePicker Today_Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Emp_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Entry_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker OUT_Time;
        private System.Windows.Forms.DateTimePicker IN_Time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button SEARCH;
        private System.Windows.Forms.Label label17;
    }
}