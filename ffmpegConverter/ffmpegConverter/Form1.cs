using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ffmpegConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> filelist = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            filelistBox.AllowDrop = true;
            InputButton.Text = "Input";
            ConvertButton.Text = "Convert";
            FormatBox.SelectedIndex = 1;
            filelistBox.SelectionMode = SelectionMode.MultiExtended;
            openFileDialog1.Multiselect = true;
            this.Text = "ffmpegConverter";
        }

        private void FilelistBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
                e.Effect = DragDropEffects.All;
        }

        private async void FilelistBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] filepaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string filepath in filepaths)
            {
                filelistBox.Items.Add(filepath);
                filelist.Add(filepath);
            }
            if (AutoConvertBox.Checked)
                if (OutputPathBox.Text == "")
                    throw new Exception("NoOutputPath");
                while (filelistBox.Items.Count > 0)
                    await Convert();
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string filepath in openFileDialog1.FileNames)
                {
                    filelistBox.Items.Add(filepath);
                    filelist.Add(filepath);
                }
            }
            openFileDialog1.Dispose();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;
        }

        private async void ConvertButton_Click(object sender, EventArgs e)
        {
            if (OutputPathBox.Text == "")
                throw new Exception("NoOutputPath");
            while (filelistBox.Items.Count > 0)
                await Convert();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                do
                {
                    filelist.Remove(filelistBox.SelectedItem.ToString());
                    filelistBox.Items.Remove(filelistBox.SelectedItem);
                }
                while (filelistBox.SelectedItems.Count != 0);
            else if (e.Control && e.KeyCode == Keys.A)
                for (int i = 0; i < filelistBox.Items.Count; i++)
                    filelistBox.SetSelected(i, true);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            filelistBox.ClearSelected();
        }

        private async void AutoConvertBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoConvertBox.Checked)
            {
                ConvertButton.Enabled = false;
                if (OutputPathBox.Text == "")
                    throw new Exception("NoOutputPath");
                while (filelistBox.Items.Count > 0)
                    await Convert();
            }
            else if (!AutoConvertBox.Checked)
                ConvertButton.Enabled = true;
        }

        private async Task<bool> Convert()
        {
            try
            {
                if (filelistBox.Items.Count <= 0)
                    return false;
                string filepath = "", filename = "";
                filepath = filelist[0];
                filename = Path.GetFileNameWithoutExtension(filepath);
                var proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "ffmpeg.exe",
                        Arguments = @" -i " + '"' + filepath + '"' + " " + '"' + OutputPathBox.Text + "\\" + filename + FormatBox.Text + '"',
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true,
                    },
                    EnableRaisingEvents = true,
                    
                };
                filelist.RemoveAt(0);
                filelistBox.Items.Remove(filepath);
                await Task.Run(() =>
                    {
                        proc.Start();
                        proc.WaitForExit();
                    });
                return true;
                //Process.Start("C:\\Users\\User\\Desktop\\ffmpeg.exe", " -i " + '"' + filepath + '"' + " " + '"' + "C:\\Users\\User\\Desktop\\ffmpegOutput\\" + filename + FormatBox.Text + '"');

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void OuputPathbtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                OutputPathBox.Text = folderBrowserDialog1.SelectedPath;
            folderBrowserDialog1.Dispose();
            folderBrowserDialog1 = new FolderBrowserDialog();
        }
    }
}