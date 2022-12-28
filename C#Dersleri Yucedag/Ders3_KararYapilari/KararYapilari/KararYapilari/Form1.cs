using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int GirilenSayi;
            GirilenSayi = Convert.ToInt16(textBox1.Text);
            if(GirilenSayi % 2 == 0 && GirilenSayi >= 10)
            {
                label1.Text = "Girilen sayi  2 ye blünüyor ve 10 dan büyüktür";
            }
            else
            {
                label1.Text = " Girilen sayi 2 ye bölünmüyor ya da 10 dan küçük";
            }
        }
    }
}
