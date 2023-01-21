using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders6_Metodlar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int SayiCarp(int a ,int b ,int c)
        {
            int CarpmaSonuc = 0;
            CarpmaSonuc = a * b * c;
            return CarpmaSonuc;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = SayiCarp(3, 4, 5).ToString();
            label2.Text = SayiCarp(4, 5, 6).ToString();
            label3.Text = SayiCarp(6, 5, 2).ToString();
        }
    }
}
