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
    public partial class FloatForm : Form
    {
        public FloatForm()
        {
            InitializeComponent();
        }

        private void FloatForm_Load(object sender, EventArgs e)
        {
            wb.Navigate("http://www.youtube.com/v/UOueMzKYbP0?version=3&autoplay=1&fs=0");
        }
    }
}
