using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders3_FinalProjesi
{
    public partial class Form1 : Form
    {
        public int Sorusayisi;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            LblSoruNo.Text="1";
            
            richTextBox1.Text = "Normal boyutlarda bir uçak kaç müşteri kapasitesine sahiptir.";

        }
    }
}
