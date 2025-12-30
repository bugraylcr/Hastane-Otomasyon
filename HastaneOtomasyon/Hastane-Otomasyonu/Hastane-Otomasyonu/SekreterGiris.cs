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

    public partial class SekreterGiris : Form
    {
        // global değişken
        public SekreterGiris()
        {
            InitializeComponent();
        }
        SqlConnection Baglan = new SqlConnection("Data Source=DESKTOP-PR6L655;Initial Catalog=HastaneDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");

        public static int Sekreterid;
        private void SekreterGiris_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;

            textBox2.UseSystemPasswordChar = true;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 ana = new Form1();
            ana.Show();
            this.Hide();
        }

       

        private void GirisButon_Click(object sender, EventArgs e)
        {
            // sekreter girişi yapıyorum 
            Baglan.Open();

            SqlCommand Kontrol = new SqlCommand("select * from SekreterBilgi where Tc_Kimlik = @Kimlik  and Sifre = @Sifre ", Baglan);
            //  SqlCommand hedefid = new SqlCommand("select Sekreterid from SekreterBilgi where Tc_Kimlik = @Kimlik  and Sifre = @Sifre", Baglan);

            Kontrol.Parameters.AddWithValue("@kimlik", textBox1.Text);
            Kontrol.Parameters.AddWithValue("@Sifre", textBox2.Text);
            SqlDataReader oku = Kontrol.ExecuteReader();
            if (oku.Read())
            {
              
              
                // burada sekreterid i bir global değişkene atadık 
                // diğer sekreter sayfasında kullanmak için

                    Sekreterid = Convert.ToInt16(oku["Sekreterid"]);
                

                MessageBox.Show("kullanici giriş başarılı");
                SekreterSayfa Sekr = new SekreterSayfa();
                Sekr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("kullanici giriş başarısız Tekrar deneyin");
                textBox1.Text = " ";
                textBox2.Text = "";

            }


              Baglan.Close();



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }
    }
}
