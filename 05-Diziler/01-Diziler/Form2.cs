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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] sehirler = { "Ankara", "Eskişehir", "Antalya", "Adana", "Bursa", "Balıkesir" };
            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    listBox1.Items.Add(sehirler[i]);
            //}

            //int[] sayilar = { 4, 2, 3, 1, 5, 6, 7, 9 };
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 2 == 0)
            //    {
            //        listBox1.Items.Add(sayilar[i]);
            //    }           
            //}

            //DERS SONU ÖRNEK: 10 eleman içerisinde 10'dan büyük ve çift sayıları listbox'a yazdıran program
            int[] sayilar = { 5, 12, 7, 19, 41, 52, 15, 28, 32, 10 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] > 10 && sayilar[i] % 2 == 0)
                {
                    listBox1.Items.Add(sayilar[i]);
                }
            }
        }
    }
}
