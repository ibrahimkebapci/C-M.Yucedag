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
            

        }

        private void ButonSonuc_Click(object sender, EventArgs e)
        {
            int SoruNo = 0;
            SoruNo = Convert.ToInt16(LblSoruNo);

            if (SoruNo == 1)
            {
                richTextBox1.Text = "Normal boyutlarda bir uçak kaç müşteri kapasitesine sahiptir?";
                ButonA.Text = "10";
                ButonB.Text = "20";
                ButonC.Text = "30";
                ButonD.Text = "40";
                SoruNo++;
            }
            if(SoruNo == 2)
            {
                richTextBox1.Text = "Türkiyenin en yüksek dağı hangisidir?";
                ButonA.Text = "Erciyes";
                ButonB.Text = "Ağrı";
                ButonC.Text = "Uludag";
                ButonD.Text = "Gabar";
                SoruNo++;
            }
            if(SoruNo == 3)
            {
                richTextBox1.Text = "Kükürt içerisine ne kadarad karbon bulunmaktadır?";
                ButonA.Text = "2";
                ButonB.Text = "8";
                ButonC.Text = "10";
                ButonD.Text = "16";
                SoruNo++;
            }
            SoruNo++;

        }
    }
}
