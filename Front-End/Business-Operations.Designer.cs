namespace Front_End
{
    partial class Business_Operations
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
            this.extButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.holiday_Booking_System_NEWDataSet = new Front_End.Holiday_Booking_System_NEWDataSet();
            this.customerInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerInfoTableAdapter = new Front_End.Holiday_Booking_System_NEWDataSetTableAdapters.CustomerInfoTableAdapter();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNationalityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerGenderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holiday_Booking_System_NEWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // extButton
            // 
            this.extButton.Location = new System.Drawing.Point(9, 329);
            this.extButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.extButton.Name = "extButton";
            this.extButton.Size = new System.Drawing.Size(104, 27);
            this.extButton.TabIndex = 1;
            this.extButton.Text = "Exit";
            this.extButton.UseVisualStyleBackColor = true;
            this.extButton.Click += new System.EventHandler(this.extButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.customerTitleDataGridViewTextBoxColumn,
            this.customerFirstNameDataGridViewTextBoxColumn,
            this.customerLastNameDataGridViewTextBoxColumn,
            this.customerAgeDataGridViewTextBoxColumn,
            this.passportNumberDataGridViewTextBoxColumn,
            this.customerAddressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.postCodeDataGridViewTextBoxColumn,
            this.customerContactDataGridViewTextBoxColumn,
            this.customerEmailDataGridViewTextBoxColumn,
            this.customerNationalityIDDataGridViewTextBoxColumn,
            this.customerGenderIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(311, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // holiday_Booking_System_NEWDataSet
            // 
            this.holiday_Booking_System_NEWDataSet.DataSetName = "Holiday_Booking_System_NEWDataSet";
            this.holiday_Booking_System_NEWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerInfoBindingSource
            // 
            this.customerInfoBindingSource.DataMember = "CustomerInfo";
            this.customerInfoBindingSource.DataSource = this.holiday_Booking_System_NEWDataSet;
            // 
            // customerInfoTableAdapter
            // 
            this.customerInfoTableAdapter.ClearBeforeFill = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // customerTitleDataGridViewTextBoxColumn
            // 
            this.customerTitleDataGridViewTextBoxColumn.DataPropertyName = "CustomerTitle";
            this.customerTitleDataGridViewTextBoxColumn.HeaderText = "CustomerTitle";
            this.customerTitleDataGridViewTextBoxColumn.Name = "customerTitleDataGridViewTextBoxColumn";
            // 
            // customerFirstNameDataGridViewTextBoxColumn
            // 
            this.customerFirstNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerFirstName";
            this.customerFirstNameDataGridViewTextBoxColumn.HeaderText = "CustomerFirstName";
            this.customerFirstNameDataGridViewTextBoxColumn.Name = "customerFirstNameDataGridViewTextBoxColumn";
            // 
            // customerLastNameDataGridViewTextBoxColumn
            // 
            this.customerLastNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerLastName";
            this.customerLastNameDataGridViewTextBoxColumn.HeaderText = "CustomerLastName";
            this.customerLastNameDataGridViewTextBoxColumn.Name = "customerLastNameDataGridViewTextBoxColumn";
            // 
            // customerAgeDataGridViewTextBoxColumn
            // 
            this.customerAgeDataGridViewTextBoxColumn.DataPropertyName = "CustomerAge";
            this.customerAgeDataGridViewTextBoxColumn.HeaderText = "CustomerAge";
            this.customerAgeDataGridViewTextBoxColumn.Name = "customerAgeDataGridViewTextBoxColumn";
            // 
            // passportNumberDataGridViewTextBoxColumn
            // 
            this.passportNumberDataGridViewTextBoxColumn.DataPropertyName = "PassportNumber";
            this.passportNumberDataGridViewTextBoxColumn.HeaderText = "PassportNumber";
            this.passportNumberDataGridViewTextBoxColumn.Name = "passportNumberDataGridViewTextBoxColumn";
            // 
            // customerAddressDataGridViewTextBoxColumn
            // 
            this.customerAddressDataGridViewTextBoxColumn.DataPropertyName = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.HeaderText = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // postCodeDataGridViewTextBoxColumn
            // 
            this.postCodeDataGridViewTextBoxColumn.DataPropertyName = "PostCode";
            this.postCodeDataGridViewTextBoxColumn.HeaderText = "PostCode";
            this.postCodeDataGridViewTextBoxColumn.Name = "postCodeDataGridViewTextBoxColumn";
            // 
            // customerContactDataGridViewTextBoxColumn
            // 
            this.customerContactDataGridViewTextBoxColumn.DataPropertyName = "CustomerContact";
            this.customerContactDataGridViewTextBoxColumn.HeaderText = "CustomerContact";
            this.customerContactDataGridViewTextBoxColumn.Name = "customerContactDataGridViewTextBoxColumn";
            // 
            // customerEmailDataGridViewTextBoxColumn
            // 
            this.customerEmailDataGridViewTextBoxColumn.DataPropertyName = "CustomerEmail";
            this.customerEmailDataGridViewTextBoxColumn.HeaderText = "CustomerEmail";
            this.customerEmailDataGridViewTextBoxColumn.Name = "customerEmailDataGridViewTextBoxColumn";
            // 
            // customerNationalityIDDataGridViewTextBoxColumn
            // 
            this.customerNationalityIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerNationality_ID";
            this.customerNationalityIDDataGridViewTextBoxColumn.HeaderText = "CustomerNationality_ID";
            this.customerNationalityIDDataGridViewTextBoxColumn.Name = "customerNationalityIDDataGridViewTextBoxColumn";
            // 
            // customerGenderIDDataGridViewTextBoxColumn
            // 
            this.customerGenderIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerGender_ID";
            this.customerGenderIDDataGridViewTextBoxColumn.HeaderText = "CustomerGender_ID";
            this.customerGenderIDDataGridViewTextBoxColumn.Name = "customerGenderIDDataGridViewTextBoxColumn";
            // 
            // Business_Operations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.extButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Business_Operations";
            this.Text = "Business Operations";
            this.Load += new System.EventHandler(this.Business_Operations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holiday_Booking_System_NEWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button extButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Holiday_Booking_System_NEWDataSet holiday_Booking_System_NEWDataSet;
        private System.Windows.Forms.BindingSource customerInfoBindingSource;
        private Holiday_Booking_System_NEWDataSetTableAdapters.CustomerInfoTableAdapter customerInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNationalityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerGenderIDDataGridViewTextBoxColumn;
    }
}