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

namespace OkulProje
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        private void pctGeri_Click(object sender, EventArgs e)
        {
            FrmOgretmen fr = new FrmOgretmen();
            fr.Show();
            this.Hide();
        }
        void Temizle()
        {
            txtOgrenciAdi.Clear();
            txtOgrenciSoyadi.Clear();
            cmbKulup.Text = "";
            rdbKiz.Checked = false;
            rdbErkek.Checked = false;
            txtOgrenciAdi.Focus();
        }
        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=BonusOkulDb;Integrated Security=True;");
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            dgvOgrenciler.DataSource = ds.OgrenciListesi();

            //Kulüpleri Combobox'a Aktarma
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLKULUPLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbKulup.DisplayMember = "KULUPAD";
            cmbKulup.ValueMember = "KULUPID";
            cmbKulup.DataSource = dt;
            baglanti.Close();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dgvOgrenciler.DataSource = ds.OgrenciListesi();
        }
        string c = "";
        private void btnEkle_Click(object sender, EventArgs e)
        {


            ds.OgrenciEkle(txtOgrenciAdi.Text, txtOgrenciSoyadi.Text, byte.Parse(cmbKulup.SelectedValue.ToString()), c);
            MessageBox.Show("Öğrenci Ekleme İşlemi Yapıldı");
            Temizle();
            dgvOgrenciler.DataSource = ds.OgrenciListesi();
        }

        private void dgvOgrenciler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtOgrenciID.Text = dgvOgrenciler.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtOgrenciAdi.Text = dgvOgrenciler.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtOgrenciSoyadi.Text = dgvOgrenciler.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbKulup.Text = dgvOgrenciler.Rows[e.RowIndex].Cells[3].Value.ToString();
                c = dgvOgrenciler.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (c == "KIZ")
                {
                    rdbKiz.Checked = true;
                    rdbErkek.Checked = false;
                }
                if (c == "ERKEK")
                {
                    rdbKiz.Checked = false;
                    rdbErkek.Checked = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void cmbKulup_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtOgrenciID.Text = cmbKulup.SelectedValue.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.OgrenciSil(int.Parse(txtOgrenciID.Text));
            MessageBox.Show("Öğrenci Silme İşlemi Yapıldı");
            Temizle();
            dgvOgrenciler.DataSource = ds.OgrenciListesi();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds.OgrenciGuncelle(txtOgrenciAdi.Text, txtOgrenciSoyadi.Text, byte.Parse(cmbKulup.SelectedValue.ToString()), c, int.Parse(txtOgrenciID.Text));
            MessageBox.Show("Öğrenci Güncelleme İşlemi Yapıldı");
            Temizle();
            dgvOgrenciler.DataSource = ds.OgrenciListesi();
        }

        private void rdbKiz_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKiz.Checked == true)
            {
                c = "KIZ";
            }
        }

        private void rdbErkek_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbErkek.Checked == true)
            {
                c = "ERKEK";
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dgvOgrenciler.DataSource = ds.OgrenciGetir(txtOgrenciAra.Text);
        }
    }
}
