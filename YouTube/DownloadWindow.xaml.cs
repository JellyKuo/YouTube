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
        public DownloadWindow()
        {
            InitializeComponent();
            UseTitleAsNameCheck.Click += (sender, e) => OutBox.Text = "";
        }

        private void SfdBtn_Click(object sender, RoutedEventArgs e)
        {
            if (UseTitleAsNameCheck.IsChecked.Value)
            {
                using (var fbd = new System.Windows.Forms.FolderBrowserDialog() { ShowNewFolderButton = true})
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
    }
}
