using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTube
{
    class WindowProvider
    {
        private static MainWindow _MainWindow;
        private static DownloadWindow _DownloadWindow;
        private static BrowserWindow _BrowserWindow;
        private static QueueWindow _QueueWindow;

        public static MainWindow MainWindow
        {
            get
            {
                if (_MainWindow == null)
                    _MainWindow = new MainWindow();
                return _MainWindow;
            }
        }

        public static DownloadWindow DownloadWindow
        {
            get
            {
                if (_DownloadWindow == null)
                    _DownloadWindow = new DownloadWindow();
                return _DownloadWindow;
            }
        }

        public static BrowserWindow BrowserWindow
        {
            get
            {
                if (_BrowserWindow == null)
                    _BrowserWindow = new BrowserWindow();
                return _BrowserWindow;
            }
        }

        public static QueueWindow QueueWindow
        {
            get
            {
                if (_QueueWindow == null)
                    _QueueWindow = new QueueWindow();
                return _QueueWindow;
            }
        }
    }
}
