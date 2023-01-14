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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        int Sayac;

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Sayac++;
            label1.Text = timer1.ToString();
            
            if( Sayac == 10)
            {
                this.BackColor = Color.Red;
            }
            if( Sayac == 20)
            {
                this.BackColor= Color.Green;
            }
            if (Sayac == 30)
            {
                this.BackColor = Color.Blue;
            }
            if (Sayac == 40)
            {
                Sayac = 0;
            }
        }
    }
}
