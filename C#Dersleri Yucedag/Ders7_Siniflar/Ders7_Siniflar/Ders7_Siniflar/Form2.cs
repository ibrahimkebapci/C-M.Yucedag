using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders7_Siniflar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UcakOzellikleri Ucak1 = new UcakOzellikleri();
            Ucak1.Marka = "S150";
            Ucak1.YolcuKapasite = 75;
            Ucak1.Renk = "Kirmizi";
            Ucak1.Fiyat = "100.000 TL";
            Ucak1.Kapsulleme1="Selam";
            Ucak1.Kapsulleme2="Melam";
            

            pictureBox1.BackColor = Color.Green;

            label1.Text = Ucak1.Marka.ToString();
            label2.Text = Ucak1.Renk.ToString();
            label3.Text = Ucak1.YolcuKapasite.ToString();
            label4.Text = Ucak1.Fiyat.ToString();
            label5.Text = Ucak1.Kapsulleme1.ToString();
            label6.Text = Ucak1.Kapsulleme2.ToString();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rast = new Random();
            int S1, S2, S3, S4;
            S1 = rast.Next(1, 5);
            S2 = rast.Next(1, 5);
            S3 = rast.Next(1, 5);
            S4 = rast.Next(1, 5);

            label7.Text = S1.ToString();
            label8.Text = S2.ToString();
            label9.Text = S3.ToString();
            label10.Text = S4.ToString();

            if(textBox1.Text == label7.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }
            if (textBox2.Text == label8.Text)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }
            if (textBox3.Text == label9.Text)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }
            if (textBox4.Text == label10.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
        }
    }
}
