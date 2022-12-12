using System;
using System.Windows.Forms;

namespace Ders1_ArayüzVeButonAtaması
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SehirEkleB1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("İlk sehir");

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Aşçı");
            listBox1.Items.Add("Mühendis");
            listBox1.Items.Add("Marangoz");
            listBox1.Items.Add("Başkan");
            listBox1.Items.Add("Kalemci");
            listBox1.Items.Add("Temizlikçi");
            listBox1.Items.Add("Yardimci");
            listBox1.Items.Add("Şovalye");
            listBox1.Items.Add("Memur");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text + " " + textBox5.Text);
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
