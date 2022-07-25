using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106.M21._1_Lab04_Nhom9
{
    public partial class SourceHTML : Form
    {
        public SourceHTML()
        {
            InitializeComponent();
        }

        public SourceHTML(string source) : this()
        {
            rtbSource.Text = source;
        }

        private void rtbSource_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
