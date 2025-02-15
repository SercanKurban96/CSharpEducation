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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }
        EntityUrunDbEntities db = new EntityUrunDbEntities();
        private void btnListele_Click(object sender, EventArgs e)
        {
            var kategoriler = db.TBLKATEGORI.ToList();
            dgvKategori.DataSource = kategoriler;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBLKATEGORI t = new TBLKATEGORI();
            t.KategoriAd = txtKategoriAdi.Text;
            db.TBLKATEGORI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtKategoriID.Text);
            var ktgr = db.TBLKATEGORI.Find(x);
            db.TBLKATEGORI.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtKategoriID.Text);
            var ktgr = db.TBLKATEGORI.Find(x);
            ktgr.KategoriAd = txtKategoriAdi.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellendi");
        }

        private void dgvKategori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtKategoriID.Text = dgvKategori.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtKategoriAdi.Text = dgvKategori.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }       
        }

        private void pctGeri_Click(object sender, EventArgs e)
        {
            FrmAnaForm fr = new FrmAnaForm();
            fr.Show();
            this.Hide();
        }
    }
}
