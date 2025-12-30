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
using System.Drawing.Imaging;
namespace Hastane_Otomasyonu
{
    public partial class LabDoktor : Form
    {
        public LabDoktor()
        {
            InitializeComponent();
        }
        SqlConnection Baglan = new SqlConnection("Data Source=DESKTOP-PR6L655;Initial Catalog=HastaneDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");

        string RontgenFoto;
        private void LabDoktor_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneDBDataSet30.RontgenSonuc' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
              this.rontgenSonucTableAdapter2.Fill(this.hastaneDBDataSet30.RontgenSonuc);
            // TODO: Bu kod satırı 'hastaneDBDataSet29.RontgenSonuc' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.rontgenSonucTableAdapter1.Fill(this.hastaneDBDataSet29.RontgenSonuc);
            // TODO: Bu kod satırı 'hastaneDBDataSet27.DoktorBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // this.doktorBilgiTableAdapter.Fill(this.hastaneDBDataSet27.DoktorBilgi);
            // TODO: Bu kod satırı 'hastaneDBDataSet28.RontgenSonuc' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.rontgenSonucTableAdapter.Fill(this.hastaneDBDataSet28.RontgenSonuc);
            // şuan düzgün bir şekilde çalışmaya başladı 
            //    MessageBox.Show(DoktorSayfa.Bransisim);
            // TODO: Bu kod satırı 'hastaneDBDataSet26.KanSonuc' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //  this.kanSonucTableAdapter1.Fill(this.hastaneDBDataSet26.KanSonuc);
            // TODO: Bu kod satırı 'hastaneDBDataSet25.KanSonuc' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           //   this.kanSonucTableAdapter.Fill(this.hastaneDBDataSet25.KanSonuc);
            BackColor = Color.WhiteSmoke;
           //   MessageBox.Show(DoktorGiris.Doktorid.ToString());
            Baglan.Open();

            // o doktor a ait hastaların değerlerini gösterme işlemi
            string sec = "select * from KanSonuc where Doktorid = @Dkid";
            SqlDataAdapter Dt = new SqlDataAdapter(sec,Baglan);
            Dt.SelectCommand.Parameters.AddWithValue("@Dkid",DoktorGiris.Doktorid);
            DataTable tb = new DataTable();
            dataGridView1.DataSource = tb;
            Dt.Fill(tb);
            Baglan.Close();

            // burada sadece istenen branşlar var 
          //    MessageBox.Show(DoktorSayfa.Bransisim);

           
        }

        private void GeriBut_Click(object sender, EventArgs e)
        {
            DoktorSayfa Ds = new DoktorSayfa();
            Ds.Show();
            this.Hide();
        }

        
        private void KanButton_Click(object sender, EventArgs e)
        {
            // burada Röntgen görüntülerini çekiyoruz 
            // yaptığım işlem ise burada switch case ile sistem  giriş yapan doktorun bransı ile case yapılıyor ve röntgen seçiliyor 
                string RontgenFoto = " ";
                switch (DoktorGiris.DoktorBrans)
                {
                    case "Ortopedi (Skolyoz)":
                        RontgenFoto = "\"C:\\Users\\W11\\Desktop\\HastaneOtomasyon\\SkolyozFoto.jpeg\"";
                        RontgenFoto = RontgenFoto.Trim().Trim('"');
                        //   pictureBox1.Image = Image.FromFile(RontgenFoto);
                        break;

                    case "Dahiliye (Akciğer)":
                        RontgenFoto = "\"C:\\Users\\W11\\Desktop\\HastaneOtomasyon\\AkcigerRöntgen.jpg\"";
                        RontgenFoto = RontgenFoto.Trim().Trim('"');
                        //  pictureBox1.Image = Image.FromFile(RontgenFoto);


                        break;
                    case "Kardiyoloji (Kalp)":
                        RontgenFoto = "\"C:\\Users\\W11\\Desktop\\HastaneOtomasyon\\KalpRöntgen.jpeg\"";
                        RontgenFoto = RontgenFoto.Trim().Trim('"');
                        //   pictureBox1.Image = Image.FromFile(RontgenFoto);
                        break;

                    //break;
                    case "Burun":
                        RontgenFoto = "\"C:\\Users\\W11\\Desktop\\HastaneOtomasyon\\BurunFoto.jpg\"";
                        RontgenFoto = RontgenFoto.Trim().Trim('"');
                        //   pictureBox1.Image = Image.FromFile(RontgenFoto);


                        break;
                    case "Göz":
                        RontgenFoto = "\"C:\\Users\\W11\\Desktop\\HastaneOtomasyon\\GozFoto.jpg\"";
                        RontgenFoto = RontgenFoto.Trim().Trim('"');

                        break;



                       
           
             }

            Baglan.Open();
            //    SqlCommand RontgenVeri = new SqlCommand("insert into RontgenSonuc(Hastaid,Doktorid,RontgenGoruntu,RontgenTarih,HastaAd,HastaSoyad,RontgenBrans,HastaTc) select Hastaid,Doktorid, @Gr, getdate(),HastaAd,HastaSoyad,@Br,TC_Kimlik from RandevuBilgi ", Baglan);

            SqlCommand RontgenVeri = new SqlCommand("insert into RontgenSonuc(Hastaid,Doktorid,HastaAd,HastaSoyad,HastaTc,RontgenBrans,RontgenGoruntu,RontgenTarih) select RandevuBilgi.Hastaid,RandevuBilgi.Doktorid,RandevuBilgi.HastaAd,RandevuBilgi.HastaSoyad,RandevuBilgi.TC_Kimlik,Brans,@Gr,getdate() from RandevuBilgi where Brans = @Br", Baglan);


            //  RontgenVeri.Parameters.AddWithValue("@Brr", DoktorSayfa.Bransisim);

            //  RontgenVeri.Parameters.Add("@Br", SqlDbType.NVarChar, 50);
            RontgenVeri.Parameters.Add("@Gr", SqlDbType.NVarChar, 4000);
            RontgenVeri.Parameters["@Gr"].Value = RontgenFoto;
            //  RontgenVeri.Parameters["@Br"].Value = DoktorGiris.DoktorBrans;
            RontgenVeri.Parameters.AddWithValue("@Br", DoktorGiris.DoktorBrans);
            RontgenVeri.ExecuteNonQuery();
            Baglan.Close();
            MessageBox.Show("Röntgenler oluşturuldu şimdi Röntgenleri Çekiniz ");
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // burada ise seçilen görseli picturebox da açılmasını sağlıyoruz 
            // string Gorsel = Res.ExecuteScalar().ToString();
            int secilen = dataGridView2.SelectedCells[0].RowIndex;

            string Gorsel = dataGridView2.Rows[secilen].Cells[8].Value.ToString();
            // burun seçmeme rağmen gözü seçiyor 
           //   MessageBox.Show(Gorsel);
            Gorsel = Gorsel.Trim().Trim('"');
           //  MessageBox.Show(Gorsel);
            pictureBox1.ImageLocation = Gorsel;
             pictureBox1.Load();
             // Baglan.Close() ;    
        }

        private void Rtng_Click(object sender, EventArgs e)
        {
            this.rontgenSonucTableAdapter2.Fill(this.hastaneDBDataSet30.RontgenSonuc);

        }
    }
}
