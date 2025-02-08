using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Dosya İşlemleri için gerekli kütüphane
using System.IO;

namespace _02_Metin_Belgesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string dosyaadi, dosyayolu;
        StreamWriter sw; //Dosya oluşturma, dosyaya yazı yazma işlemleri için kullanılır.

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            dosyaadi = txtDosyaAdi.Text;
            sw = File.CreateText(dosyayolu + "\\" + dosyaadi + ".txt");
            sw.Close();
        }

        private void btnYolSec_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                dosyayolu = folderBrowserDialog1.SelectedPath.ToString();
                txtDosyaYolu.Text = dosyayolu;
            }
        }
    }
}
