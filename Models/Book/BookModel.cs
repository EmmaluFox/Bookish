using System.Collections.Generic;
using System.Linq;

namespace Bookish.Models.Book
{
    public class BookModel
    {
        public static string BookTable()
        {
            string htmlRows = $@"<tr>
                <th>Title</th>
                <th>Publication Year</th>
                <th>ISBN</th>
                </tr>";
            BookServices getBookList = new BookServices();
            IEnumerable<BookServices.Book> bookList = getBookList.GetBook();
            string title = "";
            int publicationYear;
            string isbn = "";
            foreach (var book in bookList)
            {
                title = book.Title;
                publicationYear = book.OriginalPublicationYear;
                isbn = book.Isbn;
                string htmlRow = 
                    $@"<tr>
                        <td>{title}</td>
                        <td>{publicationYear}</td>
                        <td>{isbn}</td>
                        </tr>";
                htmlRows = htmlRows + htmlRow;
            }

            return htmlRows;

        }
    }
}