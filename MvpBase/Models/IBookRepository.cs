using System.Collections.Generic;

namespace MvpBase.Models
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();
        Book FindBook(string id);
        Book AddBook(Book book);
        void DeleteBook(string id);
    }
}
