using System.Collections.Generic;
using Bookish.Models.Copy;
using Dapper;
using MySql.Data.MySqlClient;

namespace Bookish.Models.Users
{
    public class UserServices : IDbServices
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
    }
}