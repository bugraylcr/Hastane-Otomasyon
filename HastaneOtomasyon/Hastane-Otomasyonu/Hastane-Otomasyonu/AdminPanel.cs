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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void GeB_Click(object sender, EventArgs e)
        {
            AdminSayfa As = new AdminSayfa();
            As.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.doktorBilgiTableAdapter.Fill(this.hastaneDBDataSet30.DoktorBilgi);
            //DoktorSayfa D = new DoktorSayfa();
            //D.Show();
            //this.Hide();

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            // admin panelinde gitmek istediği sayfaları ilk önce bilgileri gösterip ondan sonra 
            // sayfaların girişine yönlendiriyoruz 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.sekreterBilgiTableAdapter.Fill(this.hastaneDBDataSet30.SekreterBilgi);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.hastaBilgiTableAdapter.Fill(this.hastaneDBDataSet30.HastaBilgi);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DoktorGiris Dg = new DoktorGiris();
            Dg.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HastaSayfa Hs = new HastaSayfa();
            Hs.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SekreterGiris Sg = new SekreterGiris();
            Sg.Show();
            this.Hide();
        }
    }
}
