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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        EntityUrunDbEntities db = new EntityUrunDbEntities();
        private void pctGeri_Click(object sender, EventArgs e)
        {
            FrmAnaForm fr = new FrmAnaForm();
            fr.Show();
            this.Hide();
        }

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            //Toplam Kategori Sayısı
            lblToplamKategoriSayisi.Text = db.TBLKATEGORI.Count().ToString();

            //Toplam Ürün Sayısı
            lblToplamUrunSayisi.Text = db.TBLURUN.Count().ToString();

            //Aktif Müşteri Sayısı
            lblAktifMusteriSayisi.Text = db.TBLMUSTERI.Count(x => x.Durum == true).ToString();

            //Pasif Müşteri Sayısı
            lblPasifMusteriSayisi.Text = db.TBLMUSTERI.Count(x => x.Durum == false).ToString();

            //Beyaz Eşya Sayısı
            lblBeyazEsyaSayisi.Text = db.TBLURUN.Count(x => x.Kategori== 1).ToString();

            //Toplam Stok
            lblToplamStok.Text = db.TBLURUN.Sum(x => x.Stok).ToString();

            //En Yüksek Fiyatlı Ürün
            lblEnYuksekFiyatliUrun.Text = (from x in db.TBLURUN orderby x.Fiyat descending select x.UrunAd).FirstOrDefault();

            //En Düşük Fiyatlı Ürün
            lblEnDusukFiyatliUrun.Text = (from x in db.TBLURUN orderby x.Fiyat ascending select x.UrunAd).FirstOrDefault();

            //Şehir Sayısı
            lblSehirSayisi.Text = (from x in db.TBLMUSTERI select x.Sehir).Distinct().Count().ToString();

            //Kasadaki Tutar
            lblKasadakiTutar.Text = db.TBLSATIS.Sum(x=>x.Fiyat).ToString() + " ₺";

            //En Fazla Ürünlü Marka
            //BURADA MARKA OLUŞTURMAK İÇİN SQL VERİ TABANIMIZA GELİP YENİ BİR PROSEDÜR OLUŞTURACAĞIZ.

            //SQL SORGUSU
            /*
             * CREATE PROCEDURE MARKAGETIR
               AS
               SELECT TOP 1 Marka FROM TBLURUN GROUP BY Marka ORDER BY COUNT(*) DESC
             */

            //Çalıştırdıktan sonra Programmability kısmından Stored Procedures kısmına geldiğimizde MARKAGETIR prosedürü oluşturulacaktır. Sağ tıklayıp Execute Stored Procedure diyoruz.

            //Modele yansıtmak için modelimize gelip sağ tıklıyoruz ve Update Model from Database diyoruz. Ardından Stored Procedures and Functions kısmına gelip oradan sadece MARKAGETIR prosedürünü seçiyoruz ve Finish diyoruz.

            lblEnFazlaUrunluMarka.Text = db.MARKAGETIR().FirstOrDefault();

            //Toplam Buzdolabı Sayısı
            lblToplamBuzdolabiSayisi.Text = db.TBLURUN.Count(x=>x.UrunAd == "BUZDOLABI").ToString();
        }
    }
}
