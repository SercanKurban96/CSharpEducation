using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace NKatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
            dgvPersonel.DataSource = PerList;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = txtAD.Text;
            ent.Soyad = txtSOYAD.Text;
            ent.Sehir = txtSEHIR.Text;
            ent.Maas = short.Parse(txtMAAS.Text);
            ent.Gorev = txtGOREV.Text;
            LogicPersonel.LLPersonelEkle(ent);
            MessageBox.Show("Personel Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(txtID.Text);
            LogicPersonel.LLPersonelSil(ent.Id);
            MessageBox.Show("Personel Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(txtID.Text);
            ent.Ad = txtAD.Text;
            ent.Soyad = txtSOYAD.Text;
            ent.Sehir = txtSEHIR.Text;
            ent.Gorev = txtGOREV.Text;
            ent.Maas = short.Parse(txtMAAS.Text);
            LogicPersonel.LLPersonelGuncelle(ent);
            MessageBox.Show("Personel Güncellendi");
        }
    }
}
