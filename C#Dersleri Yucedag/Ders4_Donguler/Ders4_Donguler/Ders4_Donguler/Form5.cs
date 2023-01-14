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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            do
            {
                listBox1.Items.Add("Selam Dunya");
                i++;
            }
            while (i>21);
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
