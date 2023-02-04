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
    public partial class VeriVer : Form
    {
        public VeriVer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VeriAl veri= new VeriAl();
            veri.ad = textBox1.Text;
            veri.Soyad = textBox2.Text;
            veri.Yas = Convert.ToInt16(textBox3.Text);
            veri.Show();
            this.Hide();
          
        }
    }
}
