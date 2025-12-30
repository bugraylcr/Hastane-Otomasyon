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

    public partial class DoktorSayfa : Form
    {
      //   public static string Bransisim;

        public DoktorSayfa()
        {
            InitializeComponent();
        }
        SqlConnection Baglan = new SqlConnection("Data Source=DESKTOP-PR6L655;Initial Catalog=HastaneDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
       public static string Bransisim;
        private void DoktorSayfa_Load(object sender, EventArgs e)
        {
            // hiçbir sorun yok gözüküyor 
           //   MessageBox.Show(DoktorGiris.DoktorBrans);
            // TODO: Bu kod satırı 'hastaneDBDataSet28.RandevuBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.randevuBilgiTableAdapter3.Fill(this.hastaneDBDataSet28.RandevuBilgi);
            // TODO: Bu kod satırı 'hastaneDBDataSet21.RandevuDetay' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.randevuDetayTableAdapter1.Fill(this.hastaneDBDataSet21.RandevuDetay);
            // TODO: Bu kod satırı 'hastaneDBDataSet21.HastaBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hastaBilgiTableAdapter.Fill(this.hastaneDBDataSet21.HastaBilgi);
            // TODO: Bu kod satırı 'hastaneDBDataSet21.AdminBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.adminBilgiTableAdapter.Fill(this.hastaneDBDataSet21.AdminBilgi);
            // TODO: Bu kod satırı 'hastaneDBDataSet17.RandevuBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           
            
            // burada da aynı hatayı alıyoruz 
            // hata olmasının sebebi ise  tablo da bir değişkenin  boyutunu değiştirdiğimizde bütün tabloların etkilenmesi 
           
           //   this.randevuBilgiTableAdapter2.Fill(this.hastaneDBDataSet17.RandevuBilgi);
            // TODO: Bu kod satırı 'hastaneDBDataSet21.RandevuBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
             //this.randevuBilgiTableAdapter1.Fill(this.hastaneDBDataSet21.RandevuBilgi);
            // TODO: Bu kod satırı 'hastaneDBDataSet18.RandevuDetay' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.randevuDetayTableAdapter.Fill(this.hastaneDBDataSet18.RandevuDetay);
            // TODO: Bu kod satırı 'hastaneDBDataSet18.RandevuBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //  this.randevuBilgiTableAdapter.Fill(this.hastaneDBDataSet18.RandevuBilgi);
            // TODO: Bu kod satırı 'hastaneDBDataSet20.HastaBilgiler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
              this.hastaBilgilerTableAdapter1.Fill(this.hastaneDBDataSet20.HastaBilgiler);
            // TODO: Bu kod satırı 'hastaneDBDataSet19.HastaBilgiler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // this.hastaBilgilerTableAdapter.Fill(this.hastaneDBDataSet19.HastaBilgiler);
            BackColor = Color.WhiteSmoke;
            Baglan.Open();
            // zaten değeri olan ifadeleri böyle kontrol edebiliriz 
            // table ifade için yeni bir sqlCommand yapı lazımdı 
            // burada bir funksiyon kullanılıyor 
            // kontrol amaç
             // MessageBox.Show(Convert.ToString(DoktorGiris.Doktorid));

            SqlCommand Bilgi = new SqlCommand("select *  from dbo.DoktorAdSoyad(@Doktorid)", Baglan);
            Bilgi.Parameters.AddWithValue("@Doktorid", DoktorGiris.Doktorid);
            SqlDataReader Bil = Bilgi.ExecuteReader();
            if (Bil.Read())
            {
                // burada doktorların doktogiriş sayfasından bilgilerini alıyoruz 
                // giren doktorun Bilgileri de gözüküyor 
                AdSoyad.Text = Bil["AdSoyad"].ToString();
                DoktorTc.Text = Bil["Tc_Kimlik"].ToString();
                bransbi.Text = Bil["Brans"].ToString();

            }

            Baglan.Close();

            Baglan.Open();
            Bransisim = bransbi.Text;

            /*
            string yap = "select Rb.HastaAd,Rb.HastaSoyad, Rb.TC_Kimlik,dbo.HastaYas(@Doktorid)  as HastaYas from RandevuBilgi as Rb ";
            SqlDataAdapter Yb = new SqlDataAdapter(yap, Baglan);
            Yb.SelectCommand.Parameters.AddWithValue("@Doktorid",DoktorGiris.Doktorid);

            DataTable Dtb = new DataTable();
            dataGridView1.DataSource = Dtb;
            Yb.Fill(Dtb);
            */
            // burada bunu kullansak sorun çünkü bu sefer yaslar yazılmıyor

            //string yap = " select * from RandevuBilgi  where  Doktorid = @Doktorid";
            //SqlDataAdapter Yb = new SqlDataAdapter(yap, Baglan);
            //Yb.SelectCommand.Parameters.AddWithValue("@Doktorid ", DoktorGiris.Doktorid);

            //DataTable Dtb = new DataTable();
            //dataGridView1.DataSource = Dtb;
            //Yb.Fill(Dtb);

            Baglan.Close();
             // Randevuları dataadapter ile giriş yapan doktor  a ve RandevuTarihlerine göre olduğunu gösteriyor 
            Baglan.Open();
            string secenek = "select * from RandevuBilgi  where HastaOnayla = 1  and  Doktorid = @Dkid order by RandevuTarih , RandevuSaat asc";
            SqlDataAdapter Dt = new SqlDataAdapter(secenek, Baglan);
            Dt.SelectCommand.Parameters.AddWithValue("@Dkid", DoktorGiris.Doktorid);

            DataTable tb = new DataTable();
            dataGridView3.DataSource = tb;
            Dt.Fill(tb);
            Baglan.Close();
        }

        private void GeriButon_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();


     


        }

        private void yuvarlakbuton1_Click(object sender, EventArgs e)
        {
            RandevuDetay Rd = new RandevuDetay();
            Rd.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView3.SelectedCells[0].RowIndex;
            //  string isim = dataGridView3.Rows[secilen].Cells[1].Value.ToString();
            isim.Text = dataGridView3.Rows[secilen].Cells[0].Value.ToString();
            Soyad.Text = dataGridView3.Rows[secilen].Cells[1].Value.ToString();
            HTc.Text = dataGridView3.Rows[secilen].Cells[2].Value.ToString();
            // burada zaten Bransisim seçiliyor 
            //ama sadece tıklandğı zaman seçiyor 
            //genel anlam da seçmiyor 
            Bransisim = dataGridView3.Rows[secilen].Cells[3].Value.ToString();
            Hsid.Text = dataGridView3.Rows[secilen].Cells[7].Value.ToString();
            Dkid.Text = dataGridView3.Rows[secilen].Cells[6].Value.ToString();
            // burada değer gözüküyor 
            //  MessageBox.Show(Bransisim);
        }
        private void ReceteK_Click(object sender, EventArgs e)
        {
            Baglan.Open();
            SqlCommand Ekle = new SqlCommand("insert into ReceteHasta (Hastaid,Doktorid,HastaTc,ReceteBilgi,HastaAd,HastaSoyad) values (@Hid,@Dkid,@Tc,@Bilgi,@Had,@Hsoyad)" , Baglan);

            // burada ise reçete ekleme işlemlerini yapıyoruz 
            Ekle.Parameters.AddWithValue("@Hid", Hsid.Text);
            Ekle.Parameters.AddWithValue("@Dkid", Dkid.Text);
            Ekle.Parameters.AddWithValue("@Tc", HTc.Text);
            Ekle.Parameters.AddWithValue("@Bilgi", BilgiRa.Text);
            Ekle.Parameters.AddWithValue("@Had", isim.Text);
            Ekle.Parameters.AddWithValue("@Hsoyad", Soyad.Text);

            Ekle.ExecuteNonQuery();

            MessageBox.Show("Reçete oluşturulmuştur");
            Baglan.Close();

            Hsid.Text = " ";
            Dkid.Text = " ";
            HTc.Text = "Tc";
            BilgiRa.Text = " ";
            isim.Text = "Ad";
            Soyad.Text = "Soyad";
        }

        private void ReceteP_Click(object sender, EventArgs e)
        {
            Receteler Rc = new Receteler();
            Rc.Show();
            this.Hide();
        }

        private void LabDk_Click(object sender, EventArgs e)
        {
            LabDoktor LD = new LabDoktor();
            LD.Show();
            this.Hide();
        }
    }
}
