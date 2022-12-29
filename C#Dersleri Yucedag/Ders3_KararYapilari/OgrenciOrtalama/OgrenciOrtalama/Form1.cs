using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciOrtalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sinav1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double Sinav1,Sinav2,Proje,Ortalma;
            Sinav1 = Convert.ToDouble(Sinav1Txt.Text);
            Sinav2 = Convert.ToDouble(Sinav2Txt.Text);
            Proje = Convert.ToDouble(ProjeTxt.Text);
            Ortalma = Sinav1 * 4 / 10 + Sinav2 * 4 / 10 + Proje * 2 / 10;
            if(Ortalma>50)
            {
                Sonuc.Text = "Ogrenci Basarili: " + Ortalma;
            }
            else
            {
                Sonuc.Text = "Ogrenci basarisiz " + Ortalma;
            }
                
        }
    }
}
