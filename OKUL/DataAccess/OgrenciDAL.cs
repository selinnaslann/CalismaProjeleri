using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using OKUL.Models;
using OKUL.DataAccess;

namespace OKUL.DataAccess
{
    public class OgrenciDAL
    {
        private static OgrenciDAL _Current {get;set;}

        public static OgrenciDAL Current
        {
            get 
            {
                if (_Current == null)
                    _Current = new OgrenciDAL();
                return _Current;
            }
        }
        public object Create(Ogrenci ogrenci)
        {
            string query = $"INSERT INTO Ogrenci (Ad,Soyad,OgretmenID,FotoAdres) VALUES('{ogrenci.Ad}','{ogrenci.Soyad}',{ogrenci.OgretmenID},'{ogrenci.FotoAdres}'); SELECT CAST(scope_identity() AS int);";
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