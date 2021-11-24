using System;

namespace aracsorusu
{
    enum Renk
    {
        Siyah,
        Kırmızı,
        Beyaz,
        Gri

    }
    class Otomobil : Arac
    {

        private byte _KapiSayisi;

        public byte KapiSayisi { get => _KapiSayisi; set => _KapiSayisi = value; }
        

        public override void OTVHesapla()
        {
            if (MotorHacmi >= 0 && MotorHacmi <= 999)
            {
                Console.WriteLine($"0-999 CC'li Aracın ÖTV'li Fiyatı: {this.Fiyat * 1.05}");
            }
            else if (MotorHacmi >= 1000 && MotorHacmi <= 1599)
            {
                Console.WriteLine($"1000-1599 CC'li Aracın ÖTV'li Fiyatı: {this.Fiyat * 1.10}");
            }
            else if (MotorHacmi >= 1600 && MotorHacmi <= 1999)
            {
                Console.WriteLine($"1600-1999 CC'li Aracın ÖTV'li Fiyatı: {this.Fiyat * 1.15}");
            }
            else if (MotorHacmi >= 2000)
            {
                Console.WriteLine($"2000 ve Üzeri CC'li Aracın ÖTV'li Fiyatı: {this.Fiyat * 1.20}");
            }
        }

        public override void YillikVergiHesapla()
        {
            if (Yas>=0 && Yas<=4)
            {
                Console.WriteLine($"Araç Yaşı 0-4 olanların Yıllık Vergisi:{this.Fiyat*1.05}");
            }
            else if (Yas >= 5 && Yas <= 9)
            {
                Console.WriteLine($"Araç Yaşı 5-9 olanların Yıllık Vergisi:{this.Fiyat * 1.04}");
            }
            else if (Yas >= 10)
            {
                Console.WriteLine($"Araç Yaşı 10 ve Üzeri olanların Yıllık Vergisi:{this.Fiyat * 1.03}");
            }
            if (MotorHacmi >= 0 && MotorHacmi <= 999)
            {
                Console.WriteLine($"0-999 CC'li Aracın Yıllık Vergisi: {this.Fiyat * 1.02}");
            }
            else if (MotorHacmi >= 1000 && MotorHacmi <= 1599)
            {
                Console.WriteLine($"1000-1599 CC'li Aracın Yıllık Vergisi: {this.Fiyat * 1.05}");
            }
            else if (MotorHacmi >= 1600 && MotorHacmi <= 1999)
            {
                Console.WriteLine($"1600-1999 CC'li Aracın Yıllık Vergisi: {this.Fiyat * 1.08}");
            }
            else if (MotorHacmi >= 2000)
            {
                Console.WriteLine($"2000 ve Üzeri CC'li Aracın Yıllık Vergisi: {this.Fiyat * 1.10}");
            }
        }


        
        public Otomobil()
        {

        }

        public Otomobil(short motorHacmi, byte vitesSayisi, double fiyat, double otvFiyat, int uretimYili, int yas) : base(motorHacmi, vitesSayisi, fiyat, otvFiyat, uretimYili, yas)
        {
            this.KapiSayisi = KapiSayisi;
            

        }

        public void BilgiYaz()
        {
            Console.WriteLine("*****   OTOMOBİL BİLGİLERİ   *****");
            Console.WriteLine($"Otomobilin motor hacmi:{this.MotorHacmi}");
            Console.WriteLine($"Otomobilin vites sayısı:{this.VitesSayisi}");
            Console.WriteLine($"Otomobilin fiyatı:{this.Fiyat} Bin TL");
            Console.WriteLine($"Otomobilin üretim yılı:{this.MotorHacmi}");
            Console.WriteLine($"Otomobilin Kapı Sayısı:{this.KapiSayisi}");
            Console.WriteLine($"Otomobilin Rengi:{Renk.Beyaz}");
            Console.WriteLine("****************************************");
        }
    }

}
