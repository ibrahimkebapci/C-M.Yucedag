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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int i = 0;
            while(i< 10)
            {
                listBox1.Items.Add("Selam");
                listBox2.Items.Add(i + ".Dostum");
                i++;
            }
            int j = 1;
            int Sayi;
            while(j <= 10)
            {
                Sayi = Sayi + j;
                j++;
            }
            MessageBox.Show(Sayi.ToString());

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
