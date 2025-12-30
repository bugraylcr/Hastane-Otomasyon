using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu
{
    public class Yuvarlakbuton:Button
    {
        private HastaneDBDataSet1TableAdapters.HastaKayitBilgiTableAdapter hastaKayitBilgiTableAdapter1;

        protected override void OnPaint(PaintEventArgs pevent)
        {

              GraphicsPath sekil = new GraphicsPath();
            sekil.AddEllipse(0,0,ClientSize.Width,ClientSize.Height);
            this.Region = new System.Drawing.Region(sekil);
            base.OnPaint(pevent);
        }

        private void InitializeComponent()
        {
            this.hastaKayitBilgiTableAdapter1 = new Hastane_Otomasyonu.HastaneDBDataSet1TableAdapters.HastaKayitBilgiTableAdapter();
            this.SuspendLayout();
            // 
            // hastaKayitBilgiTableAdapter1
            // 
            this.hastaKayitBilgiTableAdapter1.ClearBeforeFill = true;
            this.ResumeLayout(false);

        }
    }
}
