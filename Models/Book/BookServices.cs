using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Data.SqlClient;

namespace Bookish.Models.Book

{
    using Dapper;

    public class BookServices
    {
        public class Book
        {
            public int Id { get; set; }
            public int AuthorId { get; set; }
            public string Title { get; set; }
            public string Isbn { get; set; }
            public int OriginalPublicationYear { get; set; }

        }
        public static IEnumerable<Book> GetBook()
        {
            string serverConnection = "Server=localhost;Port=3306;Database=bookishdb;Uid=root;Pwd=Astrid2014;";
            using SqlConnection connection = new SqlConnection(serverConnection);
            var books = connection.Query<Book>("SELECT * FROM Book");
            return books;
        }

    }

}


