using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RealEstate.DataAccess;
using RealEstate.Models;
using Newtonsoft.Json;

namespace RealEstate.Controllers
{
    public class AddressController : Controller
    {
        public string GetCountries()
        {
            string query = "SELECT * FROM Address;";
            string jsonCountries= JsonConvert.SerializeObject(DbTools.Connection.ListCountry(query));
            return jsonCountries;

        }

        public string GetCities(int countryid)
        {
            string query = $"SELECT * FROM AddressCity WHERE CountryID={countryid};";
            string jsonCities = JsonConvert.SerializeObject(DbTools.Connection.ListCity(query));
            return jsonCities;

        }

        public string GetTowns(int cityid)
        {
            string query = $"SELECT * FROM AddressTown WHERE CountryID={cityid};";
            string jsonTowns = JsonConvert.SerializeObject(DbTools.Connection.ListTown(query));
            return jsonTowns;

        }

        public string GetAddressByID(int addressid)
        {
            string jsonAddress = JsonConvert.SerializeObject(DbTools.Connection.GetAddressByID(addressid));
            return jsonAddress;
        }
    }
}
