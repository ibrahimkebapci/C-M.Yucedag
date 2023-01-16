using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders4_Donguler
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            timer1.Start();
        }
        int Saat = 0, Dakika = 0, Saniye = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Saniye++;
            label3.Text = Saniye.ToString();
            if(Saniye == 30)
            {
                Dakika++;
                label2.Text = Dakika.ToString();
                if(Dakika == 5 )
                {
                    Saat++;
                    label1.Text=Saat.ToString();
                    Dakika = 0;
                }
                Saniye = 0;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
         
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
        }
    }
}
