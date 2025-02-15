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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        EntityUrunDbEntities db = new EntityUrunDbEntities();

        void Temizle()
        {
            txtUrunID.Clear();
            txtUrunAdi.Clear();
            txtMarka.Clear();
            txtStok.Clear();
            txtFiyat.Clear();
            txtDurum.Clear();
            cmbKategori.Text = "";
        }
        private void pctGeri_Click(object sender, EventArgs e)
        {
            FrmAnaForm fr = new FrmAnaForm();
            fr.Show();
            this.Hide();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            //dgvUrun.DataSource = db.TBLURUN.ToList(); //Tüm sütunları listeler.

            dgvUrun.DataSource = (from x in db.TBLURUN
                                  select new
                                  {
                                      x.UrunID,
                                      x.UrunAd,
                                      x.Marka,
                                      x.Stok,
                                      x.Fiyat,
                                      x.TBLKATEGORI.KategoriAd,
                                      x.Durum
                                  }).ToList(); //Yalnızca seçilen sütunları listeler.
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.UrunAd = txtUrunAdi.Text;
            t.Marka = txtMarka.Text;
            t.Stok = short.Parse(txtStok.Text);
            t.Fiyat = decimal.Parse(txtFiyat.Text);
            t.Durum = true;
            t.Kategori = int.Parse(cmbKategori.SelectedValue.ToString());
            //t.Kategori = int.Parse(cmbKategori.Text);
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Eklendi");
            Temizle();
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.TBLKATEGORI
                               select new
                               {
                                   x.KategoriID,
                                   x.KategoriAd
                               }).ToList();
            cmbKategori.DisplayMember = "KategoriAd";
            cmbKategori.ValueMember = "KategoriID";
            cmbKategori.DataSource = kategoriler;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUrunID.Text);
            var urun = db.TBLURUN.Find(id);
            db.TBLURUN.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi");
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtUrunID.Text);
            var urun = db.TBLURUN.Find(id);
            urun.UrunAd = txtUrunAdi.Text;
            urun.Marka = txtMarka.Text;
            urun.Stok = short.Parse(txtStok.Text);
            urun.Fiyat = decimal.Parse(txtFiyat.Text);
            urun.Durum = true;
            urun.Kategori = int.Parse(cmbKategori.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi");
            Temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dgvUrun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtUrunID.Text = dgvUrun.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtUrunAdi.Text = dgvUrun.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMarka.Text = dgvUrun.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtStok.Text = dgvUrun.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtFiyat.Text = dgvUrun.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDurum.Text = dgvUrun.Rows[e.RowIndex].Cells[6].Value.ToString();
                cmbKategori.Text = dgvUrun.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
