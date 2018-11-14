namespace dailw_wage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.hours = new System.Windows.Forms.TextBox();
            this.wage = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new dailw_wage.Database1DataSet1();
            this.dailyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new dailw_wage.Database1DataSet();
            this.dailyTableAdapter = new dailw_wage.Database1DataSetTableAdapters.dailyTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.wageTableAdapter = new dailw_wage.Database1DataSet1TableAdapters.wageTableAdapter();
            this.save = new System.Windows.Forms.Button();
            this.database1DataSet2 = new dailw_wage.Database1DataSet2();
            this.wageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.wageTableAdapter1 = new dailw_wage.Database1DataSet2TableAdapters.wageTableAdapter();
            this.manager = new System.Windows.Forms.RadioButton();
            this.supervisor = new System.Windows.Forms.RadioButton();
            this.worker = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wageBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Designation";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hours";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wage  ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(182, 61);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(191, 22);
            this.name.TabIndex = 4;
            // 
            // hours
            // 
            this.hours.Location = new System.Drawing.Point(182, 142);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(191, 22);
            this.hours.TabIndex = 6;
            this.hours.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // wage
            // 
            this.wage.Location = new System.Drawing.Point(182, 180);
            this.wage.Name = "wage";
            this.wage.Size = new System.Drawing.Size(191, 22);
            this.wage.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.hoursDataGridViewTextBoxColumn,
            this.wageDataGridViewTextBoxColumn,
            this.desiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wageBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(49, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 140);
            this.dataGridView1.TabIndex = 8;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // hoursDataGridViewTextBoxColumn
            // 
            this.hoursDataGridViewTextBoxColumn.DataPropertyName = "hours";
            this.hoursDataGridViewTextBoxColumn.HeaderText = "hours";
            this.hoursDataGridViewTextBoxColumn.Name = "hoursDataGridViewTextBoxColumn";
            // 
            // wageDataGridViewTextBoxColumn
            // 
            this.wageDataGridViewTextBoxColumn.DataPropertyName = "wage";
            this.wageDataGridViewTextBoxColumn.HeaderText = "wage";
            this.wageDataGridViewTextBoxColumn.Name = "wageDataGridViewTextBoxColumn";
            // 
            // desiDataGridViewTextBoxColumn
            // 
            this.desiDataGridViewTextBoxColumn.DataPropertyName = "desi";
            this.desiDataGridViewTextBoxColumn.HeaderText = "desi";
            this.desiDataGridViewTextBoxColumn.Name = "desiDataGridViewTextBoxColumn";
            // 
            // wageBindingSource
            // 
            this.wageBindingSource.DataMember = "wage";
            this.wageBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dailyBindingSource
            // 
            this.dailyBindingSource.DataMember = "daily";
            this.dailyBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dailyTableAdapter
            // 
            this.dailyTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Id";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(181, 30);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(191, 22);
            this.id.TabIndex = 10;
            // 
            // wageTableAdapter
            // 
            this.wageTableAdapter.ClearBeforeFill = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(182, 208);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(88, 32);
            this.save.TabIndex = 11;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wageBindingSource1
            // 
            this.wageBindingSource1.DataMember = "wage";
            this.wageBindingSource1.DataSource = this.database1DataSet2;
            // 
            // wageTableAdapter1
            // 
            this.wageTableAdapter1.ClearBeforeFill = true;
            // 
            // manager
            // 
            this.manager.AutoSize = true;
            this.manager.Location = new System.Drawing.Point(20, 16);
            this.manager.Name = "manager";
            this.manager.Size = new System.Drawing.Size(69, 18);
            this.manager.TabIndex = 12;
            this.manager.TabStop = true;
            this.manager.Text = "manager";
            this.manager.UseVisualStyleBackColor = true;
            // 
            // supervisor
            // 
            this.supervisor.AutoSize = true;
            this.supervisor.Location = new System.Drawing.Point(116, 16);
            this.supervisor.Name = "supervisor";
            this.supervisor.Size = new System.Drawing.Size(76, 18);
            this.supervisor.TabIndex = 13;
            this.supervisor.TabStop = true;
            this.supervisor.Text = "supervisor";
            this.supervisor.UseVisualStyleBackColor = true;
            // 
            // worker
            // 
            this.worker.AutoSize = true;
            this.worker.Location = new System.Drawing.Point(243, 16);
            this.worker.Name = "worker";
            this.worker.Size = new System.Drawing.Size(60, 18);
            this.worker.TabIndex = 14;
            this.worker.TabStop = true;
            this.worker.Text = "worker";
            this.worker.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.worker);
            this.groupBox1.Controls.Add(this.supervisor);
            this.groupBox1.Controls.Add(this.manager);
            this.groupBox1.Location = new System.Drawing.Point(181, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 40);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 392);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.wage);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wageBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox hours;
        private System.Windows.Forms.TextBox wage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource dailyBindingSource;
        private Database1DataSetTableAdapters.dailyTableAdapter dailyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource wageBindingSource;
        private Database1DataSet1TableAdapters.wageTableAdapter wageTableAdapter;
        private System.Windows.Forms.Button save;
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource wageBindingSource1;
        private Database1DataSet2TableAdapters.wageTableAdapter wageTableAdapter1;
        private System.Windows.Forms.RadioButton manager;
        private System.Windows.Forms.RadioButton supervisor;
        private System.Windows.Forms.RadioButton worker;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

