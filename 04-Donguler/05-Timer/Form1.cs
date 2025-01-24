using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //sayac++;
            //label1.Text = sayac.ToString();
            //if (sayac == 2)
            //{
            //    //timer1.Stop();
            //    this.BackColor = Color.Red;
            //}
            //if (sayac == 4)
            //{
            //    this.BackColor = Color.Green;
            //    sayac = 0;
            //}

            //DERS SONU ÖRNEK PROJE: 3 lambalı trafik animasyonu yapan program
            //0-30 saniye arası kırmızı
            //30-40 arası sarı
            //40-70 arası yeşil

            sayac++;
            label1.Text = sayac.ToString();
            if (sayac == 1)
            {
                this.BackColor = Color.Red;
            }
            if (sayac == 30)
            {
                this.BackColor = Color.Yellow;
            }
            if (sayac == 40)
            {
                this.BackColor = Color.Green;
            }
            if (sayac == 70)
            {
                this.BackColor = Color.Red;
                sayac = 0;      
            }
        }
    }
}
