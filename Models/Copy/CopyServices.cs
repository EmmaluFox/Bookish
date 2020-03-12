using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Data.SqlClient;
using Bookish.Models.Author.Bookish.Models.Author;
using MySql.Data.MySqlClient;

namespace Bookish.Models.Copy
{
    using Dapper;
    public class CopyServices
    {
        public class Copy
        {
            public int Id { get; set; }
            public int BookId { get; set; }
            public string Title { get; set; }
            public bool CurrentlyLoaned { get; set; }
        }
        
        public IEnumerable<Copy> GetCopy()
        {
            var server = "localhost";
            var database = "bookishdb";
            var uid = "EmmFox";
            var password = "Astrid2014";
            string serverConnection = "Server=" + server + ";" + "Database=" + 
                                      database + ";" + "Uid=" + uid + ";" + "Pwd=" + password + ";";
            using MySqlConnection connection = new MySqlConnection(serverConnection);
            var copies = connection.Query<Copy>
                ("SELECT * FROM copy");
            return copies;
        }
    }
}