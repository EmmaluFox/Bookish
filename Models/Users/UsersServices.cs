using System.Collections.Generic;
using Bookish.Models.Copy;
using Dapper;
using MySql.Data.MySqlClient;

namespace Bookish.Models.Users
{
    public class UserServices
    {
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
            var server = "localhost";
            var database = "bookishdb";
            var uid = "EmmFox";
            var password = "Astrid2014";
            string serverConnection = "Server=" + server + ";" + "Database=" + 
                                      database + ";" + "Uid=" + uid + ";" + "Pwd=" + password + ";";
            using MySqlConnection connection = new MySqlConnection(serverConnection);
            var users = connection.Query<User>
                ("SELECT * FROM users");
            return users;
        }
    }
}