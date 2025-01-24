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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //int Toplam(int s1,int s2)
        //{
        //    int s3 = s1 + s2;
        //    return s3;
        //}

        int Carpim(int s1,int s2,int s3)
        {
            return s1 * s2 * s3;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = Toplam(4, 6).ToString();
            //label2.Text = Toplam(2, 3).ToString();
            //label3.Text = Toplam(4, 8).ToString();

            label1.Text = Carpim(2, 2, 4).ToString();
            label2.Text = Carpim(1, 2, 5).ToString();
            label3.Text = Carpim(3, 7, 5).ToString();
        }
    }
}
//DERS SORU ÖRNEK: 3 tane sayıyı çarpan metotu hesaplayınız.