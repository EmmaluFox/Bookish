﻿using System.Collections.Generic;
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
        public IEnumerable<Book> GetBook()
        {
            var server = "127.0.0.1";
            var database = "bookishdb";
            var uid = "EmmFox";
            var password = "Astrid2014";
            string serverConnection = "Server=" + server + ";" + "Database=" + 
                                      database + ";" + "Uid=" + uid + ";" + "Pwd=" + password + ";";
            using SqlConnection connection = new SqlConnection(serverConnection);
            var books = connection.Query<Book>("SELECT * FROM Book");
            return books;
        }

    }

}


