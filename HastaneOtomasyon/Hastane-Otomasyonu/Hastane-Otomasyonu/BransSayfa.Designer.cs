namespace Hastane_Otomasyonu
{
    partial class BransSayfa
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
            this.Geri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BransAd = new System.Windows.Forms.TextBox();
            this.BransEkle = new System.Windows.Forms.Button();
            this.SilBrans = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bransidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bransBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDBDataSet6 = new Hastane_Otomasyonu.HastaneDBDataSet6();
            this.bransBilgiTableAdapter = new Hastane_Otomasyonu.HastaneDBDataSet6TableAdapters.BransBilgiTableAdapter();
            this.Listele = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bransBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // Geri
            // 
            this.Geri.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Geri.Location = new System.Drawing.Point(21, 12);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(123, 61);
            this.Geri.TabIndex = 0;
            this.Geri.Text = "Geri";
            this.Geri.UseVisualStyleBackColor = true;
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(164, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Branş Ekle";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(44, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Branş Adı";
            // 
            // BransAd
            // 
            this.BransAd.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BransAd.Location = new System.Drawing.Point(151, 74);
            this.BransAd.Name = "BransAd";
            this.BransAd.Size = new System.Drawing.Size(161, 31);
            this.BransAd.TabIndex = 3;
            // 
            // BransEkle
            // 
            this.BransEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BransEkle.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BransEkle.Location = new System.Drawing.Point(22, 154);
            this.BransEkle.Name = "BransEkle";
            this.BransEkle.Size = new System.Drawing.Size(95, 50);
            this.BransEkle.TabIndex = 4;
            this.BransEkle.Text = "Ekle";
            this.BransEkle.UseVisualStyleBackColor = true;
            this.BransEkle.Click += new System.EventHandler(this.BransEkle_Click);
            // 
            // SilBrans
            // 
            this.SilBrans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SilBrans.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilBrans.Location = new System.Drawing.Point(151, 183);
            this.SilBrans.Name = "SilBrans";
            this.SilBrans.Size = new System.Drawing.Size(117, 54);
            this.SilBrans.TabIndex = 5;
            this.SilBrans.Text = "Sil";
            this.SilBrans.UseVisualStyleBackColor = true;
            this.SilBrans.Click += new System.EventHandler(this.SilBrans_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Listele);
            this.panel1.Controls.Add(this.idBox);
            this.panel1.Controls.Add(this.SilBrans);
            this.panel1.Controls.Add(this.BransEkle);
            this.panel1.Controls.Add(this.BransAd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(258, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 322);
            this.panel1.TabIndex = 7;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(320, 14);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(79, 22);
            this.idBox.TabIndex = 7;
            this.idBox.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bransidDataGridViewTextBoxColumn,
            this.bransDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bransBilgiBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(21, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(190, 323);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // bransidDataGridViewTextBoxColumn
            // 
            this.bransidDataGridViewTextBoxColumn.DataPropertyName = "Bransid";
            this.bransidDataGridViewTextBoxColumn.HeaderText = "Bransid";
            this.bransidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bransidDataGridViewTextBoxColumn.Name = "bransidDataGridViewTextBoxColumn";
            this.bransidDataGridViewTextBoxColumn.ReadOnly = true;
            this.bransidDataGridViewTextBoxColumn.Visible = false;
            // 
            // bransDataGridViewTextBoxColumn
            // 
            this.bransDataGridViewTextBoxColumn.DataPropertyName = "Brans";
            this.bransDataGridViewTextBoxColumn.HeaderText = "Brans";
            this.bransDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bransDataGridViewTextBoxColumn.Name = "bransDataGridViewTextBoxColumn";
            // 
            // bransBilgiBindingSource
            // 
            this.bransBilgiBindingSource.DataMember = "BransBilgi";
            this.bransBilgiBindingSource.DataSource = this.hastaneDBDataSet6;
            // 
            // hastaneDBDataSet6
            // 
            this.hastaneDBDataSet6.DataSetName = "HastaneDBDataSet6";
            this.hastaneDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bransBilgiTableAdapter
            // 
            this.bransBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // Listele
            // 
            this.Listele.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Listele.Location = new System.Drawing.Point(298, 225);
            this.Listele.Name = "Listele";
            this.Listele.Size = new System.Drawing.Size(128, 50);
            this.Listele.TabIndex = 8;
            this.Listele.Text = "Listele";
            this.Listele.UseVisualStyleBackColor = true;
            this.Listele.Click += new System.EventHandler(this.Listele_Click);
            // 
            // BransSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Geri);
            this.Name = "BransSayfa";
            this.Text = "BransSayfa";
            this.Load += new System.EventHandler(this.BransSayfa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bransBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDBDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Geri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BransAd;
        private System.Windows.Forms.Button BransEkle;
        private System.Windows.Forms.Button SilBrans;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HastaneDBDataSet6 hastaneDBDataSet6;
        private System.Windows.Forms.BindingSource bransBilgiBindingSource;
        private HastaneDBDataSet6TableAdapters.BransBilgiTableAdapter bransBilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bransidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bransDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button Listele;
    }
}