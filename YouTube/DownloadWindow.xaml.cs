using Microsoft.Win32;
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

namespace YouTube
{
    /// <summary>
    /// DownloadWindow.xaml 的互動邏輯
    /// </summary>
    public partial class DownloadWindow : Window
    {
        QueueWindow qw = null;

        public DownloadWindow()
        {
            InitializeComponent();
            UseTitleAsNameCheck.Click += (sender, e) => OutBox.Text = "";
        }

        private void SfdBtn_Click(object sender, RoutedEventArgs e)
        {
            if (UseTitleAsNameCheck.IsChecked.Value)
            {
                using (var fbd = new System.Windows.Forms.FolderBrowserDialog() { ShowNewFolderButton = true })
                {
                    if (fbd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                        return;
                    OutBox.Text = fbd.SelectedPath;
                }
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog()
                {
                    Filter = "MP4 (*.mp4)|*.mp4|MP3 (*.mp3)|*mp3",
                    FilterIndex = 1
                };
                if (sfd.ShowDialog() != true)
                    return;
                OutBox.Text = sfd.FileName;
                FormatCombo.SelectedIndex = sfd.FilterIndex - 1;
            }
        }

        private void FormatCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            QualityCombo.Items.Clear();
            QualityCombo.Items.Add(new ComboBoxItem() { Content = "最高品質" });
            switch (FormatCombo.SelectedIndex)
            {
                case 0:
                    QualityCombo.Items.Add(new ComboBoxItem() { Content = "1080p" });
                    QualityCombo.Items.Add(new ComboBoxItem() { Content = "720p" });
                    QualityCombo.Items.Add(new ComboBoxItem() { Content = "480p" });
                    QualityCombo.Items.Add(new ComboBoxItem() { Content = "360p" });
                    QualityCombo.Items.Add(new ComboBoxItem() { Content = "240p" });
                    QualityCombo.Items.Add(new ComboBoxItem() { Content = "144p" });
                    break;
                case 1:
                    QualityCombo.Items.Add(new ComboBoxItem() { Content = "320kbps" });
                    QualityCombo.Items.Add(new ComboBoxItem() { Content = "256kbps" });
                    QualityCombo.Items.Add(new ComboBoxItem() { Content = "192kbps" });
                    QualityCombo.Items.Add(new ComboBoxItem() { Content = "128kbps" });
                    break;
            }
        }

        private void Enqueue()
        {
            var Ex = Check();
            if (Ex != null)
            {
                MessageBox.Show(Ex.Message, "操作錯誤", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            //TODO: Enqueue object
            string url = "";
            Work w = new Work(Work.Type.Download, "Name", url, OutBox.Text, Work.Format.MP4, QualityCombo.Text);
            Process.Queue.Add(w);
        }

        private InvalidOperationException Check()
        {
            if (!UrlRadio.IsChecked.Value && !VidIDRadio.IsChecked.Value)
                return new InvalidOperationException("請選擇輸入資料類型");
            if (InpBox.Text == "")
                return new InvalidOperationException("請輸入輸入資訊");
            if (OutBox.Text == "")
                return new InvalidOperationException("請輸入輸出位置");
            if(FormatCombo.Text =="")
                return new InvalidOperationException("請選擇輸出格式");
            if (QualityCombo.Text == "")
                return new InvalidOperationException("請選擇輸出品質");
            return null;
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            Enqueue();
        }

        private void EnqueueBtn_Click(object sender, RoutedEventArgs e)
        {
            if (qw == null)
            {
                qw = new QueueWindow();
                AdjustQueueWindow(null, null);
            }
            qw.Show();
            StartBtn.Content = "開始處理序列";
            //Audit Required
        }

        private void AdjustQueueWindow(object sender, EventArgs e)
        {
            if (qw != null)
            {
                qw.Top = Top;
                qw.Left = Left + Width - 10;
                qw.Height = Height;
                if (WindowState == WindowState.Minimized)
                    qw.WindowState = WindowState.Minimized;
                if (WindowState == WindowState.Normal)
                    qw.WindowState = WindowState.Normal;
            }
        }
    }
}
