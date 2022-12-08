using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders1_ArayüzVeButonAtaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İlk mesajımız");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "ibrahim";
            label4.Text = "Kebapci";
            label5.Text = "IT";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label10.Text = "ibrahi kebapci";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Selam";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = textBox2.Text;
            label9.Text = textBox3.Text;
            label11.Text = textBox4.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
