using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Access veri tabanına bağlanmak için gerekli kod
using System.Data.OleDb;

namespace _01_Kitaplik_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=Kitaplik.mdb");
        void listele()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Kitaplar", baglanti);
            da.Fill(dt);
            dgvKitaplik.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        string durum = "";
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Kitaplar (KitapAd,Yazar,Tur,Sayfa,Durum) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKitapAd.Text);
            komut.Parameters.AddWithValue("@p2", txtYazar.Text);
            komut.Parameters.AddWithValue("@p3", cmbTur.Text);
            komut.Parameters.AddWithValue("@p4", txtSayfa.Text);
            komut.Parameters.AddWithValue("@p5", durum);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Sistemi Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void rdbIkinciEl_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void rdbPakette_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        private void dgvKitaplik_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvKitaplik.SelectedCells[0].RowIndex;
            txtKitapID.Text = dgvKitaplik.Rows[secilen].Cells[0].Value.ToString();
            txtKitapAd.Text = dgvKitaplik.Rows[secilen].Cells[1].Value.ToString();
            txtYazar.Text = dgvKitaplik.Rows[secilen].Cells[2].Value.ToString();
            cmbTur.Text = dgvKitaplik.Rows[secilen].Cells[3].Value.ToString();
            txtSayfa.Text = dgvKitaplik.Rows[secilen].Cells[4].Value.ToString();

            if (dgvKitaplik.Rows[secilen].Cells[5].Value.ToString() == "True")
            {
                rdbPakette.Checked = true;
            }
            else
            {
                rdbIkinciEl.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from Kitaplar where KitapID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKitapID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Listeden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update Kitaplar set KitapAd=@p1,Yazar=@p2,Tur=@p3,Sayfa=@p4,Durum=@p5 where KitapID=@p6", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKitapAd.Text);
            komut.Parameters.AddWithValue("@p2", txtYazar.Text);
            komut.Parameters.AddWithValue("@p3", cmbTur.Text);
            komut.Parameters.AddWithValue("@p4", txtSayfa.Text);
            if (rdbIkinciEl.Checked == true)
            {
                komut.Parameters.AddWithValue("@p5", durum);
            }
            if (rdbPakette.Checked == true)
            {
                komut.Parameters.AddWithValue("@p5", durum);
            }
            komut.Parameters.AddWithValue("@p6", txtKitapID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Sistemde Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("select * from Kitaplar where KitapAd=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKitapBul.Text);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dgvKitaplik.DataSource = dt;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("select * from Kitaplar where KitapAd like '%" + txtKitapBul.Text + "%'", baglanti);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dgvKitaplik.DataSource = dt;
        }

        private void txtKitapBul_TextChanged(object sender, EventArgs e)
        {
            //ÖDEV: TextBox'a yazıldığı zaman kitap arama işlemi gerçekleştiren programı yazınız.
            OleDbCommand komut = new OleDbCommand("select * from Kitaplar where KitapAd like '%" + txtKitapBul.Text + "%'", baglanti);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dgvKitaplik.DataSource = dt;
        }
    }
}
