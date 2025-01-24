using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Donguler_Pratik
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1 ile 10 arasında 3'e tam bölen program
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        listBox1.Items.Add(i);
            //    }
            //}

            //1 ile 100 arasında 5'e ve 7'ye tam bölen program
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0 && i % 7 == 0)
            //    {
            //        listBox1.Items.Add(i);
            //    }
            //}

            //Klavyeden girilen sayıya kadar olan sayıları listeleyen program
            //int sayi = Convert.ToInt16(textBox1.Text);
            //for (int i = 1; i <= sayi; i++)
            //{
            //    listBox1.Items.Add(i);
            //}

            //Klavyeden girilen sayının tam bölenlerini veren program
            //int sayi = Convert.ToInt16(textBox1.Text);
            //for (int i = 1; i <= sayi; i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        listBox1.Items.Add(i);
            //    }
            //}

            //DERR SONU ÖRNEK PROJE: Klavyeden girilen sayının faktöriyelini hesaplayan program
            int sayi = Convert.ToInt16(textBox1.Text);
            int faktoriyel = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel = faktoriyel * i;
            }
            listBox1.Items.Add(faktoriyel);
        }
    }
}
