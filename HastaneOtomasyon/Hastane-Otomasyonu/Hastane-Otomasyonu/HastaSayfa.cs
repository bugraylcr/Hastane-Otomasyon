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
using System.Net.NetworkInformation;

namespace Hastane_Otomasyonu
{
    public partial class HastaSayfa : Form
    {
        public static string Tc;
       
        public HastaSayfa()
        {
            InitializeComponent();
        }
        // arada boşluklar olmamalıdır 
        SqlConnection Baglan = new SqlConnection("Data Source=DESKTOP-PR6L655;Initial Catalog=HastaneDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");

        public static int Hastaid;
        private void HastaSayfa_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            this.BackColor = Color.WhiteSmoke;
        }

       
        private void GirisButton_Click(object sender, EventArgs e)
        {
            
            Baglan.Open();
            // bunlara gerek birde yok 
           //string TcKimlik = textBox1.Text;
           // string Sifre = textBox2.Text;
           // burada kontrol işlemlerini yapıyoruz 
           // burada giriş sağlıyoruz
            SqlCommand Kontrol = new SqlCommand("select * from HastaBilgi where TC_Kimlik = @Kimlik  and Sifre = @Sifre " ,Baglan);
            Tc = textBox1.Text;
            //  MessageBox.Show(Tc);
            Kontrol.Parameters.AddWithValue("@kimlik",textBox1.Text);
            Kontrol.Parameters.AddWithValue("@Sifre",textBox2.Text);
            SqlDataReader okuma = Kontrol.ExecuteReader();
            if (okuma.Read())
            {
                Hastaid = Convert.ToInt16(okuma["Hastaid"]);

                MessageBox.Show("kullanici giriş başarılı");
                MhrsSayfa mh = new MhrsSayfa();
                mh.Show();
                this.Hide();
                 // Application.Exit();

            }
            else
            {
                MessageBox.Show("kullanici giriş başarısız Tekrar deneyin");
                textBox1.Text = " ";
                textBox2.Text = "";
                
            }
            Tc = " ";
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
                textBox2.UseSystemPasswordChar= false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ana  = new Form1();
            ana.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
