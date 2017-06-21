using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ffmpegConverter
{
    public partial class ProgressBarForm : Form
    {
        public ProgressBarForm()
        {
            InitializeComponent();
        }

        private void ProgressBarForm_Load(object sender, EventArgs e)
        {
            this.FormClosing += (e2, sender2) => this.Dispose(); ;
        }

        public ProgressBar FileprogressBar { get { return FileProgressBar; } set { } }
        public Label Filenamelabel { get { return FileNameLabel; } set { } }
        public Label ProgressrateLabel { get { return ProgressRateLabel; } set { } }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
