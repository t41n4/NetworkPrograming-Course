using System;
using System.Windows.Forms;

namespace NT106.M21__Nhom09_55
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FormReadMail readMail = new FormReadMail();
            this.Hide();
            readMail.ShowDialog();
            this.Show();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            FormWriteMail writeMail = new FormWriteMail();
            this.Hide();
            writeMail.ShowDialog();
            this.Show();
        }
    }
}