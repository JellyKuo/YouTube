using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace YouTube
{
    public partial class DownloadForm : Form
    {
        public DownloadForm()
        {
            InitializeComponent();

#if DEBUG
            Console.WriteLine("Debug 組態");
            DebugTool();
#else
            Console.WriteLine("Release 組態");
#endif
        }

        #region 表單控制項

        private void 影片搜尋器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form SearchForm = new SearchForm();
            //SearchForm.Show();
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Exit();
        }

        private void formatBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (formatBox.SelectedIndex)
            {
                case 0:
                    bitrateLabel.Visible = true;
                    bitrateBox.Visible = true;
                    quaLabel.Visible = false;
                    quaBox.Visible = false;
                    bestCheck.Visible = false; //TODO: Add best
                    break;
                case 1:
                    bitrateLabel.Visible = false;
                    bitrateBox.Visible = false;
                    quaLabel.Visible = true;
                    quaBox.Visible = true;
                    bestCheck.Visible = false;
                    break;
            }
        }

        private void bestBitrateCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (bestCheck.Checked)
                bitrateBox.Enabled = false;
            else
                bestCheck.Enabled = true;
        }

        private void selOutButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            if (useTitleAsNameBox.Checked)
            {
                if (fbd.ShowDialog() != DialogResult.OK)
                    return;
                outputBox.Text = fbd.SelectedPath;
            }
            else
            {
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;
                outputBox.Text = sfd.FileName;
                switch (sfd.FilterIndex)
                {
                    case 1:
                        formatBox.SelectedIndex = 0;
                        break;
                    case 2:
                        formatBox.SelectedIndex = 1;
                        break;
                }
            }
        }

        private void useTitleAsNameBox_CheckedChanged(object sender, EventArgs e)
        {
            outputBox.Text = "";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Exception ex = Check();
            //if (ex != null)
                //MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //else
                //Start();
        }

        #endregion

        #region Debug 
        [Conditional("DEBUG")]
        private void DebugTool()
        {
            ToolStripMenuItem debugToolStripMenuItem = new ToolStripMenuItem()
            {
                Name = "debugToolStripMenuItem",
                Text = "Debug",
                BackColor = Color.LightPink,
            };
            ToolStripMenuItem convertToolStripMenuItem = new ToolStripMenuItem()
            {
                Name = "convertToolStripMenyItem",
                Text = "Convert"
            };
            menuStrip1.Items.Add(debugToolStripMenuItem);
            debugToolStripMenuItem.DropDown.Items.Add(convertToolStripMenuItem);
            
        }

        #endregion

        private Exception Check()
        {
            if (!(urlRadio.Checked || idRadio.Checked))
                return new Exception("未選取輸入類別");
            if (inputBox.Text == "")
                return new Exception("輸入項為空");
            if (outputBox.Text == "")
                return new Exception("輸出項為空");
            if (formatBox.Text == "")
                return new Exception("檔案格式未填選");
            if (quaBox.Visible && quaBox.Text == "")
                return new Exception("品質未填選");
            if (bitrateBox.Visible && bitrateBox.Text == "")
                return new Exception("位元率未填選");
            return null;
        }
        /*
        private async void Start()
        {
            progressBar.Style = ProgressBarStyle.Marquee;
            ToggleControls(false);

            statLabel.Text = "下載程序進行中";
            YTVideo vid = await Download();

            statLabel.Text = "轉檔程序進行中";
            string output = outputBox.Text;
            if (useTitleAsNameBox.Checked)
                if (outputBox.Text.EndsWith("\\"))
                    output += vid.GetFileFriendlyTitle() + vid.fileExt;
                else
                    output += "\\" + vid.GetFileFriendlyTitle() + vid.fileExt;
            Convert(vid, output);

            statLabel.Text = "清理暫存檔中";
            CleanUp();

            ToggleControls(true);
            progressBar.Value = 0;
            progressBar.Style = ProgressBarStyle.Continuous;
            statLabel.Text = "就緒";
        }

        private async Task<YTVideo> Download()
        {
            string url;
            if (urlRadio.Checked == true)
                url = inputBox.Text;
            else if (idRadio.Checked == true)
                url = "https://youtube.com/watch?v=" + inputBox.Text;
            else
                throw new Exception("Input is empty");

            Downloader dl = new Downloader()
            {
                url = url
            };
            return await dl.ExecuteDownload();
        }

        private void Convert(YTVideo vid, string output)
        {
            Converter con = new Converter()
            {
                Video = vid.Video,
                FileFormat = formatBox.Text,
                AudioBitrate = bitrateBox.Text,
                VideoQuality = quaBox.Text,
                OutputFile = output
            };
            con.WriteByteToFile();
            con.ExecuteConvert();
        }

        private void Exit()
        {
            CleanUp();
            Application.Exit();
        }

        private void CleanUp()
        {
            if (File.Exists("Temp.mp4"))
                File.Delete("Temp.mp4");
            Dispose();
        }

        private void ToggleControls(bool toggle)
        {
            inpGroup.Enabled = toggle;
            outGroup.Enabled = toggle;
            startButton.Enabled = toggle;
        }*/

        #region ProgressBar

        public void PrepareProgressBar(bool arg)
        {
            if (arg)
            {
                progressBar.Style = ProgressBarStyle.Continuous;
                progressBar.Value = 0;
            }
            else
            {
                progressBar.Value = 0;
                progressBar.Style = ProgressBarStyle.Marquee;
            }
        }
        public void UpdateProgress(int percent)
        {
            progressBar.Value = percent;
        }

#endregion
    }
}