﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1 ile 10 arasındaki sayıları toplayan program

            //int toplam = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    toplam = toplam + i;
            //}
            //label1.Text = toplam.ToString();

            //1 ile 10 arasındaki çift sayıları toplayan program

            int toplam = 0;
            for (int i = 2; i <= 10; i+=2)
            {
                toplam = toplam + i;
            }
            label2.Text = toplam.ToString();
        }
    }
}
