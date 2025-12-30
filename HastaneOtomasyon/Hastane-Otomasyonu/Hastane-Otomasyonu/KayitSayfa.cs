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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hastane_Otomasyonu
{
    public partial class KayitSayfa : Form
    {
        public KayitSayfa()
        {
            InitializeComponent();
        }
        SqlConnection Baglan = new SqlConnection("Data Source=DESKTOP-PR6L655;Initial Catalog=HastaneDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
        bool Cinsiyet;
        HastaSayfa Sayfahasta = new HastaSayfa();
        private void KayitSayfa_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneDBDataSet10.HastaBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hastaBilgiTableAdapter.Fill(this.hastaneDBDataSet10.HastaBilgi);
            this.BackColor = Color.WhiteSmoke;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void KayitButton_Click(object sender, EventArgs e)
        {

           
            Baglan.Open();

           
             // burada sql deki  HastaTcKontrol   stored procedure kullanıyoruz  
            SqlCommand Kontrol = new SqlCommand("HastaTcKontrol", Baglan);
            Kontrol.CommandType = CommandType.StoredProcedure;
            Kontrol.Parameters.AddWithValue("@Tc", TCtext.Text);
            int? deger = (int?)Kontrol.ExecuteScalar();
            // burada  null dönerse Kayıtlı Tc ile giriş vardır 

            // dönen değerleri ise  yapısı ile gerekli çıktılar üretiyoruz
            if (deger == 0)
            {
                Baglan.Close();
                MessageBox.Show("Kayıtlı olan Tc ile kayıt yapılamaz");
                


            }
            if (deger == null)
            {
                Baglan.Close();
                MessageBox.Show("Lütfen düzgün bir Tc kimlik giriniz");
                AdText.Text = " ";
                SoyadText.Text = " ";
                TCtext.Text = " ";
                SifreText.Text = " ";
                ErkekMi.Checked = false;
                KadinMi.Checked = false;
                HastaDogum.Value = DateTime.Now;



            }
            if (deger == 1)
            {
                // eğer hastatckontol sp sinde  çıktısı 1 olursa 
                // ikinci bir sp olan TelKontrol u çağrıyoruz 

                SqlCommand TelKn = new SqlCommand("TelKontrol", Baglan);
                TelKn.CommandType = CommandType.StoredProcedure;
                TelKn.Parameters.AddWithValue("@Tel", TelefonText.Text);
                int? tel = (int?)TelKn.ExecuteScalar();

                if (tel == 0)
                {
                    Baglan.Close();

                    MessageBox.Show("Kayıtlı olan tel numarası ile kayıt yapılamaz ");

                }
                 if (tel == 2)
                {
                    Baglan.Close();

                    MessageBox.Show("Lütfen düzgün bir tel Numarası giriniz");
                }


                if (tel == 1)
                {


                    string Cins = "";

                    if (ErkekMi.Checked)
                    {
                        Cins = "Erkek";
                    }
                    else if (KadinMi.Checked)
                    {
                        Cins = "Kadın";
                    }
                    // burada ise HastaKayit Sp sini kullanıyoruz hasta kayit işlemlerinde 
                    SqlCommand Ekle = new SqlCommand("HastaKayit", Baglan);
                    Ekle.CommandType = CommandType.StoredProcedure;

                    Ekle.Parameters.AddWithValue("@Ad", AdText.Text);
                    Ekle.Parameters.AddWithValue("@Soyad", SoyadText.Text);
                    Ekle.Parameters.AddWithValue("@Tc", TCtext.Text);
                    Ekle.Parameters.AddWithValue("@Sifre", SifreText.Text);
                    Ekle.Parameters.AddWithValue("@Tel", TelefonText.Text);
                    Ekle.Parameters.AddWithValue("@Cins", Cins);
                    Ekle.Parameters.AddWithValue("@Tarih", HastaDogum.Value);

                    Ekle.ExecuteNonQuery();
                    MessageBox.Show("Başarılı bir şekilde kayıt gerçekleştirildi ");
                 
                }
               
                Baglan.Close();

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SekreterSayfa SH = new SekreterSayfa();
            SH.Show();
            this.Close();
        }

        private void GuncelHasta_Click(object sender, EventArgs e)
        {


            Baglan.Open();

            string Cins = "";

            if (ErkekMi.Checked)
            {
                Cins = "Erkek";
            }
            else if (KadinMi.Checked)
            {
                Cins = "Kadın";
            }
         
           
            
            // aynı zamanda burada Hasta Guncelle sp sini kullanıyoruz 
                    SqlCommand Guncel = new SqlCommand("HastaGuncelle", Baglan);
                    Guncel.CommandType = CommandType.StoredProcedure;

                    Guncel.Parameters.AddWithValue("@Ad", AdText.Text);
                    Guncel.Parameters.AddWithValue("@Soyad", SoyadText.Text);
                    Guncel.Parameters.AddWithValue("@Tc", TCtext.Text);
                    Guncel.Parameters.AddWithValue("@Sifre", SifreText.Text);
                    Guncel.Parameters.AddWithValue("@Tel", TelefonText.Text);
                    Guncel.Parameters.AddWithValue("@Cins", Cins);
                    Guncel.Parameters.AddWithValue("@Tarih", HastaDogum.Value);
                    Guncel.Parameters.AddWithValue("@Hid", Convert.ToInt16(Textid.Text));


                    Guncel.ExecuteNonQuery();
                    MessageBox.Show("Guncelleme gerçekleşti ");

            Textid.Text = " ";
                Baglan.Close();

            




        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // burada ise text box da direkmen datagridview da eklemek için böyle bir yöntem yapıyoruz 

            int sec = dataGridView1.SelectedCells[0].RowIndex;
            AdText.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            SoyadText.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            TCtext.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            SifreText.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            string Kontrol = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            HastaDogum.Value = Convert.ToDateTime(dataGridView1.Rows[sec].Cells[6].Value);
            TelefonText.Text = dataGridView1.Rows[sec].Cells[7].Value.ToString();
            Textid.Text = dataGridView1.Rows[sec].Cells[5].Value.ToString();

            if (Kontrol == "Erkek")
            {
                ErkekMi.Checked = true;
            }
            else
            {
                KadinMi.Checked = true;
            }

        }

        private void TemizleHasta_Click(object sender, EventArgs e)
        {
            // temizlik işlemleri yapılır 
            AdText.Text = " ";
            SoyadText.Text = " ";
            TCtext.Text = " ";
            SifreText.Text = " ";
            ErkekMi.Checked = false;
            KadinMi.Checked = false;
            HastaDogum.Value = DateTime.Now;
            TelefonText.Text = " ";
        }

        private void YenileHasta_Click(object sender, EventArgs e)
        {
            this.hastaBilgiTableAdapter.Fill(this.hastaneDBDataSet10.HastaBilgi);

        }

        private void SilButon_Click(object sender, EventArgs e)
        {
            Baglan.Open();

            // hasta silmek için HastaSil sp sini kullanıyoruz 
            SqlCommand Sil = new SqlCommand("HastaSil", Baglan);
            Sil.CommandType = CommandType.StoredProcedure;

            Sil.Parameters.AddWithValue("@id", Convert.ToInt16(Textid.Text));

            Sil.ExecuteNonQuery();
            Baglan.Close();
            MessageBox.Show("silme işlemi başarılı bir şekilde tamamlandı");
        }

        private void DetayHasta_Click(object sender, EventArgs e)
        {
            HastaDetay hastaDetay = new HastaDetay();
            hastaDetay.Show();
            this.Hide();
        }
    }
    
}
