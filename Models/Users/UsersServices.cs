using System.Collections.Generic;
using Bookish.Models.Copy;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace Bookish.Models.Users
{
    public class UsersServices
    {
        private MySqlConnection connection = IDbServices.ConnectToDb();
        public class User
        {
            public int Id { get; set; }
            public string ImageUrl { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }

        }
        public IEnumerable<User> GetUsers()
        {
            var users = connection.Query<User>
                ("SELECT * FROM users");
            return users;
        }

        public void NewUser(UsersModel newUserModel)
        {
           connection.Execute(
                "INSERT INTO users (first_name, last_name, email, image_url) VALUES (@FirstName, @LastName, @Email, @ImageURL)",
                new {FirstName = newUserModel.FirstName, LastName = newUserModel.LastName, Email = newUserModel.Email, ImageUrl = newUserModel.ImageUrl}
            );
        }
        
    }
}