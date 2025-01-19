using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Sinema_Bufe_Satis
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int kisaKenar, uzunKenar, alan, cevre;
            kisaKenar = Convert.ToInt32(txtKisaKenar.Text);
            uzunKenar = Convert.ToInt32(txtUzunKenar.Text);
            alan = kisaKenar * uzunKenar;
            cevre = (kisaKenar + uzunKenar) * 2;
            lblAlan.Text = alan.ToString();
            lblCevre.Text = cevre.ToString();
        }

        private void btnHesapla2_Click(object sender, EventArgs e)
        {
            double r, alan, cevre;
            r = Convert.ToDouble(txtYaricap.Text);
            alan = Math.PI * r * r;
            cevre = 2 * Math.PI * r;
            lblCemberAlan.Text = alan.ToString("0.00");
            lblCemberCevre.Text = cevre.ToString("0.00");
        }

        private void btnHesapla3_Click(object sender, EventArgs e)
        {
            int s1, s2, s3;
            double ortalama;
            s1 = Convert.ToInt32(txtSinav1.Text);
            s2 = Convert.ToInt32(txtSinav2.Text);
            s3 = Convert.ToInt32(txtSinav3.Text);
            ortalama = (double)(s1 + s2 + s3) / 3;
            lblOrtalama.Text = ortalama.ToString("0.00");
        }

        private void btnHesapla4_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, toplam, fark, carpim;
            s1 = Convert.ToInt32(txtSayi1.Text);
            s2 = Convert.ToInt32(txtSayi2.Text);
            s3 = Convert.ToInt32(txtSayi3.Text);
            toplam = s1 + s2 + s3;
            fark = s1 - s2 - s3;
            carpim = s1 * s2 * s3;
            lblToplam.Text = toplam.ToString();
            lblFark.Text = fark.ToString();
            lblCarpim.Text = carpim.ToString();
        }
    }
}
