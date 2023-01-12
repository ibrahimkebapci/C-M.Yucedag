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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int GirilenSayi,ToplamSayi = 0;
            GirilenSayi = Convert.ToInt32(textBox1.Text);
            for(int i = 0; i < GirilenSayi;i++)
            {
                ToplamSayi = ToplamSayi + i;
            }
            label1.Text = ToplamSayi.ToString();
        }
    }
}
