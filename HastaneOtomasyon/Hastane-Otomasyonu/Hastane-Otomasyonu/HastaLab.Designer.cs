namespace Hastane_Otomasyonu
{
    partial class HastaLab
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
            this.GBu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kanidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hemoglobinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trombositDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glukozDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokositDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kanTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kanSonucBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDBDataSet30 = new Hastane_Otomasyonu.HastaneDBDataSet30();
            this.kanSonucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kanSonucTableAdapter = new Hastane_Otomasyonu.HastaneDBDataSet30TableAdapters.KanSonucTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.rontgenidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktoridDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaAdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaSoyadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rontgenBransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaTcDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rontgenTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rontgenGoruntuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rontgenSonucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rontgenSonucTableAdapter = new Hastane_Otomasyonu.HastaneDBDataSet30TableAdapters.RontgenSonucTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.receteDetayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receteDetayTableAdapter = new Hastane_Otomasyonu.HastaneDBDataSet30TableAdapters.ReceteDetayTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanSonucBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanSonucBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rontgenSonucBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receteDetayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GBu
            // 
            this.GBu.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GBu.Location = new System.Drawing.Point(24, 30);
            this.GBu.Name = "GBu";
            this.GBu.Size = new System.Drawing.Size(145, 68);
            this.GBu.TabIndex = 0;
            this.GBu.Text = "Geri Dön";
            this.GBu.UseVisualStyleBackColor = true;
            this.GBu.Click += new System.EventHandler(this.GBu_Click);
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
            this.kanidDataGridViewTextBoxColumn,
            this.hastaidDataGridViewTextBoxColumn,
            this.doktoridDataGridViewTextBoxColumn,
            this.hastaAdDataGridViewTextBoxColumn,
            this.hastaSoyadDataGridViewTextBoxColumn,
            this.hastaTcDataGridViewTextBoxColumn,
            this.hemoglobinDataGridViewTextBoxColumn,
            this.trombositDataGridViewTextBoxColumn,
            this.glukozDataGridViewTextBoxColumn,
            this.lokositDataGridViewTextBoxColumn,
            this.kanTarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kanSonucBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(360, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(791, 310);
            this.dataGridView1.TabIndex = 1;
            // 
            // kanidDataGridViewTextBoxColumn
            // 
            this.kanidDataGridViewTextBoxColumn.DataPropertyName = "Kanid";
            this.kanidDataGridViewTextBoxColumn.HeaderText = "Kanid";
            this.kanidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kanidDataGridViewTextBoxColumn.Name = "kanidDataGridViewTextBoxColumn";
            this.kanidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hastaidDataGridViewTextBoxColumn
            // 
            this.hastaidDataGridViewTextBoxColumn.DataPropertyName = "Hastaid";
            this.hastaidDataGridViewTextBoxColumn.HeaderText = "Hastaid";
            this.hastaidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hastaidDataGridViewTextBoxColumn.Name = "hastaidDataGridViewTextBoxColumn";
            this.hastaidDataGridViewTextBoxColumn.Visible = false;
            // 
            // doktoridDataGridViewTextBoxColumn
            // 
            this.doktoridDataGridViewTextBoxColumn.DataPropertyName = "Doktorid";
            this.doktoridDataGridViewTextBoxColumn.HeaderText = "Doktorid";
            this.doktoridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doktoridDataGridViewTextBoxColumn.Name = "doktoridDataGridViewTextBoxColumn";
            // 
            // hastaAdDataGridViewTextBoxColumn
            // 
            this.hastaAdDataGridViewTextBoxColumn.DataPropertyName = "HastaAd";
            this.hastaAdDataGridViewTextBoxColumn.HeaderText = "HastaAd";
            this.hastaAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hastaAdDataGridViewTextBoxColumn.Name = "hastaAdDataGridViewTextBoxColumn";
            this.hastaAdDataGridViewTextBoxColumn.Visible = false;
            // 
            // hastaSoyadDataGridViewTextBoxColumn
            // 
            this.hastaSoyadDataGridViewTextBoxColumn.DataPropertyName = "HastaSoyad";
            this.hastaSoyadDataGridViewTextBoxColumn.HeaderText = "HastaSoyad";
            this.hastaSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hastaSoyadDataGridViewTextBoxColumn.Name = "hastaSoyadDataGridViewTextBoxColumn";
            this.hastaSoyadDataGridViewTextBoxColumn.Visible = false;
            // 
            // hastaTcDataGridViewTextBoxColumn
            // 
            this.hastaTcDataGridViewTextBoxColumn.DataPropertyName = "HastaTc";
            this.hastaTcDataGridViewTextBoxColumn.HeaderText = "HastaTc";
            this.hastaTcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hastaTcDataGridViewTextBoxColumn.Name = "hastaTcDataGridViewTextBoxColumn";
            this.hastaTcDataGridViewTextBoxColumn.Visible = false;
            // 
            // hemoglobinDataGridViewTextBoxColumn
            // 
            this.hemoglobinDataGridViewTextBoxColumn.DataPropertyName = "Hemoglobin";
            this.hemoglobinDataGridViewTextBoxColumn.HeaderText = "Hemoglobin";
            this.hemoglobinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hemoglobinDataGridViewTextBoxColumn.Name = "hemoglobinDataGridViewTextBoxColumn";
            // 
            // trombositDataGridViewTextBoxColumn
            // 
            this.trombositDataGridViewTextBoxColumn.DataPropertyName = "Trombosit";
            this.trombositDataGridViewTextBoxColumn.HeaderText = "Trombosit";
            this.trombositDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trombositDataGridViewTextBoxColumn.Name = "trombositDataGridViewTextBoxColumn";
            // 
            // glukozDataGridViewTextBoxColumn
            // 
            this.glukozDataGridViewTextBoxColumn.DataPropertyName = "Glukoz";
            this.glukozDataGridViewTextBoxColumn.HeaderText = "Glukoz";
            this.glukozDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.glukozDataGridViewTextBoxColumn.Name = "glukozDataGridViewTextBoxColumn";
            // 
            // lokositDataGridViewTextBoxColumn
            // 
            this.lokositDataGridViewTextBoxColumn.DataPropertyName = "Lokosit";
            this.lokositDataGridViewTextBoxColumn.HeaderText = "Lokosit";
            this.lokositDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lokositDataGridViewTextBoxColumn.Name = "lokositDataGridViewTextBoxColumn";
            // 
            // kanTarihDataGridViewTextBoxColumn
            // 
            this.kanTarihDataGridViewTextBoxColumn.DataPropertyName = "KanTarih";
            this.kanTarihDataGridViewTextBoxColumn.HeaderText = "KanTarih";
            this.kanTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kanTarihDataGridViewTextBoxColumn.Name = "kanTarihDataGridViewTextBoxColumn";
            // 
            // kanSonucBindingSource1
            // 
            this.kanSonucBindingSource1.DataMember = "KanSonuc";
            this.kanSonucBindingSource1.DataSource = this.hastaneDBDataSet30;
            // 
            // hastaneDBDataSet30
            // 
            this.hastaneDBDataSet30.DataSetName = "HastaneDBDataSet30";
            this.hastaneDBDataSet30.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kanSonucBindingSource
            // 
            this.kanSonucBindingSource.DataMember = "KanSonuc";
            this.kanSonucBindingSource.DataSource = this.hastaneDBDataSet30;
            // 
            // kanSonucTableAdapter
            // 
            this.kanSonucTableAdapter.ClearBeforeFill = true;
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
            this.rontgenidDataGridViewTextBoxColumn,
            this.hastaidDataGridViewTextBoxColumn1,
            this.doktoridDataGridViewTextBoxColumn1,
            this.hastaAdDataGridViewTextBoxColumn1,
            this.hastaSoyadDataGridViewTextBoxColumn1,
            this.rontgenBransDataGridViewTextBoxColumn,
            this.hastaTcDataGridViewTextBoxColumn1,
            this.rontgenTarihDataGridViewTextBoxColumn,
            this.rontgenGoruntuDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.rontgenSonucBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(360, 415);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(791, 295);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // rontgenidDataGridViewTextBoxColumn
            // 
            this.rontgenidDataGridViewTextBoxColumn.DataPropertyName = "Rontgenid";
            this.rontgenidDataGridViewTextBoxColumn.HeaderText = "Rontgenid";
            this.rontgenidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rontgenidDataGridViewTextBoxColumn.Name = "rontgenidDataGridViewTextBoxColumn";
            this.rontgenidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hastaidDataGridViewTextBoxColumn1
            // 
            this.hastaidDataGridViewTextBoxColumn1.DataPropertyName = "Hastaid";
            this.hastaidDataGridViewTextBoxColumn1.HeaderText = "Hastaid";
            this.hastaidDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.hastaidDataGridViewTextBoxColumn1.Name = "hastaidDataGridViewTextBoxColumn1";
            this.hastaidDataGridViewTextBoxColumn1.Visible = false;
            // 
            // doktoridDataGridViewTextBoxColumn1
            // 
            this.doktoridDataGridViewTextBoxColumn1.DataPropertyName = "Doktorid";
            this.doktoridDataGridViewTextBoxColumn1.HeaderText = "Doktorid";
            this.doktoridDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.doktoridDataGridViewTextBoxColumn1.Name = "doktoridDataGridViewTextBoxColumn1";
            // 
            // hastaAdDataGridViewTextBoxColumn1
            // 
            this.hastaAdDataGridViewTextBoxColumn1.DataPropertyName = "HastaAd";
            this.hastaAdDataGridViewTextBoxColumn1.HeaderText = "HastaAd";
            this.hastaAdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.hastaAdDataGridViewTextBoxColumn1.Name = "hastaAdDataGridViewTextBoxColumn1";
            this.hastaAdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // hastaSoyadDataGridViewTextBoxColumn1
            // 
            this.hastaSoyadDataGridViewTextBoxColumn1.DataPropertyName = "HastaSoyad";
            this.hastaSoyadDataGridViewTextBoxColumn1.HeaderText = "HastaSoyad";
            this.hastaSoyadDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.hastaSoyadDataGridViewTextBoxColumn1.Name = "hastaSoyadDataGridViewTextBoxColumn1";
            this.hastaSoyadDataGridViewTextBoxColumn1.Visible = false;
            // 
            // rontgenBransDataGridViewTextBoxColumn
            // 
            this.rontgenBransDataGridViewTextBoxColumn.DataPropertyName = "RontgenBrans";
            this.rontgenBransDataGridViewTextBoxColumn.HeaderText = "RontgenBrans";
            this.rontgenBransDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rontgenBransDataGridViewTextBoxColumn.Name = "rontgenBransDataGridViewTextBoxColumn";
            // 
            // hastaTcDataGridViewTextBoxColumn1
            // 
            this.hastaTcDataGridViewTextBoxColumn1.DataPropertyName = "HastaTc";
            this.hastaTcDataGridViewTextBoxColumn1.HeaderText = "HastaTc";
            this.hastaTcDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.hastaTcDataGridViewTextBoxColumn1.Name = "hastaTcDataGridViewTextBoxColumn1";
            this.hastaTcDataGridViewTextBoxColumn1.Visible = false;
            // 
            // rontgenTarihDataGridViewTextBoxColumn
            // 
            this.rontgenTarihDataGridViewTextBoxColumn.DataPropertyName = "RontgenTarih";
            this.rontgenTarihDataGridViewTextBoxColumn.HeaderText = "RontgenTarih";
            this.rontgenTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rontgenTarihDataGridViewTextBoxColumn.Name = "rontgenTarihDataGridViewTextBoxColumn";
            // 
            // rontgenGoruntuDataGridViewTextBoxColumn
            // 
            this.rontgenGoruntuDataGridViewTextBoxColumn.DataPropertyName = "RontgenGoruntu";
            this.rontgenGoruntuDataGridViewTextBoxColumn.HeaderText = "RontgenGoruntu";
            this.rontgenGoruntuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rontgenGoruntuDataGridViewTextBoxColumn.Name = "rontgenGoruntuDataGridViewTextBoxColumn";
            // 
            // rontgenSonucBindingSource
            // 
            this.rontgenSonucBindingSource.DataMember = "RontgenSonuc";
            this.rontgenSonucBindingSource.DataSource = this.hastaneDBDataSet30;
            // 
            // rontgenSonucTableAdapter
            // 
            this.rontgenSonucTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // receteDetayBindingSource
            // 
            this.receteDetayBindingSource.DataMember = "ReceteDetay";
            this.receteDetayBindingSource.DataSource = this.hastaneDBDataSet30;
            // 
            // receteDetayTableAdapter
            // 
            this.receteDetayTableAdapter.ClearBeforeFill = true;
            // 
            // HastaLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 735);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GBu);
            this.Name = "HastaLab";
            this.Text = "HastaLab";
            this.Load += new System.EventHandler(this.HastaLab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanSonucBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanSonucBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rontgenSonucBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receteDetayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GBu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HastaneDBDataSet30 hastaneDBDataSet30;
        private System.Windows.Forms.BindingSource kanSonucBindingSource;
        private HastaneDBDataSet30TableAdapters.KanSonucTableAdapter kanSonucTableAdapter;
        private System.Windows.Forms.BindingSource kanSonucBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kanidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hemoglobinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trombositDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn glukozDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokositDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kanTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource rontgenSonucBindingSource;
        private HastaneDBDataSet30TableAdapters.RontgenSonucTableAdapter rontgenSonucTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rontgenidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktoridDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaAdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaSoyadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rontgenBransDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTcDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rontgenTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rontgenGoruntuDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource receteDetayBindingSource;
        private HastaneDBDataSet30TableAdapters.ReceteDetayTableAdapter receteDetayTableAdapter;
    }
}