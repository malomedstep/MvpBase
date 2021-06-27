using System;
using System.Windows.Forms;
using MvpBase.Models;
using MvpBase.Presenters;
using MvpBase.Views;

namespace MvpBase.Infrastructure
{
    public class DefaultWindowManager : WindowManager
    {
        public override void ShowMainDialog()
        {
            var view = new BookView();
            var books = new[]
            {
                new Book
                {
                    Id = Guid.NewGuid().ToString(),
                    Author = "Jeffrey Richter",
                    Title = "CLR via C#"
                },
                new Book
                {
                    Id = Guid.NewGuid().ToString(),
                    Author = "Nahid Jamalli",
                    Title = "C programming language"
                }
            };
            var repo = new InMemoryBookRepository(books);
            var presenter = new MainPresenter(repo, view);

            Application.Run(view);
        }

        public override void ShowBookInfoDialog(Book book)
        {
            var view = new BookInfoView();
            var presenter = new BookInfoPresenter(view, book);
            view.ShowDialog();
        }

        public override void ShowError(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK);
        }
    }
}