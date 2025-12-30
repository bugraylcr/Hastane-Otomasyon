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
    public partial class HastaDetay : Form
    {
        public HastaDetay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KayitSayfa hs = new KayitSayfa();
            hs.Show();
            this.Hide();
        }

        private void HastaDetay_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneDBDataSet12.SilinenHastalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.silinenHastalarTableAdapter.Fill(this.hastaneDBDataSet12.SilinenHastalar);
            // TODO: Bu kod satırı 'hastaneDBDataSet11.HastaDetay' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hastaDetayTableAdapter.Fill(this.hastaneDBDataSet11.HastaDetay);
            BackColor = Color.WhiteSmoke;
        }
    }
}
