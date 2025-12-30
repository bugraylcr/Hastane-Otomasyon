using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Otomasyonu
{
    public partial class RandevuSayfa : Form
    {
        public RandevuSayfa()
        {
            InitializeComponent();
        }
        SqlConnection Baglan = new SqlConnection("Data Source=DESKTOP-PR6L655;Initial Catalog=HastaneDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");

        private void RandevuSayfa_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneDBDataSet28.RandevuBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.randevuBilgiTableAdapter2.Fill(this.hastaneDBDataSet28.RandevuBilgi);
            // TODO: Bu kod satırı 'hastaneDBDataSet27.RandevuBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           //   this.randevuBilgiTableAdapter1.Fill(this.hastaneDBDataSet27.RandevuBilgi);

            // TODO: Bu kod satırı 'hastaneDBDataSet15.RandevuBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           //   this.randevuBilgiTableAdapter.Fill(this.hastaneDBDataSet15.RandevuBilgi);
            // TODO: Bu kod satırı 'hastaneDBDataSet14.OnayliOlmayanTablo' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //  this.onayliOlmayanTabloTableAdapter.Fill(this.hastaneDBDataSet14.OnayliOlmayanTablo);
            // TODO: Bu kod satırı 'hastaneDBDataSet13.OnayliTablo' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           //   this.onayliTabloTableAdapter.Fill(this.hastaneDBDataSet13.OnayliTablo);
            // TODO: Bu kod satırı 'hastaneDBDataSet12.DoktorBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.doktorBilgiTableAdapter.Fill(this.hastaneDBDataSet12.DoktorBilgi);
            // TODO: Bu kod satırı 'hastaneDBDataSet12.BransBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bransBilgiTableAdapter.Fill(this.hastaneDBDataSet12.BransBilgi);
            // TODO: Bu kod satırı 'hastaneDBDataSet12.HastaBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hastaBilgiTableAdapter.Fill(this.hastaneDBDataSet12.HastaBilgi);
            BackColor = Color.WhiteSmoke;


            // burada onaylanmayan datagridview için 
            // Randevu Bilgisiden çekilen tabloyu hastaOnay a ve Randevu Tarih , Saat e göre sırala işlemi yapılmaktadır 
            Baglan.Open();
            string secenek = "select * from RandevuBilgi  where HastaOnayla = 0 order by RandevuTarih , RandevuSaat asc";
            SqlDataAdapter Dt = new SqlDataAdapter(secenek, Baglan);
            DataTable tb = new DataTable();
             //tb.Columns["Brans"].MaxLength = 50;
            dataGridView2.DataSource = tb;
            Dt.Fill(tb);
             // dataGridView2.AutoGenerateColumns = true;
           //   dataGridView2.DataSource = tb;
            //  MessageBox.Show("Satır sayısı: " + tb.Rows.Count);


              Baglan.Close();


            Baglan.Open();
            // burada tek fark HastaOnayla işlemi HastaOnayla 1 ile yapılır 
            string  yap = "select * from RandevuBilgi  where HastaOnayla = 1 order by RandevuTarih , RandevuSaat asc";
            SqlDataAdapter Yb = new SqlDataAdapter(yap, Baglan);
            DataTable Dtb = new DataTable();
            dataGridView1.DataSource = Dtb;
            Yb.Fill(Dtb);
            // dataGridView2.AutoGenerateColumns = true;
            //   dataGridView2.DataSource = tb;
            //  MessageBox.Show("Satır sayısı: " + tb.Rows.Count);

            Baglan.Close();






        }

        private void GeriButton_Click(object sender, EventArgs e)
        {
            SekreterSayfa  Sa = new SekreterSayfa();
            Sa.Show();
            this.Hide();
        }

        private void BransBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // hastanin verilerin değiştirmek için kolaylık açısından cellclick ile textbox a gönderiyoruz 
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string isim = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            MessageBox.Show(isim + " adlı hastanın Verilerini değiştirmek de emin misin?");
            //  Hastaid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            Ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            Soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            Tc.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            hastaTarih.Value = Convert.ToDateTime(dataGridView1.Rows[secilen].Cells[6].Value);
            SaatCombo.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            string deger = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            BilgiEdit.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();

            if (deger == "True")
            {
                OnayBox.Checked = true;
            }
            else if (deger == "False") 
            {
                OnaylamaBox.Checked = true;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // text boxlar gönderme işlemleri burada da geçerli
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            string isim = dataGridView2.Rows[secilen].Cells[1].Value.ToString();

            MessageBox.Show( isim + " adlı hastanın Verilerini değiştirmek de emin misin?");
            Ad.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            Soyad.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            Tc.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            hastaTarih.Value = Convert.ToDateTime(dataGridView2.Rows[secilen].Cells[6].Value);
            SaatCombo.Text = dataGridView2.Rows[secilen].Cells[7].Value.ToString();
            string deger = dataGridView2.Rows[secilen].Cells[8].Value.ToString();
            BilgiEdit.Text = dataGridView2.Rows[secilen].Cells[9].Value.ToString();

            if (deger == "True")
            {
                OnayBox.Checked = true;
            }
            else if (deger == "False") 
            {
                OnaylamaBox.Checked = true;
            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TemizleButton_Click(object sender, EventArgs e)
        {
            Ad.Text = "Ad";
            Soyad.Text = "Soyad";
            Tc.Text = "Tc";
            hastaTarih.Value = DateTime.Today;
            SaatCombo.Text = "Saat";
            OnayBox.Checked = false;
            OnaylamaBox.Checked = false;
            BilgiEdit.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // burada listeleme işlemi yapıyoruz
            // this.randevuBilgiTableAdapter.Fill(this.hastaneDBDataSet15.RandevuBilgi);
            string secenek = "select * from RandevuBilgi  where HastaOnayla = 0 order by RandevuTarih , RandevuSaat asc";
            SqlDataAdapter Dt = new SqlDataAdapter(secenek, Baglan);
            DataTable tb = new DataTable();
            dataGridView2.DataSource = tb;
            Dt.Fill(tb);

            string yap = "select * from RandevuBilgi  where HastaOnayla = 1 order by RandevuTarih , RandevuSaat asc";
            SqlDataAdapter Yb = new SqlDataAdapter(yap, Baglan);
            DataTable Dtb = new DataTable();
            dataGridView1.DataSource = Dtb;
            Yb.Fill(Dtb);

        }

        private void GncelleButon_Click(object sender, EventArgs e)
        {

            // burada ise update işlemleri yapıyoruz
            string Onay = "";

            if (OnayBox.Checked)
            {
                Onay = "True";

            }
            else if (OnaylamaBox.Checked)
            {
                Onay = "False";
            }
            Baglan.Open();
            SqlCommand satirguncelle = new SqlCommand("update  RandevuBilgi set  RandevuTarih = @Tr, RandevuSaat = @Sa, HastaOnayla = @Ho, HastaBilgilendirme = @HB  where TC_Kimlik = @tc and HastaAd = @ad ", Baglan);
            satirguncelle.Parameters.AddWithValue("@Tr", hastaTarih.Value);
            satirguncelle.Parameters.AddWithValue("@Sa", SaatCombo.Text);
            satirguncelle.Parameters.AddWithValue("@HB",BilgiEdit.Text);
            

            satirguncelle.Parameters.AddWithValue("@Ho", Onay);

            satirguncelle.Parameters.AddWithValue("@tc",Tc.Text);
            satirguncelle.Parameters.AddWithValue("@ad",Ad.Text);
            satirguncelle.ExecuteNonQuery();
            Baglan.Close();
            MessageBox.Show("satir güncelleme işlemi gerçekleşti");



        }

        private void SilButton_Click(object sender, EventArgs e)
        {
            // burada silme işlemi 
            Baglan.Open();
            SqlCommand satirSil = new SqlCommand("Delete from RandevuBilgi where TC_Kimlik = @tc and HastaAd = @ad ", Baglan);
            satirSil.Parameters.AddWithValue("@tc", Tc.Text);
            satirSil.Parameters.AddWithValue("@ad", Ad.Text);
            satirSil.ExecuteNonQuery();
            Baglan.Close();
            MessageBox.Show("satir silme işlemi gerçekleşti");

        }
    }
}
