﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }

        void renklendir()
        {
            textBox1.BackColor = Color.Green;
            textBox2.BackColor = Color.SaddleBrown;
            textBox3.BackColor = Color.Firebrick;
            textBox4.BackColor = Color.Tan;
        }

        void bilgileriDoldur()
        {
            textBox1.Text = "Sercan";
            textBox2.Text = "Kurban";
            textBox3.Text = "İstanbul";
            textBox4.Text = "29";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bilgileriDoldur();
        }
    }
}
//DERS SONU ÖRNEK: Butona bastığınız zaman 4 tane textbox'a otomatik olarak veri yazan bir metot oluşturun.
//textBox1 adınız, textBox2 soyadınız, textBox3 şehriniz, textBox4 yaşınız