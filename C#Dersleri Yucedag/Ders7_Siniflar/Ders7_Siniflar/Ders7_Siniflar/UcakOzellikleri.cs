using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders7_Siniflar
{
    internal class UcakOzellikleri
    {
        public int YolcuKapasite;
        public string Renk;
        public string Marka;
        public string Fiyat;
        private string UcakSahibi;
        private string UcakKazanc;
        
        public string Kapsulleme1
        {
            get{ return UcakSahibi; }
            set{ UcakSahibi = UcakSahibi+"Balon" ; }
        }
        public string Kapsulleme2
        {
            get { return UcakKazanc; }
            set { UcakKazanc = UcakKazanc +"Deneme"; }
        }
    }
}
