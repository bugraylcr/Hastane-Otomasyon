namespace Hastane_Otomasyonu
{
    partial class RandevuDetay
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
            this.hastaAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuDetayBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDBDataSet17 = new Hastane_Otomasyonu.HastaneDBDataSet17();
            this.randevuDetayBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.hastaneDBDataSet16 = new Hastane_Otomasyonu.HastaneDBDataSet16();
            this.randevuDetayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.randevuDetayTableAdapter = new Hastane_Otomasyonu.HastaneDBDataSet16TableAdapters.RandevuDetayTableAdapter();
            this.randevuDetayBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.randevuDetayTableAdapter1 = new Hastane_Otomasyonu.HastaneDBDataSet17TableAdapters.RandevuDetayTableAdapter();
            this.randevuBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.randevuBilgiTableAdapter = new Hastane_Otomasyonu.HastaneDBDataSet17TableAdapters.RandevuBilgiTableAdapter();
            this.HastaTc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToplamRandevu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Randevuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KayitTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuDetayBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuDetayBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuDetayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuDetayBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuBilgiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GeriB
            // 
            this.GeriB.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GeriB.Location = new System.Drawing.Point(12, 12);
            this.GeriB.Name = "GeriB";
            this.GeriB.Size = new System.Drawing.Size(158, 72);
            this.GeriB.TabIndex = 0;
            this.GeriB.Text = "Geri Dön";
            this.GeriB.UseVisualStyleBackColor = true;
            this.GeriB.Click += new System.EventHandler(this.GeriB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hastaAdDataGridViewTextBoxColumn,
            this.hastaSoyadDataGridViewTextBoxColumn,
            this.doktorAdDataGridViewTextBoxColumn,
            this.HastaTc,
            this.ToplamRandevu,
            this.Randevuid,
            this.KayitTarih});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.randevuDetayBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(21, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(798, 330);
            this.dataGridView1.TabIndex = 1;
            // 
            // hastaAdDataGridViewTextBoxColumn
            // 
            this.hastaAdDataGridViewTextBoxColumn.DataPropertyName = "HastaAd";
            this.hastaAdDataGridViewTextBoxColumn.HeaderText = "HastaAd";
            this.hastaAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hastaAdDataGridViewTextBoxColumn.Name = "hastaAdDataGridViewTextBoxColumn";
            // 
            // hastaSoyadDataGridViewTextBoxColumn
            // 
            this.hastaSoyadDataGridViewTextBoxColumn.DataPropertyName = "HastaSoyad";
            this.hastaSoyadDataGridViewTextBoxColumn.HeaderText = "HastaSoyad";
            this.hastaSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hastaSoyadDataGridViewTextBoxColumn.Name = "hastaSoyadDataGridViewTextBoxColumn";
            // 
            // doktorAdDataGridViewTextBoxColumn
            // 
            this.doktorAdDataGridViewTextBoxColumn.DataPropertyName = "DoktorAd";
            this.doktorAdDataGridViewTextBoxColumn.HeaderText = "DoktorAd";
            this.doktorAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doktorAdDataGridViewTextBoxColumn.Name = "doktorAdDataGridViewTextBoxColumn";
            // 
            // randevuDetayBindingSource2
            // 
            this.randevuDetayBindingSource2.DataMember = "RandevuDetay";
            this.randevuDetayBindingSource2.DataSource = this.hastaneDBDataSet17;
            // 
            // hastaneDBDataSet17
            // 
            this.hastaneDBDataSet17.DataSetName = "HastaneDBDataSet17";
            this.hastaneDBDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // randevuDetayBindingSource3
            // 
            this.randevuDetayBindingSource3.DataMember = "RandevuDetay";
            this.randevuDetayBindingSource3.DataSource = this.hastaneDBDataSet17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(363, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Randevu Detay";
            // 
            // hastaneDBDataSet16
            // 
            this.hastaneDBDataSet16.DataSetName = "HastaneDBDataSet16";
            this.hastaneDBDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // randevuDetayBindingSource
            // 
            this.randevuDetayBindingSource.DataMember = "RandevuDetay";
            this.randevuDetayBindingSource.DataSource = this.hastaneDBDataSet16;
            // 
            // randevuDetayTableAdapter
            // 
            this.randevuDetayTableAdapter.ClearBeforeFill = true;
            // 
            // randevuDetayBindingSource1
            // 
            this.randevuDetayBindingSource1.DataMember = "RandevuDetay";
            this.randevuDetayBindingSource1.DataSource = this.hastaneDBDataSet17;
            // 
            // randevuDetayTableAdapter1
            // 
            this.randevuDetayTableAdapter1.ClearBeforeFill = true;
            // 
            // randevuBilgiBindingSource
            // 
            this.randevuBilgiBindingSource.DataMember = "RandevuBilgi";
            this.randevuBilgiBindingSource.DataSource = this.hastaneDBDataSet17;
            // 
            // randevuBilgiTableAdapter
            // 
            this.randevuBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // HastaTc
            // 
            this.HastaTc.DataPropertyName = "HastaTc";
            this.HastaTc.HeaderText = "HastaTc";
            this.HastaTc.MinimumWidth = 6;
            this.HastaTc.Name = "HastaTc";
            // 
            // ToplamRandevu
            // 
            this.ToplamRandevu.DataPropertyName = "ToplamRandevu";
            this.ToplamRandevu.HeaderText = "ToplamRandevu";
            this.ToplamRandevu.MinimumWidth = 6;
            this.ToplamRandevu.Name = "ToplamRandevu";
            // 
            // Randevuid
            // 
            this.Randevuid.DataPropertyName = "Randevuid";
            this.Randevuid.HeaderText = "Randevuid";
            this.Randevuid.MinimumWidth = 6;
            this.Randevuid.Name = "Randevuid";
            // 
            // KayitTarih
            // 
            this.KayitTarih.DataPropertyName = "KayitTarih";
            this.KayitTarih.HeaderText = "KayitTarih";
            this.KayitTarih.MinimumWidth = 6;
            this.KayitTarih.Name = "KayitTarih";
            // 
            // RandevuDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GeriB);
            this.Name = "RandevuDetay";
            this.Text = "RandevuDetay";
            this.Load += new System.EventHandler(this.RandevuDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuDetayBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuDetayBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuDetayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuDetayBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuBilgiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GeriB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private HastaneDBDataSet16 hastaneDBDataSet16;
        private System.Windows.Forms.BindingSource randevuDetayBindingSource;
        private HastaneDBDataSet16TableAdapters.RandevuDetayTableAdapter randevuDetayTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorAdDataGridViewTextBoxColumn;
        private HastaneDBDataSet17 hastaneDBDataSet17;
        private System.Windows.Forms.BindingSource randevuDetayBindingSource1;
        private HastaneDBDataSet17TableAdapters.RandevuDetayTableAdapter randevuDetayTableAdapter1;
        private System.Windows.Forms.BindingSource randevuDetayBindingSource2;
        private System.Windows.Forms.BindingSource randevuDetayBindingSource3;
        private System.Windows.Forms.BindingSource randevuBilgiBindingSource;
        private HastaneDBDataSet17TableAdapters.RandevuBilgiTableAdapter randevuBilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaTc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToplamRandevu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Randevuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn KayitTarih;
    }
}