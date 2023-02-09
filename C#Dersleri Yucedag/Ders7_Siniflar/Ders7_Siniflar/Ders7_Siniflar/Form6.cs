using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders7_Siniflar
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        enum Sehirler {Adana,Manisa,Urfa,Istanbul,Mersin,Antalya,Al,Ak,Beyaz}
        private void button1_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt16(textBox1.Text);
            Sehirler Dizi;
            Dizi = (Sehirler) s;
            label1.Text = s.ToString();

            
        }
    }
}
