﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OKUL.DataAccess;

namespace OKUL.Models
{
    public class Ogrenci
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        private int _OgretmenID { get; set; }
        public int OgretmenID
        {
            get
            {
                return _OgretmenID;
            }
            set
            {
                this._OgretmenID = value;
            }
        }

        private Ogretmen _Ogretmen { get; set; }
        public Ogretmen Ogretmen {
            get {
                if (this._Ogretmen == null)
                    this._Ogretmen = OgretmenDAL.methods.GetByID(this.OgretmenID);
                return this._Ogretmen;
            }
            set
            {
                this._Ogretmen = value;
                this.OgretmenID = value.ID;
            }
        }

        public HttpPostedFileBase Foto { get; set; }
        public string FotoAdres { get; set; }

    }
}