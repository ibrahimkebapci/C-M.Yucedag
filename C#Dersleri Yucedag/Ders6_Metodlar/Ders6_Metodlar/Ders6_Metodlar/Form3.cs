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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public int KupHacim(int s)
        {
            int Hacim = s*s*s;
            return Hacim;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int TekKenar;
            TekKenar = Convert.ToInt32(textBox1.Text);
            label1.Text = KupHacim(TekKenar).ToString();
        }
    }
}
