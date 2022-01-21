using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealEstate.Models;
using RealEstate.DataAccess;

namespace RealEstate.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string ProfilePicUrl { get; set; }
        public HttpPostedFileBase ProfilePic { get; set; }
        private int _AddressID { get; set; }

        public int AddressID {
            get
            {
                return this._AddressID;
            }
            set
            {
                this._AddressID = value;
                this.Address = DbTools.Connection.GetAddressByID(value);
            }
         }
        public Address Address { get; set; }
        private int _RoleID { get; set; }
        public int RoleID
        {
            get
            {
                return this._RoleID;
            }
            set
            {
                this._RoleID = value;
                this.Role = DbTools.Connection.GetRoleByID(value);
            }
        }
        public Role Role { get; set; }
       

    }
}