namespace Hastane_Otomasyonu
{
    partial class AdminPanel
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.GeB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hastaneDBDataSet30 = new Hastane_Otomasyonu.HastaneDBDataSet30();
            this.doktorBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doktorBilgiTableAdapter = new Hastane_Otomasyonu.HastaneDBDataSet30TableAdapters.DoktorBilgiTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.hastaBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaBilgiTableAdapter = new Hastane_Otomasyonu.HastaneDBDataSet30TableAdapters.HastaBilgiTableAdapter();
            this.tCKimlikDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktoridDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sekreterBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sekreterBilgiTableAdapter = new Hastane_Otomasyonu.HastaneDBDataSet30TableAdapters.SekreterBilgiTableAdapter();
            this.tcKimlikDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sekreteridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tcKimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekreterBilgiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "Doktor Bilgileri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(12, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 74);
            this.button2.TabIndex = 1;
            this.button2.Text = "Hasta Bilgileri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(12, 619);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 74);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sekreter Bilgileri";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GeB
            // 
            this.GeB.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GeB.Location = new System.Drawing.Point(12, 21);
            this.GeB.Name = "GeB";
            this.GeB.Size = new System.Drawing.Size(131, 73);
            this.GeB.TabIndex = 3;
            this.GeB.Text = "Geri Dön";
            this.GeB.UseVisualStyleBackColor = true;
            this.GeB.Click += new System.EventHandler(this.GeB_Click);
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
            this.tcKimlikDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.bransDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.doktoridDataGridViewTextBoxColumn,
            this.doktorTarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doktorBilgiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(321, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 154);
            this.dataGridView1.TabIndex = 4;
            // 
            // hastaneDBDataSet30
            // 
            this.hastaneDBDataSet30.DataSetName = "HastaneDBDataSet30";
            this.hastaneDBDataSet30.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doktorBilgiBindingSource
            // 
            this.doktorBilgiBindingSource.DataMember = "DoktorBilgi";
            this.doktorBilgiBindingSource.DataSource = this.hastaneDBDataSet30;
            // 
            // doktorBilgiTableAdapter
            // 
            this.doktorBilgiTableAdapter.ClearBeforeFill = true;
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
            this.tCKimlikDataGridViewTextBoxColumn1,
            this.hastaAdDataGridViewTextBoxColumn,
            this.hastaSoyadDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn1,
            this.cinsiyetDataGridViewTextBoxColumn1,
            this.hastaidDataGridViewTextBoxColumn,
            this.hastaTarihDataGridViewTextBoxColumn,
            this.hastaTelDataGridViewTextBoxColumn,
            this.doktoridDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.hastaBilgiBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(321, 336);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(680, 141);
            this.dataGridView2.TabIndex = 5;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tcKimlikDataGridViewTextBoxColumn2,
            this.adDataGridViewTextBoxColumn1,
            this.soyadDataGridViewTextBoxColumn1,
            this.sifreDataGridViewTextBoxColumn2,
            this.cinsiyetDataGridViewTextBoxColumn2,
            this.sekreteridDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.sekreterBilgiBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(321, 577);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(680, 145);
            this.dataGridView3.TabIndex = 6;
            // 
            // hastaBilgiBindingSource
            // 
            this.hastaBilgiBindingSource.DataMember = "HastaBilgi";
            this.hastaBilgiBindingSource.DataSource = this.hastaneDBDataSet30;
            // 
            // hastaBilgiTableAdapter
            // 
            this.hastaBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // tCKimlikDataGridViewTextBoxColumn1
            // 
            this.tCKimlikDataGridViewTextBoxColumn1.DataPropertyName = "TC_Kimlik";
            this.tCKimlikDataGridViewTextBoxColumn1.HeaderText = "TC_Kimlik";
            this.tCKimlikDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.tCKimlikDataGridViewTextBoxColumn1.Name = "tCKimlikDataGridViewTextBoxColumn1";
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
            // sifreDataGridViewTextBoxColumn1
            // 
            this.sifreDataGridViewTextBoxColumn1.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn1.HeaderText = "Sifre";
            this.sifreDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn1.Name = "sifreDataGridViewTextBoxColumn1";
            // 
            // cinsiyetDataGridViewTextBoxColumn1
            // 
            this.cinsiyetDataGridViewTextBoxColumn1.DataPropertyName = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn1.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cinsiyetDataGridViewTextBoxColumn1.Name = "cinsiyetDataGridViewTextBoxColumn1";
            // 
            // hastaidDataGridViewTextBoxColumn
            // 
            this.hastaidDataGridViewTextBoxColumn.DataPropertyName = "Hastaid";
            this.hastaidDataGridViewTextBoxColumn.HeaderText = "Hastaid";
            this.hastaidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hastaidDataGridViewTextBoxColumn.Name = "hastaidDataGridViewTextBoxColumn";
            this.hastaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hastaTarihDataGridViewTextBoxColumn
            // 
            this.hastaTarihDataGridViewTextBoxColumn.DataPropertyName = "HastaTarih";
            this.hastaTarihDataGridViewTextBoxColumn.HeaderText = "HastaTarih";
            this.hastaTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hastaTarihDataGridViewTextBoxColumn.Name = "hastaTarihDataGridViewTextBoxColumn";
            this.hastaTarihDataGridViewTextBoxColumn.Visible = false;
            // 
            // hastaTelDataGridViewTextBoxColumn
            // 
            this.hastaTelDataGridViewTextBoxColumn.DataPropertyName = "HastaTel";
            this.hastaTelDataGridViewTextBoxColumn.HeaderText = "HastaTel";
            this.hastaTelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hastaTelDataGridViewTextBoxColumn.Name = "hastaTelDataGridViewTextBoxColumn";
            this.hastaTelDataGridViewTextBoxColumn.Visible = false;
            // 
            // doktoridDataGridViewTextBoxColumn1
            // 
            this.doktoridDataGridViewTextBoxColumn1.DataPropertyName = "Doktorid";
            this.doktoridDataGridViewTextBoxColumn1.HeaderText = "Doktorid";
            this.doktoridDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.doktoridDataGridViewTextBoxColumn1.Name = "doktoridDataGridViewTextBoxColumn1";
            this.doktoridDataGridViewTextBoxColumn1.Visible = false;
            // 
            // sekreterBilgiBindingSource
            // 
            this.sekreterBilgiBindingSource.DataMember = "SekreterBilgi";
            this.sekreterBilgiBindingSource.DataSource = this.hastaneDBDataSet30;
            // 
            // sekreterBilgiTableAdapter
            // 
            this.sekreterBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // tcKimlikDataGridViewTextBoxColumn2
            // 
            this.tcKimlikDataGridViewTextBoxColumn2.DataPropertyName = "Tc_Kimlik";
            this.tcKimlikDataGridViewTextBoxColumn2.HeaderText = "Tc_Kimlik";
            this.tcKimlikDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.tcKimlikDataGridViewTextBoxColumn2.Name = "tcKimlikDataGridViewTextBoxColumn2";
            // 
            // adDataGridViewTextBoxColumn1
            // 
            this.adDataGridViewTextBoxColumn1.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn1.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn1.Name = "adDataGridViewTextBoxColumn1";
            // 
            // soyadDataGridViewTextBoxColumn1
            // 
            this.soyadDataGridViewTextBoxColumn1.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn1.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn1.Name = "soyadDataGridViewTextBoxColumn1";
            // 
            // sifreDataGridViewTextBoxColumn2
            // 
            this.sifreDataGridViewTextBoxColumn2.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn2.HeaderText = "Sifre";
            this.sifreDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn2.Name = "sifreDataGridViewTextBoxColumn2";
            // 
            // cinsiyetDataGridViewTextBoxColumn2
            // 
            this.cinsiyetDataGridViewTextBoxColumn2.DataPropertyName = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn2.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.cinsiyetDataGridViewTextBoxColumn2.Name = "cinsiyetDataGridViewTextBoxColumn2";
            this.cinsiyetDataGridViewTextBoxColumn2.Visible = false;
            // 
            // sekreteridDataGridViewTextBoxColumn
            // 
            this.sekreteridDataGridViewTextBoxColumn.DataPropertyName = "Sekreterid";
            this.sekreteridDataGridViewTextBoxColumn.HeaderText = "Sekreterid";
            this.sekreteridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sekreteridDataGridViewTextBoxColumn.Name = "sekreteridDataGridViewTextBoxColumn";
            this.sekreteridDataGridViewTextBoxColumn.ReadOnly = true;
            this.sekreteridDataGridViewTextBoxColumn.Visible = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(166, 126);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 77);
            this.button4.TabIndex = 7;
            this.button4.Text = "Giriş";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(166, 379);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 74);
            this.button5.TabIndex = 8;
            this.button5.Text = "Giriş";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(166, 619);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 74);
            this.button6.TabIndex = 9;
            this.button6.Text = "Giriş";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tcKimlikDataGridViewTextBoxColumn
            // 
            this.tcKimlikDataGridViewTextBoxColumn.DataPropertyName = "Tc_Kimlik";
            this.tcKimlikDataGridViewTextBoxColumn.HeaderText = "Tc_Kimlik";
            this.tcKimlikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tcKimlikDataGridViewTextBoxColumn.Name = "tcKimlikDataGridViewTextBoxColumn";
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Sifre";
            this.sifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            // 
            // bransDataGridViewTextBoxColumn
            // 
            this.bransDataGridViewTextBoxColumn.DataPropertyName = "Brans";
            this.bransDataGridViewTextBoxColumn.HeaderText = "Brans";
            this.bransDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bransDataGridViewTextBoxColumn.Name = "bransDataGridViewTextBoxColumn";
            this.bransDataGridViewTextBoxColumn.Visible = false;
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            this.cinsiyetDataGridViewTextBoxColumn.Visible = false;
            // 
            // doktoridDataGridViewTextBoxColumn
            // 
            this.doktoridDataGridViewTextBoxColumn.DataPropertyName = "Doktorid";
            this.doktoridDataGridViewTextBoxColumn.HeaderText = "Doktorid";
            this.doktoridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doktoridDataGridViewTextBoxColumn.Name = "doktoridDataGridViewTextBoxColumn";
            this.doktoridDataGridViewTextBoxColumn.ReadOnly = true;
            this.doktoridDataGridViewTextBoxColumn.Visible = false;
            // 
            // doktorTarihDataGridViewTextBoxColumn
            // 
            this.doktorTarihDataGridViewTextBoxColumn.DataPropertyName = "DoktorTarih";
            this.doktorTarihDataGridViewTextBoxColumn.HeaderText = "DoktorTarih";
            this.doktorTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doktorTarihDataGridViewTextBoxColumn.Name = "doktorTarihDataGridViewTextBoxColumn";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 794);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GeB);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekreterBilgiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button GeB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HastaneDBDataSet30 hastaneDBDataSet30;
        private System.Windows.Forms.BindingSource doktorBilgiBindingSource;
        private HastaneDBDataSet30TableAdapters.DoktorBilgiTableAdapter doktorBilgiTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource hastaBilgiBindingSource;
        private HastaneDBDataSet30TableAdapters.HastaBilgiTableAdapter hastaBilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCKimlikDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktoridDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource sekreterBilgiBindingSource;
        private HastaneDBDataSet30TableAdapters.SekreterBilgiTableAdapter sekreterBilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcKimlikDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sekreteridDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcKimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bransDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorTarihDataGridViewTextBoxColumn;
    }
}