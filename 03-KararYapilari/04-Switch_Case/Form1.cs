using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Switch_Case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int ay = Convert.ToInt16(textBox1.Text);
            //switch (ay)
            //{
            //    case 1: label2.Text = "Ocak"; break;
            //    case 2: label2.Text = "Şubat"; break;
            //    case 3: label2.Text = "Mart"; break;
            //    case 4: label2.Text = "Nisan"; break;
            //    case 5: label2.Text = "Mayıs"; break;
            //    case 6: label2.Text = "Haziran"; break;
            //    case 7: label2.Text = "Temmuz"; break;
            //    case 8: label2.Text = "Ağustos"; break;
            //    case 9: label2.Text = "Eylül"; break;
            //    case 10: label2.Text = "Ekim"; break;
            //    case 11: label2.Text = "Kasım"; break;
            //    case 12: label2.Text = "Aralık"; break;
            //    default: label2.Text = "Hatalı Ay"; break;
            //}

            string mevsim = textBox1.Text;
            switch (mevsim)
            {
                case "yaz":
                    label2.Text = "haziran temmuz ağustos";
                    break;
                case "sonbahar":
                    label2.Text = "eylül ekim kasım";
                    break;
                case "kis":
                    label2.Text = "aralık ocak şubat";
                    break;
                case "ilkbahar":
                    label2.Text = "mart nisan mayıs";
                    break;
                default:
                    label2.Text = "hatalı mevsim";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox2.Text);
            double sayi2 = Convert.ToDouble(textBox3.Text);
            double sonuc;
            char sembol = Convert.ToChar(textBox4.Text);

            switch (sembol)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    label5.Text = sonuc.ToString();
                    break;
                case '-':
                    sonuc = sayi1 - sayi2;
                    label5.Text = sonuc.ToString();
                    break;
                case '*':
                    sonuc = sayi1 * sayi2;
                    label5.Text = sonuc.ToString();
                    break;
                case '/':
                    sonuc = sayi1 / sayi2;
                    label5.Text = sonuc.ToString();
                    break;
                default: label5.Text = "hatalı seçim"; break;
            }
        }
    }
}
