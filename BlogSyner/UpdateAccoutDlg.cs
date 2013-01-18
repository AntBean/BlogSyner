using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlogSyner
{
    public partial class UpdateAccoutDlg : Form
    {
        public UpdateAccoutDlg()
        {
            InitializeComponent();
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            BlogTypeDlg blogTypeDlg = new BlogTypeDlg(this);

           // this.Hide();
            this.Close();

            blogTypeDlg.ShowDialog();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }
    }
}
