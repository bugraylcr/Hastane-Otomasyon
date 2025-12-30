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

namespace Hastane_Otomasyonu
{
    public partial class BransSayfa : Form
    {
        public BransSayfa()
        {
            InitializeComponent();
        }
        SqlConnection Baglan = new SqlConnection("Data Source=DESKTOP-PR6L655;Initial Catalog=HastaneDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");

        private void Geri_Click(object sender, EventArgs e)
        {
            SekreterSayfa sk = new SekreterSayfa();
            sk.Show();
            this.Hide();
        }

        private void BransSayfa_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneDBDataSet6.BransBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bransBilgiTableAdapter.Fill(this.hastaneDBDataSet6.BransBilgi);
            BackColor = Color.WhiteSmoke;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            int sec = dataGridView1.SelectedCells[0].RowIndex;
            idBox.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            BransAd.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
        }

        private void Listele_Click(object sender, EventArgs e)
        {
            this.bransBilgiTableAdapter.Fill(this.hastaneDBDataSet6.BransBilgi);

        }

        private void BransEkle_Click(object sender, EventArgs e)
        {
            Baglan.Open();
            SqlCommand Ekle = new SqlCommand("insert into BransBilgi (Brans) values (@BransAd)", Baglan);
            Ekle.Parameters.AddWithValue("@BransAd", BransAd.Text);
            Ekle.ExecuteNonQuery();
            Baglan.Close();
            MessageBox.Show("Başarılı bir şekilde Yeni bir Brans Eklendi ");
        }

        private void SilBrans_Click(object sender, EventArgs e)
        {
            Baglan.Open();
            SqlCommand Sil = new SqlCommand("delete from  BransBilgi where Bransid = @id", Baglan);
            Sil.Parameters.AddWithValue("@id", idBox.Text);
            Sil.ExecuteNonQuery();
            Baglan.Close();
            MessageBox.Show("Silinme işlemi gerçekleşti");
        }
    }
}
