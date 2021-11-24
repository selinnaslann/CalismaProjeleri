using System;
namespace aracsorusu
{
    abstract class Arac
    {
        private int _ID;

        
        public short MotorHacmi { get => _MotorHacmi; set => _MotorHacmi = value; }
        public byte VitesSayisi { get => _VitesSayisi; set => _VitesSayisi = value; }
        public double Fiyat { get => _Fiyat; set => _Fiyat = value; }
        public double OTVFiyat { get => _OTVFiyat; set => _OTVFiyat = value; }
        
        public int Yas
        {

            get { return this._Yas; }
            set
            {
                DateTime tarih = new DateTime();
                tarih = DateTime.Now;
                this._Yas = tarih.Year - this.UretimYili;
                Console.WriteLine($"Araç Yaşı:{this.Yas}");
            }
        }

        public int UretimYili { get => _UretimYili; set => _UretimYili = value; }
        public int ID { get => _ID; set => _ID = value; }

        private short _MotorHacmi;

        private byte _VitesSayisi;

        private double _Fiyat;
        private double _OTVFiyat;
        private int _UretimYili;
        private int _Yas;

        abstract public void OTVHesapla();

        abstract public void YillikVergiHesapla();

        virtual public void IndirimYap(byte IndirimOrani)
        {
            this.Fiyat = this.Fiyat - (this.Fiyat * (IndirimOrani / 100));

            Console.WriteLine($"Fiyat %{IndirimOrani} kadar düşürüldü.Güncel Fiyat:{this.Fiyat}");
        }
        public void GetFiyat()
        {
            Console.WriteLine($"fiyat:{this.Fiyat}");
        }

        public Arac()
        {

        }

        public Arac(short motorHacmi, byte vitesSayisi, double fiyat, double otvFiyat, int uretimYili,int yas)
        {
            this.MotorHacmi = motorHacmi;
            this.VitesSayisi = vitesSayisi;
            this.Fiyat = fiyat;
            this.OTVFiyat = otvFiyat;
            this.UretimYili = uretimYili;
            this.Yas = yas;

        }
    }
}