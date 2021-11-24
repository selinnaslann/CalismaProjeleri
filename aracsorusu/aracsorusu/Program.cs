using System;

namespace aracsorusu
{
    class Program
    {
        static void Main(string[] args)
        {
            Otomobil oto = new Otomobil();
            oto.MotorHacmi = 1200;
            oto.VitesSayisi = 5;
            oto.Fiyat = 100.000D;
            oto.UretimYili = 2000;
            oto.KapiSayisi = 4;



            oto.BilgiYaz();
            oto.OTVHesapla();
            oto.YillikVergiHesapla();
            


            Ticari tic = new Ticari();
            tic.MotorHacmi = 1900;
            tic.VitesSayisi = 7;
            tic.Fiyat = 150.000D;
            tic.UretimYili = 2005;
            tic.TasimaKapasitesi = 100;
            

            tic.BilgiYaz();
            tic.OTVHesapla();
            tic.YillikVergiHesapla();

        }

        static void OTVHesap(Arac arac)
        {
            arac.OTVHesapla();

        }

        static void YillikVergi(Arac arac)
        {
            arac.YillikVergiHesapla();
        }
    }
}
