using System;
using System.Windows.Forms;
using MvpBase.Models;

namespace MvpBase.Views
{
    public partial class BookInfoView : Form, IBookInfoView
    {
        public BookInfoView()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ShowBookInfo(Book book)
        {
            _idTextBox.Text = book.Id;
            _authorTextBox.Text = book.Author;
            _titleTextBox.Text = book.Title;
        }
    }
}
