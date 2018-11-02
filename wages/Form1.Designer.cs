namespace wages
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
            this.label5 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.hours = new System.Windows.Forms.TextBox();
            this.wage = new System.Windows.Forms.TextBox();
            this.wageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new wages.Database1DataSet();
            this.save = new System.Windows.Forms.Button();
            this.wageTableAdapter = new wages.Database1DataSetTableAdapters.wageTableAdapter();
            this.database1DataSet1 = new wages.Database1DataSet1();
            this.wageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.wageTableAdapter1 = new wages.Database1DataSet1TableAdapters.wageTableAdapter();
            this.desi = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet2 = new wages.Database1DataSet2();
            this.wageBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.wageTableAdapter2 = new wages.Database1DataSet2TableAdapters.wageTableAdapter();
            this.database1DataSet3 = new wages.Database1DataSet3();
            this.wageBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.wageTableAdapter3 = new wages.Database1DataSet3TableAdapters.wageTableAdapter();
            this.database1DataSet4 = new wages.Database1DataSet4();
            this.wageBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.wageTableAdapter4 = new wages.Database1DataSet4TableAdapters.wageTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.database1DataSet5 = new wages.Database1DataSet5();
            this.wageBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.wageTableAdapter5 = new wages.Database1DataSet5TableAdapters.wageTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.wageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wageBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wageBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wageBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wageBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wageBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DESIGNATION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "HOURS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "WAGE";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(128, 33);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(157, 20);
            this.id.TabIndex = 5;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(128, 68);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(157, 20);
            this.name.TabIndex = 6;
            // 
            // hours
            // 
            this.hours.Location = new System.Drawing.Point(128, 140);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(157, 20);
            this.hours.TabIndex = 8;
            // 
            // wage
            // 
            this.wage.Location = new System.Drawing.Point(128, 184);
            this.wage.Name = "wage";
            this.wage.Size = new System.Drawing.Size(157, 20);
            this.wage.TabIndex = 9;
            // 
            // wageBindingSource
            // 
            this.wageBindingSource.DataMember = "wage";
            this.wageBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(305, 204);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(140, 49);
            this.save.TabIndex = 11;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // wageTableAdapter
            // 
            this.wageTableAdapter.ClearBeforeFill = true;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wageBindingSource1
            // 
            this.wageBindingSource1.DataMember = "wage";
            this.wageBindingSource1.DataSource = this.database1DataSet1;
            // 
            // wageTableAdapter1
            // 
            this.wageTableAdapter1.ClearBeforeFill = true;
            // 
            // desi
            // 
            this.desi.FormattingEnabled = true;
            this.desi.Items.AddRange(new object[] {
            "manager",
            "supervisor",
            "worker"});
            this.desi.Location = new System.Drawing.Point(133, 108);
            this.desi.Name = "desi";
            this.desi.Size = new System.Drawing.Size(151, 21);
            this.desi.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.designation,
            this.nameDataGridViewTextBoxColumn,
            this.hoursDataGridViewTextBoxColumn,
            this.wageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wageBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(32, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 153);
            this.dataGridView1.TabIndex = 10;
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wageBindingSource2
            // 
            this.wageBindingSource2.DataMember = "wage";
            this.wageBindingSource2.DataSource = this.database1DataSet2;
            // 
            // wageTableAdapter2
            // 
            this.wageTableAdapter2.ClearBeforeFill = true;
            // 
            // database1DataSet3
            // 
            this.database1DataSet3.DataSetName = "Database1DataSet3";
            this.database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wageBindingSource3
            // 
            this.wageBindingSource3.DataMember = "wage";
            this.wageBindingSource3.DataSource = this.database1DataSet3;
            // 
            // wageTableAdapter3
            // 
            this.wageTableAdapter3.ClearBeforeFill = true;
            // 
            // database1DataSet4
            // 
            this.database1DataSet4.DataSetName = "Database1DataSet4";
            this.database1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wageBindingSource4
            // 
            this.wageBindingSource4.DataMember = "wage";
            this.wageBindingSource4.DataSource = this.database1DataSet4;
            // 
            // wageTableAdapter4
            // 
            this.wageTableAdapter4.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // designation
            // 
            this.designation.DataPropertyName = "designation";
            this.designation.HeaderText = "designation";
            this.designation.Name = "designation";
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
            // database1DataSet5
            // 
            this.database1DataSet5.DataSetName = "Database1DataSet5";
            this.database1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wageBindingSource5
            // 
            this.wageBindingSource5.DataMember = "wage";
            this.wageBindingSource5.DataSource = this.database1DataSet5;
            // 
            // wageTableAdapter5
            // 
            this.wageTableAdapter5.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.desi);
            this.Controls.Add(this.save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.wage);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wageBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wageBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wageBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wageBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wageBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox hours;
        private System.Windows.Forms.TextBox wage;
        private System.Windows.Forms.Button save;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource wageBindingSource;
        private Database1DataSetTableAdapters.wageTableAdapter wageTableAdapter;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource wageBindingSource1;
        private Database1DataSet1TableAdapters.wageTableAdapter wageTableAdapter1;
        private System.Windows.Forms.ComboBox desi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource wageBindingSource2;
        private Database1DataSet2TableAdapters.wageTableAdapter wageTableAdapter2;
        private Database1DataSet3 database1DataSet3;
        private System.Windows.Forms.BindingSource wageBindingSource3;
        private Database1DataSet3TableAdapters.wageTableAdapter wageTableAdapter3;
        private Database1DataSet4 database1DataSet4;
        private System.Windows.Forms.BindingSource wageBindingSource4;
        private Database1DataSet4TableAdapters.wageTableAdapter wageTableAdapter4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wageDataGridViewTextBoxColumn;
        private Database1DataSet5 database1DataSet5;
        private System.Windows.Forms.BindingSource wageBindingSource5;
        private Database1DataSet5TableAdapters.wageTableAdapter wageTableAdapter5;
    }
}

