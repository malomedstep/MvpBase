using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvpBase.Models;

namespace MvpBase.Views
{
    public class BookEventArgs : EventArgs
    {
        public BookEventArgs(Book book)
        {
            Book = book;
        }

        public Book Book { get; }
    }

    public interface IBookView
    {
        void PopulateBooksList(IEnumerable<Book> books);
        void ClearInputs();
        event EventHandler<BookEventArgs> AddBook;
        event EventHandler<BookEventArgs> RemoveBook;
        event EventHandler<BookEventArgs> ShowBookInfo;
    }
}
