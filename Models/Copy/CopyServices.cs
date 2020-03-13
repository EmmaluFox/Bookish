using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Data.SqlClient;
using Bookish.Models.Author.Bookish.Models.Author;
using MySql.Data.MySqlClient;

namespace Bookish.Models.Copy
{
    using Dapper;
    public class CopyServices : IDbServices
    {
        private MySqlConnection connection = IDbServices.ConnectToDb();
        public class Copy
        {
            public int Id { get; set; }
            public int BookId { get; set; }
            public string Title { get; set; }
            public bool CurrentlyLoaned { get; set; }
        }
        
        public IEnumerable<Copy> GetCopy()
        {
           var copies = connection.Query<Copy>
                ("SELECT * FROM copy");
            return copies;
        }
    }
}