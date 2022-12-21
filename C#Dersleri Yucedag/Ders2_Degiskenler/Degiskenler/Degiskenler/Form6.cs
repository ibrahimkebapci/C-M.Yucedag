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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ad, soyAd;
            int Ucret, KDV, Kargo;
            Double toplam;
            ad = textBox1.Text;
            soyAd = textBox2.Text;
            Ucret = Convert.ToInt16(textBox3.Text);
            KDV = Convert.ToInt16(textBox5.Text);
            Kargo = Convert.ToInt16(textBox4.Text);
            toplam = (KDV * 18 / 10) + Ucret + Kargo;
            listBox1.Items.Add = (ad + " " + soyAd + "Toplam Fiyat: " + toplam);
        }
    }
}
