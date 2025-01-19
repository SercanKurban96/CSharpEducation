using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Degiskenler_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string metin;
            //metin = "Merhaba bugün 19 Ocak 2025 Pazar";
            //label1.Text = metin;

            //string adsoyad, meslek;
            //adsoyad = "Sercan Kurban";
            //meslek = "Yazılım Geliştirici";
            //label1.Text = adsoyad;
            //label2.Text = meslek;

            string sehir;
            sehir = textBox1.Text;
            label1.Text = sehir;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string adi, soyadi, yas, meslek, cinsiyet;
            adi = textBox2.Text;
            soyadi = textBox3.Text;
            yas = maskedTextBox1.Text;
            meslek = textBox4.Text;
            cinsiyet = textBox5.Text;
            listBox1.Items.Add(adi + " " + soyadi + " " + yas + " " + meslek + " " + cinsiyet);
        }
    }
}
