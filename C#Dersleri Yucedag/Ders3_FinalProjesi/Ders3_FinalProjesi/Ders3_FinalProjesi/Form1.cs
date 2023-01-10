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
        public int SoruNo = 0;
        public int DogruSayisi = 0;
        public int YanlisSayi = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(SoruNo==1)
            {
                DogruSayisi = Convert.ToInt16(LblDogru.Text);
                Yesil.Visible=true;
                DogruSayisi++;
                LblDogru.Text = DogruSayisi.ToString();
                
            }
          else
            {
                Kirmizi.Visible = true;
                YanlisSayi++;
                LblYanlis.Text = YanlisSayi.ToString();

            }
            ButonA.Enabled = false;
            ButonB.Enabled = false;
            ButonC.Enabled = false;
            ButonD.Enabled = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
            

        }

        private void ButonSonuc_Click(object sender, EventArgs e)
        {
            if (SoruNo == 0)
            {
                richTextBox1.Text = "Normal boyutlarda bir uçak kaç müşteri kapasitesine sahiptir?";
                ButonA.Text = "10";
                ButonB.Text = "20";
                ButonC.Text = "30";
                ButonD.Text = "40";
            }
            if (SoruNo == 1)
            {
                richTextBox1.Text = "Türkiyenin en yüksek dağı hangisidir?";
                ButonA.Text = "Erciyes";
                ButonB.Text = "Ağrı";
                ButonC.Text = "Uludag";
                ButonD.Text = "Gabar";

            }
            if (SoruNo == 2)
            {
                richTextBox1.Text = "Kükürt içerisine ne kaç tane karbon atomu bulunmaktadır?";
                ButonA.Text = "2";
                ButonB.Text = "8";
                ButonC.Text = "10";
                ButonD.Text = "16";
            }
            
            SoruNo++;
            LblSoruNo.Text = SoruNo.ToString();
            Kirmizi.Visible = false;
            Yesil.Visible = false;

            ButonA.Enabled = true;
            ButonB.Enabled = true;
            ButonC.Enabled = true;
            ButonD.Enabled = true;
        }

        private void ButonB_Click(object sender, EventArgs e)
        {
            int DogruSay;
            if (SoruNo == 2)
            {
                DogruSay = Convert.ToInt16(LblDogru.Text);
                Yesil.Visible = true;
                DogruSayisi++;
                LblDogru.Text = DogruSayisi.ToString();
            }
            else
            {
                Kirmizi.Visible = true;
                YanlisSayi++;
                LblYanlis.Text = YanlisSayi.ToString();
            }

            ButonA.Enabled = false;
            ButonB.Enabled = false;
            ButonC.Enabled = false;
            ButonD.Enabled = false;
        }

        private void ButonC_Click(object sender, EventArgs e)
        {
            int DogruSay;
            if (SoruNo == 3)
            {
                DogruSay = Convert.ToInt16(LblDogru.Text);
                Yesil.Visible = true;
                DogruSayisi++;
                LblDogru.Text = DogruSayisi.ToString();
                MessageBox.Show("Dogru: " + LblDogru.Text + "\n" + "Yanlis " + LblYanlis.Text);
            }
            else
            {
                Kirmizi.Visible = true;
                YanlisSayi++;
                LblYanlis.Text = YanlisSayi.ToString();
                MessageBox.Show("Dogru: " + LblDogru.Text + "\n" + "Yanlis " + LblYanlis.Text);

            }
            ButonA.Enabled = false;
            ButonB.Enabled = false;
            ButonC.Enabled = false;
            ButonD.Enabled = false;
        }

        private void LblYanlis_Click(object sender, EventArgs e)
        {

        }

        private void ButonD_Click(object sender, EventArgs e)
        {
            Kirmizi.Visible = true;
            YanlisSayi++;
            LblYanlis.Text = YanlisSayi.ToString();
            ButonA.Enabled = false;
            ButonB.Enabled = false;
            ButonC.Enabled = false;
            ButonD.Enabled = false;
        }
    }
}
