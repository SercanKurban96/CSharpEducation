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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string mesaj;
        public string kimden;

        //ödev
        public string ornek1;
        public string ornek2;
        public string ornek3;
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = kimden;
            label2.Text = mesaj;


            comboBox1.Text = ornek1;
            comboBox2.Text = ornek2;
            comboBox3.Text = ornek3;
        }
    }
}
