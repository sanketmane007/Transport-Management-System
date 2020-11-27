namespace Transport_mgmt
{
    partial class View_Employees_Details
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
            this.transport_Mgmt_SystemDataSet22 = new Transport_mgmt.Transport_Mgmt_SystemDataSet22();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new Transport_mgmt.Transport_Mgmt_SystemDataSet22TableAdapters.EmployeesTableAdapter();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.religionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adharNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drivingLicNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pancardNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pincodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alternativeEmailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoUploadDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CANCEL
            // 
            this.CANCEL.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCEL.ForeColor = System.Drawing.Color.Orange;
            this.CANCEL.Location = new System.Drawing.Point(292, 325);
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
            this.statusDataGridViewTextBoxColumn,
            this.empIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.religionDataGridViewTextBoxColumn,
            this.bloodGroupDataGridViewTextBoxColumn,
            this.adharNoDataGridViewTextBoxColumn,
            this.drivingLicNoDataGridViewTextBoxColumn,
            this.pancardNoDataGridViewTextBoxColumn,
            this.presentAddressDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.districtDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.pincodeDataGridViewTextBoxColumn,
            this.phoneNoDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.emailIDDataGridViewTextBoxColumn,
            this.alternativeEmailIDDataGridViewTextBoxColumn,
            this.entryDateDataGridViewTextBoxColumn,
            this.photoUploadDataGridViewImageColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.employeesBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(32, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(688, 238);
            this.dataGridView1.TabIndex = 2;
            // 
            // transport_Mgmt_SystemDataSet22
            // 
            this.transport_Mgmt_SystemDataSet22.DataSetName = "Transport_Mgmt_SystemDataSet22";
            this.transport_Mgmt_SystemDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.transport_Mgmt_SystemDataSet22;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "Middle_Name";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "Middle_Name";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date_Of_Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // religionDataGridViewTextBoxColumn
            // 
            this.religionDataGridViewTextBoxColumn.DataPropertyName = "Religion";
            this.religionDataGridViewTextBoxColumn.HeaderText = "Religion";
            this.religionDataGridViewTextBoxColumn.Name = "religionDataGridViewTextBoxColumn";
            this.religionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bloodGroupDataGridViewTextBoxColumn
            // 
            this.bloodGroupDataGridViewTextBoxColumn.DataPropertyName = "Blood_Group";
            this.bloodGroupDataGridViewTextBoxColumn.HeaderText = "Blood_Group";
            this.bloodGroupDataGridViewTextBoxColumn.Name = "bloodGroupDataGridViewTextBoxColumn";
            this.bloodGroupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adharNoDataGridViewTextBoxColumn
            // 
            this.adharNoDataGridViewTextBoxColumn.DataPropertyName = "Adhar_No";
            this.adharNoDataGridViewTextBoxColumn.HeaderText = "Adhar_No";
            this.adharNoDataGridViewTextBoxColumn.Name = "adharNoDataGridViewTextBoxColumn";
            this.adharNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drivingLicNoDataGridViewTextBoxColumn
            // 
            this.drivingLicNoDataGridViewTextBoxColumn.DataPropertyName = "Driving_Lic_No";
            this.drivingLicNoDataGridViewTextBoxColumn.HeaderText = "Driving_Lic_No";
            this.drivingLicNoDataGridViewTextBoxColumn.Name = "drivingLicNoDataGridViewTextBoxColumn";
            this.drivingLicNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pancardNoDataGridViewTextBoxColumn
            // 
            this.pancardNoDataGridViewTextBoxColumn.DataPropertyName = "Pancard_No";
            this.pancardNoDataGridViewTextBoxColumn.HeaderText = "Pancard_No";
            this.pancardNoDataGridViewTextBoxColumn.Name = "pancardNoDataGridViewTextBoxColumn";
            this.pancardNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // presentAddressDataGridViewTextBoxColumn
            // 
            this.presentAddressDataGridViewTextBoxColumn.DataPropertyName = "Present_Address";
            this.presentAddressDataGridViewTextBoxColumn.HeaderText = "Present_Address";
            this.presentAddressDataGridViewTextBoxColumn.Name = "presentAddressDataGridViewTextBoxColumn";
            this.presentAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // districtDataGridViewTextBoxColumn
            // 
            this.districtDataGridViewTextBoxColumn.DataPropertyName = "District";
            this.districtDataGridViewTextBoxColumn.HeaderText = "District";
            this.districtDataGridViewTextBoxColumn.Name = "districtDataGridViewTextBoxColumn";
            this.districtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pincodeDataGridViewTextBoxColumn
            // 
            this.pincodeDataGridViewTextBoxColumn.DataPropertyName = "Pincode";
            this.pincodeDataGridViewTextBoxColumn.HeaderText = "Pincode";
            this.pincodeDataGridViewTextBoxColumn.Name = "pincodeDataGridViewTextBoxColumn";
            this.pincodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNoDataGridViewTextBoxColumn
            // 
            this.phoneNoDataGridViewTextBoxColumn.DataPropertyName = "Phone_No";
            this.phoneNoDataGridViewTextBoxColumn.HeaderText = "Phone_No";
            this.phoneNoDataGridViewTextBoxColumn.Name = "phoneNoDataGridViewTextBoxColumn";
            this.phoneNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // entryDateDataGridViewTextBoxColumn
            // 
            this.entryDateDataGridViewTextBoxColumn.DataPropertyName = "Entry_Date";
            this.entryDateDataGridViewTextBoxColumn.HeaderText = "Entry_Date";
            this.entryDateDataGridViewTextBoxColumn.Name = "entryDateDataGridViewTextBoxColumn";
            this.entryDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // photoUploadDataGridViewImageColumn
            // 
            this.photoUploadDataGridViewImageColumn.DataPropertyName = "Photo_Upload";
            this.photoUploadDataGridViewImageColumn.HeaderText = "Photo_Upload";
            this.photoUploadDataGridViewImageColumn.Name = "photoUploadDataGridViewImageColumn";
            this.photoUploadDataGridViewImageColumn.ReadOnly = true;
            // 
            // View_Employees_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(752, 409);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "View_Employees_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Employees_Details";
            this.Load += new System.EventHandler(this.View_Employees_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_Mgmt_SystemDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Transport_Mgmt_SystemDataSet22 transport_Mgmt_SystemDataSet22;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private Transport_Mgmt_SystemDataSet22TableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn religionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adharNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drivingLicNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pancardNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pincodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alternativeEmailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoUploadDataGridViewImageColumn;
    }
}