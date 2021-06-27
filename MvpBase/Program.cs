using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using MvpBase.Infrastructure;
using MvpBase.Models;
using MvpBase.Presenters;

namespace MvpBase
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // WindowManager.SetInstance(new WpfWindowManager());
            // WindowManager.Instance.ShowMainDialog();

            WindowManager.SetInstance(new DefaultWindowManager());
        }
    }
}
