using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CefSharp;
using CefSharp.Wpf;

namespace YouTube
{
    /// <summary>
    /// BrowserWindow.xaml 的互動邏輯
    /// </summary>
    public partial class BrowserWindow : Window
    {
        public BrowserWindow()
        {
            InitializeComponent();
        }

        private void Browser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            Console.Write("Url: {0}",e.Url);
            UpdateUrlBox(e.Url);
        }

        private void UpdateUrlBox(string url)
        {
            Action act = () => UrlBox.Text = url;
            var dispatcher = UrlBox.Dispatcher;
            if (dispatcher.CheckAccess())
                act();
            else
                dispatcher.Invoke(act);
        }

        private void UrlBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter)
                return;
            Browser.Load(UrlBox.Text);
        }
    }
}
