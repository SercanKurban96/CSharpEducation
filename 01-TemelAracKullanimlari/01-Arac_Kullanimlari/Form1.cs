using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Arac_Kullanimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Sercan";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "Sercan";
            label6.Text = "Kurban";
            label8.Text = "Yazılımcı";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Yönetim Bilişim Sistemleri";
            label9.Text = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label13.Text = textBox2.Text;
            label14.Text = textBox3.Text;
            label15.Text = textBox4.Text;
        }
    }
}
