using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealEstate.ModelBase;
using RealEstate.Models;


namespace RealEstate.DataAccess
{
    public class ResidentialDAL
    {
        private static ResidentialDAL _Current { get; set; }

        public static ResidentialDAL Current
        {
            get
            {
                if (_Current == null)
                    _Current = new ResidentialDAL();
                return _Current;
            }
        }
        public object Create(Residential residential)
        {
            string query = $"INSERT INTO Residentials (SellType,Square,Age,FloorNumber) VALUES('{ogrenci.Ad}','{ogrenci.Soyad}',{ogrenci.OgretmenID},'{ogrenci.FotoAdres}'); SELECT CAST(scope_identity() AS int);";
            object insertedID = DbTools.Connection.Create(query);
            return insertedID;
        }

        public List<Ogrenci> ListOgrenci()
        {
            string query = "SELECT * FROM Ogrenci;";
            return DbTools.Connection.ReadOgrenci(query);
        }

        public Ogrenci GetByID(int id)
        {
            string query = $"SELECT * FROM Ogrenci WHERE ID={id};";
            return DbTools.Connection.ReadOgrenci(query)[0]; // Öğrenci listesinin ilk elemanını döndür.
        }
        public bool Update(Ogrenci ogrenci)
        {
            string query = $"UPDATE Ogrenci SET Ad='{ogrenci.Ad}',Soyad='{ogrenci.Soyad}',OgretmenID={ogrenci.OgretmenID},FotoAdres='{ogrenci.FotoAdres}' WHERE ID={ogrenci.ID};";
            return DbTools.Connection.Execute(query);
        }
        public bool Delete(Ogrenci ogrenci)
        {
            string query = $"DELETE FROM Ogrenci WHERE ID = {ogrenci.ID};";
            return DbTools.Connection.Execute(query);
        }

        public List<Ogrenci> Search(string word)
        {
            string query = $"SELECT * FROM Ogrenci WHERE Ad LIKE '%{word}%' OR Soyad LIKE '%{word}%';";
            return DbTools.Connection.ReadOgrenci(query);
        }
    }
}
