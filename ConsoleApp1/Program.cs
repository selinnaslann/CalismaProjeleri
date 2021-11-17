using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp1
{
    class Program
    {
        static List<long> TCler = new List<long>();
        static List<string> adSoyadlar = new List<string>();
        static List<string> adresler = new List<string>();
        static List<string> telefonlar = new List<string>();

        static void Main(string[] args)
        {
            /*
            PersonelEkle(0001, "selin aslan", "muğla", "05541198537");
            PersonelEkle(0002, "ali veli", "Kocaeli", "0555");

            PersonelSil(0001);
            Console.WriteLine(PersonelSil(0001));
           

            PersonelGuncelle(0001);
            Console.WriteLine(PersonelGuncelle(0001));
             */

            PersonelBul(0,"selin aslan");
            Console.WriteLine(PersonelBul(0, "selin aslan"));




        }

        static bool PersonelEkle(long tc = 0, string adsoyad = "", string adres = "", string telefon = "")
        {
            TCler.Add(tc);
            adSoyadlar.Add(adsoyad);
            adresler.Add(adres);
            telefonlar.Add(telefon);

            return true;
        }

        static bool PersonelSil(long tc)
        {
            int indeks = TCler.IndexOf(tc);

            TCler.RemoveAt(indeks);
            adSoyadlar.RemoveAt(indeks);
            adresler.RemoveAt(indeks);
            telefonlar.RemoveAt(indeks);

            return true;

        }

        static string PersonelGuncelle(long tc)
        {
            int indeks= TCler.IndexOf(tc);

            string personelEskiBilgiler = TCler[indeks] + adSoyadlar[indeks] + adresler[indeks] + telefonlar[indeks];

            Console.Write("Ad Soyad giriniz : ");
            adSoyadlar[indeks] = Console.ReadLine();

            Console.Write("Adres giriniz : ");
            adresler[indeks] = Console.ReadLine();

            Console.Write("Telefon giriniz : ");
            telefonlar[indeks] = Console.ReadLine();

            string personelYeniBilgiler = $"TC: {TCler[indeks]}\nAd Soyad:{adSoyadlar[indeks]}\nAdres:{adresler[indeks]}\nTelefon:{telefonlar[indeks]} ";

            return personelYeniBilgiler;
        }

        static string PersonelBul(long tc = 0, string adsoyad = "", string adres = "", string telefon = "")
        {
            
            int indeks = -1;

            if (tc!= 0 && TCler.Contains(tc)==true)
            {
                indeks = TCler.IndexOf(tc);
            }
            else if (adsoyad != "" && adSoyadlar.Contains(adsoyad)==true)
            {
                indeks = adSoyadlar.IndexOf(adsoyad);
            }
            else if (adres != "" && adresler.Contains(adres)==true)
            {
                indeks = adresler.IndexOf(adres);
            }
            else if (telefon != "" && telefonlar.Contains(telefon)==true)
            {
                indeks = telefonlar.IndexOf(telefon);
            }

            string personel = $"TC: {TCler[indeks]}\nAd Soyad:{adSoyadlar[indeks]}\nAdres:{adresler[indeks]}\nTelefon:{telefonlar[indeks]} ";

            return personel;

        }
    }
}
