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
    public partial class FileExistForm : Form
    {
        public Label Pathlb { get { return pathlb; }set { } }
        public Button Replacebtn { get { return replacebtn; }set { } }
        public Button Skipbtn { get { return skipbtn; }set { } }
        public Button ReplaceAllbtn { get { return replaceallbtn; } set { } }

        public FileExistForm()
        {
            InitializeComponent();
        }
    }
}
