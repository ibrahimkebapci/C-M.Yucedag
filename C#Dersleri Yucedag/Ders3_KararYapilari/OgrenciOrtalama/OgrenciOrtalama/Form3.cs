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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Isaret_TextChanged(object sender, EventArgs e)
        {
            string isaret;
            double sayi1,sayi2,Sonuc;
            isaret = TxtIsaret.Text;
            sayi1 = Convert.ToDouble(TxtSayi1.Text);
            sayi2 = Convert.ToDouble(TxtSayi2.Text);
           
            switch (isaret)
            {
                case "+":
                     Sonuc = sayi1 + sayi2;
                    LableSonuc.Text = Sonuc.ToString();
                    break;
                case "-":
                    Sonuc = sayi1 - sayi2;
                    LableSonuc.Text = Sonuc.ToString();
                    break;
                case "*":
                    Sonuc = sayi1 * sayi2;
                    LableSonuc.Text = Sonuc.ToString();
                    break;
                case "/":
                    Sonuc = sayi1 / sayi2;
                    LableSonuc.Text = Sonuc.ToString();
                    break;
                
                default:
                    LableSonuc.Text = "Yanlis İsaret girildi";
                    break;
            }
        }
    }
}
