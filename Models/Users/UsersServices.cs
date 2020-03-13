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

        public MySqlCommand NewUser()
        {
            return new MySqlCommand("INSERT INTO users (first_name, last_name, email, image_url) VALUES ('test', 'test', 'test@test.com', 'https://test.test?///test278846565=dyhgyg');");
        }
        
    }
}