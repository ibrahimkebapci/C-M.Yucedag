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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int GirilenSayi;
            GirilenSayi = Convert.ToInt16(textBox1.Text);
            for(int i = 1; i < GirilenSayi; i++)
            {
                if (GirilenSayi % i == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
            
        }
    }
}
