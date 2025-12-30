namespace Hastane_Otomasyonu
{
    partial class HastaDetay
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hastaneDBDataSet11 = new Hastane_Otomasyonu.HastaneDBDataSet11();
            this.hastaneDBDataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaDetayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaDetayTableAdapter = new Hastane_Otomasyonu.HastaneDBDataSet11TableAdapters.HastaDetayTableAdapter();
            this.adHastaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadHastaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamHastaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaneDBDataSet12 = new Hastane_Otomasyonu.HastaneDBDataSet12();
            this.hastaneDBDataSet12BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silinenHastalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silinenHastalarTableAdapter = new Hastane_Otomasyonu.HastaneDBDataSet12TableAdapters.SilinenHastalarTableAdapter();
            this.silidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adHastaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadHastaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silinmeTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaDetayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet12BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silinenHastalarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "GERİ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.adHastaDataGridViewTextBoxColumn,
            this.soyadHastaDataGridViewTextBoxColumn,
            this.toplamHastaDataGridViewTextBoxColumn,
            this.kayitTarihDataGridViewTextBoxColumn,
            this.hastaidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hastaDetayBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(536, 308);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.silidDataGridViewTextBoxColumn,
            this.adHastaDataGridViewTextBoxColumn1,
            this.soyadHastaDataGridViewTextBoxColumn1,
            this.silinmeTarihDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.silinenHastalarBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(623, 161);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(537, 308);
            this.dataGridView2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(209, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kayıt olanlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(863, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Silinenler";
            // 
            // hastaneDBDataSet11
            // 
            this.hastaneDBDataSet11.DataSetName = "HastaneDBDataSet11";
            this.hastaneDBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaneDBDataSet11BindingSource
            // 
            this.hastaneDBDataSet11BindingSource.DataSource = this.hastaneDBDataSet11;
            this.hastaneDBDataSet11BindingSource.Position = 0;
            // 
            // hastaDetayBindingSource
            // 
            this.hastaDetayBindingSource.DataMember = "HastaDetay";
            this.hastaDetayBindingSource.DataSource = this.hastaneDBDataSet11BindingSource;
            // 
            // hastaDetayTableAdapter
            // 
            this.hastaDetayTableAdapter.ClearBeforeFill = true;
            // 
            // adHastaDataGridViewTextBoxColumn
            // 
            this.adHastaDataGridViewTextBoxColumn.DataPropertyName = "AdHasta";
            this.adHastaDataGridViewTextBoxColumn.HeaderText = "AdHasta";
            this.adHastaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adHastaDataGridViewTextBoxColumn.Name = "adHastaDataGridViewTextBoxColumn";
            // 
            // soyadHastaDataGridViewTextBoxColumn
            // 
            this.soyadHastaDataGridViewTextBoxColumn.DataPropertyName = "SoyadHasta";
            this.soyadHastaDataGridViewTextBoxColumn.HeaderText = "SoyadHasta";
            this.soyadHastaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadHastaDataGridViewTextBoxColumn.Name = "soyadHastaDataGridViewTextBoxColumn";
            // 
            // toplamHastaDataGridViewTextBoxColumn
            // 
            this.toplamHastaDataGridViewTextBoxColumn.DataPropertyName = "ToplamHasta";
            this.toplamHastaDataGridViewTextBoxColumn.HeaderText = "ToplamHasta";
            this.toplamHastaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toplamHastaDataGridViewTextBoxColumn.Name = "toplamHastaDataGridViewTextBoxColumn";
            // 
            // kayitTarihDataGridViewTextBoxColumn
            // 
            this.kayitTarihDataGridViewTextBoxColumn.DataPropertyName = "KayitTarih";
            this.kayitTarihDataGridViewTextBoxColumn.HeaderText = "KayitTarih";
            this.kayitTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kayitTarihDataGridViewTextBoxColumn.Name = "kayitTarihDataGridViewTextBoxColumn";
            // 
            // hastaidDataGridViewTextBoxColumn
            // 
            this.hastaidDataGridViewTextBoxColumn.DataPropertyName = "Hastaid";
            this.hastaidDataGridViewTextBoxColumn.HeaderText = "Hastaid";
            this.hastaidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hastaidDataGridViewTextBoxColumn.Name = "hastaidDataGridViewTextBoxColumn";
            // 
            // hastaneDBDataSet12
            // 
            this.hastaneDBDataSet12.DataSetName = "HastaneDBDataSet12";
            this.hastaneDBDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaneDBDataSet12BindingSource
            // 
            this.hastaneDBDataSet12BindingSource.DataSource = this.hastaneDBDataSet12;
            this.hastaneDBDataSet12BindingSource.Position = 0;
            // 
            // silinenHastalarBindingSource
            // 
            this.silinenHastalarBindingSource.DataMember = "SilinenHastalar";
            this.silinenHastalarBindingSource.DataSource = this.hastaneDBDataSet12BindingSource;
            // 
            // silinenHastalarTableAdapter
            // 
            this.silinenHastalarTableAdapter.ClearBeforeFill = true;
            // 
            // silidDataGridViewTextBoxColumn
            // 
            this.silidDataGridViewTextBoxColumn.DataPropertyName = "Silid";
            this.silidDataGridViewTextBoxColumn.HeaderText = "Silid";
            this.silidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.silidDataGridViewTextBoxColumn.Name = "silidDataGridViewTextBoxColumn";
            this.silidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adHastaDataGridViewTextBoxColumn1
            // 
            this.adHastaDataGridViewTextBoxColumn1.DataPropertyName = "AdHasta";
            this.adHastaDataGridViewTextBoxColumn1.HeaderText = "AdHasta";
            this.adHastaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.adHastaDataGridViewTextBoxColumn1.Name = "adHastaDataGridViewTextBoxColumn1";
            // 
            // soyadHastaDataGridViewTextBoxColumn1
            // 
            this.soyadHastaDataGridViewTextBoxColumn1.DataPropertyName = "SoyadHasta";
            this.soyadHastaDataGridViewTextBoxColumn1.HeaderText = "SoyadHasta";
            this.soyadHastaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.soyadHastaDataGridViewTextBoxColumn1.Name = "soyadHastaDataGridViewTextBoxColumn1";
            // 
            // silinmeTarihDataGridViewTextBoxColumn
            // 
            this.silinmeTarihDataGridViewTextBoxColumn.DataPropertyName = "SilinmeTarih";
            this.silinmeTarihDataGridViewTextBoxColumn.HeaderText = "SilinmeTarih";
            this.silinmeTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.silinmeTarihDataGridViewTextBoxColumn.Name = "silinmeTarihDataGridViewTextBoxColumn";
            // 
            // HastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 503);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "HastaDetay";
            this.Text = "HastaDetay";
            this.Load += new System.EventHandler(this.HastaDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaDetayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet12BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silinenHastalarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource hastaneDBDataSet11BindingSource;
        private HastaneDBDataSet11 hastaneDBDataSet11;
        private System.Windows.Forms.BindingSource hastaDetayBindingSource;
        private HastaneDBDataSet11TableAdapters.HastaDetayTableAdapter hastaDetayTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adHastaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadHastaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamHastaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hastaneDBDataSet12BindingSource;
        private HastaneDBDataSet12 hastaneDBDataSet12;
        private System.Windows.Forms.BindingSource silinenHastalarBindingSource;
        private HastaneDBDataSet12TableAdapters.SilinenHastalarTableAdapter silinenHastalarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn silidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adHastaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadHastaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn silinmeTarihDataGridViewTextBoxColumn;
    }
}