﻿using System;
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
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=BonusOkulDb;Integrated Security=True;");
        public string numara;
        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT DERSAD,SINAV1,SINAV2,SINAV3,PROJE,ORTALAMA,DURUM FROM TBLNOTLAR INNER JOIN TBLDERSLER ON TBLNOTLAR.DERSID = TBLDERSLER.DERSID WHERE OGRID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            //this.Text = numara.ToString();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvOgrenciNotlar.DataSource = dt;

            //Öğrencinin numarası girildiğinde programın sol üst köşesinde öğrencinin adını soyadını gösteren kod
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select OGRAD,OGRSOYAD from TBLOGRENCILER where OGRID=@p1", baglanti);
            komut1.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                this.Text = dr1[0] + " " + dr1[1].ToString();
            }
            baglanti.Close();
        }
    }
}
