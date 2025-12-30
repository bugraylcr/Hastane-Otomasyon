using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            HastaSayfa hasta = new HastaSayfa();
            hasta.Show();
            this.Hide();
        }
        // burada ise 4 tane ana paneller bulunur ve bunlar doktor sekreter hasta ve admindir 
        // burada picturebox ile erişiriz 
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SekreterGiris sekter = new SekreterGiris();
             sekter.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DoktorGiris dk = new DoktorGiris();
            dk.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AdminGiris admin = new AdminGiris();
            admin.Show();   
            this.Hide();
        }
    }
}
