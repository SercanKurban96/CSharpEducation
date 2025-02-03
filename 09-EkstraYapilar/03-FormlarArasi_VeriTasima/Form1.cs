using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_FormlarArasi_VeriTasima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.kimden = textBox1.Text;
            fr.mesaj = textBox2.Text;
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.ornek1 = textBox3.Text;
            fr.ornek2 = textBox4.Text;
            fr.ornek3 = textBox5.Text;
            fr.Show();
            this.Hide();
        }
    }
}
