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
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.TBLDERSLERTableAdapter ds = new DataSet1TableAdapters.TBLDERSLERTableAdapter();
        private void pctGeri_Click(object sender, EventArgs e)
        {
            FrmOgretmen fr = new FrmOgretmen();
            fr.Show();
            this.Hide();
        }

        private void FrmDersler_Load(object sender, EventArgs e)
        {
            dgvDersler.DataSource = ds.DersListesi();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dgvDersler.DataSource = ds.DersListesi();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ds.DersEkle(txtDersAdi.Text);
            MessageBox.Show("Ders Ekleme İşlemi Yapılmıştır");
            txtDersAdi.Clear();
            dgvDersler.DataSource = ds.DersListesi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.DersSil(byte.Parse(txtDersID.Text));
            MessageBox.Show("Ders Silme İşlemi Yapılmıştır");
            txtDersID.Clear();
            txtDersAdi.Clear();
            dgvDersler.DataSource = ds.DersListesi();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds.DersGuncelle(txtDersAdi.Text, byte.Parse(txtDersID.Text));
            MessageBox.Show("Ders Güncelleme İşlemi Yapılmıştır");
            txtDersID.Clear();
            txtDersAdi.Clear();
            dgvDersler.DataSource = ds.DersListesi();
        }

        private void dgvDersler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtDersID.Text = dgvDersler.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDersAdi.Text = dgvDersler.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}
