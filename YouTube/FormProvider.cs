using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTube
{
    class FormProvider
    {
        public static MainForm MainForm
        {
            get
            {
                if (_MainForm == null || _MainForm.IsDisposed)
                {
                    _MainForm = new MainForm();
                    _MainForm.FormClosing += FormProvider.ExitApp;
                }
                return _MainForm;
            }
        }
        private static MainForm _MainForm;

        public static void ExitApp(object sender, System.Windows.Forms.FormClosingEventArgs e)  //關閉應用程式
        {
            Console.WriteLine("呼叫關閉!");
            Environment.Exit(0);
        }
    }
}
