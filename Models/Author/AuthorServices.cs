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
            private MySqlConnection connection = IDbServices.ConnectToDb();
            public class Author
            {
                public int Id { get; set; }
                public string FirstNames { get; set; }
                public string LastName { get; set; }
                
            }
            public IEnumerable<Author> GetAuthor()
            {
                var authors = connection.Query<Author>("SELECT * FROM Author");
                return authors;
            }

        }

    }
}