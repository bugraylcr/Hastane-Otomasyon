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
    public partial class RandevuDetay : Form
    {
        public RandevuDetay()
        {
            InitializeComponent();
        }

        private void RandevuDetay_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneDBDataSet17.RandevuBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //   this.randevuBilgiTableAdapter.Fill(this.hastaneDBDataSet17.RandevuBilgi);
            // TODO: Bu kod satırı 'hastaneDBDataSet17.RandevuDetay' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
             
            //burada Randevuların ne zaman kayıt olduğuna kaç kişi olduğuna bilgileri gözüktüğü bir sayfadır  
            this.randevuDetayTableAdapter1.Fill(this.hastaneDBDataSet17.RandevuDetay);
            // TODO: Bu kod satırı 'hastaneDBDataSet16.RandevuDetay' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           //   this.randevuDetayTableAdapter.Fill(this.hastaneDBDataSet16.RandevuDetay);
            BackColor = Color.WhiteSmoke;
        }

        private void GeriB_Click(object sender, EventArgs e)
        {
            DoktorSayfa doktorSayfa = new DoktorSayfa();
            doktorSayfa.Show();
            this.Hide();
        }
    }
}
