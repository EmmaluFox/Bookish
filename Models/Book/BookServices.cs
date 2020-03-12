using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Data.SqlClient;
using Bookish.Models.Author.Bookish.Models.Author;
using Bookish.Models.Copy;
using MySql.Data.MySqlClient;

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
            public string ImageUrl { get; set; }
            public string FirstNames { get; set; }
            public string LastName { get; set; }
            public int TotalCopies { get; set; }

        }
        public IEnumerable<Book> GetBook()
        {
            var server = "localhost";
            var database = "bookishdb";
            var uid = "EmmFox";
            var password = "Astrid2014";
            string serverConnection = "Server=" + server + ";" + "Database=" + 
                                      database + ";" + "Uid=" + uid + ";" + "Pwd=" + password + ";";
            using MySqlConnection connection = new MySqlConnection(serverConnection);
            var books = connection.Query<Book>
                ("SELECT * FROM Book LEFT JOIN Author ON Book.author_id = Author.id UNION SELECT * FROM Book RIGHT JOIN Author ON Book.author_id = Author.id UNION SELECT * FROM Book RIGHT JOIN Author ON Book.author_id = Author.id");
            foreach (var book in books)
            {
                CopyServices getCopies = new CopyServices();
                IEnumerable<CopyServices.Copy> copies = getCopies.GetCopy();
                int copyCount = 1;
                foreach (var copy in copies)
                {
                    if (copy.BookId == book.Id)
                    {
                        copyCount++;
                    }
                }

                book.TotalCopies = copyCount;

            }
            return books;
        }
        
    }

}


