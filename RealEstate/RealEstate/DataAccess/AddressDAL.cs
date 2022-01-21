using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealEstate.Models;

namespace RealEstate.DataAccess
{
    public class AddressDAL
    {
        private static AddressDAL _Methods { get; set; }
        public static AddressDAL Methods
        {
            get
            {
                if (_Methods == null)
                    _Methods = new AddressDAL();
                return _Methods;
            }
        }

        public object Insert(Address address)
        {
            string query = $"INSERT INTO Address(TownID,Details) VALUES({address.TownID},'{address.Details}'); SELECT CAST(scope_identity() as int);";
            object insertedID = DbTools.Connection.Create(query);
            return insertedID;
        }
        public bool Delete(Address address)
        {
            string query = $@"DELETE FROM Address WHERE ID={address.ID}";
            return DbTools.Connection.Execute(query);
        }
        public bool Update(Address address)
        {
            string query = $@"
                        UPDATE [dbo].[Address]
                        SET [TownID] = {address.TownID}
                        ,[Details] = {address.Details}
                        WHERE ID={address.ID};
                        ";
            return DbTools.Connection.Execute(query);

        }
        public Address GetByID(int addressId)
        {
            string query = $"SELECT * FROM Address WHERE ID={addressId}";
            return DbTools.Connection.ListAddress(query)[0];
        }

        
    }
}