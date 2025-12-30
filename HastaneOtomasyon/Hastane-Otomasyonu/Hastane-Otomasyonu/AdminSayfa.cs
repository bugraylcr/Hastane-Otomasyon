using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hastane_Otomasyonu
{
    public partial class AdminSayfa : Form
    {
        public AdminSayfa()
        {
            InitializeComponent();
        }

        SqlConnection Baglan = new SqlConnection("Data Source=DESKTOP-PR6L655;Initial Catalog=HastaneDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
        bool Cinsiyet;
        private void AnaD_Click(object sender, EventArgs e)
        {
            Form1 Ana = new Form1();
            Ana.Show();
            this.Close();
        }

        private void AdminSayfa_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneDBDataSet30.SekreterBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           // this.sekreterBilgiTableAdapter.Fill(this.hastaneDBDataSet30.SekreterBilgi);
            this.BackColor = Color.WhiteSmoke;
            SifreText.UseSystemPasswordChar = true;
        }

        private void Kayit_Click(object sender, EventArgs e)
        {
            // admin sayfasında Sekreter kayıt işlemi yapıyorum 
            string Cins = "";
            if (ERKEK.Checked)
            {
                Cins = "Erkek";
            }
            else if (Kadin.Checked)
            {
                Cins = "Kadın";
            }
            Baglan.Open();
            SqlCommand Ekle = new SqlCommand("insert into SekreterBilgi (Ad,Soyad,Tc_Kimlik,Sifre,Cinsiyet) values (@Ad,@Soyad,@Tc,@Sifre,@Cins)", Baglan);
            Ekle.Parameters.AddWithValue("@Ad",AdText.Text);
            Ekle.Parameters.AddWithValue("@Soyad",SoyadText.Text);
            Ekle.Parameters.AddWithValue("@Tc",TcText.Text);
            Ekle.Parameters.AddWithValue("@Sifre",SifreText.Text);
            Ekle.Parameters.AddWithValue("@Cins",Cins);
            Ekle.ExecuteNonQuery();
            Baglan.Close();
            MessageBox.Show("Başarılı bir şekilde  sekreter kayıt işlemi gerçekleştirildi");
            AdText.Text = " ";
            SoyadText.Text = " ";
            TcText.Text = " ";
            SifreText.Text = "";
            //  AdText.Text = " ";
            ERKEK.Checked = false;
            Kadin.Checked = false;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SifreText.UseSystemPasswordChar = true;
            }
            else
            {
                SifreText.UseSystemPasswordChar = false;
            }
        }

        private void AdminPa_Click(object sender, EventArgs e)
        {
            AdminPanel Ap = new AdminPanel();
            Ap.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.sekreterBilgiTableAdapter.Fill(this.hastaneDBDataSet30.SekreterBilgi);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            //string isim = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

          //  MessageBox.Show(" adlı hastanın Verilerini değiştirmek de emin misin?");

            AdText.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            SoyadText.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            SoyadText.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
             SifreText.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TcText.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
             // hastaTarih.Value = Convert.ToDateTime(dataGridView1.Rows[secilen].Cells[6].Value);
            //  SaatCombo.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            string Cins = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            Sekreterid.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

            //  BilgiEdit.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();

            if (Cins == "Erkek")
            {
                ERKEK.Checked = true;
            }
            else if (Cins == "Kadin")
            {
                Kadin.Checked = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdText.Text = " ";
            SoyadText.Text= " ";
            TcText.Text= " ";   
            SifreText.Text= "";
            ERKEK.Checked = false;
            Kadin.Checked = false;
        }

        private void SekreterGn_Click(object sender, EventArgs e)
        {
            string Cinsiyet = "";

            if (ERKEK.Checked)
            {
                Cinsiyet = "Erkek";

            }
            else if (Kadin.Checked)
            {
                Cinsiyet = "Kadin";
            }
            Baglan.Open();
            // admin sayfasında sekreter ekleme işlemleri yapılır 
            SqlCommand satirguncelle = new SqlCommand("update  SekreterBilgi set Ad = @SAd , Soyad = @Ssd , Sifre = @Ssifre,Cinsiyet = @Cs,Tc_Kimlik = @Tc where Sekreterid = @Sktd ", Baglan);
            satirguncelle.Parameters.AddWithValue("@SAd",AdText.Text);
            satirguncelle.Parameters.AddWithValue("@Ssd", SoyadText.Text);
            satirguncelle.Parameters.AddWithValue("@Ssifre", SifreText.Text);
             satirguncelle.Parameters.AddWithValue("@Cs", Cinsiyet);
            satirguncelle.Parameters.AddWithValue("@Tc", TcText.Text);

            
            satirguncelle.Parameters.AddWithValue("@Sktd", Sekreterid.Text);
            satirguncelle.ExecuteNonQuery();
            Baglan.Close();
            MessageBox.Show("satir güncelleme işlemi gerçekleşti");

        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            Baglan.Open();
            SqlCommand satirSil = new SqlCommand("Delete from SekreterBilgi where Sekreterid = @Skid ", Baglan);
            satirSil.Parameters.AddWithValue("@Skid", Sekreterid.Text);
            //satirSil.Parameters.AddWithValue("@ad", Ad.Text);
            satirSil.ExecuteNonQuery();
            Baglan.Close();
            MessageBox.Show("satir silme işlemi gerçekleşti");
        }
    }
}
