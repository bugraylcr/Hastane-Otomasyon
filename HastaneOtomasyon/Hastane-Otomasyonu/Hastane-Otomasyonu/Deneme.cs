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
    public partial class Deneme : Form
    {
        public Deneme()
        {
            InitializeComponent();
        }
        SqlConnection Baglan = new SqlConnection("Data Source=DESKTOP-PR6L655;Initial Catalog=HastaneDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");

        private void Deneme_Load(object sender, EventArgs e)
        {

            Baglan.Open();
            string secenek = "select * from RandevuBilgi where HastaOnayla = 0 order by RandevuTarih asc";
            SqlDataAdapter Dt = new SqlDataAdapter(secenek, Baglan);
            DataTable tb = new DataTable();
            Dt.Fill(tb);
            // dataGridView2.AutoGenerateColumns = true;
            dataGridView1.DataSource = tb;
            //  MessageBox.Show("Satır sayısı: " + tb.Rows.Count);

            Baglan.Close();
        }
    }
}
