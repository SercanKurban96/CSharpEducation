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

namespace OkulProje
{
    public partial class FrmSinavNotlar : Form
    {
        public FrmSinavNotlar()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.TBLNOTLARTableAdapter ds = new DataSet1TableAdapters.TBLNOTLARTableAdapter();
        SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=BonusOkulDb;Integrated Security=True;");
        private void pctGeri_Click(object sender, EventArgs e)
        {
            FrmOgretmen fr = new FrmOgretmen();
            fr.Show();
            this.Hide();
        }

        void Temizle()
        {
            txtOgrenciID.Clear();
            txtSinav1.Clear();
            txtSinav2.Clear();
            txtSinav3.Clear();
            txtProje.Clear();
            txtOrtalama.Clear();
            txtDurum.Clear();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dgvNotlar.DataSource = ds.NotListesi(int.Parse(txtOgrenciID.Text));

            //baglanti.Open();
            //SqlCommand komut2 = new SqlCommand("SELECT NOTID,DERSAD,OGRAD+' '+OGRSOYAD as 'AD SOYAD',SINAV1,SINAV2,SINAV3,PROJE,ORTALAMA,DURUM FROM TBLNOTLAR  INNER JOIN TBLDERSLER ON TBLNOTLAR.DERSID = TBLDERSLER.DERSID INNER JOIN TBLOGRENCILER ON TBLNOTLAR.OGRID = TBLOGRENCILER.OGRID\r\nWHERE NOTID=@p1", baglanti);
            //komut2.Parameters.AddWithValue("@p1", txtOgrenciID.Text);
            //SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            //DataTable dt2 = new DataTable();
            //da2.Fill(dt2);
            //dgvNotlar.DataSource = dt2;
            //baglanti.Close();
        }

        private void FrmSinavNotlar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLDERSLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDers.DisplayMember = "DERSAD";
            cmbDers.ValueMember = "DERSID";
            cmbDers.DataSource = dt;
            baglanti.Close();

            //baglanti.Open();
            //SqlCommand komut2 = new SqlCommand("SELECT NOTID,DERSAD,OGRAD+' '+OGRSOYAD as 'AD SOYAD',SINAV1,SINAV2,SINAV3,PROJE,ORTALAMA,DURUM FROM TBLNOTLAR  INNER JOIN TBLDERSLER ON TBLNOTLAR.DERSID = TBLDERSLER.DERSID INNER JOIN TBLOGRENCILER ON TBLNOTLAR.OGRID = TBLOGRENCILER.OGRID\r\nWHERE NOTID=@p1", baglanti);
            //komut2.Parameters.AddWithValue("@p1", txtOgrenciID.Text);
            //SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            //DataTable dt2 = new DataTable();
            //da2.Fill(dt2);
            //dgvNotlar.DataSource= dt2;
            //baglanti.Close();
        }

        int notid;
        private void dgvNotlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                notid = int.Parse(dgvNotlar.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtOgrenciID.Text = dgvNotlar.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSinav1.Text = dgvNotlar.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSinav2.Text = dgvNotlar.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSinav3.Text = dgvNotlar.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtProje.Text = dgvNotlar.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtOrtalama.Text = dgvNotlar.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtDurum.Text = dgvNotlar.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
        int sinav1, sinav2, sinav3, proje;
        double ortalama;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            sinav1 = Convert.ToInt16(txtSinav1.Text);
            sinav2 = Convert.ToInt16(txtSinav2.Text);
            sinav3 = Convert.ToInt16(txtSinav3.Text);
            proje = Convert.ToInt16(txtProje.Text);
            ortalama = (double)(sinav1 + sinav2 + sinav3 + proje) / 4;
            txtOrtalama.Text = ortalama.ToString("0.00");
            if (ortalama >= 50)
            {
                txtDurum.Text = "True";
            }
            else
            {
                txtDurum.Text = "False";
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds.NotGuncelle(byte.Parse(cmbDers.SelectedValue.ToString()), int.Parse(txtOgrenciID.Text), byte.Parse(txtSinav1.Text), byte.Parse(txtSinav2.Text), byte.Parse(txtSinav3.Text), byte.Parse(txtProje.Text), decimal.Parse(txtOrtalama.Text), bool.Parse(txtDurum.Text), notid);
        }
    }
}
