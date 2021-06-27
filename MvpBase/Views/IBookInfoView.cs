using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvpBase.Models;

namespace MvpBase.Views
{
    public interface IBookInfoView
    {
        void ShowBookInfo(Book book);
    }
}
