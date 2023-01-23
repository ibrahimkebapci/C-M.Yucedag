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
            Ucak1.Kapsulleme1;
            Ucak1.Kapsulleme2;

            pictureBox1.BackColor = Color.Green;

            label1.Text = Ucak1.Marka.ToString();
            label2.Text = Ucak1.Renk.ToString();
            label3.Text = Ucak1.YolcuKapasite.ToString();
            label4.Text = Ucak1.Fiyat.ToString();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
