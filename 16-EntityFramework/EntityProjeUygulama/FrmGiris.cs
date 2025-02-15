using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjeUygulama
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        EntityUrunDbEntities db = new EntityUrunDbEntities();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBLADMIN where x.Kullanici == txtKullaniciAdi.Text && x.Sifre == txtSifre.Text select x;
            if (sorgu.Any())
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }
    }
}
