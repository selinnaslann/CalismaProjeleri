using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealEstate.Models;

namespace RealEstate.DataAccess
{
    public class UserDAL
    {
        public object Insert(User user)
        {
            user.AddressID = Convert.ToInt32(AddressDAL.Methods.Insert(user.Address));
            string query = $@"USE
            INSERT INTO [dbo].[User]
             ([FullName]
           ,[Email]
           ,[Password]
           ,[PhoneNumber]
           ,[ProfilePicUrl]
           ,[AddressID]
           ,[RoleID])
             VALUES
           ('{user.FullName}','{user.Email}','{user.Password}','{user.PhoneNumber}','{user.ProfilePicUrl}',{user.AddressID},{user.RoleID});";
            return user;
        }
        public User Read(int userid)
        {
            string query = $"SELECT * FROM User WHERE ID={userid}";
            User usr = DbTools.Connection.ListUser(query)[0];
            return usr;
        }

        public bool Update(User user)
        {
            string query = $@"
               UPDATE [dbo].[User]
                        SET [FullName] = '{user.FullName}'
                            ,[Email] = '{user.Email}'
                            ,[Password] = '{user.Password}'
                            ,[PhoneNumber] = '{user.PhoneNumber}'
                            ,[ProfilePicUrl] = '{user.ProfilePicUrl}'
                            ,[AddressID] = {user.AddressID}
                            ,[RoleID] = {user.RoleID}
              WHERE ID={user.ID}; ";
            return DbTools.Connection.Execute(query);
        }

        public bool Delete(User user)
        {
            string query = $@"DELETE FROM User WHERE ID={user.ID}";
            return DbTools.Connection.Execute(query);
        }
        public List<User> List()
        {
            string query = "SELECT * FROM User;";
            return DbTools.Connection.ListUser(query);
        }
    }
}