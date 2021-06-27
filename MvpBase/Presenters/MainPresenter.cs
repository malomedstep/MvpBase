using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvpBase.Infrastructure;
using MvpBase.Models;
using MvpBase.Views;

namespace MvpBase.Presenters
{
    public class MainPresenter
    {
        private readonly IBookRepository _repo;
        private readonly IBookView _view;
        public MainPresenter(IBookRepository repo, IBookView view)
        {
            _repo = repo;
            _view = view;

            _view.AddBook += ViewOnAddBook;
            _view.RemoveBook += ViewOnRemoveBook;
            _view.ShowBookInfo += ViewOnShowBookInfo;

            UpdateBookList();

            
        }

        private void UpdateBookList()
        {
            var books = _repo.GetAllBooks();
            _view.PopulateBooksList(books);
        }

        private void ViewOnRemoveBook(object? sender, BookEventArgs e)
        {
            _repo.DeleteBook(e.Book.Id);
            UpdateBookList();
        }

        private void ViewOnShowBookInfo(object? sender, BookEventArgs e)
        {
            WindowManager.Instance.ShowBookInfoDialog(e.Book);
        }

        private void ViewOnAddBook(object? sender, BookEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.Book.Author))
            {
                WindowManager.Instance.ShowError("Author is required");
            }
            else if (string.IsNullOrWhiteSpace(e.Book.Title))
            {
                WindowManager.Instance.ShowError("Title is required");
            }
            else
            {
                _repo.AddBook(e.Book);
                UpdateBookList();
                _view.ClearInputs();
            }
        }
    }
}
