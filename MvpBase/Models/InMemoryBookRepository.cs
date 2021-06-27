using System;
using System.Collections.Generic;
using System.Linq;

namespace MvpBase.Models
{
    public class InMemoryBookRepository : IBookRepository
    {
        private List<Book> _books = new ();

        public InMemoryBookRepository(IEnumerable<Book> books)
        {
            _books.AddRange(books);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _books.ToList();
        }
        public Book FindBook(string id)
        {
            return _books.FirstOrDefault(b => b.Id == id);
        }
        public Book AddBook(Book book)
        {
            book.Id = Guid.NewGuid().ToString();
            _books.Add(book);
            return book;
        }
        public void DeleteBook(string id)
        {
            var book = FindBook(id);
            if (book is not null)
            {
                _books.Remove(book);
            }
        }
    }
}
