﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Donguler_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <= 5)
            {
                listBox1.Items.Add("Merhaba İstanbul");
                listBox2.Items.Add(i);
                i++;
            }

            //1 ile 5 arasındaki sayıların toplamını while döngüsüyle hesaplayan program
            int j = 1;
            int toplam = 0;
            while (j <= 5)
            {
                toplam = toplam + j;
                j++;
            }
            MessageBox.Show(toplam.ToString());
        }
    }
}
