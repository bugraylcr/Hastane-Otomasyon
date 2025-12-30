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
    public partial class HastaLab : Form
    {
        public HastaLab()
        {
            InitializeComponent();
        }
        SqlConnection Baglan = new SqlConnection("Data Source=DESKTOP-PR6L655;Initial Catalog=HastaneDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");

        private void HastaLab_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneDBDataSet30.ReceteDetay' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.receteDetayTableAdapter.Fill(this.hastaneDBDataSet30.ReceteDetay);
            // TODO: Bu kod satırı 'hastaneDBDataSet30.RontgenSonuc' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.rontgenSonucTableAdapter.Fill(this.hastaneDBDataSet30.RontgenSonuc);
            // TODO: Bu kod satırı 'hastaneDBDataSet30.KanSonuc' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kanSonucTableAdapter.Fill(this.hastaneDBDataSet30.KanSonuc);
            BackColor = Color.WhiteSmoke;
            Baglan.Open();

            // o doktor a ait hastaların değerlerini gösterme işlemi
            string sec = "select * from KanSonuc where Hastaid = @Htid";
            SqlDataAdapter Dt = new SqlDataAdapter(sec, Baglan);
            Dt.SelectCommand.Parameters.AddWithValue("@Htid", HastaSayfa.Hastaid);
            DataTable tb = new DataTable();
            dataGridView1.DataSource = tb;
            Dt.Fill(tb);
            Baglan.Close();
            ////////////////////////////////////////////////////////////////
            
            // Rontgen Sonuclarınını  Sadece sisteme giriş yapan hastaya ait olması için Hastaid ile işlem yapıyoruz 
            string seca = "select  * from RontgenSonuc where Hastaid = @Hsid ";
            SqlDataAdapter Dta = new SqlDataAdapter(seca, Baglan);
            Dta.SelectCommand.Parameters.AddWithValue("@Hsid", HastaSayfa.Hastaid);

            DataTable tba = new DataTable();
            //datagridview fazla dolmasında dolayı olan bir durum 
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = tba;
            Dta.Fill(tba);
            Baglan.Close();










        }

        private void GBu_Click(object sender, EventArgs e)
        {
            MhrsSayfa Mh = new MhrsSayfa();
            Mh.Show();
            this.Hide();
           //   MessageBox.Show(HastaSayfa.Hastaid.ToString());
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // picturebox da rontgenleri gösterme işlemi yapiyoruz 
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
    }
}
