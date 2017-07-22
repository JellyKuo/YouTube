using CefSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;

namespace YouTube
{
    /// <summary>
    /// App.xaml 的互動邏輯
    /// </summary>
    public partial class App : Application
    {
        public App()
        {

        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var settings = new CefSettings()
            {
                CachePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.InternetCache), "CefSharp\\Cache"),
                PersistSessionCookies = true,
                Locale = System.Globalization.CultureInfo.CurrentCulture.Name,
                PersistUserPreferences = true,
                UserDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CefSharp\\UserData"),
            };
            settings.SetOffScreenRenderingBestPerformanceArgs();
            Cef.Initialize(settings, true, null);
            BrowserWindow bw = new BrowserWindow();
            bw.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            Cef.Shutdown();
            base.OnExit(e);
        }

        
    }
}
