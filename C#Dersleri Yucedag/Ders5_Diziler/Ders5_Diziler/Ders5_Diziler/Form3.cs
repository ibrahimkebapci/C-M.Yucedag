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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int DordeBolunenSayac = 0;
            int Dordebolunen = 0;
            int BolunenlerToplam;
            int[] Sayilar = { 12, 16, 44, 23, 45, 67, 80, 26, 34 };
            foreach(int x in Sayilar)
            {
                if(x % 4 == 0)
                {
                    listBox1.Items.Add(x);
                    DordeBolunenSayac++;
                    Dordebolunen = Dordebolunen + x;
                }
            }
            listBox1.Items.Add("4 bölünen sayı toplamı: " + Dordebolunen);
            listBox1.Items.Add("4 bölünen sayı adedi: " + DordeBolunenSayac);
            label1.Text = Dordebolunen.ToString();
        }
    }
}
