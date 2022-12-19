using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler
{
    public partial class Form1 : Form
    {
        public string Ad_Soyad;
        public string Yas;
        public string Meslek;
        public string Cinsiyet;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            Ad_Soyad = textBox1.Text;
            Yas = maskedTextBox1.Text;
            Meslek = textBox4.Text;
            Cinsiyet = textBox3.Text;

            listBox2.Items.Add(" Bilgiler Kayıt edildi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(Ad_Soyad + " " + Yas + " " + Meslek + " " + Cinsiyet);
        }
    }
}
