using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24kasım2
{
    abstract class Arac
    {
        private int _ID;

        public int ID { get => ID; }
        public short MotorHacmi { get => _MotorHacmi; set => _MotorHacmi = value; }
        public byte VitesSayisi { get => _VitesSayisi; set => _VitesSayisi = value; }
        public double Fiyat { get => _Fiyat; set => _Fiyat = value; }
        public double OTVFiyat { get => _OTVFiyat; set => _OTVFiyat = value; }
        public double UretimYili { get => _UretimYili; set => _UretimYili = value; }

        private short _MotorHacmi;

        private byte _VitesSayisi;

        private double _Fiyat;
        private double _OTVFiyat;
        private double _UretimYili;

        abstract public void OTVHesapla();
        abstract public void YillikVergiHesapla();

        virtual public void IndirimYap(byte IndirimOrani)
        {
            this.Fiyat=this.Fiyat- (this.Fiyat * (IndirimOrani / 100));
            Console.WriteLine($"Fiyat %{IndirimOrani} kadar düşürüldü.Güncel Fiyat:{this.Fiyat}");
        }
         public void GetFiyat()
        {
            Console.WriteLine($"fiyat:{this.Fiyat}");
        }
       
        



    }
}
