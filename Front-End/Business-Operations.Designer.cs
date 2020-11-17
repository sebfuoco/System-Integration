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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Business_Operations));
            this.extButton = new System.Windows.Forms.Button();
            this.holiday_Booking_System_NEWDataSet = new Front_End.Holiday_Booking_System_NEWDataSet();
            this.customerInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerInfoTableAdapter = new Front_End.Holiday_Booking_System_NEWDataSetTableAdapters.CustomerInfoTableAdapter();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.titletxt = new System.Windows.Forms.TextBox();
            this.firstnametxt = new System.Windows.Forms.TextBox();
            this.surnametxt = new System.Windows.Forms.TextBox();
            this.gendertxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.agetxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Insertbttn = new System.Windows.Forms.Button();
            this.deletebttn = new System.Windows.Forms.Button();
            this.updatebttn = new System.Windows.Forms.Button();
            this.displaybttn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.basic_Customer_Details = new Front_End.Basic_Customer_Details();
            this.customerDetailsTableAdapter = new Front_End.Basic_Customer_DetailsTableAdapters.CustomerDetailsTableAdapter();
            this.searchbttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.holiday_Booking_System_NEWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basic_Customer_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // extButton
            // 
            this.extButton.Location = new System.Drawing.Point(12, 405);
            this.extButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.extButton.Name = "extButton";
            this.extButton.Size = new System.Drawing.Size(139, 33);
            this.extButton.TabIndex = 1;
            this.extButton.Text = "Exit";
            this.extButton.UseVisualStyleBackColor = true;
            this.extButton.Click += new System.EventHandler(this.extButton_Click);
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
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(139, 108);
            this.idtxt.Margin = new System.Windows.Forms.Padding(4);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(132, 22);
            this.idtxt.TabIndex = 2;
            // 
            // titletxt
            // 
            this.titletxt.Location = new System.Drawing.Point(139, 151);
            this.titletxt.Margin = new System.Windows.Forms.Padding(4);
            this.titletxt.Name = "titletxt";
            this.titletxt.Size = new System.Drawing.Size(132, 22);
            this.titletxt.TabIndex = 3;
            // 
            // firstnametxt
            // 
            this.firstnametxt.Location = new System.Drawing.Point(139, 193);
            this.firstnametxt.Margin = new System.Windows.Forms.Padding(4);
            this.firstnametxt.Name = "firstnametxt";
            this.firstnametxt.Size = new System.Drawing.Size(132, 22);
            this.firstnametxt.TabIndex = 4;
            // 
            // surnametxt
            // 
            this.surnametxt.Location = new System.Drawing.Point(139, 238);
            this.surnametxt.Margin = new System.Windows.Forms.Padding(4);
            this.surnametxt.Name = "surnametxt";
            this.surnametxt.Size = new System.Drawing.Size(132, 22);
            this.surnametxt.TabIndex = 5;
            // 
            // gendertxt
            // 
            this.gendertxt.Location = new System.Drawing.Point(139, 281);
            this.gendertxt.Margin = new System.Windows.Forms.Padding(4);
            this.gendertxt.Name = "gendertxt";
            this.gendertxt.Size = new System.Drawing.Size(132, 22);
            this.gendertxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(47, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(47, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(47, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Firstname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(47, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(47, 284);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Gender";
            // 
            // agetxt
            // 
            this.agetxt.Location = new System.Drawing.Point(139, 324);
            this.agetxt.Margin = new System.Windows.Forms.Padding(4);
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(132, 22);
            this.agetxt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(47, 327);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Age";
            // 
            // Insertbttn
            // 
            this.Insertbttn.Location = new System.Drawing.Point(28, 359);
            this.Insertbttn.Margin = new System.Windows.Forms.Padding(4);
            this.Insertbttn.Name = "Insertbttn";
            this.Insertbttn.Size = new System.Drawing.Size(100, 28);
            this.Insertbttn.TabIndex = 14;
            this.Insertbttn.Text = "Insert";
            this.Insertbttn.UseVisualStyleBackColor = true;
            this.Insertbttn.Click += new System.EventHandler(this.Insertbttn_Click);
            // 
            // deletebttn
            // 
            this.deletebttn.Location = new System.Drawing.Point(151, 359);
            this.deletebttn.Margin = new System.Windows.Forms.Padding(4);
            this.deletebttn.Name = "deletebttn";
            this.deletebttn.Size = new System.Drawing.Size(100, 28);
            this.deletebttn.TabIndex = 15;
            this.deletebttn.Text = "Delete";
            this.deletebttn.UseVisualStyleBackColor = true;
            this.deletebttn.Click += new System.EventHandler(this.deletebttn_Click);
            // 
            // updatebttn
            // 
            this.updatebttn.Location = new System.Drawing.Point(273, 359);
            this.updatebttn.Margin = new System.Windows.Forms.Padding(4);
            this.updatebttn.Name = "updatebttn";
            this.updatebttn.Size = new System.Drawing.Size(100, 28);
            this.updatebttn.TabIndex = 16;
            this.updatebttn.Text = "Update";
            this.updatebttn.UseVisualStyleBackColor = true;
            this.updatebttn.Click += new System.EventHandler(this.updatebttn_Click);
            // 
            // displaybttn
            // 
            this.displaybttn.Location = new System.Drawing.Point(395, 359);
            this.displaybttn.Margin = new System.Windows.Forms.Padding(4);
            this.displaybttn.Name = "displaybttn";
            this.displaybttn.Size = new System.Drawing.Size(100, 28);
            this.displaybttn.TabIndex = 17;
            this.displaybttn.Text = "Display";
            this.displaybttn.UseVisualStyleBackColor = true;
            this.displaybttn.Click += new System.EventHandler(this.displaybttn_Click);
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
            this.genderDataGridViewTextBoxColumn,
            this.customerAgeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(316, 60);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(873, 283);
            this.dataGridView1.TabIndex = 18;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerTitleDataGridViewTextBoxColumn
            // 
            this.customerTitleDataGridViewTextBoxColumn.DataPropertyName = "CustomerTitle";
            this.customerTitleDataGridViewTextBoxColumn.HeaderText = "CustomerTitle";
            this.customerTitleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerTitleDataGridViewTextBoxColumn.Name = "customerTitleDataGridViewTextBoxColumn";
            this.customerTitleDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerFirstNameDataGridViewTextBoxColumn
            // 
            this.customerFirstNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerFirstName";
            this.customerFirstNameDataGridViewTextBoxColumn.HeaderText = "CustomerFirstName";
            this.customerFirstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerFirstNameDataGridViewTextBoxColumn.Name = "customerFirstNameDataGridViewTextBoxColumn";
            this.customerFirstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerLastNameDataGridViewTextBoxColumn
            // 
            this.customerLastNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerLastName";
            this.customerLastNameDataGridViewTextBoxColumn.HeaderText = "CustomerLastName";
            this.customerLastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerLastNameDataGridViewTextBoxColumn.Name = "customerLastNameDataGridViewTextBoxColumn";
            this.customerLastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerAgeDataGridViewTextBoxColumn
            // 
            this.customerAgeDataGridViewTextBoxColumn.DataPropertyName = "CustomerAge";
            this.customerAgeDataGridViewTextBoxColumn.HeaderText = "CustomerAge";
            this.customerAgeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerAgeDataGridViewTextBoxColumn.Name = "customerAgeDataGridViewTextBoxColumn";
            this.customerAgeDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerDetailsBindingSource
            // 
            this.customerDetailsBindingSource.DataMember = "CustomerDetails";
            this.customerDetailsBindingSource.DataSource = this.basic_Customer_Details;
            // 
            // basic_Customer_Details
            // 
            this.basic_Customer_Details.DataSetName = "Basic_Customer_Details";
            this.basic_Customer_Details.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerDetailsTableAdapter
            // 
            this.customerDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // searchbttn
            // 
            this.searchbttn.Location = new System.Drawing.Point(273, 405);
            this.searchbttn.Margin = new System.Windows.Forms.Padding(4);
            this.searchbttn.Name = "searchbttn";
            this.searchbttn.Size = new System.Drawing.Size(100, 28);
            this.searchbttn.TabIndex = 19;
            this.searchbttn.Text = "Search";
            this.searchbttn.UseVisualStyleBackColor = true;
            this.searchbttn.Click += new System.EventHandler(this.searchbttn_Click);
            // 
            // Business_Operations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1205, 551);
            this.Controls.Add(this.searchbttn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.displaybttn);
            this.Controls.Add(this.updatebttn);
            this.Controls.Add(this.deletebttn);
            this.Controls.Add(this.Insertbttn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.agetxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gendertxt);
            this.Controls.Add(this.surnametxt);
            this.Controls.Add(this.firstnametxt);
            this.Controls.Add(this.titletxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.extButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Business_Operations";
            this.Text = "Business Operations";
            this.Load += new System.EventHandler(this.Business_Operations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.holiday_Booking_System_NEWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basic_Customer_Details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button extButton;
        private Holiday_Booking_System_NEWDataSet holiday_Booking_System_NEWDataSet;
        private System.Windows.Forms.BindingSource customerInfoBindingSource;
        private Holiday_Booking_System_NEWDataSetTableAdapters.CustomerInfoTableAdapter customerInfoTableAdapter;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox titletxt;
        private System.Windows.Forms.TextBox firstnametxt;
        private System.Windows.Forms.TextBox surnametxt;
        private System.Windows.Forms.TextBox gendertxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox agetxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Insertbttn;
        private System.Windows.Forms.Button deletebttn;
        private System.Windows.Forms.Button updatebttn;
        private System.Windows.Forms.Button displaybttn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Basic_Customer_Details basic_Customer_Details;
        private System.Windows.Forms.BindingSource customerDetailsBindingSource;
        private Basic_Customer_DetailsTableAdapters.CustomerDetailsTableAdapter customerDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button searchbttn;
    }
}