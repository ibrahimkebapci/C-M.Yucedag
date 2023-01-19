using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders5_Diziler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] Sayilar = {7,8,9,10,11,12,13,14,15}; 
            for(int i =0;i<Sayilar.Length;i++)
            {
                if(Sayilar[i] % 2 == 0 && Sayilar[i] > 10 )
                {
                    listBox1.Items.Add(Sayilar[i]);
                }

            }
        }
    }
}
