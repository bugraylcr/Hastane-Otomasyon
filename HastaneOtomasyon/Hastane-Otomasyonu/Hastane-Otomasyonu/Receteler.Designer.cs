namespace Hastane_Otomasyonu
{
    partial class Receteler
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
            this.GeriB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hastaneDBDataSet22 = new Hastane_Otomasyonu.HastaneDBDataSet22();
            this.receteHastaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receteHastaTableAdapter = new Hastane_Otomasyonu.HastaneDBDataSet22TableAdapters.ReceteHastaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.hastaneDBDataSet23 = new Hastane_Otomasyonu.HastaneDBDataSet23();
            this.hastaneDBDataSet23BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receteDetayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receteDetayTableAdapter = new Hastane_Otomasyonu.HastaneDBDataSet23TableAdapters.ReceteDetayTableAdapter();
            this.hastaneDBDataSet24 = new Hastane_Otomasyonu.HastaneDBDataSet24();
            this.receteDetayBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.receteDetayTableAdapter1 = new Hastane_Otomasyonu.HastaneDBDataSet24TableAdapters.ReceteDetayTableAdapter();
            this.rcidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dkidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receteTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RcToplam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcBilgiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receteHastaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet23BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receteDetayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receteDetayBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // GeriB
            // 
            this.GeriB.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GeriB.Location = new System.Drawing.Point(25, 24);
            this.GeriB.Name = "GeriB";
            this.GeriB.Size = new System.Drawing.Size(142, 69);
            this.GeriB.TabIndex = 0;
            this.GeriB.Text = "Geri Dön";
            this.GeriB.UseVisualStyleBackColor = true;
            this.GeriB.Click += new System.EventHandler(this.GeriB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rcidDataGridViewTextBoxColumn,
            this.hsidDataGridViewTextBoxColumn,
            this.hsAdDataGridViewTextBoxColumn,
            this.hsSoyadDataGridViewTextBoxColumn,
            this.hsTcDataGridViewTextBoxColumn,
            this.dkidDataGridViewTextBoxColumn,
            this.receteTarihDataGridViewTextBoxColumn,
            this.RcToplam,
            this.rcBilgiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.receteDetayBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(35, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(898, 315);
            this.dataGridView1.TabIndex = 1;
            // 
            // hastaneDBDataSet22
            // 
            this.hastaneDBDataSet22.DataSetName = "HastaneDBDataSet22";
            this.hastaneDBDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receteHastaBindingSource
            // 
            this.receteHastaBindingSource.DataMember = "ReceteHasta";
            this.receteHastaBindingSource.DataSource = this.hastaneDBDataSet22;
            // 
            // receteHastaTableAdapter
            // 
            this.receteHastaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(403, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "REÇETE BİLGİ";
            // 
            // hastaneDBDataSet23
            // 
            this.hastaneDBDataSet23.DataSetName = "HastaneDBDataSet23";
            this.hastaneDBDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaneDBDataSet23BindingSource
            // 
            this.hastaneDBDataSet23BindingSource.DataSource = this.hastaneDBDataSet23;
            this.hastaneDBDataSet23BindingSource.Position = 0;
            // 
            // receteDetayBindingSource
            // 
            this.receteDetayBindingSource.DataMember = "ReceteDetay";
            this.receteDetayBindingSource.DataSource = this.hastaneDBDataSet23BindingSource;
            // 
            // receteDetayTableAdapter
            // 
            this.receteDetayTableAdapter.ClearBeforeFill = true;
            // 
            // hastaneDBDataSet24
            // 
            this.hastaneDBDataSet24.DataSetName = "HastaneDBDataSet24";
            this.hastaneDBDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receteDetayBindingSource1
            // 
            this.receteDetayBindingSource1.DataMember = "ReceteDetay";
            this.receteDetayBindingSource1.DataSource = this.hastaneDBDataSet24;
            // 
            // receteDetayTableAdapter1
            // 
            this.receteDetayTableAdapter1.ClearBeforeFill = true;
            // 
            // rcidDataGridViewTextBoxColumn
            // 
            this.rcidDataGridViewTextBoxColumn.DataPropertyName = "Rcid";
            this.rcidDataGridViewTextBoxColumn.HeaderText = "Rcid";
            this.rcidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rcidDataGridViewTextBoxColumn.Name = "rcidDataGridViewTextBoxColumn";
            this.rcidDataGridViewTextBoxColumn.ReadOnly = true;
            this.rcidDataGridViewTextBoxColumn.Visible = false;
            // 
            // hsidDataGridViewTextBoxColumn
            // 
            this.hsidDataGridViewTextBoxColumn.DataPropertyName = "Hsid";
            this.hsidDataGridViewTextBoxColumn.HeaderText = "Hsid";
            this.hsidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hsidDataGridViewTextBoxColumn.Name = "hsidDataGridViewTextBoxColumn";
            // 
            // hsAdDataGridViewTextBoxColumn
            // 
            this.hsAdDataGridViewTextBoxColumn.DataPropertyName = "HsAd";
            this.hsAdDataGridViewTextBoxColumn.HeaderText = "HsAd";
            this.hsAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hsAdDataGridViewTextBoxColumn.Name = "hsAdDataGridViewTextBoxColumn";
            // 
            // hsSoyadDataGridViewTextBoxColumn
            // 
            this.hsSoyadDataGridViewTextBoxColumn.DataPropertyName = "HsSoyad";
            this.hsSoyadDataGridViewTextBoxColumn.HeaderText = "HsSoyad";
            this.hsSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hsSoyadDataGridViewTextBoxColumn.Name = "hsSoyadDataGridViewTextBoxColumn";
            // 
            // hsTcDataGridViewTextBoxColumn
            // 
            this.hsTcDataGridViewTextBoxColumn.DataPropertyName = "HsTc";
            this.hsTcDataGridViewTextBoxColumn.HeaderText = "HsTc";
            this.hsTcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hsTcDataGridViewTextBoxColumn.Name = "hsTcDataGridViewTextBoxColumn";
            // 
            // dkidDataGridViewTextBoxColumn
            // 
            this.dkidDataGridViewTextBoxColumn.DataPropertyName = "Dkid";
            this.dkidDataGridViewTextBoxColumn.HeaderText = "Dkid";
            this.dkidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dkidDataGridViewTextBoxColumn.Name = "dkidDataGridViewTextBoxColumn";
            this.dkidDataGridViewTextBoxColumn.Visible = false;
            // 
            // receteTarihDataGridViewTextBoxColumn
            // 
            this.receteTarihDataGridViewTextBoxColumn.DataPropertyName = "ReceteTarih";
            this.receteTarihDataGridViewTextBoxColumn.HeaderText = "ReceteTarih";
            this.receteTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receteTarihDataGridViewTextBoxColumn.Name = "receteTarihDataGridViewTextBoxColumn";
            // 
            // RcToplam
            // 
            this.RcToplam.DataPropertyName = "RcToplam";
            this.RcToplam.HeaderText = "RcToplam";
            this.RcToplam.MinimumWidth = 6;
            this.RcToplam.Name = "RcToplam";
            // 
            // rcBilgiDataGridViewTextBoxColumn
            // 
            this.rcBilgiDataGridViewTextBoxColumn.DataPropertyName = "RcBilgi";
            this.rcBilgiDataGridViewTextBoxColumn.HeaderText = "RcBilgi";
            this.rcBilgiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rcBilgiDataGridViewTextBoxColumn.Name = "rcBilgiDataGridViewTextBoxColumn";
            // 
            // Receteler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GeriB);
            this.Name = "Receteler";
            this.Text = "Receteler";
            this.Load += new System.EventHandler(this.Receteler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receteHastaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet23BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receteDetayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receteDetayBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GeriB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HastaneDBDataSet22 hastaneDBDataSet22;
        private System.Windows.Forms.BindingSource receteHastaBindingSource;
        private HastaneDBDataSet22TableAdapters.ReceteHastaTableAdapter receteHastaTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource hastaneDBDataSet23BindingSource;
        private HastaneDBDataSet23 hastaneDBDataSet23;
        private System.Windows.Forms.BindingSource receteDetayBindingSource;
        private HastaneDBDataSet23TableAdapters.ReceteDetayTableAdapter receteDetayTableAdapter;
        private HastaneDBDataSet24 hastaneDBDataSet24;
        private System.Windows.Forms.BindingSource receteDetayBindingSource1;
        private HastaneDBDataSet24TableAdapters.ReceteDetayTableAdapter receteDetayTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rcidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dkidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receteTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RcToplam;
        private System.Windows.Forms.DataGridViewTextBoxColumn rcBilgiDataGridViewTextBoxColumn;
    }
}