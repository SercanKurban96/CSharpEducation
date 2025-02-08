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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        public string TCno;
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void btnBilgileriDuzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgileriDuzenle fr = new FrmDoktorBilgileriDuzenle();
            fr.TCno = lblTC.Text;
            fr.Show();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Uygulamadan çıkmak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TCno;

            //Doktor Ad Soyad
            SqlCommand komut = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where RandevuDoktor='" + lblAdSoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dgvRandevuListesi.DataSource = dt;
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void dgvRandevuListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvRandevuListesi.SelectedCells[0].RowIndex;
            rchSikayet.Text = dgvRandevuListesi.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
