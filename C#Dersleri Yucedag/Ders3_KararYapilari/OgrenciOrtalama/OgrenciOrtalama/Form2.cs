using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciOrtalama
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double KitapAdedi, ToplamTutar,Fiyat;
            KitapAdedi = Convert.ToDouble(TxtKitapAdet.Text);
            Fiyat= Convert.ToDouble(TxtFiyat.Text);
                        
            if(KitapAdedi<20)
            {
                ToplamTutar = ((Fiyat * 8) / 10) * KitapAdedi;
                LableSonuc.Text = ToplamTutar.ToString();
            }
            if(20>KitapAdedi && KitapAdedi<50)
            {
                ToplamTutar = ((Fiyat * 5) / 10) * KitapAdedi;
                LableSonuc.Text = ToplamTutar.ToString();
            }
            if(KitapAdedi>50)
            {
                ToplamTutar = ((Fiyat * 3)/10) * KitapAdedi;
                LableSonuc.Text = ToplamTutar.ToString();
            }

        }

        private void LableSonuc_Click(object sender, EventArgs e)
        {

        }
    }
}
