﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Karar_Yapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "ali")
            //{
            //    label1.Text = "doğru";
            //}
            //else
            //{
            //    label1.Text = "yanlış";
            //}

            //int sayi = Convert.ToInt16(textBox1.Text);
            //if (sayi == 5)
            //{
            //    label1.Text = "doğru";
            //}
            //else
            //{
            //    label1.Text = "yanlış";
            //}

            //int sayi = Convert.ToInt16(textBox1.Text);
            //if (sayi % 2 == 0)
            //{
            //    label1.Text = "Çift";
            //}
            //else
            //{
            //    label1.Text = "Tek";
            //}

            //int sayi = Convert.ToInt16(textBox1.Text);
            //if (sayi % 2 == 0 && sayi >= 10)
            //{
            //    label1.Text = "10 dan büyük ve çift";
            //}
            //else
            //{
            //    label1.Text = "10 dan büyük değil ya da çift değil";
            //}

            int sayi = Convert.ToInt16(textBox1.Text);
            if (sayi % 2 == 0 || sayi >= 10)
            {
                label1.Text = "10 dan büyük veya çift";
            }
            else
            {
                label1.Text = "10 dan büyük değil veya çift değil";
            }
        }
    }
}
