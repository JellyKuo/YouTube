using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTube
{
    public partial class BrowserForm : Form
    {
        public BrowserForm()
        {
            InitializeComponent();

            wb.CanGoBackChanged += (BackSender, BackE) => backButton.Enabled = wb.CanGoBack; ;
            wb.CanGoForwardChanged += (ForwardSender, ForwardE) => forwardButton.Enabled = true; ;
            wb.ProgressChanged += (ProgressSender, ProgressE) =>
            {
                if (ProgressE.MaximumProgress == 0)
                    ProgBar.Value = 0;
                else
                    ProgBar.Value = Convert.ToInt32(ProgressE.CurrentProgress / ProgressE.MaximumProgress * 100);
            };
            wb.ScriptErrorsSuppressed = true;

            urlBox.PreviewKeyDown += (PKDSender, PKDE) =>
            {
                if (PKDE.KeyCode == Keys.Enter)
                    Go(null, null);
            };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            urlBox.Text = "https://www.youtube.com.tw";
            Go(null, null);
        }

        private void Go(object sender, EventArgs e)
        {
            Console.WriteLine("Navigating " + urlBox.Text);
            wb.Navigate(urlBox.Text);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            wb.GoBack();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            wb.GoForward();
        }

        private void wb_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            ProgBar.Value = 0;
            string url = wb.Url.ToString();
            if(!urlBox.Focused)
                urlBox.Text = url;
            if (url.Contains("www.youtube.com/watch?v="))
            {
                string id = url.Substring(url.IndexOf("v=")+2);
                Console.WriteLine("Video Detected!, ID = "+ id);
                PopupPanel.Visible = true;
                openFloatButton.Click += (s, ev) =>
                {
                    FloatForm ff = new FloatForm(url);
                    ff.Show();
                };
            }
        }

        private void openFloatButton_Click(object sender, EventArgs e)
        {

        }
    }
}
