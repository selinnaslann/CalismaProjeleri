using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24kasım2
{
    enum Ozellik
    {
        KapiSayisi,
        Renk
    }

    class Otomobil:Arac
    {
        public override void OTVHesapla()
        {
            if (MotorHacmi>=0 && MotorHacmi<=999)
            {
                Console.WriteLine($"ÖTV'li Fiyat: {this.Fiyat*1.05}");
            }
        }

    }
}
