using System;
using System.Collections.Generic;
using System.Linq;

namespace emlaksitesi
{
    class Kullanıcı
    {
        public long ID;
        public string adSoyad;
        public string adres;
        public string telefon;
        
        public List<long> IDler = new List<long>();
        public List<string> adSoyadlar = new List<string>();
        public List<string> adresler = new List<string>();
        public List<string> telefonlar = new List<string>();


        public Kullanıcı()
        {


        }

        public Kullanıcı(long id,string adsoyad,string adres,string telefon)
        {
            this.ID = id;
            this.adSoyad = adsoyad;
            this.adres = adres;
            this.telefon = telefon;

        }

        public void kullaniciDuzenleme(long id,string adsoyad, string adres, string telefon)
        {
            long indeks = IDler.IndexOf(id);
            int indeksad = adSoyadlar.IndexOf(adsoyad);
            int indeksadres = adresler.IndexOf(adres);
            int indekstelefon = telefonlar.IndexOf(telefon);

            Console.Write("Ad Soyad giriniz: ");
            adSoyadlar[indeksad] = Console.ReadLine();

            Console.Write("Adres giriniz: ");
            adresler[indeksadres] = Console.ReadLine();

            Console.Write("Telefon giriniz: ");
            telefonlar[indekstelefon] = Console.ReadLine();

            string kullanıcıYeniBilgiler = ($"Ad Soyad: {adSoyadlar[indeksad]}\nAdres:{adresler[indeksadres]}\nTelefon:{telefonlar[indekstelefon]}");


        }
        public void BilgiYaz()
        {
            Console.WriteLine($"Kullanıcı Adı Soyadı: {this.adSoyad}");
            Console.WriteLine($"Kullanıcı Adres: {this.adres} ");
            Console.WriteLine($"Kullanıcı Telefon: {this.telefon} ");

        }
    }
}
