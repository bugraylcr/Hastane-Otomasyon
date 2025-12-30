namespace Hastane_Otomasyonu
{
    partial class KayitSayfa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AdText = new System.Windows.Forms.TextBox();
            this.SoyadText = new System.Windows.Forms.TextBox();
            this.TCtext = new System.Windows.Forms.TextBox();
            this.SifreText = new System.Windows.Forms.TextBox();
            this.KayitButton = new System.Windows.Forms.Button();
            this.ErkekMi = new System.Windows.Forms.RadioButton();
            this.KadinMi = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.HastaDogum = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TelefonText = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GuncelHasta = new System.Windows.Forms.Button();
            this.TemizleHasta = new System.Windows.Forms.Button();
            this.SilButon = new System.Windows.Forms.Button();
            this.YenileHasta = new System.Windows.Forms.Button();
            this.DetayHasta = new Hastane_Otomasyonu.Yuvarlakbuton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hastaAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCKimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDBDataSet10BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDBDataSet10 = new Hastane_Otomasyonu.HastaneDBDataSet10();
            this.hastaBilgiTableAdapter = new Hastane_Otomasyonu.HastaneDBDataSet10TableAdapters.HastaBilgiTableAdapter();
            this.Textid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet10BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hastane_Otomasyonu.Properties.Resources.HastaAdamLogo;
            this.pictureBox1.Location = new System.Drawing.Point(261, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(97, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "AD";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(75, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "SOYAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(66, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "TC KİMLİK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(91, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "SİFRE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(66, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "CİNSİYET";
            // 
            // AdText
            // 
            this.AdText.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdText.Location = new System.Drawing.Point(199, 19);
            this.AdText.Name = "AdText";
            this.AdText.Size = new System.Drawing.Size(154, 29);
            this.AdText.TabIndex = 7;
            // 
            // SoyadText
            // 
            this.SoyadText.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SoyadText.Location = new System.Drawing.Point(199, 77);
            this.SoyadText.Name = "SoyadText";
            this.SoyadText.Size = new System.Drawing.Size(154, 30);
            this.SoyadText.TabIndex = 8;
            // 
            // TCtext
            // 
            this.TCtext.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TCtext.Location = new System.Drawing.Point(199, 142);
            this.TCtext.Name = "TCtext";
            this.TCtext.Size = new System.Drawing.Size(154, 30);
            this.TCtext.TabIndex = 9;
            // 
            // SifreText
            // 
            this.SifreText.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifreText.Location = new System.Drawing.Point(199, 208);
            this.SifreText.Name = "SifreText";
            this.SifreText.Size = new System.Drawing.Size(154, 30);
            this.SifreText.TabIndex = 10;
            // 
            // KayitButton
            // 
            this.KayitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KayitButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayitButton.Location = new System.Drawing.Point(76, 504);
            this.KayitButton.Name = "KayitButton";
            this.KayitButton.Size = new System.Drawing.Size(137, 63);
            this.KayitButton.TabIndex = 12;
            this.KayitButton.Text = "Kayıt Et";
            this.KayitButton.UseVisualStyleBackColor = true;
            this.KayitButton.Click += new System.EventHandler(this.KayitButton_Click);
            // 
            // ErkekMi
            // 
            this.ErkekMi.AutoSize = true;
            this.ErkekMi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ErkekMi.Location = new System.Drawing.Point(291, 283);
            this.ErkekMi.Name = "ErkekMi";
            this.ErkekMi.Size = new System.Drawing.Size(87, 28);
            this.ErkekMi.TabIndex = 13;
            this.ErkekMi.TabStop = true;
            this.ErkekMi.Text = "ERKEK";
            this.ErkekMi.UseVisualStyleBackColor = true;
            // 
            // KadinMi
            // 
            this.KadinMi.AutoSize = true;
            this.KadinMi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KadinMi.Location = new System.Drawing.Point(184, 283);
            this.KadinMi.Name = "KadinMi";
            this.KadinMi.Size = new System.Drawing.Size(89, 28);
            this.KadinMi.TabIndex = 14;
            this.KadinMi.TabStop = true;
            this.KadinMi.Text = "KADIN";
            this.KadinMi.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(50, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 50);
            this.button1.TabIndex = 15;
            this.button1.Text = "GERİ DÖN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HastaDogum
            // 
            this.HastaDogum.CalendarFont = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HastaDogum.Location = new System.Drawing.Point(199, 405);
            this.HastaDogum.Name = "HastaDogum";
            this.HastaDogum.Size = new System.Drawing.Size(167, 22);
            this.HastaDogum.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Doğum Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(8, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "TELEFON NUMARA";
            // 
            // TelefonText
            // 
            this.TelefonText.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TelefonText.Location = new System.Drawing.Point(213, 343);
            this.TelefonText.Mask = "(999) 000-0000";
            this.TelefonText.Name = "TelefonText";
            this.TelefonText.Size = new System.Drawing.Size(153, 31);
            this.TelefonText.TabIndex = 19;
            this.TelefonText.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.TelefonText);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.HastaDogum);
            this.panel1.Controls.Add(this.KadinMi);
            this.panel1.Controls.Add(this.ErkekMi);
            this.panel1.Controls.Add(this.SifreText);
            this.panel1.Controls.Add(this.TCtext);
            this.panel1.Controls.Add(this.SoyadText);
            this.panel1.Controls.Add(this.AdText);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(760, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 445);
            this.panel1.TabIndex = 20;
            // 
            // GuncelHasta
            // 
            this.GuncelHasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuncelHasta.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GuncelHasta.Location = new System.Drawing.Point(277, 504);
            this.GuncelHasta.Name = "GuncelHasta";
            this.GuncelHasta.Size = new System.Drawing.Size(137, 63);
            this.GuncelHasta.TabIndex = 21;
            this.GuncelHasta.Text = "Güncelle";
            this.GuncelHasta.UseVisualStyleBackColor = true;
            this.GuncelHasta.Click += new System.EventHandler(this.GuncelHasta_Click);
            // 
            // TemizleHasta
            // 
            this.TemizleHasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TemizleHasta.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TemizleHasta.Location = new System.Drawing.Point(491, 504);
            this.TemizleHasta.Name = "TemizleHasta";
            this.TemizleHasta.Size = new System.Drawing.Size(137, 63);
            this.TemizleHasta.TabIndex = 22;
            this.TemizleHasta.Text = "Temizle";
            this.TemizleHasta.UseVisualStyleBackColor = true;
            this.TemizleHasta.Click += new System.EventHandler(this.TemizleHasta_Click);
            // 
            // SilButon
            // 
            this.SilButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SilButon.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilButon.Location = new System.Drawing.Point(725, 504);
            this.SilButon.Name = "SilButon";
            this.SilButon.Size = new System.Drawing.Size(137, 63);
            this.SilButon.TabIndex = 23;
            this.SilButon.Text = "Sil";
            this.SilButon.UseVisualStyleBackColor = true;
            this.SilButon.Click += new System.EventHandler(this.SilButon_Click);
            // 
            // YenileHasta
            // 
            this.YenileHasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YenileHasta.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YenileHasta.Location = new System.Drawing.Point(944, 505);
            this.YenileHasta.Name = "YenileHasta";
            this.YenileHasta.Size = new System.Drawing.Size(137, 63);
            this.YenileHasta.TabIndex = 24;
            this.YenileHasta.Text = "Yenile";
            this.YenileHasta.UseVisualStyleBackColor = true;
            this.YenileHasta.Click += new System.EventHandler(this.YenileHasta_Click);
            // 
            // DetayHasta
            // 
            this.DetayHasta.BackColor = System.Drawing.Color.LightCyan;
            this.DetayHasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DetayHasta.FlatAppearance.BorderSize = 0;
            this.DetayHasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetayHasta.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DetayHasta.Location = new System.Drawing.Point(488, 24);
            this.DetayHasta.Name = "DetayHasta";
            this.DetayHasta.Size = new System.Drawing.Size(140, 140);
            this.DetayHasta.TabIndex = 25;
            this.DetayHasta.Text = "HastaDetay";
            this.DetayHasta.UseVisualStyleBackColor = false;
            this.DetayHasta.Click += new System.EventHandler(this.DetayHasta_Click);
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
            this.hastaAdDataGridViewTextBoxColumn,
            this.hastaSoyadDataGridViewTextBoxColumn,
            this.tCKimlikDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.hastaidDataGridViewTextBoxColumn,
            this.hastaTarihDataGridViewTextBoxColumn,
            this.hastaTelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hastaBilgiBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 187);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(730, 282);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            // tCKimlikDataGridViewTextBoxColumn
            // 
            this.tCKimlikDataGridViewTextBoxColumn.DataPropertyName = "TC_Kimlik";
            this.tCKimlikDataGridViewTextBoxColumn.HeaderText = "TC_Kimlik";
            this.tCKimlikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tCKimlikDataGridViewTextBoxColumn.Name = "tCKimlikDataGridViewTextBoxColumn";
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Sifre";
            this.sifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            // 
            // hastaidDataGridViewTextBoxColumn
            // 
            this.hastaidDataGridViewTextBoxColumn.DataPropertyName = "Hastaid";
            this.hastaidDataGridViewTextBoxColumn.HeaderText = "Hastaid";
            this.hastaidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hastaidDataGridViewTextBoxColumn.Name = "hastaidDataGridViewTextBoxColumn";
            this.hastaidDataGridViewTextBoxColumn.ReadOnly = true;
            this.hastaidDataGridViewTextBoxColumn.Visible = false;
            // 
            // hastaTarihDataGridViewTextBoxColumn
            // 
            this.hastaTarihDataGridViewTextBoxColumn.DataPropertyName = "HastaTarih";
            this.hastaTarihDataGridViewTextBoxColumn.HeaderText = "HastaTarih";
            this.hastaTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hastaTarihDataGridViewTextBoxColumn.Name = "hastaTarihDataGridViewTextBoxColumn";
            // 
            // hastaTelDataGridViewTextBoxColumn
            // 
            this.hastaTelDataGridViewTextBoxColumn.DataPropertyName = "HastaTel";
            this.hastaTelDataGridViewTextBoxColumn.HeaderText = "HastaTel";
            this.hastaTelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hastaTelDataGridViewTextBoxColumn.Name = "hastaTelDataGridViewTextBoxColumn";
            // 
            // hastaBilgiBindingSource
            // 
            this.hastaBilgiBindingSource.DataMember = "HastaBilgi";
            this.hastaBilgiBindingSource.DataSource = this.hastaneDBDataSet10BindingSource;
            // 
            // hastaneDBDataSet10BindingSource
            // 
            this.hastaneDBDataSet10BindingSource.DataSource = this.hastaneDBDataSet10;
            this.hastaneDBDataSet10BindingSource.Position = 0;
            // 
            // hastaneDBDataSet10
            // 
            this.hastaneDBDataSet10.DataSetName = "HastaneDBDataSet10";
            this.hastaneDBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaBilgiTableAdapter
            // 
            this.hastaBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // Textid
            // 
            this.Textid.Location = new System.Drawing.Point(634, 24);
            this.Textid.Name = "Textid";
            this.Textid.Size = new System.Drawing.Size(99, 22);
            this.Textid.TabIndex = 27;
            this.Textid.Visible = false;
            // 
            // KayitSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.Textid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DetayHasta);
            this.Controls.Add(this.YenileHasta);
            this.Controls.Add(this.SilButon);
            this.Controls.Add(this.TemizleHasta);
            this.Controls.Add(this.GuncelHasta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.KayitButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "KayitSayfa";
            this.Text = "KayitSayfa";
            this.Load += new System.EventHandler(this.KayitSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet10BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AdText;
        private System.Windows.Forms.TextBox SoyadText;
        private System.Windows.Forms.TextBox TCtext;
        private System.Windows.Forms.TextBox SifreText;
        private System.Windows.Forms.Button KayitButton;
        private System.Windows.Forms.RadioButton ErkekMi;
        private System.Windows.Forms.RadioButton KadinMi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker HastaDogum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox TelefonText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GuncelHasta;
        private System.Windows.Forms.Button TemizleHasta;
        private System.Windows.Forms.Button SilButon;
        private System.Windows.Forms.Button YenileHasta;
        private Yuvarlakbuton DetayHasta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hastaneDBDataSet10BindingSource;
        private HastaneDBDataSet10 hastaneDBDataSet10;
        private System.Windows.Forms.BindingSource hastaBilgiBindingSource;
        private HastaneDBDataSet10TableAdapters.HastaBilgiTableAdapter hastaBilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCKimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox Textid;
    }
}