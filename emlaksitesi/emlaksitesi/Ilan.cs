using System;
using System.Collections.Generic;
using System.Linq;
namespace emlaksitesi
{
    class Ilan
    {
        public long ID;
        public string tarih;
        public string baslik;
        public string aciklama;
        public string satilikMiKiralikMi;
        public string fiyat;
        public string kullanici;

        public List<long> IDler = new List<long>();
        public List<long> kullanicilar = new List<long>();

        public Ilan()
        {

        }

        public Ilan(long id,string tarih,string baslik,string aciklama,string satilikmikiralikmi,string fiyat,string kullanici)
        {
            this.ID = id;
            this.tarih = tarih;
            this.baslik = baslik;
            this.aciklama = aciklama;
            this.satilikMiKiralikMi = satilikmikiralikmi;
            this.fiyat = fiyat;
            this.kullanici = kullanici;
        }

        public void ilanDuzenleme()
        {



        }





    }
}
