namespace StudentManagement
{
    partial class StudentListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentListForm));
            this.dataGridViewSt = new System.Windows.Forms.DataGridView();
            this.idTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdayTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.departmentTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hometown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSet4 = new StudentManagement.QLSVDataSet4();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSet = new StudentManagement.QLSVDataSet();
            this.studentTableAdapter = new StudentManagement.QLSVDataSetTableAdapters.StudentTableAdapter();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.studentTableAdapter1 = new StudentManagement.QLSVDataSet4TableAdapters.StudentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSt
            // 
            this.dataGridViewSt.AutoGenerateColumns = false;
            this.dataGridViewSt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSt.ColumnHeadersHeight = 29;
            this.dataGridViewSt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTextBoxColumn,
            this.firstnameTextBoxColumn,
            this.lastnameTextBoxColumn,
            this.bdayTextBoxColumn,
            this.genderTextBoxColumn,
            this.phoneTextBoxColumn,
            this.emailTextBoxColumn,
            this.addressTextBoxColumn,
            this.pictureImageColumn,
            this.departmentTextBoxColumn,
            this.majorTextBoxColumn,
            this.hometown});
            this.dataGridViewSt.DataSource = this.studentBindingSource1;
            this.dataGridViewSt.Location = new System.Drawing.Point(9, 24);
            this.dataGridViewSt.Name = "dataGridViewSt";
            this.dataGridViewSt.RowHeadersWidth = 51;
            this.dataGridViewSt.RowTemplate.Height = 24;
            this.dataGridViewSt.Size = new System.Drawing.Size(1312, 456);
            this.dataGridViewSt.TabIndex = 0;
            this.dataGridViewSt.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSt_CellDoubleClick);
            // 
            // idTextBoxColumn
            // 
            this.idTextBoxColumn.DataPropertyName = "id";
            this.idTextBoxColumn.HeaderText = "StudentID";
            this.idTextBoxColumn.MinimumWidth = 6;
            this.idTextBoxColumn.Name = "idTextBoxColumn";
            // 
            // firstnameTextBoxColumn
            // 
            this.firstnameTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameTextBoxColumn.HeaderText = "First Name";
            this.firstnameTextBoxColumn.MinimumWidth = 6;
            this.firstnameTextBoxColumn.Name = "firstnameTextBoxColumn";
            // 
            // lastnameTextBoxColumn
            // 
            this.lastnameTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameTextBoxColumn.HeaderText = "Last Name";
            this.lastnameTextBoxColumn.MinimumWidth = 6;
            this.lastnameTextBoxColumn.Name = "lastnameTextBoxColumn";
            // 
            // bdayTextBoxColumn
            // 
            this.bdayTextBoxColumn.DataPropertyName = "bday";
            this.bdayTextBoxColumn.HeaderText = "BirthDate";
            this.bdayTextBoxColumn.MinimumWidth = 6;
            this.bdayTextBoxColumn.Name = "bdayTextBoxColumn";
            // 
            // genderTextBoxColumn
            // 
            this.genderTextBoxColumn.DataPropertyName = "gender";
            this.genderTextBoxColumn.HeaderText = "Gender";
            this.genderTextBoxColumn.MinimumWidth = 6;
            this.genderTextBoxColumn.Name = "genderTextBoxColumn";
            // 
            // phoneTextBoxColumn
            // 
            this.phoneTextBoxColumn.DataPropertyName = "phone";
            this.phoneTextBoxColumn.HeaderText = "Phone";
            this.phoneTextBoxColumn.MinimumWidth = 6;
            this.phoneTextBoxColumn.Name = "phoneTextBoxColumn";
            // 
            // emailTextBoxColumn
            // 
            this.emailTextBoxColumn.DataPropertyName = "email";
            this.emailTextBoxColumn.HeaderText = "Email";
            this.emailTextBoxColumn.MinimumWidth = 6;
            this.emailTextBoxColumn.Name = "emailTextBoxColumn";
            // 
            // addressTextBoxColumn
            // 
            this.addressTextBoxColumn.DataPropertyName = "address";
            this.addressTextBoxColumn.HeaderText = "Address";
            this.addressTextBoxColumn.MinimumWidth = 6;
            this.addressTextBoxColumn.Name = "addressTextBoxColumn";
            // 
            // pictureImageColumn
            // 
            this.pictureImageColumn.DataPropertyName = "picture";
            this.pictureImageColumn.HeaderText = "Picture";
            this.pictureImageColumn.MinimumWidth = 6;
            this.pictureImageColumn.Name = "pictureImageColumn";
            // 
            // departmentTextBoxColumn
            // 
            this.departmentTextBoxColumn.DataPropertyName = "department";
            this.departmentTextBoxColumn.HeaderText = "Department";
            this.departmentTextBoxColumn.MinimumWidth = 6;
            this.departmentTextBoxColumn.Name = "departmentTextBoxColumn";
            // 
            // majorTextBoxColumn
            // 
            this.majorTextBoxColumn.DataPropertyName = "major";
            this.majorTextBoxColumn.HeaderText = "Major";
            this.majorTextBoxColumn.MinimumWidth = 6;
            this.majorTextBoxColumn.Name = "majorTextBoxColumn";
            // 
            // hometown
            // 
            this.hometown.DataPropertyName = "hometown";
            this.hometown.HeaderText = "Place of Birth";
            this.hometown.MinimumWidth = 6;
            this.hometown.Name = "hometown";
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            this.studentBindingSource1.DataSource = this.qLSVDataSet4;
            // 
            // qLSVDataSet4
            // 
            this.qLSVDataSet4.DataSetName = "QLSVDataSet4";
            this.qLSVDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.qLSVDataSet;
            // 
            // qLSVDataSet
            // 
            this.qLSVDataSet.DataSetName = "QLSVDataSet";
            this.qLSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Lime;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(1183, 494);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(138, 45);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.BackColor = System.Drawing.Color.Orange;
            this.buttonFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFind.Location = new System.Drawing.Point(12, 494);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(159, 46);
            this.buttonFind.TabIndex = 81;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 555);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridViewSt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentListView";
            this.Load += new System.EventHandler(this.StudentListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSt;
        private QLSVDataSet qLSVDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private QLSVDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Timer timer1;
        private QLSVDataSet4 qLSVDataSet4;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private QLSVDataSet4TableAdapters.StudentTableAdapter studentTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdayTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hometown;
    }
}