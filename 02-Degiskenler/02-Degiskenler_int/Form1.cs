using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Degiskenler_int
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int sayi;
            //sayi = 24;
            //label1.Text = sayi.ToString();

            //int sayi1, sayi2, toplam;
            //sayi1 = 5;
            //sayi2 = 4;
            //toplam = sayi1 + sayi2;
            //label1.Text = toplam.ToString();

            int kenar, alan, cevre;
            kenar = 10;
            alan = kenar * kenar;
            cevre = kenar * 4;
            label1.Text = "Alan: " + alan + " Çevre: " + cevre;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kisakenar, uzunkenar, alan, cevre;
            kisakenar = 3;
            uzunkenar = 5;
            alan = kisakenar * uzunkenar;
            cevre = (kisakenar + uzunkenar) * 2;
            label3.Text = "Alan: " + alan + " Çevre: " + cevre;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sinav1, sinav2, sinav3, ortalama;
            sinav1 = 55;
            sinav2 = 68;
            sinav3 = 82;
            ortalama = (sinav1 + sinav2 + sinav3) / 3;
            label5.Text = "Ortalama: " + ortalama;
        }
    }
}
//kısa: 10 uzun: 20
//3 sınav notu girilen öğrencinin ortalaması