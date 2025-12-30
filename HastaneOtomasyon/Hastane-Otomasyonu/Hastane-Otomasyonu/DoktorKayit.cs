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
using System.Data.SqlClient;

namespace Hastane_Otomasyonu
{
    public partial class DoktorKayit : Form
    {
        public DoktorKayit()
        {
            InitializeComponent();
        }
        SqlConnection Baglan = new SqlConnection("Data Source=DESKTOP-PR6L655;Initial Catalog=HastaneDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");

        private void DoktorKayit_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneDBDataSet5.DoktorBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.doktorBilgiTableAdapter1.Fill(this.hastaneDBDataSet5.DoktorBilgi);
            // TODO: Bu kod satırı 'hastaneDBDataSet3.DoktorBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
             // this.doktorBilgiTableAdapter.Fill(this.hastaneDBDataSet3.DoktorBilgi);
            // TODO: Bu kod satırı 'hastaneDBDataSet2.BransBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bransBilgiTableAdapter.Fill(this.hastaneDBDataSet2.BransBilgi);
            BackColor = Color.WhiteSmoke;
            BransBox.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SekreterSayfa gr = new SekreterSayfa();
            gr.Show();
            this.Hide();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ErkekMi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Kayitlama_Click(object sender, EventArgs e)
        {

            // burada insert işlemleri yapılıyor 
            string brans = BransBox.SelectedItem.ToString();

            string Cins = "";

            if (ErkekMi.Checked)
            {
                Cins = "Erkek";

            } else if (KadinMi.Checked)
            {
                Cins = "Kadın";
            }

            Baglan.Open();
             // burada Tc kimlikleri kontrolleri için Stored Procedureler kullanılıyoruz 
            SqlCommand Ekle = new SqlCommand("DoktorKayit", Baglan);
            Ekle.CommandType = CommandType.StoredProcedure;
           

            Ekle.Parameters.AddWithValue("@Ad", AdText.Text);
            Ekle.Parameters.AddWithValue("@Soyad", SoyadText.Text);
            Ekle.Parameters.AddWithValue("@Tc", TcText.Text);
            Ekle.Parameters.AddWithValue("@Sifre", SifreText.Text);
            Ekle.Parameters.AddWithValue("@Brans", BransBox.Text);
            Ekle.Parameters.AddWithValue("@Tarih", DoktorTarih.Value);
            Ekle.Parameters.AddWithValue("@Cins", Cins);
            
            //   Ekle.ExecuteNonQuery();
            int? deger = (int?)Ekle.ExecuteScalar();
            // burada  null dönerse Kayıtlı Tc ile giriş vardır 

            if (deger == null)
            {
                MessageBox.Show("Kayıtlı olan Tc ile kayıt yapılamaz ");

            }
            //   Baglan.Close();
            // burada kaydetmediği zaman mesela tc kimlik doğru yazmaz ise kayıt yapılamadığına dair 
            // ekrana  Tc  kimlik düzgün girin 
            if (deger == 1)
            {

                MessageBox.Show("Doktor başarılı bir şekilde sisteme kayıt edildi");
            }
            else if (deger == 0) {

                MessageBox.Show("Tc kimlik yanlış girildi lütfen tekrar deneyiniz");
                AdText.Text = "";
                SoyadText.Text = "";
                TcText.Text = "";
                SifreText.Text = "";
                BransBox.SelectedIndex = -1;
                ErkekMi.Checked = false;
                KadinMi.Checked = false;
            }
            Baglan.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // burada cellclick ile textboxlara atama işlemleri yapılıyor 
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            AdText.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            SoyadText.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
             TcText.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            Tclik.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            SifreText.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            BransBox.Text = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            string Kontrol = dataGridView1.Rows[sec].Cells[5].Value.ToString();
            DoktorTarih.Value = Convert.ToDateTime(dataGridView1.Rows[sec].Cells[6].Value);
            idText.Text = dataGridView1.Rows[sec].Cells[7].Value.ToString();

            if (Kontrol == "Erkek")
            {
                ErkekMi.Checked = true;
            }
            else
            {
                KadinMi.Checked = true;
            }

        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            // burada temizleme işlemleri yapılıyor 
            AdText.Text = "";
            SoyadText.Text = "";
            TcText.Text = "";
            SifreText.Text = "";
            BransBox.Text = "";
            ErkekMi.Checked = false;
            KadinMi.Checked = false;
            DoktorTarih.Value  = DateTime.Now;
            Tclik.Text = "TC Bilgisi";
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            // burada silme işlemleri yapılıyor 
            Baglan.Open();

            SqlCommand Sil = new SqlCommand("DoktorSilme", Baglan);
            Sil.CommandType = CommandType.StoredProcedure;

            Sil.Parameters.AddWithValue("@Doktorid",Convert.ToInt16(idText.Text));

            Sil.ExecuteNonQuery();
            Baglan.Close();
            MessageBox.Show("silme işlemi başarılı bir şekilde tamamlandı");
        }

