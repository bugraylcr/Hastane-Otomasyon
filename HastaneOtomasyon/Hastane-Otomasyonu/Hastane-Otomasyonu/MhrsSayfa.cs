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
    public partial class MhrsSayfa : Form
    {
        string ad;


        public MhrsSayfa()
        {
            InitializeComponent();
        }
        SqlConnection Baglan = new SqlConnection("Data Source=DESKTOP-PR6L655;Initial Catalog=HastaneDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");

        private void MhrsSayfa_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneDBDataSet27.DoktorBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.doktorBilgiTableAdapter1.Fill(this.hastaneDBDataSet27.DoktorBilgi);
            // TODO: Bu kod satırı 'hastaneDBDataSet27.BransBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bransBilgiTableAdapter1.Fill(this.hastaneDBDataSet27.BransBilgi);
            // TODO: Bu kod satırı 'hastaneDBDataSet12.DoktorBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.doktorBilgiTableAdapter.Fill(this.hastaneDBDataSet12.DoktorBilgi);
            // TODO: Bu kod satırı 'hastaneDBDataSet12.BransBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bransBilgiTableAdapter.Fill(this.hastaneDBDataSet12.BransBilgi);
            BackColor = Color.WhiteSmoke;

            //   SqlDataAdapter Filter = new SqlDataAdapter("Select Distinct Brans from DoktorBilgi",Baglan);
            //  DataTable  da = new DataTable();
            // Filter.Fill(da);
            // BransBox.DataSource = da;
            // BransBox.DisplayMember = 
            //  HastaTarih.Value = new DateTime(2025,01,01);

            BransBox.Text = "Brans Seç";
            HastaSaat.Text = "Saat Seç";
            DoktorBox.Text = "Doktor Seç";


            Baglan.Open();
            // zaten değeri olan ifadeleri böyle kontrol edebiliriz 
            // table ifade için yeni bir sqlCommand yapı lazımdı 
            //  string TcDeger = HastaSayfa.Tc;
            //  MessageBox.Show(TcDeger);

            SqlCommand Bilgi = new SqlCommand("select *  from HastaBilgi where TC_Kimlik = @TcDeger ", Baglan);
            Bilgi.Parameters.AddWithValue("@TcDeger", HastaSayfa.Tc);

            //SqlCommand Tar = new SqlCommand("select HastaTarih from RandevuBilgi ");

            //String tarih = Tar.ExecuteScalar().ToString();
            //MessageBox.Show(tarih);


            SqlDataReader Bil = Bilgi.ExecuteReader();
             //  ad = Bil["HastaAd"].ToString();
            if (Bil.Read())
            {
               // Hasta bilgileri ile giriş yaptıktan sonra direkmen o bilgiler ile textbox lara giriş sağlıyoruz 
                HastaAd.Text = Bil["HastaAd"].ToString();
                HastaSoyad.Text = Bil["HastaSoyad"].ToString();
                HastaTc.Text = Bil["TC_Kimlik"].ToString();
                // burada isim almada bir sorun yok 
                

                 ad = Bil["HastaAd"].ToString();

            

               
                

            }

           // HastaAd.Text = " ";
           // HastaSoyad.Text = " ";
            //  HastaTc.Text = " ";

            Baglan.Close();
            String TCKontrol = null;
            Baglan.Open();

            SqlCommand Kontrol = new SqlCommand("select *  from RandevuBilgi where TC_Kimlik = @TcDeger ", Baglan);
            Kontrol.Parameters.AddWithValue("@TcDeger", HastaSayfa.Tc);

            //SqlCommand Tar = new SqlCommand("select HastaTarih from RandevuBilgi ");

            //String tarih = Tar.ExecuteScalar().ToString();
            //MessageBox.Show(tarih);


            SqlDataReader kon = Kontrol.ExecuteReader();

            if (kon.Read())
            {
               TCKontrol = kon["TC_Kimlik"].ToString();
            }

            Baglan.Close();

            Baglan.Open();
           // burada hastanın randevusuna 1 gün kalmasına karşın mesaj çekiyoruz 
            if(TCKontrol != null)
            {
                string Hastaisim = "select dbo.HastaMesaj(@isim)";
                SqlCommand Yaz = new SqlCommand(Hastaisim, Baglan);
                Yaz.Parameters.AddWithValue("@isim", ad);

                string HastaMes = Yaz.ExecuteScalar().ToString();
                MessageBox.Show(HastaMes);
               

            }
            //string Hastaisim = "select dbo.HastaMesaj(@isim)";
            //SqlCommand Yaz = new SqlCommand(Hastaisim, Baglan);
            //Yaz.Parameters.AddWithValue("@isim", ad);

            //string HastaMes = Yaz.ExecuteScalar().ToString();
            //MessageBox.Show(HastaMes);


            //  Baglan.Open();
            //SqlCommand Tar = new SqlCommand("select HastaTarih from RandevuBilgi where HastaAd = @ad");

            //String tarih = Tar.ExecuteScalar().ToString();
            //MessageBox.Show(tarih);

            // ad = " ";
            Baglan.Close();

        }

        private void AnaGeriButton_Click(object sender, EventArgs e)
        {
            Form1 Ana = new Form1();
            Ana.Show();
            this.Close();
        }
        public static  string bb;
        private void BransBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // böylece burada combobox daki değer ile tablodaki değeri filterebiliyoruz 
            bb = BransBox.Text;
            doktorBilgiBindingSource4.Filter = "Brans = '" + bb + "'";

        }

        private void DoktorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void Randev_Click(object sender, EventArgs e)
        {
            // burada randevu bilgilerini insert ediyoruz 
            Baglan.Open();
            SqlCommand Ekle = new SqlCommand("insert into RandevuBilgi (HastaAd,HastaSoyad,TC_Kimlik,RandevuTarih,RandevuSaat,DoktorAd,Brans,HastaBilgilendirme,Hastaid,Doktorid,Bransid) values (@Ad,@Soyad,@Tc,@RandevTar,@RandevSaat,@DkAd,@Br,@Hastainfo,@Hsid,@Dkid,@Brid)", Baglan);
           
            
            Ekle.Parameters.AddWithValue("@Ad", HastaAd.Text);
            Ekle.Parameters.AddWithValue("@Soyad", HastaSoyad.Text);
            Ekle.Parameters.AddWithValue("@Tc", HastaTc.Text);
            Ekle.Parameters.AddWithValue("@RandevSaat", HastaSaat.Text);
            Ekle.Parameters.AddWithValue("@RandevTar", HastaTarih.Value);
            Ekle.Parameters.AddWithValue("@Br", BransBox.Text);
            Ekle.Parameters.AddWithValue("@DkAd", DoktorBox.Text);


             // burada Doktor id sini foreign key yaparak RandevuBilgi talbosu aktardık 
            //  string isim = DoktorBox.Text;
             string hedef = "select Doktorid from DoktorBilgi where Ad = @isim";
            SqlCommand ad = new SqlCommand(hedef,Baglan);
            ad.Parameters.AddWithValue("@isim", DoktorBox.Text);
            Doktorid.Text = ad.ExecuteScalar().ToString();

            //  string Bisim = BransBox.Text;
            string ara = "select Bransid from BransBilgi where Brans = @Bisim";
            SqlCommand BrAd = new SqlCommand(ara, Baglan);
            BrAd.Parameters.AddWithValue("@Bisim", BransBox.Text);
            BransTextBox.Text = BrAd.ExecuteScalar().ToString();

            // burada isimde herhangi bir sorun yok 
            //   MessageBox.Show(isim);
            //   gecici = Convert.ToInt16(Doktorid.Text);
            Ekle.Parameters.AddWithValue("@Hastainfo", HastaBilgi.Text);
            Ekle.Parameters.AddWithValue("@Hsid", HastaSayfa.Hastaid);
             Ekle.Parameters.AddWithValue("@Dkid", Convert.ToInt16(Doktorid.Text));
            Ekle.Parameters.AddWithValue("@Brid", Convert.ToInt16(BransTextBox.Text));



            Ekle.ExecuteNonQuery();
            Baglan.Close();


            //Baglan.Open();
            //Doktorid.Text = "select Doktorid from DoktorBilgi where DoktorAd = @isim";




            //Baglan.Close();
            MessageBox.Show("Randevu Kayıt Gerçekleştirildi");
            HastaAd.Text = " ";
            HastaSoyad.Text = " ";
            HastaTc.Text = " ";
            HastaTarih.Value = DateTime.Today;
            HastaSaat.Text = "Saat Seç";
            BransBox.Text = "Brans Seç";
            DoktorBox.Text = "Doktor Seç";
            HastaBilgi.Text = " ";
            Doktorid.Text = " ";

          
        }

        private void ReceteS_Click(object sender, EventArgs e)
        {
            HastaRecete Hr = new HastaRecete();
            Hr.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HastaLab Hl = new HastaLab();
            Hl.Show();
            this.Hide();
        }
    }
}
