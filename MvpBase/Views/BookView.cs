using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MvpBase.Models;
using MvpBase.Views;

namespace MvpBase
{
    public partial class BookView : Form, IBookView
    {
        public BookView()
        {
            InitializeComponent();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            var book = new Book
            {
                Title = _titleTextBox.Text,
                Author = _authorTextBox.Text
            };
            AddBook?.Invoke(this, new BookEventArgs(book));

        }

        private void RemoveBookButton_Click(object sender, EventArgs e)
        {
            var book = _booksListBox.SelectedItem as Book;
            RemoveBook?.Invoke(this, new BookEventArgs(book));
        }

        public void PopulateBooksList(IEnumerable<Book> books)
        {
            _booksListBox.DataSource = books;
        }

        public void ClearInputs()
        {
            _authorTextBox.Clear();
            _titleTextBox.Clear();
        }

        public event EventHandler<BookEventArgs> AddBook;
        public event EventHandler<BookEventArgs> RemoveBook;
        public event EventHandler<BookEventArgs> ShowBookInfo;

        private void BooksListBox_DoubleClick(object sender, EventArgs e)
        {
            if (_booksListBox.SelectedItem is Book book)
            {
                ShowBookInfo?.Invoke(this, new BookEventArgs(book));
            }
        }
    }
}