        private void Yenile_Click(object sender, EventArgs e)
        {
            this.doktorBilgiTableAdapter1.Fill(this.hastaneDBDataSet5.DoktorBilgi);
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            string brans = BransBox.SelectedItem.ToString();

            string Cins = "";

            if (ErkekMi.Checked)
            {
                Cins = "Erkek";

            }
            else if (KadinMi.Checked)
            {
                Cins = "Kadın";
            }

            Baglan.Open();

            // güncelleme işleminde malesef tc kimlik kontrolu yapılmıyor ve çünkü farklı bir mesela ad değişse Tc  kimlik sistemde bulunuyor diye hata alıyorum 

           //   SqlCommand Guncel = new SqlCommand("Doktorguncel", Baglan);
            SqlCommand Guncel = new SqlCommand("update DoktorBilgi set Ad = @Ad , Soyad = @Soyad, Tc_Kimlik = @Tc , Sifre = @Sifre, Cinsiyet = @Cins, Brans = @Brans, DoktorTarih = @Tarihd  where Doktorid = @Doktorid ", Baglan);

            //  Guncel.CommandType = CommandType.StoredProcedure;
            Guncel.Parameters.AddWithValue("@Doktorid", idText.Text);

            Guncel.Parameters.AddWithValue("@Ad", AdText.Text);
            Guncel.Parameters.AddWithValue("@Soyad", SoyadText.Text);
            Guncel.Parameters.AddWithValue("@Tc", Tclik.Text);
            Guncel.Parameters.AddWithValue("@Sifre", SifreText.Text);
            Guncel.Parameters.AddWithValue("@Brans", BransBox.Text);
            Guncel.Parameters.AddWithValue("@Cins", Cins);
            Guncel.Parameters.AddWithValue("@Tarihd", DoktorTarih.Value);
            Guncel.ExecuteNonQuery();

            // burada diğer birimlerden hata alıyorum 
            /*
            int? deger = (int?)Guncel.ExecuteScalar();
            //   Guncel.ExecuteNonQuery();
            if (deger == null)
            {
                MessageBox.Show("Kayıtlı olan Tc ile kayıt yapılamaz ");

            }
            //   Baglan.Close();
            // burada kaydetmediği zaman mesela tc kimlik doğru yazmaz ise kayıt yapılamadığına dair 
            // ekrana  Tc  kimlik düzgün girin 
            if (deger == 1)
            {

                MessageBox.Show("Doktor başarılı bir şekilde güncellendi");
            }
            else if (deger == 0)
            {

                MessageBox.Show("düzgün bir Tc kimlik giriniz");
            }
            */
            MessageBox.Show("Doktor başarılı bir şekilde güncellendi");
            Baglan.Close();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DoktorDetay_Click(object sender, EventArgs e)
        {
            DoktorDetay detay = new DoktorDetay();
            detay.Show();
            this.Hide();

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
    }

