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

namespace Proje_Hastane
{
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        public void BranslariGoruntule()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            dgvBranslar.DataSource = dt;
        }
        public void Temizle()
        {
            txtBransID.Clear();
            txtBransAd.Clear();
        }

        private void FrmBrans_Load(object sender, EventArgs e)
        {
            BranslariGoruntule();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Branslar (BransAd) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBransAd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            BranslariGoruntule();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Branslar where BransID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBransID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            BranslariGoruntule();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Branslar set BransAd=@p1 where BransID=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBransAd.Text);
            komut.Parameters.AddWithValue("@p2", txtBransID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            BranslariGoruntule();
        }

        private void dgvBranslar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvBranslar.SelectedCells[0].RowIndex;
            txtBransID.Text = dgvBranslar.Rows[secilen].Cells[0].Value.ToString();
            txtBransAd.Text = dgvBranslar.Rows[secilen].Cells[1].Value.ToString();
        }
    }
}
