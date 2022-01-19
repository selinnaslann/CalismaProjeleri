using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OKUL.Models;

namespace OKUL.DataAccess
{
    public class OgretmenDAL
    {
        private static OgretmenDAL _methods { get; set; }
        public static OgretmenDAL methods {
            get {
                if (_methods == null)
                    _methods = new OgretmenDAL(); // _methods set
                return _methods; //  get _methods
            }
        }
        public object Create(Ogretmen ogretmen)
        {
            string query = $"INSERT INTO Ogretmen (Ad,Soyad) VALUES('{ogretmen.Ad}','{ogretmen.Soyad}'); SELECT CAST(scope_identity() as INT); ";
            return DbTools.Connection.Create(query);
        }
        public List<Ogretmen> ListOgretmen()
        {
            string query = "SELECT * FROM Ogretmen;";
            return DbTools.Connection.ReadOgretmen(query);
        }

        public Ogretmen GetByID(int id)
        {
            string query = $"SELECT * FROM Ogretmen WHERE ID = {id};";
            return DbTools.Connection.ReadOgretmen(query)[0];
        }

        public bool Update(Ogretmen ogrt)
        {
            string query = $"UPDATE Ogretmen SET Ad='{ogrt.Ad}',Soyad='{ogrt.Soyad}' WHERE ID={ogrt.ID};";
            return DbTools.Connection.Execute(query);
        }

        public bool Delete(Ogretmen ogrt)
        {
            string query = $"DELETE FROM Ogretmen WHERE ID={ogrt.ID};";
            return DbTools.Connection.Execute(query);
        }
        public List<Ogretmen> Search(string word)
        {
            string query = $"SELECT * FROM Ogretmen WHERE Ad LIKE '%{word}%' OR Soyad LIKE '%{word}%';";
            return DbTools.Connection.ReadOgretmen(query);
        }
    }
}