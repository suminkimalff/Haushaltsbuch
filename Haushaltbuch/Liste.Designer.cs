namespace Haushaltbuch
{
    partial class Liste
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.haushaltsbuchDataSet1 = new Haushaltbuch.HaushaltsbuchDataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buchTableAdapter = new Haushaltbuch.HaushaltsbuchDataSet1TableAdapters.BuchTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.betragDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.haushaltsbuchDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.haushaltsbuchDataSet1;
            this.bindingSource1.Position = 0;
            // 
            // haushaltsbuchDataSet1
            // 
            this.haushaltsbuchDataSet1.DataSetName = "HaushaltsbuchDataSet1";
            this.haushaltsbuchDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.eADataGridViewTextBoxColumn,
            this.betragDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.kategorieDataGridViewTextBoxColumn,
            this.saldoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.buchBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(645, 368);
            this.dataGridView1.TabIndex = 3;
            // 
            // buchBindingSource
            // 
            this.buchBindingSource.DataMember = "Buch";
            this.buchBindingSource.DataSource = this.bindingSource1;
            // 
            // buchTableAdapter
            // 
            this.buchTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eADataGridViewTextBoxColumn
            // 
            this.eADataGridViewTextBoxColumn.DataPropertyName = "EA";
            this.eADataGridViewTextBoxColumn.HeaderText = "EA";
            this.eADataGridViewTextBoxColumn.Name = "eADataGridViewTextBoxColumn";
            this.eADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // betragDataGridViewTextBoxColumn
            // 
            this.betragDataGridViewTextBoxColumn.DataPropertyName = "Betrag";
            this.betragDataGridViewTextBoxColumn.HeaderText = "Betrag";
            this.betragDataGridViewTextBoxColumn.Name = "betragDataGridViewTextBoxColumn";
            this.betragDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kategorieDataGridViewTextBoxColumn
            // 
            this.kategorieDataGridViewTextBoxColumn.DataPropertyName = "Kategorie";
            this.kategorieDataGridViewTextBoxColumn.HeaderText = "Kategorie";
            this.kategorieDataGridViewTextBoxColumn.Name = "kategorieDataGridViewTextBoxColumn";
            this.kategorieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saldoDataGridViewTextBoxColumn
            // 
            this.saldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo";
            this.saldoDataGridViewTextBoxColumn.HeaderText = "Saldo";
            this.saldoDataGridViewTextBoxColumn.Name = "saldoDataGridViewTextBoxColumn";
            this.saldoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 369);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Liste";
            this.Text = "Liste";
            this.Load += new System.EventHandler(this.Liste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.haushaltsbuchDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buchBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private HaushaltsbuchDataSet1 haushaltsbuchDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource buchBindingSource;
        private HaushaltsbuchDataSet1TableAdapters.BuchTableAdapter buchTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn betragDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDataGridViewTextBoxColumn;
    }
}