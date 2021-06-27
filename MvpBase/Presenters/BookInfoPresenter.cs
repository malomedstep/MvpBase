using MvpBase.Models;
using MvpBase.Views;

namespace MvpBase.Presenters
{
    public class BookInfoPresenter
    {
        private IBookInfoView _view;

        public BookInfoPresenter(IBookInfoView view, Book book)
        {
            _view = view;
            _view.ShowBookInfo(book);
        }
    }
}
