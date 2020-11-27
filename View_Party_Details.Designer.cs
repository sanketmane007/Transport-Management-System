namespace Transport_mgmt
{
    partial class View_Party_Details
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
            this.partyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headOfficeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alternativeEmailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.websiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pARTYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transport_Mgmt_SystemDataSet21 = new Transport_mgmt.Transport_Mgmt_SystemDataSet21();
            this.pARTYTableAdapter = new Transport_mgmt.Transport_Mgmt_SystemDataSet21TableAdapters.PARTYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet21)).BeginInit();
            this.SuspendLayout();
            // 
            // CANCEL
            // 
            this.CANCEL.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCEL.ForeColor = System.Drawing.Color.Orange;
            this.CANCEL.Location = new System.Drawing.Point(287, 324);
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
            this.partyIDDataGridViewTextBoxColumn,
            this.partyNameDataGridViewTextBoxColumn,
            this.headOfficeDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.postCodeDataGridViewTextBoxColumn,
            this.telephoneNoDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.faxNoDataGridViewTextBoxColumn,
            this.emailIDDataGridViewTextBoxColumn,
            this.alternativeEmailIDDataGridViewTextBoxColumn,
            this.websiteDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.pARTYBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(27, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(688, 238);
            this.dataGridView1.TabIndex = 2;
            // 
            // partyIDDataGridViewTextBoxColumn
            // 
            this.partyIDDataGridViewTextBoxColumn.DataPropertyName = "Party_ID";
            this.partyIDDataGridViewTextBoxColumn.HeaderText = "Party_ID";
            this.partyIDDataGridViewTextBoxColumn.Name = "partyIDDataGridViewTextBoxColumn";
            this.partyIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partyNameDataGridViewTextBoxColumn
            // 
            this.partyNameDataGridViewTextBoxColumn.DataPropertyName = "Party_Name";
            this.partyNameDataGridViewTextBoxColumn.HeaderText = "Party_Name";
            this.partyNameDataGridViewTextBoxColumn.Name = "partyNameDataGridViewTextBoxColumn";
            this.partyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // headOfficeDataGridViewTextBoxColumn
            // 
            this.headOfficeDataGridViewTextBoxColumn.DataPropertyName = "Head_Office";
            this.headOfficeDataGridViewTextBoxColumn.HeaderText = "Head_Office";
            this.headOfficeDataGridViewTextBoxColumn.Name = "headOfficeDataGridViewTextBoxColumn";
            this.headOfficeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postCodeDataGridViewTextBoxColumn
            // 
            this.postCodeDataGridViewTextBoxColumn.DataPropertyName = "Post_Code";
            this.postCodeDataGridViewTextBoxColumn.HeaderText = "Post_Code";
            this.postCodeDataGridViewTextBoxColumn.Name = "postCodeDataGridViewTextBoxColumn";
            this.postCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telephoneNoDataGridViewTextBoxColumn
            // 
            this.telephoneNoDataGridViewTextBoxColumn.DataPropertyName = "Telephone_No";
            this.telephoneNoDataGridViewTextBoxColumn.HeaderText = "Telephone_No";
            this.telephoneNoDataGridViewTextBoxColumn.Name = "telephoneNoDataGridViewTextBoxColumn";
            this.telephoneNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faxNoDataGridViewTextBoxColumn
            // 
            this.faxNoDataGridViewTextBoxColumn.DataPropertyName = "Fax_No";
            this.faxNoDataGridViewTextBoxColumn.HeaderText = "Fax_No";
            this.faxNoDataGridViewTextBoxColumn.Name = "faxNoDataGridViewTextBoxColumn";
            this.faxNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailIDDataGridViewTextBoxColumn
            // 
            this.emailIDDataGridViewTextBoxColumn.DataPropertyName = "Email_ID";
            this.emailIDDataGridViewTextBoxColumn.HeaderText = "Email_ID";
            this.emailIDDataGridViewTextBoxColumn.Name = "emailIDDataGridViewTextBoxColumn";
            this.emailIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alternativeEmailIDDataGridViewTextBoxColumn
            // 
            this.alternativeEmailIDDataGridViewTextBoxColumn.DataPropertyName = "Alternative_Email_ID";
            this.alternativeEmailIDDataGridViewTextBoxColumn.HeaderText = "Alternative_Email_ID";
            this.alternativeEmailIDDataGridViewTextBoxColumn.Name = "alternativeEmailIDDataGridViewTextBoxColumn";
            this.alternativeEmailIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // websiteDataGridViewTextBoxColumn
            // 
            this.websiteDataGridViewTextBoxColumn.DataPropertyName = "Website";
            this.websiteDataGridViewTextBoxColumn.HeaderText = "Website";
            this.websiteDataGridViewTextBoxColumn.Name = "websiteDataGridViewTextBoxColumn";
            this.websiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pARTYBindingSource
            // 
            this.pARTYBindingSource.DataMember = "PARTY";
            this.pARTYBindingSource.DataSource = this.transport_Mgmt_SystemDataSet21;
            // 
            // transport_Mgmt_SystemDataSet21
            // 
            this.transport_Mgmt_SystemDataSet21.DataSetName = "Transport_Mgmt_SystemDataSet21";
            this.transport_Mgmt_SystemDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pARTYTableAdapter
            // 
            this.pARTYTableAdapter.ClearBeforeFill = true;
            // 
            // View_Party_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(743, 406);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "View_Party_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Party_Details";
            this.Load += new System.EventHandler(this.View_Party_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Transport_Mgmt_SystemDataSet21 transport_Mgmt_SystemDataSet21;
        private System.Windows.Forms.BindingSource pARTYBindingSource;
        private Transport_Mgmt_SystemDataSet21TableAdapters.PARTYTableAdapter pARTYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headOfficeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alternativeEmailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn websiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}