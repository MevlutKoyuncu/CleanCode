using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeKadarClean
{
    internal class CamasirMakinesi : BeyazEsya
    {
        public string YikamaKapasitesi;
        public bool Kurutma;


        public CamasirMakinesi() { } //Default Constructer

        public CamasirMakinesi(string marka, string model, double fiyat, string yikamaKapasitesi, bool kurutma)
            : base(marka, model, fiyat)
        {
            YikamaKapasitesi = yikamaKapasitesi;
            Kurutma = kurutma;
        }

        public override string ToString()
        {
            return base.ToString() + "\tYıkama Kapasitesi = " + YikamaKapasitesi + "\tKurutma = " + (Kurutma ? "Evet" : "Hayır");
        }
    }
}

