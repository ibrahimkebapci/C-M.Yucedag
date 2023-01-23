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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArabaOzellik Car1 = new ArabaOzellik();
            Car1.Yakit = "Dizel";
            Car1.Marka = "Volvo";
            Car1.Yil = 2021;
            Car1.Model = "XC90";
            Car1.KM = "13.588";
            pictureBox1.BackColor = Color.CadetBlue;

            label1.Text = Car1.Yakit.ToString();
            label2.Text = Car1.Marka.ToString();
            label3.Text = Car1.Yil.ToString();
            label4.Text = Car1.Model.ToString();
            label5.Text = Car1.KM.ToString();
        }
    }
}
