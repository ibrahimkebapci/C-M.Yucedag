using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, Toplama, Cikarma, Carpma, Bolme;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            Toplama = sayi1 + sayi2;
            Cikarma = sayi1 - sayi2;
            Carpma  = sayi1 * sayi2;
            Bolme = sayi1 / sayi2;
            MessageBox.Show("Toplama: " + Toplama + "\n" + "Cikarma: " + Cikarma + "\n" + "Carpma: " + Carpma + "\n" + "Bolme: " + Bolme);
        }
    }
}
