﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Dosya_Klasor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void btnSaveFileDialog_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void btnFolderBrowserDialog_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }
    }
}
