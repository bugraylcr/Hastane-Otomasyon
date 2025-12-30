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
namespace Hastane_Otomasyonu
{
    public partial class SekreterSayfa : Form
    {
        public SekreterSayfa()
        {
            InitializeComponent();
        }
        SqlConnection Baglan = new SqlConnection("Data Source=DESKTOP-PR6L655;Initial Catalog=HastaneDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
         
        private void SekreterSayfa_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneDBDataSet8.DoktorBilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.doktorBilgileriTableAdapter1.Fill(this.hastaneDBDataSet8.DoktorBilgileri);
            // TODO: Bu kod satırı 'hastaneDBDataSet7.DoktorBilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           //   this.doktorBilgileriTableAdapter.Fill(this.hastaneDBDataSet7.DoktorBilgileri);
            // TODO: Bu kod satırı 'hastaneDBDataSet6.DoktorlarDetay' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           //   this.doktorlarDetayTableAdapter.Fill(this.hastaneDBDataSet6.DoktorlarDetay);
            // TODO: Bu kod satırı 'hastaneDBDataSet6.DoktorBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
             // this.doktorBilgiTableAdapter2.Fill(this.hastaneDBDataSet6.DoktorBilgi);

            BackColor = Color.WhiteSmoke;
            // TODO: Bu kod satırı 'hastaneDBDataSet31.BransBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           
            


            // view ile doktorların yaşlarını gösteriyoruz 
            this.bransBilgiTableAdapter.Fill(this.hastaneDBDataSet31.BransBilgi);
            // TODO: Bu kod satırı 'hastaneDBDataSet31.DoktorBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
             // this.doktorBilgiTableAdapter1.Fill(this.hastaneDBDataSet31.DoktorBilgi);
            // TODO: Bu kod satırı 'hastaneDBDataSet1.DoktorBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           //   this.doktorBilgiTableAdapter1.Fill(this.hastaneDBDataSet3.DoktorBilgi);
            
            this.BackColor = Color.WhiteSmoke;
            Baglan.Open();
            // zaten değeri olan ifadeleri böyle kontrol edebiliriz 
            // table ifade için yeni bir sqlCommand yapı lazımdı 
            // burada bir funksiyon kullanılıyor 
            SqlCommand Bilgi = new SqlCommand("select *  from dbo.SekreterAdSoyad(@Sekreterid)", Baglan);
            Bilgi.Parameters.AddWithValue("@Sekreterid",SekreterGiris.Sekreterid);
             SqlDataReader Bil = Bilgi.ExecuteReader();
            if (Bil.Read())
            {
                SekreterAd.Text = Bil["AdSoyad"].ToString();
                SekreterSoyad.Text = Bil["Tc_Kimlik"].ToString();
            }




            Baglan.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        /*
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.doktorBilgiTableAdapter.FillBy(this.hastaneDBDataSet1.DoktorBilgi);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        */
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.doktorBilgiTableAdapter1.FillBy(this.hastaneDBDataSet3.DoktorBilgi);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.doktorBilgiTableAdapter1.FillBy1(this.hastaneDBDataSet3.DoktorBilgi);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.doktorBilgiTableAdapter1.FillBy2(this.hastaneDBDataSet3.DoktorBilgi);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.doktorBilgiTableAdapter1.FillBy3(this.hastaneDBDataSet3.DoktorBilgi);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void yuvarlakbuton1_Click(object sender, EventArgs e)
        {
            DoktorKayit kayit = new DoktorKayit();
            kayit.Show();
            this.Hide();
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            Form1 geri = new Form1();
            geri.Show();
            this.Hide();
        }

        private void yuvarlakbuton4_Click(object sender, EventArgs e)
        {
            BransSayfa Br = new BransSayfa();
            Br.Show();
            this.Hide();
        }

        private void HastaSayfa_Click(object sender, EventArgs e)
        {
            KayitSayfa Hs = new KayitSayfa();
            Hs.Show();
            this.Hide();
        }

        private void yuvarlakbuton2_Click(object sender, EventArgs e)
        {
            RandevuSayfa R = new RandevuSayfa();
            R.Show();
            this.Hide();
        }
    }
}
