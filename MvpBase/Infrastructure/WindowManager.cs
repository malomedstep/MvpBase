using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvpBase.Models;

namespace MvpBase.Infrastructure
{
    public abstract class WindowManager
    {
        private static WindowManager _instance;
        public static WindowManager Instance => _instance;
        public static void SetInstance(WindowManager manager) => _instance = manager;

        public abstract void ShowMainDialog();
        public abstract void ShowBookInfoDialog(Book book);

        public abstract void ShowError(string error);
    }

}
