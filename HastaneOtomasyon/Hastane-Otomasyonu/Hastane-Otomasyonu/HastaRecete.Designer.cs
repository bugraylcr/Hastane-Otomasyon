namespace Hastane_Otomasyonu
{
    partial class HastaRecete
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
            this.GeriMhrs = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.hastaneDBDataSet24 = new Hastane_Otomasyonu.HastaneDBDataSet24();
            this.receteDetayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receteDetayTableAdapter = new Hastane_Otomasyonu.HastaneDBDataSet24TableAdapters.ReceteDetayTableAdapter();
            this.rcidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dkidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receteTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcBilgiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcToplamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receteDetayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GeriMhrs
            // 
            this.GeriMhrs.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GeriMhrs.Location = new System.Drawing.Point(23, 22);
            this.GeriMhrs.Name = "GeriMhrs";
            this.GeriMhrs.Size = new System.Drawing.Size(140, 73);
            this.GeriMhrs.TabIndex = 0;
            this.GeriMhrs.Text = "Geri dön";
            this.GeriMhrs.UseVisualStyleBackColor = true;
            this.GeriMhrs.Click += new System.EventHandler(this.GeriMhrs_Click);
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
            this.dkidDataGridViewTextBoxColumn,
            this.hsAdDataGridViewTextBoxColumn,
            this.hsSoyadDataGridViewTextBoxColumn,
            this.hsTcDataGridViewTextBoxColumn,
            this.receteTarihDataGridViewTextBoxColumn,
            this.rcBilgiDataGridViewTextBoxColumn,
            this.rcToplamDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.receteDetayBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(965, 315);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(421, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hasta Reçete";
            // 
            // hastaneDBDataSet24
            // 
            this.hastaneDBDataSet24.DataSetName = "HastaneDBDataSet24";
            this.hastaneDBDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receteDetayBindingSource
            // 
            this.receteDetayBindingSource.DataMember = "ReceteDetay";
            this.receteDetayBindingSource.DataSource = this.hastaneDBDataSet24;
            // 
            // receteDetayTableAdapter
            // 
            this.receteDetayTableAdapter.ClearBeforeFill = true;
            // 
            // rcidDataGridViewTextBoxColumn
            // 
            this.rcidDataGridViewTextBoxColumn.DataPropertyName = "Rcid";
            this.rcidDataGridViewTextBoxColumn.HeaderText = "Rcid";
            this.rcidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rcidDataGridViewTextBoxColumn.Name = "rcidDataGridViewTextBoxColumn";
            this.rcidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hsidDataGridViewTextBoxColumn
            // 
            this.hsidDataGridViewTextBoxColumn.DataPropertyName = "Hsid";
            this.hsidDataGridViewTextBoxColumn.HeaderText = "Hsid";
            this.hsidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hsidDataGridViewTextBoxColumn.Name = "hsidDataGridViewTextBoxColumn";
            // 
            // dkidDataGridViewTextBoxColumn
            // 
            this.dkidDataGridViewTextBoxColumn.DataPropertyName = "Dkid";
            this.dkidDataGridViewTextBoxColumn.HeaderText = "Dkid";
            this.dkidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dkidDataGridViewTextBoxColumn.Name = "dkidDataGridViewTextBoxColumn";
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
            // receteTarihDataGridViewTextBoxColumn
            // 
            this.receteTarihDataGridViewTextBoxColumn.DataPropertyName = "ReceteTarih";
            this.receteTarihDataGridViewTextBoxColumn.HeaderText = "ReceteTarih";
            this.receteTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receteTarihDataGridViewTextBoxColumn.Name = "receteTarihDataGridViewTextBoxColumn";
            // 
            // rcBilgiDataGridViewTextBoxColumn
            // 
            this.rcBilgiDataGridViewTextBoxColumn.DataPropertyName = "RcBilgi";
            this.rcBilgiDataGridViewTextBoxColumn.HeaderText = "RcBilgi";
            this.rcBilgiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rcBilgiDataGridViewTextBoxColumn.Name = "rcBilgiDataGridViewTextBoxColumn";
            // 
            // rcToplamDataGridViewTextBoxColumn
            // 
            this.rcToplamDataGridViewTextBoxColumn.DataPropertyName = "RcToplam";
            this.rcToplamDataGridViewTextBoxColumn.HeaderText = "RcToplam";
            this.rcToplamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rcToplamDataGridViewTextBoxColumn.Name = "rcToplamDataGridViewTextBoxColumn";
            this.rcToplamDataGridViewTextBoxColumn.Visible = false;
            // 
            // HastaRecete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GeriMhrs);
            this.Name = "HastaRecete";
            this.Text = "HastaRecete";
            this.Load += new System.EventHandler(this.HastaRecete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receteDetayBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GeriMhrs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private HastaneDBDataSet24 hastaneDBDataSet24;
        private System.Windows.Forms.BindingSource receteDetayBindingSource;
        private HastaneDBDataSet24TableAdapters.ReceteDetayTableAdapter receteDetayTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rcidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dkidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receteTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rcBilgiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rcToplamDataGridViewTextBoxColumn;
    }
}