using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace Bookish.Models.Author {
    
    namespace Bookish.Models.Author
    {
        using Dapper;
        public class AuthorServices
        {
            public class Author
            {
                public int Id { get; set; }
                public string FirstNames { get; set; }
                public string LastName { get; set; }
                
            }
            public IEnumerable<Author> GetAuthor()
            {
                var server = "localhost";
                var database = "bookishdb";
                var uid = "EmmFox";
                var password = "Astrid2014";
                string serverConnection = "Server=" + server + ";" + "Database=" + 
                                          database + ";" + "Uid=" + uid + ";" + "Pwd=" + password + ";";
                using MySqlConnection connection = new MySqlConnection(serverConnection);
                var authors = connection.Query<Author>("SELECT * FROM Author");
                return authors;
            }

        }

    }
}