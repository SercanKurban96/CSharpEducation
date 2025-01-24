using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] kisiler = { "Ali", "Ahmet", "Mehmet", "Aslı", "Hakan", "Ayşe", "Demet" };
            //label1.Text = kisiler[4];

            //int[] sayilar = { 4, 7, 5, 6, 9, 8, 2, 3 };
            //label1.Text = sayilar[5].ToString();

            //DERS SONU ÖRNEK SORU 1: Ondalıklı olarak 5 tane değerden oluşan bir dizi oluşturun.
            double[] ondalikliSayilar = { 5.23, 4.16, 21.22, 61.54, 73.41 };
            label1.Text = ondalikliSayilar[2].ToString();

            //DERS SONU ÖRNEK SORU 2: 10 tane harflerden oluşan bir dizi oluşturun.
            char[] harfler = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
            label1.Text = harfler[3].ToString();
        }
    }
}
