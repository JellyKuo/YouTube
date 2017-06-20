using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTube
{
    class FormProvider
    {
        public static BrowserForm BrowserForm
        {
            get
            {
                if (_BrowserForm == null || _BrowserForm.IsDisposed)
                {
                    _BrowserForm = new BrowserForm();
                    _BrowserForm.FormClosing += FormProvider.ExitApp;
                }
                return _BrowserForm;
            }
        }
        private static BrowserForm _BrowserForm;

        public static void ExitApp(object sender, System.Windows.Forms.FormClosingEventArgs e)  //關閉應用程式
        {
            Console.WriteLine("呼叫關閉!");
            Environment.Exit(0);
        }
    }
}
