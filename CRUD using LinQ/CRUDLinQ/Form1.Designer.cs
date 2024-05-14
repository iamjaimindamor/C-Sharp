namespace CRUDLinQ
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDesignationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyDBDataSet = new CRUDLinQ.CompanyDBDataSet();
            this.employeeTableAdapter = new CRUDLinQ.CompanyDBDataSetTableAdapters.EmployeeTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.enameDataGridViewTextBoxColumn,
            this.eAddressDataGridViewTextBoxColumn,
            this.eDepartmentDataGridViewTextBoxColumn,
            this.eDesignationDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(965, 509);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // enameDataGridViewTextBoxColumn
            // 
            this.enameDataGridViewTextBoxColumn.DataPropertyName = "Ename";
            this.enameDataGridViewTextBoxColumn.HeaderText = "Ename";
            this.enameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.enameDataGridViewTextBoxColumn.Name = "enameDataGridViewTextBoxColumn";
            this.enameDataGridViewTextBoxColumn.ReadOnly = true;
            this.enameDataGridViewTextBoxColumn.Width = 125;
            // 
            // eAddressDataGridViewTextBoxColumn
            // 
            this.eAddressDataGridViewTextBoxColumn.DataPropertyName = "EAddress";
            this.eAddressDataGridViewTextBoxColumn.HeaderText = "EAddress";
            this.eAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eAddressDataGridViewTextBoxColumn.Name = "eAddressDataGridViewTextBoxColumn";
            this.eAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.eAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // eDepartmentDataGridViewTextBoxColumn
            // 
            this.eDepartmentDataGridViewTextBoxColumn.DataPropertyName = "EDepartment";
            this.eDepartmentDataGridViewTextBoxColumn.HeaderText = "EDepartment";
            this.eDepartmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eDepartmentDataGridViewTextBoxColumn.Name = "eDepartmentDataGridViewTextBoxColumn";
            this.eDepartmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.eDepartmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // eDesignationDataGridViewTextBoxColumn
            // 
            this.eDesignationDataGridViewTextBoxColumn.DataPropertyName = "EDesignation";
            this.eDesignationDataGridViewTextBoxColumn.HeaderText = "EDesignation";
            this.eDesignationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eDesignationDataGridViewTextBoxColumn.Name = "eDesignationDataGridViewTextBoxColumn";
            this.eDesignationDataGridViewTextBoxColumn.ReadOnly = true;
            this.eDesignationDataGridViewTextBoxColumn.Width = 125;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            this.salaryDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.companyDBDataSet;
            // 
            // companyDBDataSet
            // 
            this.companyDBDataSet.DataSetName = "CompanyDBDataSet";
            this.companyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(345, 519);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 58);
            this.button3.TabIndex = 3;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(654, 519);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 58);
            this.button4.TabIndex = 4;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 589);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CompanyDBDataSet companyDBDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private CompanyDBDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDesignationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

