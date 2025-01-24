using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] kisiler = { "Ali", "Ahmet", "Mehmet", "Mesut", "Pınar", "Berna" };
            //foreach (string k in kisiler)
            //{
            //    listBox1.Items.Add(k);
            //}

            //int toplam = 0;
            //int[] sinavlar = { 70, 65, 85, 100, 90 };
            //foreach (int x in sinavlar)
            //{
            //    listBox1.Items.Add(x);
            //    toplam = toplam + x;
            //}
            //label1.Text = toplam.ToString();

            //int ortalama = toplam / sinavlar.Length;
            //label2.Text = ortalama.ToString();

            //DERS SONU ÖRNEK SORU: 10 elemanlı bir tamsayı dizisi içerisinde 4'e tam bölünen sayıları foreach döngüsüyle listeleyen, bu sayıların kaç adet olduğunu ve 4'e tam bölünen sayıların toplamını hesaplayan programı label'a yazdırınız.

            int toplam = 0;
            int sayac = 0;
            int[] sayilar = { 5, 12, 41, 60, 25, 33, 17, 32, 8, 24 };
            foreach (int x in sayilar)
            {       
                if (x % 4 == 0)
                {
                    listBox1.Items.Add(x);
                    sayac++;
                    toplam = toplam + x;
                }             
            }
            label1.Text = sayac.ToString();
            label2.Text = toplam.ToString();
        }
    }
}
