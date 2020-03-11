using System.Data;
using System.Threading;

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
        public static void GetBook()
        {
            
        }

    }

}


