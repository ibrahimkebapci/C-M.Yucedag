using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders6_Metodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void AdYaz()
        {
            textBox1.Text = "İbrahim";
            textBox2.Text = "Kebapci";
            textBox3.Text = "Bilgisayar Mühendisi";
            textBox4.Text = "22";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            AdYaz();
        }
    }
}
