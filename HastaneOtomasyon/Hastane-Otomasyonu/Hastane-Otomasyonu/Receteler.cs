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
    public partial class Receteler : Form
    {
        public Receteler()
        {
            InitializeComponent();
        }

        private void GeriB_Click(object sender, EventArgs e)
        {
            DoktorSayfa Dy = new DoktorSayfa();
            Dy.Show();
            this.Hide();
        }

        private void Receteler_Load(object sender, EventArgs e)
        {
            // burada genel olarak bütün receteler gözüküyor 
            // TODO: Bu kod satırı 'hastaneDBDataSet24.ReceteDetay' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.receteDetayTableAdapter1.Fill(this.hastaneDBDataSet24.ReceteDetay);
            // TODO: Bu kod satırı 'hastaneDBDataSet23.ReceteDetay' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.receteDetayTableAdapter.Fill(this.hastaneDBDataSet23.ReceteDetay);
            // TODO: Bu kod satırı 'hastaneDBDataSet22.ReceteHasta' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.receteHastaTableAdapter.Fill(this.hastaneDBDataSet22.ReceteHasta);




        }
    }
}
