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
    public partial class DoktorDetay : Form
    {
        public DoktorDetay()
        {
            InitializeComponent();
        }

        private void DoktorDetay_Load(object sender, EventArgs e)
        {
            // sistem de kayıtlı ve silinen  doktorların Stored procedures ile yapıyoruz 
            // TODO: Bu kod satırı 'hastaneDBDataSet9.SilinenDoktorlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.silinenDoktorlarTableAdapter.Fill(this.hastaneDBDataSet9.SilinenDoktorlar);
            // TODO: Bu kod satırı 'hastaneDBDataSet4.DoktorlarDetay' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.doktorlarDetayTableAdapter.Fill(this.hastaneDBDataSet4.DoktorlarDetay);
            BackColor = Color.WhiteSmoke;
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            DoktorKayit ky = new DoktorKayit();
            ky.Show();
            this.Hide();
        }
    }
}
