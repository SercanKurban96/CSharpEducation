using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OkulProje
{
    public partial class FrmKulup : Form
    {
        public FrmKulup()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=BonusOkulDb;Integrated Security=True;");
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLKULUPLER", baglanti);
            da.Fill(dt);
            dgvKulupler.DataSource = dt;
        }
        void Temizle()
        {
            txtKulupID.Clear();
            txtKulupAdi.Clear();
            txtKulupAdi.Focus();
        }
        private void pctGeri_Click(object sender, EventArgs e)
        {
            FrmOgretmen fr = new FrmOgretmen();
            fr.Show();
            this.Hide();
        }

        private void FrmKulup_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLKULUPLER (KULUPAD) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKulupAdi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kulüp Listeye Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from TBLKULUPLER where KULUPID=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1", txtKulupID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kulüp Listeden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLKULUPLER set KULUPAD=@p1 where KULUPID=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1", txtKulupAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtKulupID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kulüp Listede Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void dgvKulupler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvKulupler.SelectedCells[0].RowIndex;
            txtKulupID.Text = dgvKulupler.Rows[secilen].Cells[0].Value.ToString();
            txtKulupAdi.Text = dgvKulupler.Rows[secilen].Cells[1].Value.ToString();
        }
    }
}
