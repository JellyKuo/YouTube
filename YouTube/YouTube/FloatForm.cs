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
        public FloatForm(string url)
        {
            InitializeComponent();
            wb.Navigate(url);
            this.Show();
        }

        private void FloatForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
