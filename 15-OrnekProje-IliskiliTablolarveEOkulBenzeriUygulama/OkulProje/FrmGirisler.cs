using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulProje
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void pctCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctOgrenci_Click(object sender, EventArgs e)
        {
            FrmOgrenciNotlar fr = new FrmOgrenciNotlar();
            fr.numara = txtNumara.Text;
            fr.Show();
        }

        private void pctOgretmen_Click(object sender, EventArgs e)
        {
            if (txtNumara.Text == "0000")
            {
                FrmOgretmen fr = new FrmOgretmen();
                fr.Show();
                this.Hide();
            }
        }
    }
}
