namespace Hastane_Otomasyonu
{
    partial class DoktorKayit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ErkekMi = new System.Windows.Forms.RadioButton();
            this.KadinMi = new System.Windows.Forms.RadioButton();
            this.BransBox = new System.Windows.Forms.ComboBox();
            this.bransBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDBDataSet2 = new Hastane_Otomasyonu.HastaneDBDataSet2();
            this.AdText = new System.Windows.Forms.TextBox();
            this.SoyadText = new System.Windows.Forms.TextBox();
            this.TcText = new System.Windows.Forms.TextBox();
            this.SifreText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bransBilgiTableAdapter = new Hastane_Otomasyonu.HastaneDBDataSet2TableAdapters.BransBilgiTableAdapter();
            this.Kayitlama = new System.Windows.Forms.Button();
            this.Guncelle = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DoktorTarih = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.Tclik = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcKimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorBilgiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDBDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDBDataSet5 = new Hastane_Otomasyonu.HastaneDBDataSet5();
            this.doktorBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDBDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDBDataSet3 = new Hastane_Otomasyonu.HastaneDBDataSet3();
            this.doktorBilgiTableAdapter = new Hastane_Otomasyonu.HastaneDBDataSet3TableAdapters.DoktorBilgiTableAdapter();
            this.Temizle = new System.Windows.Forms.Button();
            this.Yenile = new System.Windows.Forms.Button();
            this.idText = new System.Windows.Forms.TextBox();
            this.DoktorDetay = new Hastane_Otomasyonu.Yuvarlakbuton();
            this.doktorBilgiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.doktorBilgiTableAdapter1 = new Hastane_Otomasyonu.HastaneDBDataSet5TableAdapters.DoktorBilgiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bransBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBilgiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBilgiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "GERİ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(65, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(52, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tc Kimlik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(65, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(65, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Branş";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cinsiyet";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ErkekMi
            // 
            this.ErkekMi.AutoSize = true;
            this.ErkekMi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ErkekMi.Location = new System.Drawing.Point(212, 409);
            this.ErkekMi.Name = "ErkekMi";
            this.ErkekMi.Size = new System.Drawing.Size(74, 27);
            this.ErkekMi.TabIndex = 7;
            this.ErkekMi.TabStop = true;
            this.ErkekMi.Text = "Erkek";
            this.ErkekMi.UseVisualStyleBackColor = true;
            this.ErkekMi.CheckedChanged += new System.EventHandler(this.ErkekMi_CheckedChanged);
            // 
            // KadinMi
            // 
            this.KadinMi.AutoSize = true;
            this.KadinMi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KadinMi.Location = new System.Drawing.Point(112, 408);
            this.KadinMi.Name = "KadinMi";
            this.KadinMi.Size = new System.Drawing.Size(77, 27);
            this.KadinMi.TabIndex = 8;
            this.KadinMi.TabStop = true;
            this.KadinMi.Text = "Kadın";
            this.KadinMi.UseVisualStyleBackColor = true;
            // 
            // BransBox
            // 
            this.BransBox.DataSource = this.bransBilgiBindingSource;
            this.BransBox.DisplayMember = "Brans";
            this.BransBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BransBox.FormattingEnabled = true;
            this.BransBox.Location = new System.Drawing.Point(170, 292);
            this.BransBox.Name = "BransBox";
            this.BransBox.Size = new System.Drawing.Size(159, 32);
            this.BransBox.TabIndex = 9;
            this.BransBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bransBilgiBindingSource
            // 
            this.bransBilgiBindingSource.DataMember = "BransBilgi";
            this.bransBilgiBindingSource.DataSource = this.hastaneDBDataSet2;
            // 
            // hastaneDBDataSet2
            // 
            this.hastaneDBDataSet2.DataSetName = "HastaneDBDataSet2";
            this.hastaneDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AdText
            // 
            this.AdText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdText.Location = new System.Drawing.Point(170, 34);
            this.AdText.Name = "AdText";
            this.AdText.Size = new System.Drawing.Size(159, 29);
            this.AdText.TabIndex = 10;
            // 
            // SoyadText
            // 
            this.SoyadText.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SoyadText.Location = new System.Drawing.Point(170, 91);
            this.SoyadText.Name = "SoyadText";
            this.SoyadText.Size = new System.Drawing.Size(159, 30);
            this.SoyadText.TabIndex = 11;
            // 
            // TcText
            // 
            this.TcText.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TcText.Location = new System.Drawing.Point(170, 158);
            this.TcText.Name = "TcText";
            this.TcText.Size = new System.Drawing.Size(159, 30);
            this.TcText.TabIndex = 12;
            // 
            // SifreText
            // 
            this.SifreText.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifreText.Location = new System.Drawing.Point(170, 231);
            this.SifreText.Name = "SifreText";
            this.SifreText.Size = new System.Drawing.Size(159, 30);
            this.SifreText.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hastane_Otomasyonu.Properties.Resources.DoktorLogo;
            this.pictureBox1.Location = new System.Drawing.Point(221, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // bransBilgiTableAdapter
            // 
            this.bransBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // Kayitlama
            // 
            this.Kayitlama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Kayitlama.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kayitlama.Location = new System.Drawing.Point(507, 527);
            this.Kayitlama.Name = "Kayitlama";
            this.Kayitlama.Size = new System.Drawing.Size(117, 47);
            this.Kayitlama.TabIndex = 15;
            this.Kayitlama.Text = "Kayıt Et";
            this.Kayitlama.UseVisualStyleBackColor = true;
            this.Kayitlama.Click += new System.EventHandler(this.Kayitlama_Click);
            // 
            // Guncelle
            // 
            this.Guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guncelle.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Guncelle.Location = new System.Drawing.Point(966, 527);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(119, 47);
            this.Guncelle.TabIndex = 16;
            this.Guncelle.Text = "Güncelle";
            this.Guncelle.UseVisualStyleBackColor = true;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // Sil
            // 
            this.Sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sil.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sil.Location = new System.Drawing.Point(738, 527);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(117, 47);
            this.Sil.TabIndex = 17;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.DoktorTarih);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.SifreText);
            this.panel1.Controls.Add(this.SoyadText);
            this.panel1.Controls.Add(this.AdText);
            this.panel1.Controls.Add(this.TcText);
            this.panel1.Controls.Add(this.BransBox);
            this.panel1.Controls.Add(this.KadinMi);
            this.panel1.Controls.Add(this.ErkekMi);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(817, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 457);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DoktorTarih
            // 
            this.DoktorTarih.CalendarFont = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DoktorTarih.Location = new System.Drawing.Point(170, 359);
            this.DoktorTarih.Name = "DoktorTarih";
            this.DoktorTarih.Size = new System.Drawing.Size(159, 22);
            this.DoktorTarih.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Doğum Tarih";
            // 
            // Tclik
            // 
            this.Tclik.AutoSize = true;
            this.Tclik.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tclik.Location = new System.Drawing.Point(450, 73);
            this.Tclik.Name = "Tclik";
            this.Tclik.Size = new System.Drawing.Size(86, 23);
            this.Tclik.TabIndex = 16;
            this.Tclik.Text = "TC Bilgisi";
            this.Tclik.Visible = false;
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
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.tcKimlikDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.bransDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.doktorTarihDataGridViewTextBoxColumn,
            this.doktoridDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.doktorBilgiBindingSource2;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(799, 282);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
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
            // tcKimlikDataGridViewTextBoxColumn
            // 
            this.tcKimlikDataGridViewTextBoxColumn.DataPropertyName = "Tc_Kimlik";
            this.tcKimlikDataGridViewTextBoxColumn.HeaderText = "Tc_Kimlik";
            this.tcKimlikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tcKimlikDataGridViewTextBoxColumn.Name = "tcKimlikDataGridViewTextBoxColumn";
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
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            // 
            // doktorTarihDataGridViewTextBoxColumn
            // 
            this.doktorTarihDataGridViewTextBoxColumn.DataPropertyName = "DoktorTarih";
            this.doktorTarihDataGridViewTextBoxColumn.HeaderText = "DoktorTarih";
            this.doktorTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doktorTarihDataGridViewTextBoxColumn.Name = "doktorTarihDataGridViewTextBoxColumn";
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
            // doktorBilgiBindingSource2
            // 
            this.doktorBilgiBindingSource2.DataMember = "DoktorBilgi";
            this.doktorBilgiBindingSource2.DataSource = this.hastaneDBDataSet5BindingSource;
            // 
            // hastaneDBDataSet5BindingSource
            // 
            this.hastaneDBDataSet5BindingSource.DataSource = this.hastaneDBDataSet5;
            this.hastaneDBDataSet5BindingSource.Position = 0;
            // 
            // hastaneDBDataSet5
            // 
            this.hastaneDBDataSet5.DataSetName = "HastaneDBDataSet5";
            this.hastaneDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doktorBilgiBindingSource
            // 
            this.doktorBilgiBindingSource.DataMember = "DoktorBilgi";
            this.doktorBilgiBindingSource.DataSource = this.hastaneDBDataSet3BindingSource;
            // 
            // hastaneDBDataSet3BindingSource
            // 
            this.hastaneDBDataSet3BindingSource.DataSource = this.hastaneDBDataSet3;
            this.hastaneDBDataSet3BindingSource.Position = 0;
            // 
            // hastaneDBDataSet3
            // 
            this.hastaneDBDataSet3.DataSetName = "HastaneDBDataSet3";
            this.hastaneDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doktorBilgiTableAdapter
            // 
            this.doktorBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // Temizle
            // 
            this.Temizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Temizle.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Temizle.Location = new System.Drawing.Point(277, 527);
            this.Temizle.Name = "Temizle";
            this.Temizle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Temizle.Size = new System.Drawing.Size(117, 47);
            this.Temizle.TabIndex = 20;
            this.Temizle.Text = "Temizle";
            this.Temizle.UseVisualStyleBackColor = true;
            this.Temizle.Click += new System.EventHandler(this.Temizle_Click);
            // 
            // Yenile
            // 
            this.Yenile.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yenile.Location = new System.Drawing.Point(65, 527);
            this.Yenile.Name = "Yenile";
            this.Yenile.Size = new System.Drawing.Size(117, 47);
            this.Yenile.TabIndex = 21;
            this.Yenile.Text = "Yenile";
            this.Yenile.UseVisualStyleBackColor = true;
            this.Yenile.Click += new System.EventHandler(this.Yenile_Click);
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(676, 12);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(109, 22);
            this.idText.TabIndex = 22;
            this.idText.Visible = false;
            // 
            // DoktorDetay
            // 
            this.DoktorDetay.BackColor = System.Drawing.Color.LightCyan;
            this.DoktorDetay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoktorDetay.FlatAppearance.BorderSize = 0;
            this.DoktorDetay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoktorDetay.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DoktorDetay.Location = new System.Drawing.Point(554, 51);
            this.DoktorDetay.Name = "DoktorDetay";
            this.DoktorDetay.Size = new System.Drawing.Size(140, 140);
            this.DoktorDetay.TabIndex = 23;
            this.DoktorDetay.Text = "Doktor Detay";
            this.DoktorDetay.UseVisualStyleBackColor = false;
            this.DoktorDetay.Click += new System.EventHandler(this.DoktorDetay_Click);
            // 
            // doktorBilgiBindingSource1
            // 
            this.doktorBilgiBindingSource1.DataMember = "DoktorBilgi";
            this.doktorBilgiBindingSource1.DataSource = this.hastaneDBDataSet5BindingSource;
            // 
            // doktorBilgiTableAdapter1
            // 
            this.doktorBilgiTableAdapter1.ClearBeforeFill = true;
            // 
            // DoktorKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.Tclik);
            this.Controls.Add(this.DoktorDetay);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.Yenile);
            this.Controls.Add(this.Temizle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.Guncelle);
            this.Controls.Add(this.Kayitlama);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "DoktorKayit";
            this.Text = "DoktorKayit";
            this.Load += new System.EventHandler(this.DoktorKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bransBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBilgiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBilgiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton ErkekMi;
        private System.Windows.Forms.RadioButton KadinMi;
        private System.Windows.Forms.ComboBox BransBox;
        private System.Windows.Forms.TextBox AdText;
        private System.Windows.Forms.TextBox SoyadText;
        private System.Windows.Forms.TextBox TcText;
        private System.Windows.Forms.TextBox SifreText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private HastaneDBDataSet2 hastaneDBDataSet2;
        private System.Windows.Forms.BindingSource bransBilgiBindingSource;
        private HastaneDBDataSet2TableAdapters.BransBilgiTableAdapter bransBilgiTableAdapter;
        private System.Windows.Forms.Button Kayitlama;
        private System.Windows.Forms.Button Guncelle;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hastaneDBDataSet3BindingSource;
        private HastaneDBDataSet3 hastaneDBDataSet3;
        private System.Windows.Forms.BindingSource doktorBilgiBindingSource;
        private HastaneDBDataSet3TableAdapters.DoktorBilgiTableAdapter doktorBilgiTableAdapter;
        private System.Windows.Forms.Button Temizle;
        private System.Windows.Forms.Button Yenile;
        private System.Windows.Forms.TextBox idText;
        private Yuvarlakbuton DoktorDetay;
        private System.Windows.Forms.DateTimePicker DoktorTarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource hastaneDBDataSet5BindingSource;
        private HastaneDBDataSet5 hastaneDBDataSet5;
        private System.Windows.Forms.BindingSource doktorBilgiBindingSource1;
        private HastaneDBDataSet5TableAdapters.DoktorBilgiTableAdapter doktorBilgiTableAdapter1;
        private System.Windows.Forms.BindingSource doktorBilgiBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcKimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bransDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label Tclik;
    }
}