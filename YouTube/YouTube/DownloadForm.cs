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

        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProvider.ExitApp(null, null);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormProvider.ExitApp(null, null);
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
            var ex = Check();
            if (ex != null)
                MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                Start();
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
            menuStrip1.Items.Add(debugToolStripMenuItem);

            ToolStripMenuItem debugDownloadToolStripMenuItem = new ToolStripMenuItem()
            {
                Name = "debugDownloadToolStripMenuItem",
                Text = "Download"
            };
            debugDownloadToolStripMenuItem.Click += (sender,e) =>
            {
                throw new NotImplementedException("Add automatic value setting and sending");
                Download();  
            };
            debugToolStripMenuItem.DropDown.Items.Add(debugDownloadToolStripMenuItem);
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

        private void Start()
        {

        }

        private void Download()
        {
            string Url;
            if (urlRadio.Checked)
                Url = inputBox.Text;
            else
                Url = @"https://www.youtube.com/watch?v=" + inputBox.Text;
            Downloader Downloader = new Downloader(Url, formatBox.Text, int.Parse(quaBox.Text), outputBox.Text, useTitleAsNameBox.Checked);
            throw new NotImplementedException("I haven't completed yet!");
        }

        
    }
}