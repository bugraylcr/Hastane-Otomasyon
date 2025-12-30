namespace Hastane_Otomasyonu
{
    partial class DoktorDetay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Geri = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doktorAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamDoktorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorlarDetayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDBDataSet4 = new Hastane_Otomasyonu.HastaneDBDataSet4();
            this.doktorlarDetayTableAdapter = new Hastane_Otomasyonu.HastaneDBDataSet4TableAdapters.DoktorlarDetayTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.hastaneDBDataSet9 = new Hastane_Otomasyonu.HastaneDBDataSet9();
            this.hastaneDBDataSet9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silinenDoktorlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silinenDoktorlarTableAdapter = new Hastane_Otomasyonu.HastaneDBDataSet9TableAdapters.SilinenDoktorlarTableAdapter();
            this.silidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorAdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorSoyadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silinmeTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorlarDetayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet9BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silinenDoktorlarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Geri
            // 
            this.Geri.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Geri.Location = new System.Drawing.Point(26, 25);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(155, 77);
            this.Geri.TabIndex = 0;
            this.Geri.Text = "GERİ";
            this.Geri.UseVisualStyleBackColor = true;
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doktorAdDataGridViewTextBoxColumn,
            this.doktorSoyadDataGridViewTextBoxColumn,
            this.toplamDoktorDataGridViewTextBoxColumn,
            this.kayitTarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doktorlarDetayBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.Location = new System.Drawing.Point(12, 191);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(496, 260);
            this.dataGridView1.TabIndex = 1;
            // 
            // doktorAdDataGridViewTextBoxColumn
            // 
            this.doktorAdDataGridViewTextBoxColumn.DataPropertyName = "DoktorAd";
            this.doktorAdDataGridViewTextBoxColumn.HeaderText = "   DoktorAd";
            this.doktorAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doktorAdDataGridViewTextBoxColumn.Name = "doktorAdDataGridViewTextBoxColumn";
            // 
            // doktorSoyadDataGridViewTextBoxColumn
            // 
            this.doktorSoyadDataGridViewTextBoxColumn.DataPropertyName = "DoktorSoyad";
            this.doktorSoyadDataGridViewTextBoxColumn.HeaderText = "DoktorSoyad";
            this.doktorSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doktorSoyadDataGridViewTextBoxColumn.Name = "doktorSoyadDataGridViewTextBoxColumn";
            // 
            // toplamDoktorDataGridViewTextBoxColumn
            // 
            this.toplamDoktorDataGridViewTextBoxColumn.DataPropertyName = "ToplamDoktor";
            this.toplamDoktorDataGridViewTextBoxColumn.HeaderText = "ToplamDoktor";
            this.toplamDoktorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toplamDoktorDataGridViewTextBoxColumn.Name = "toplamDoktorDataGridViewTextBoxColumn";
            // 
            // kayitTarihDataGridViewTextBoxColumn
            // 
            this.kayitTarihDataGridViewTextBoxColumn.DataPropertyName = "KayitTarih";
            this.kayitTarihDataGridViewTextBoxColumn.HeaderText = "  KayitTarih";
            this.kayitTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kayitTarihDataGridViewTextBoxColumn.Name = "kayitTarihDataGridViewTextBoxColumn";
            // 
            // doktorlarDetayBindingSource
            // 
            this.doktorlarDetayBindingSource.DataMember = "DoktorlarDetay";
            this.doktorlarDetayBindingSource.DataSource = this.hastaneDBDataSet4;
            // 
            // hastaneDBDataSet4
            // 
            this.hastaneDBDataSet4.DataSetName = "HastaneDBDataSet4";
            this.hastaneDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doktorlarDetayTableAdapter
            // 
            this.doktorlarDetayTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(180, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kayıtlı Olanlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(848, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Silinenler";
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
            this.doktorAdDataGridViewTextBoxColumn1,
            this.doktorSoyadDataGridViewTextBoxColumn1,
            this.silinmeTarihDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.silinenDoktorlarBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(619, 191);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(524, 258);
            this.dataGridView2.TabIndex = 4;
            // 
            // hastaneDBDataSet9
            // 
            this.hastaneDBDataSet9.DataSetName = "HastaneDBDataSet9";
            this.hastaneDBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaneDBDataSet9BindingSource
            // 
            this.hastaneDBDataSet9BindingSource.DataSource = this.hastaneDBDataSet9;
            this.hastaneDBDataSet9BindingSource.Position = 0;
            // 
            // silinenDoktorlarBindingSource
            // 
            this.silinenDoktorlarBindingSource.DataMember = "SilinenDoktorlar";
            this.silinenDoktorlarBindingSource.DataSource = this.hastaneDBDataSet9BindingSource;
            // 
            // silinenDoktorlarTableAdapter
            // 
            this.silinenDoktorlarTableAdapter.ClearBeforeFill = true;
            // 
            // silidDataGridViewTextBoxColumn
            // 
            this.silidDataGridViewTextBoxColumn.DataPropertyName = "Silid";
            this.silidDataGridViewTextBoxColumn.HeaderText = "Silid";
            this.silidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.silidDataGridViewTextBoxColumn.Name = "silidDataGridViewTextBoxColumn";
            this.silidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doktorAdDataGridViewTextBoxColumn1
            // 
            this.doktorAdDataGridViewTextBoxColumn1.DataPropertyName = "DoktorAd";
            this.doktorAdDataGridViewTextBoxColumn1.HeaderText = "DoktorAd";
            this.doktorAdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.doktorAdDataGridViewTextBoxColumn1.Name = "doktorAdDataGridViewTextBoxColumn1";
            // 
            // doktorSoyadDataGridViewTextBoxColumn1
            // 
            this.doktorSoyadDataGridViewTextBoxColumn1.DataPropertyName = "DoktorSoyad";
            this.doktorSoyadDataGridViewTextBoxColumn1.HeaderText = "DoktorSoyad";
            this.doktorSoyadDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.doktorSoyadDataGridViewTextBoxColumn1.Name = "doktorSoyadDataGridViewTextBoxColumn1";
            // 
            // silinmeTarihDataGridViewTextBoxColumn
            // 
            this.silinmeTarihDataGridViewTextBoxColumn.DataPropertyName = "SilinmeTarih";
            this.silinmeTarihDataGridViewTextBoxColumn.HeaderText = "SilinmeTarih";
            this.silinmeTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.silinmeTarihDataGridViewTextBoxColumn.Name = "silinmeTarihDataGridViewTextBoxColumn";
            // 
            // DoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 503);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Geri);
            this.Name = "DoktorDetay";
            this.Text = "DoktorDetay";
            this.Load += new System.EventHandler(this.DoktorDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorlarDetayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet9BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silinenDoktorlarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Geri;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HastaneDBDataSet4 hastaneDBDataSet4;
        private System.Windows.Forms.BindingSource doktorlarDetayBindingSource;
        private HastaneDBDataSet4TableAdapters.DoktorlarDetayTableAdapter doktorlarDetayTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamDoktorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource hastaneDBDataSet9BindingSource;
        private HastaneDBDataSet9 hastaneDBDataSet9;
        private System.Windows.Forms.BindingSource silinenDoktorlarBindingSource;
        private HastaneDBDataSet9TableAdapters.SilinenDoktorlarTableAdapter silinenDoktorlarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn silidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorAdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorSoyadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn silinmeTarihDataGridViewTextBoxColumn;
    }
}