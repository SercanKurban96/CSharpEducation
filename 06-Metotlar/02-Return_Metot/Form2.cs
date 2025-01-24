using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Return_Metot
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int Kup(int sayi)
        {
            int sonuc = sayi * sayi * sayi;
            return sonuc;
        }

        int Topla(int s1, int s2)
        {
            return s1 + s2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt16(textBox1.Text);
            label1.Text = Kup(s).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt16(textBox2.Text);
            int s2 = Convert.ToInt16(textBox3.Text);
            label2.Text = Topla(s1, s2).ToString();
        }
    }
}
//DERS SONU ÖRNEK: Klavyeden girilen 2 sayıyı toplayan metotu yazınız.