using System;
namespace aracsorusu
{
    class Ticari:Arac
    {

        private byte _TasimaKapasitesi;

        public byte TasimaKapasitesi { get => _TasimaKapasitesi; set => _TasimaKapasitesi = value; }

        public override void OTVHesapla()
        {
            if (MotorHacmi >= 0 && MotorHacmi <= 999)
            {
                Console.WriteLine($"0-999 CC'li Ticari Aracın ÖTV'li Fiyatı: {this.Fiyat * 0.00}");
            }
            else if (MotorHacmi >= 1000 && MotorHacmi <= 1599)
            {
                Console.WriteLine($"1000-1599 CC'li Ticari Aracın ÖTV'li Fiyatı: {this.Fiyat * 1.05}");
            }
            else if (MotorHacmi >= 1600 && MotorHacmi <= 1999)
            {
                Console.WriteLine($"1600-1999 CC'li Ticari Aracın ÖTV'li Fiyatı: {this.Fiyat * 1.10}");
            }
            else if (MotorHacmi >= 2000)
            {
                Console.WriteLine($"2000 ve Üzeri CC'li Ticari Aracın ÖTV'li Fiyatı: {this.Fiyat * 1.15}");
            }
        }

        public override void YillikVergiHesapla()
        {
            if (Yas >= 0 && Yas <= 4)
            {
                Console.WriteLine($"Yaşına Göre Yıllık Vergisi:{2*(this.Fiyat * 1.03)}");
            }
            else if (Yas >= 5 && Yas <= 9)
            {
                Console.WriteLine($"Yaşına Göre Yıllık Vergisi:{2*(this.Fiyat * 1.02)}");
            }
            else if (Yas >= 10)
            {
                Console.WriteLine($"Yaşına Göre Yıllık Vergisi:{2*(Fiyat * 1.01)}");
            }
            if (MotorHacmi >= 0 && MotorHacmi <= 999)
            {
                Console.WriteLine($"Motor Hacmine Göre Yıllık Vergisi: {2*(this.Fiyat * 0.00)}");
            }
            else if (MotorHacmi >= 1000 && MotorHacmi <= 1599)
            {
                Console.WriteLine($"Motor Hacmine Göre Yıllık Vergisi: {2*(this.Fiyat * 1.02)}");
            }
            else if (MotorHacmi >= 1600 && MotorHacmi <= 1999)
            {
                Console.WriteLine($"Motor Hacmine Göre Yıllık Vergisi: {2*(this.Fiyat * 1.05)}");
            }
            else if (MotorHacmi >= 2000)
            {
                Console.WriteLine($"Motor Hacmine Göre Yıllık Vergisi: {2*(this.Fiyat * 1.10)}");
            }
        }


        public Ticari()
        {

        }

        public Ticari(short motorHacmi, byte vitesSayisi, double fiyat, double otvFiyat, int uretimYili, int yas):base(motorHacmi, vitesSayisi, fiyat, otvFiyat, uretimYili, yas)
        {

            this.TasimaKapasitesi = TasimaKapasitesi;
        }

        public void BilgiYaz()
        {
            Console.WriteLine("*****   TİCARİ ARACIN BİLGİLERİ   *****");
            Console.WriteLine($"Ticari aracın motor hacmi:{this.MotorHacmi}");
            Console.WriteLine($"Ticari aracın vites sayısı:{this.VitesSayisi}");
            Console.WriteLine($"Ticari aracın fiyatı:{this.Fiyat} Bin TL");
            Console.WriteLine($"Ticari aracın üretim yılı:{this.MotorHacmi}");
            Console.WriteLine($"Ticari aracın taşıma kapasitesi:{this.TasimaKapasitesi}");
            Console.WriteLine("****************************************");
        }
    }
}
