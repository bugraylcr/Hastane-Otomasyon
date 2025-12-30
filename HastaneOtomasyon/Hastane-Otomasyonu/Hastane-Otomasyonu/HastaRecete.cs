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
    public partial class HastaRecete : Form
    {
        public HastaRecete()
        {
            InitializeComponent();
        }
        SqlConnection Baglan = new SqlConnection("Data Source=DESKTOP-PR6L655;Initial Catalog=HastaneDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");

        private void GeriMhrs_Click(object sender, EventArgs e)
        {
            MhrsSayfa mh = new MhrsSayfa();
            mh.Show();
            this.Hide();
        }

        private void HastaRecete_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneDBDataSet24.ReceteDetay' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.receteDetayTableAdapter.Fill(this.hastaneDBDataSet24.ReceteDetay);
            BackColor = Color.WhiteSmoke;
             // Baglan.Open();
            //  int Hastaid = 0;
            // burada bir atama hatası var 
             // SqlCommand Bilgi = new SqlCommand("select Hastaid from HastaBilgi where TC_Kimlik = @TcDeger ", Baglan);
             // Bilgi.Parameters.AddWithValue("@TcDeger", HastaSayfa.Tc);

            //  MessageBox.Show(HastaSayfa.Hastaid.ToString());

            /*  
              SqlDataReader Bil = Bilgi.ExecuteReader();
              if (Bil.Read())
              {
                  HastaidT.Text = Convert.ToString(Bil["Hastaid"]);


              }

              Baglan.Close();
              Hastaid = Convert.ToInt16(HastaidT.Text);
              MessageBox.Show(HastaidT.Text);
            */

            // Yazılan Recetelerim sisteme giriş yapan Hastaya ve Tarihe  eskiden yeniye  göre tablo da gösterme   işlemi yapıyoruz 
            Baglan.Open();
            string secenek = "select * from  ReceteDetay where Hsid = @Hastaid order by ReceteTarih asc";
            SqlDataAdapter Dt = new SqlDataAdapter(secenek, Baglan);
            Dt.SelectCommand.Parameters.AddWithValue("@Hastaid",HastaSayfa.Hastaid);
           
            DataTable tb = new DataTable();
            dataGridView1.DataSource = tb;
            Dt.Fill(tb);
           Baglan.Close();
             
        }
    }
}
