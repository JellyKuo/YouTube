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
    public partial class ConverterForm : Form
    {
        public ConverterForm()
        {
            InitializeComponent();
        }

        BindingList<string> filelist = new BindingList<string>();
        Process proc = new Process() { EnableRaisingEvents = true };
        bool processcacenl = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            filelistBox.AllowDrop = true;
            FormatBox.Text = "(Default)";
            filelistBox.SelectionMode = SelectionMode.MultiExtended;
            openFileDialog1.Multiselect = true;
            remindlb.Parent = filelistBox;
            remindlb.BackColor = Color.Transparent;
            remindlb.Location = new Point(filelistBox.Location.X - 8, filelistBox.Location.Y - 10);
            filelist.ListChanged += (sender2, e2) =>
              {
                  //if (filelistBox.Items.Count == 0 && filelistBox.Enabled == false)
                  //    filelistBox.Enabled = true;
                  if (filelistBox.Items.Count == 0)
                      remindlb.Visible = true;
              };
        }

        private void FilelistBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
                e.Effect = DragDropEffects.All;
        }

        private void FilelistBox_DragDrop(object sender, DragEventArgs e)
        {
            remindlb.Visible = false;
            string[] filepaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string filepath in filepaths)
            {
                filelistBox.Items.Add(filepath);
                filelist.Add(filepath);
            }
            if (AutoConvertBox.Checked)
            {
                if (check())
                    Convert();
            }
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
            if (filelistBox.Items.Count != 0)
                remindlb.Visible = false;
            openFileDialog1.Dispose();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (check())
                Convert();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && filelistBox.Items.Count > 0)
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

        private void AutoConvertBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoConvertBox.Checked && filelistBox.Items.Count != 0)
            {
                remindlb.Visible = false;
                ConvertButton.Enabled = false;
                if (check())
                    Convert();
            }
            else if (!AutoConvertBox.Checked)
                ConvertButton.Enabled = true;

        }

        private void OuputPathbtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                OutputPathBox.Text = folderBrowserDialog1.SelectedPath;
            folderBrowserDialog1.Dispose();
            folderBrowserDialog1 = new FolderBrowserDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pbf = new ProgressBarForm();
            pbf.Show();
        }

        private async Task<bool> ConvertProcess()
        {
            try
            {
                if (filelistBox.Items.Count <= 0)
                    return false;
                string arg = "", filepath = "", filename = "", outputpath = "";
                filepath = filelist[0];
                filename = Path.GetFileNameWithoutExtension(filepath);
                outputpath = @OutputPathBox.Text + "\\" + Path.GetFileNameWithoutExtension(filelist[0]) + FormatBox.Text;
                arg = @" -i " + '"' + filepath + '"' + " " //input
                    + '"' + OutputPathBox.Text + "\\" + filename + FormatBox.Text + '"' //output
                    ;
                proc.StartInfo = new ProcessStartInfo
                {
                    FileName = "ffmpeg.exe",
                    Arguments = arg,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                };
                if (!processcacenl)
                    await Task.Run(() =>
                    {
                        proc.Start();
                        proc.WaitForExit();
                    });
                else
                {
                    processcacenl = false;
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private async void Convert()
        {
            string filepath = "", filename = "", outputpath = "";
            filepath = filelist[0];
            filename = Path.GetFileNameWithoutExtension(filepath);
            outputpath = @OutputPathBox.Text + "\\" + Path.GetFileNameWithoutExtension(filelist[0]) + FormatBox.Text;
            var pbf = new ProgressBarForm();
            pbf.FileprogressBar.Maximum = filelistBox.Items.Count;
            pbf.FileprogressBar.Value = 0;
            pbf.Disposed += (sender, e) =>
            {
                proc.Kill();
                processcacenl = true;
            };
            pbf.Cancelbtn.Click += (sender, e) =>
              {
                  processcacenl = true;
                  try { throw new Exception("ProcessCancel"); }
                  catch (Exception ex) { MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
              };
            pbf.Show();
            if (File.Exists(outputpath))
            {
                var fef = new FileExistForm();
                fef.Replacebtn.Click += (sender, e) =>
                {
                    File.Delete(outputpath);
                    fef.Dispose();
                    pbf.Dispose();
                    Convert();
                };
                fef.Skipbtn.Click += (sender, e) =>
                {
                    filelistBox.Items.Remove(filelist[0]);
                    filelist.RemoveAt(0);
                    fef.Dispose();
                    pbf.Dispose();
                };
                fef.ReplaceAllbtn.Click += (sender, e) =>
                {
                    File.Delete(outputpath);
                    fef.Dispose();
                    pbf.Dispose();
                    Convert();
                };
                fef.Show();
                return;
            }
            while (filelistBox.Items.Count > 0)
            {
                pbf.Filenamelabel.Text = filelist[0];
                pbf.ProgressrateLabel.Text = "Finished : " + pbf.FileprogressBar.Value.ToString() + "/" + pbf.FileprogressBar.Maximum.ToString();
                if (await ConvertProcess())
                {
                    if (!processcacenl)
                    {
                        filelistBox.Items.Remove(filelist[0]);
                        filelist.RemoveAt(0);
                        pbf.FileprogressBar.Value += 1;
                    }
                    if (pbf.FileprogressBar.Value == pbf.FileprogressBar.Maximum)
                        pbf.Dispose();
                }
                else
                {
                    proc = new Process() { EnableRaisingEvents = true };
                    return;
                }
            }
            if (filelistBox.Items.Count == 0)
                remindlb.Visible = true;
        }

        private bool check()
        {
            try
            {
                if (OutputPathBox.Text == "")
                    throw new Exception("NoOutputPath");
                if (FormatBox.Text == "(Default)")
                    throw new Exception("NoSelectedFormat");
                if (filelistBox.Items.Count == 0)
                    return false;
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}