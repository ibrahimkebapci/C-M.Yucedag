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
        public int SoruNo = 1;
        public int DogruSayisi = 0;
        public int YanlisSayi = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int DogruSay;
            if(SoruNo==1)
            {
                DogruSay = Convert.ToInt16(LblDogru.Text);
                Yesil.Visible=true;
            }
            if (SoruNo == 2)
            {
                DogruSay = Convert.ToInt16(LblDogru.Text);
                Kirmizi.Visible=true;
            }
            if (SoruNo == 3)
            {
                DogruSay = Convert.ToInt16(LblDogru.Text);
                Kirmizi.Visible = true;
            }
            SoruNo++;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void ButonSonuc_Click(object sender, EventArgs e)
        {
         ;
            SoruNo = Convert.ToInt16(LblSoruNo);

            if (SoruNo == 1)
            {
                richTextBox1.Text = "Normal boyutlarda bir uçak kaç müşteri kapasitesine sahiptir?";
                ButonA.Text = "10";
                ButonB.Text = "20";
                ButonC.Text = "30";
                ButonD.Text = "40";
            }
            if(SoruNo == 2)
            {
                richTextBox1.Text = "Türkiyenin en yüksek dağı hangisidir?";
                ButonA.Text = "Erciyes";
                ButonB.Text = "Ağrı";
                ButonC.Text = "Uludag";
                ButonD.Text = "Gabar";
                
            }
            if(SoruNo == 3)
            {
                richTextBox1.Text = "Kükürt içerisine ne kadarad karbon bulunmaktadır?";
                ButonA.Text = "2";
                ButonB.Text = "8";
                ButonC.Text = "10";
                ButonD.Text = "16";
            }
        }

        private void ButonB_Click(object sender, EventArgs e)
        {
            int DogruSay;
            if (SoruNo == 2)
            {
                DogruSay = Convert.ToInt16(LblDogru.Text);
                Yesil.Visible = true;
            }
            else
            {
                Kirmizi.Visible = true;    
            }    
            

            SoruNo++;
        }

        private void ButonC_Click(object sender, EventArgs e)
        {
            int DogruSay;
            if (SoruNo == 3)
            {
                DogruSay = Convert.ToInt16(LblDogru.Text);
                Yesil.Visible = true;
            }
            else
            {
                Kirmizi.Visible = true; 
            }

            SoruNo++;
        }
    }
}
