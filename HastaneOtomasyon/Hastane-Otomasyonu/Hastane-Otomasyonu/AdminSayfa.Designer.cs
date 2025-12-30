namespace Hastane_Otomasyonu
{
    partial class AdminSayfa
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
            this.AnaD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ERKEK = new System.Windows.Forms.RadioButton();
            this.Kadin = new System.Windows.Forms.RadioButton();
            this.AdText = new System.Windows.Forms.TextBox();
            this.SoyadText = new System.Windows.Forms.TextBox();
            this.TcText = new System.Windows.Forms.TextBox();
            this.SifreText = new System.Windows.Forms.TextBox();
            this.Kayit = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.AdminPa = new System.Windows.Forms.Button();
            this.SekreterGn = new System.Windows.Forms.Button();
            this.SilBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tcKimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sekreteridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sekreterBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDBDataSet30 = new Hastane_Otomasyonu.HastaneDBDataSet30();
            this.sekreterBilgiTableAdapter = new Hastane_Otomasyonu.HastaneDBDataSet30TableAdapters.SekreterBilgiTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Sekreterid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekreterBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet30)).BeginInit();
            this.SuspendLayout();
            // 
            // AnaD
            // 
            this.AnaD.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnaD.Location = new System.Drawing.Point(12, 11);
            this.AnaD.Name = "AnaD";
            this.AnaD.Size = new System.Drawing.Size(150, 82);
            this.AnaD.TabIndex = 0;
            this.AnaD.Text = "Ana Sayfa";
            this.AnaD.UseVisualStyleBackColor = true;
            this.AnaD.Click += new System.EventHandler(this.AnaD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(193, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sekreter Kayıt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(104, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "AD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(83, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "SOYAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(67, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "TC_KİMLİK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(83, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "SİFRE";
            // 
            // ERKEK
            // 
            this.ERKEK.AutoSize = true;
            this.ERKEK.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ERKEK.Location = new System.Drawing.Point(143, 354);
            this.ERKEK.Name = "ERKEK";
            this.ERKEK.Size = new System.Drawing.Size(87, 28);
            this.ERKEK.TabIndex = 6;
            this.ERKEK.TabStop = true;
            this.ERKEK.Text = "ERKEK";
            this.ERKEK.UseVisualStyleBackColor = true;
            // 
            // Kadin
            // 
            this.Kadin.AutoSize = true;
            this.Kadin.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kadin.Location = new System.Drawing.Point(278, 354);
            this.Kadin.Name = "Kadin";
            this.Kadin.Size = new System.Drawing.Size(89, 28);
            this.Kadin.TabIndex = 7;
            this.Kadin.TabStop = true;
            this.Kadin.Text = "KADIN";
            this.Kadin.UseVisualStyleBackColor = true;
            // 
            // AdText
            // 
            this.AdText.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdText.Location = new System.Drawing.Point(190, 105);
            this.AdText.Name = "AdText";
            this.AdText.Size = new System.Drawing.Size(156, 30);
            this.AdText.TabIndex = 8;
            // 
            // SoyadText
            // 
            this.SoyadText.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SoyadText.Location = new System.Drawing.Point(190, 162);
            this.SoyadText.Name = "SoyadText";
            this.SoyadText.Size = new System.Drawing.Size(156, 30);
            this.SoyadText.TabIndex = 9;
            // 
            // TcText
            // 
            this.TcText.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TcText.Location = new System.Drawing.Point(191, 227);
            this.TcText.Name = "TcText";
            this.TcText.Size = new System.Drawing.Size(158, 30);
            this.TcText.TabIndex = 10;
            // 
            // SifreText
            // 
            this.SifreText.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifreText.Location = new System.Drawing.Point(191, 282);
            this.SifreText.Name = "SifreText";
            this.SifreText.Size = new System.Drawing.Size(158, 30);
            this.SifreText.TabIndex = 11;
            // 
            // Kayit
            // 
            this.Kayit.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kayit.Location = new System.Drawing.Point(982, 418);
            this.Kayit.Name = "Kayit";
            this.Kayit.Size = new System.Drawing.Size(135, 69);
            this.Kayit.TabIndex = 12;
            this.Kayit.Text = "Kayıt ";
            this.Kayit.UseVisualStyleBackColor = true;
            this.Kayit.Click += new System.EventHandler(this.Kayit_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(384, 285);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 28);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "GİZLİ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // AdminPa
            // 
            this.AdminPa.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPa.Location = new System.Drawing.Point(982, 289);
            this.AdminPa.Name = "AdminPa";
            this.AdminPa.Size = new System.Drawing.Size(165, 93);
            this.AdminPa.TabIndex = 14;
            this.AdminPa.Text = "Admin Paneli";
            this.AdminPa.UseVisualStyleBackColor = true;
            this.AdminPa.Click += new System.EventHandler(this.AdminPa_Click);
            // 
            // SekreterGn
            // 
            this.SekreterGn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SekreterGn.Location = new System.Drawing.Point(763, 418);
            this.SekreterGn.Name = "SekreterGn";
            this.SekreterGn.Size = new System.Drawing.Size(135, 69);
            this.SekreterGn.TabIndex = 15;
            this.SekreterGn.Text = "Güncelle";
            this.SekreterGn.UseVisualStyleBackColor = true;
            this.SekreterGn.Click += new System.EventHandler(this.SekreterGn_Click);
            // 
            // SilBtn
            // 
            this.SilBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilBtn.Location = new System.Drawing.Point(538, 418);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(136, 69);
            this.SilBtn.TabIndex = 16;
            this.SilBtn.Text = "Sil";
            this.SilBtn.UseVisualStyleBackColor = true;
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(317, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 69);
            this.button1.TabIndex = 17;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(108, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 69);
            this.button2.TabIndex = 18;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.cinsiyetDataGridViewTextBoxColumn,
            this.sekreteridDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sekreterBilgiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(399, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(771, 222);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
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
            // sekreterBilgiBindingSource
            // 
            this.sekreterBilgiBindingSource.DataMember = "SekreterBilgi";
            this.sekreterBilgiBindingSource.DataSource = this.hastaneDBDataSet30;
            // 
            // hastaneDBDataSet30
            // 
            this.hastaneDBDataSet30.DataSetName = "HastaneDBDataSet30";
            this.hastaneDBDataSet30.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sekreterBilgiTableAdapter
            // 
            this.sekreterBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(549, 263);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 22);
            this.textBox1.TabIndex = 20;
            this.textBox1.Visible = false;
            // 
            // Sekreterid
            // 
            this.Sekreterid.AutoSize = true;
            this.Sekreterid.Location = new System.Drawing.Point(655, 266);
            this.Sekreterid.Name = "Sekreterid";
            this.Sekreterid.Size = new System.Drawing.Size(44, 16);
            this.Sekreterid.TabIndex = 21;
            this.Sekreterid.Text = "label6";
            this.Sekreterid.Visible = false;
            // 
            // AdminSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.Sekreterid);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SilBtn);
            this.Controls.Add(this.SekreterGn);
            this.Controls.Add(this.AdminPa);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Kayit);
            this.Controls.Add(this.SifreText);
            this.Controls.Add(this.TcText);
            this.Controls.Add(this.SoyadText);
            this.Controls.Add(this.AdText);
            this.Controls.Add(this.Kadin);
            this.Controls.Add(this.ERKEK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnaD);
            this.Name = "AdminSayfa";
            this.Text = "AdminSayfa";
            this.Load += new System.EventHandler(this.AdminSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekreterBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet30)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AnaD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton ERKEK;
        private System.Windows.Forms.RadioButton Kadin;
        private System.Windows.Forms.TextBox AdText;
        private System.Windows.Forms.TextBox SoyadText;
        private System.Windows.Forms.TextBox TcText;
        private System.Windows.Forms.TextBox SifreText;
        private System.Windows.Forms.Button Kayit;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button AdminPa;
        private System.Windows.Forms.Button SekreterGn;
        private System.Windows.Forms.Button SilBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HastaneDBDataSet30 hastaneDBDataSet30;
        private System.Windows.Forms.BindingSource sekreterBilgiBindingSource;
        private HastaneDBDataSet30TableAdapters.SekreterBilgiTableAdapter sekreterBilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcKimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sekreteridDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Sekreterid;
    }
}