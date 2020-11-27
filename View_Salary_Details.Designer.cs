namespace Transport_mgmt
{
    partial class View_Salary_Details
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
            this.salaryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfJoiningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfRetirementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basicPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSalaryCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALARYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transport_Mgmt_SystemDataSet20 = new Transport_mgmt.Transport_Mgmt_SystemDataSet20();
            this.sALARYTableAdapter = new Transport_mgmt.Transport_Mgmt_SystemDataSet20TableAdapters.SALARYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALARYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet20)).BeginInit();
            this.SuspendLayout();
            // 
            // CANCEL
            // 
            this.CANCEL.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCEL.ForeColor = System.Drawing.Color.Orange;
            this.CANCEL.Location = new System.Drawing.Point(283, 327);
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
            this.salaryIDDataGridViewTextBoxColumn,
            this.empIDDataGridViewTextBoxColumn,
            this.dateOfJoiningDataGridViewTextBoxColumn,
            this.dateOfRetirementDataGridViewTextBoxColumn,
            this.basicPayDataGridViewTextBoxColumn,
            this.deductionDataGridViewTextBoxColumn,
            this.eSalaryCodeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.sALARYBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(23, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(688, 238);
            this.dataGridView1.TabIndex = 2;
            // 
            // salaryIDDataGridViewTextBoxColumn
            // 
            this.salaryIDDataGridViewTextBoxColumn.DataPropertyName = "Salary_ID";
            this.salaryIDDataGridViewTextBoxColumn.HeaderText = "Salary_ID";
            this.salaryIDDataGridViewTextBoxColumn.Name = "salaryIDDataGridViewTextBoxColumn";
            this.salaryIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfJoiningDataGridViewTextBoxColumn
            // 
            this.dateOfJoiningDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Joining";
            this.dateOfJoiningDataGridViewTextBoxColumn.HeaderText = "Date_Of_Joining";
            this.dateOfJoiningDataGridViewTextBoxColumn.Name = "dateOfJoiningDataGridViewTextBoxColumn";
            this.dateOfJoiningDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfRetirementDataGridViewTextBoxColumn
            // 
            this.dateOfRetirementDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Retirement";
            this.dateOfRetirementDataGridViewTextBoxColumn.HeaderText = "Date_Of_Retirement";
            this.dateOfRetirementDataGridViewTextBoxColumn.Name = "dateOfRetirementDataGridViewTextBoxColumn";
            this.dateOfRetirementDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // basicPayDataGridViewTextBoxColumn
            // 
            this.basicPayDataGridViewTextBoxColumn.DataPropertyName = "Basic_Pay";
            this.basicPayDataGridViewTextBoxColumn.HeaderText = "Basic_Pay";
            this.basicPayDataGridViewTextBoxColumn.Name = "basicPayDataGridViewTextBoxColumn";
            this.basicPayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deductionDataGridViewTextBoxColumn
            // 
            this.deductionDataGridViewTextBoxColumn.DataPropertyName = "Deduction";
            this.deductionDataGridViewTextBoxColumn.HeaderText = "Deduction";
            this.deductionDataGridViewTextBoxColumn.Name = "deductionDataGridViewTextBoxColumn";
            this.deductionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eSalaryCodeDataGridViewTextBoxColumn
            // 
            this.eSalaryCodeDataGridViewTextBoxColumn.DataPropertyName = "E_Salary_Code";
            this.eSalaryCodeDataGridViewTextBoxColumn.HeaderText = "E_Salary_Code";
            this.eSalaryCodeDataGridViewTextBoxColumn.Name = "eSalaryCodeDataGridViewTextBoxColumn";
            this.eSalaryCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sALARYBindingSource
            // 
            this.sALARYBindingSource.DataMember = "SALARY";
            this.sALARYBindingSource.DataSource = this.transport_Mgmt_SystemDataSet20;
            // 
            // transport_Mgmt_SystemDataSet20
            // 
            this.transport_Mgmt_SystemDataSet20.DataSetName = "Transport_Mgmt_SystemDataSet20";
            this.transport_Mgmt_SystemDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sALARYTableAdapter
            // 
            this.sALARYTableAdapter.ClearBeforeFill = true;
            // 
            // View_Salary_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(734, 412);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "View_Salary_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Salary_Details";
            this.Load += new System.EventHandler(this.View_Salary_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALARYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet20)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Transport_Mgmt_SystemDataSet20 transport_Mgmt_SystemDataSet20;
        private System.Windows.Forms.BindingSource sALARYBindingSource;
        private Transport_Mgmt_SystemDataSet20TableAdapters.SALARYTableAdapter sALARYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfJoiningDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfRetirementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basicPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSalaryCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}