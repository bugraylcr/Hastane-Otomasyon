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
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection Baglan = new SqlConnection("Data Source=DESKTOP-PR6L655;Initial Catalog=HastaneDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");

        private void GeriB_Click(object sender, EventArgs e)
        {
            Form1 Ana = new Form1();
            Ana.Show();
            this.Hide();
        }

        private void AdminGiris_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            textBox2.UseSystemPasswordChar = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Baglan.Open();

            SqlCommand Kontrol = new SqlCommand("select * from AdminBilgi where Tc_Kimlik = @Kimlik  and Sifre = @Sifre ", Baglan);


            Kontrol.Parameters.AddWithValue("@kimlik", textBox1.Text);
            Kontrol.Parameters.AddWithValue("@Sifre", textBox2.Text);
            SqlDataReader oku = Kontrol.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("kullanici giriş başarılı");
                AdminSayfa AS = new AdminSayfa();
                AS.Show();
                this.Close();
                

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
