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
    public partial class BlogTypeDlg : Form
    {
        private Form prevdlg;

        public BlogTypeDlg(Form prevDlg)
        {
            InitializeComponent();

            prevdlg = prevDlg;

            if (prevDlg == null)
            {
                prevbtn.Enabled = false;
            }
        }

        private void prevbtn_Click(object sender, EventArgs e)
        {
            this.Close();

            if (prevdlg != null)
                prevdlg.ShowDialog();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        //验证账户有效性 建立连接
        private void nextbtn_Click(object sender, EventArgs e)
        {

        }


        
    }
}
