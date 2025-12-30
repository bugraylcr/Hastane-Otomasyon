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
    public partial class DoktorGiris : Form
    {
        public DoktorGiris()
        {
            InitializeComponent();
        }
        SqlConnection Baglan = new SqlConnection("Data Source=DESKTOP-PR6L655;Initial Catalog=HastaneDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");

        public static int Doktorid;
        public static string DoktorBrans;
        private void DoktorGiris_Load(object sender, EventArgs e)
        {
            BackColor = Color.WhiteSmoke;
            textBox2.UseSystemPasswordChar = true;

        }

        private void Geri_Click(object sender, EventArgs e)
        {
               Form1 ana = new Form1();
            ana.Show();
            this.Hide();
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

        private void GirdiButon_Click(object sender, EventArgs e)
        {
            Baglan.Open();
            SqlCommand Kontrol = new SqlCommand("select * from DoktorBilgi where Tc_Kimlik = @Kimlik  and Sifre = @Sifre ", Baglan);


            Kontrol.Parameters.AddWithValue("@kimlik", textBox1.Text);
            Kontrol.Parameters.AddWithValue("@Sifre", textBox2.Text);
            SqlDataReader okut = Kontrol.ExecuteReader();
            if (okut.Read())
            {
                MessageBox.Show("kullanici giriş başarılı");

                // burada bilgileri almamızın sebebi diğer sayfalarda kullanmamızdan dolayıdır 
                // bu bilgileri almak için global değişken oluşturduk 
                Doktorid = Convert.ToInt16(okut["Doktorid"]);
                DoktorBrans = Convert.ToString(okut["Brans"]);

                DoktorSayfa doktorSayfa = new DoktorSayfa();
                doktorSayfa.Show();
                this.Hide();

                //  this.Close();
                 // Application.Exit();

            }
            else
            {
                MessageBox.Show("kullanici giriş başarısız Tekrar deneyin");
                textBox1.Text = " ";
                textBox2.Text = "";

            }
            Baglan.Close();

        }

       
    }
}
