using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders2_FinalProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double KisaKenar,UzunKenar;
            Double Alan,Cevre;
            KisaKenar = Convert.ToDouble(textBox1.Text);
            UzunKenar = Convert.ToDouble(textBox2.Text);
            Alan = (KisaKenar * UzunKenar);
            Cevre = (KisaKenar + UzunKenar) * 2;
            LabAlan.Text = Alan.ToString();
            LabCevre.Text = Cevre.ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double PiSayisi,Yaricap,Alan,Cevre;
            Yaricap= Convert.ToDouble(textBox3.Text);
            PiSayisi = Convert.ToDouble(textBox4.Text);
            Alan = (PiSayisi*Yaricap*Yaricap);
            Cevre = (PiSayisi * Yaricap *2);
            label9.Text = Alan.ToString();
            label8.Text = Cevre.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double Sonuc, Sinav1, Sinav2, Sinav3;
            Sinav1 = Convert.ToDouble(TxtSinav1.Text);
            Sinav2 = Convert.ToDouble(TxtSinav2.Text);
            Sinav3 = Convert.ToDouble(TxtSinav3.Text);
            Sonuc = (Sinav1 + Sinav2 + Sinav3) / 3;
            labSonuc.Text = Sonuc.ToString();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Double Sayi1,Sayi2,Sayi3,Toplama,Cikarma,Carpma;
            Sayi1 =Convert.ToDouble(TexSayi1.Text);
            Sayi2 = Convert.ToDouble(TexSayi2.Text);
            Sayi3 = Convert.ToDouble(TexSayi3.Text);
            Toplama = Sayi1 + Sayi2 + Sayi3;
            Carpma = Sayi1 * Sayi2 * Sayi3;
            Cikarma = Sayi1 - Sayi2 - Sayi3;
            LabCarp.Text = Carpma.ToString();
            LabCik.Text = Cikarma.ToString();
            LabTop.Text = Toplama.ToString();
        }
    }
}
