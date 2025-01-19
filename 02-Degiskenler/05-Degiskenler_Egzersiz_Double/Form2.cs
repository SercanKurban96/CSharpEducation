using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Degiskenler_Egzersiz_Double
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string urunAdi;
            double fiyat, kdv8, kdv18;
            urunAdi = textBox1.Text;
            fiyat = Convert.ToDouble(textBox2.Text);
            kdv8 = fiyat + (fiyat * 0.08);
            kdv18 = fiyat + (fiyat * 0.18);
            listBox1.Items.Add("Ürün Adı: " + urunAdi + " KDV 8%: " + kdv8 + " KDV 18%: " + kdv18);
        }
    }
}
