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
    public partial class VeriAl : Form
    {
        public VeriAl()
        {
            InitializeComponent();
        }

        public string ad;
        public string Soyad;
        public int Yas;
        private void VeriAl_Load(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add(ad);
            comboBox1.Items.Add(Soyad);
            comboBox1.Items.Add(Yas.ToString());
        }
    }
}
