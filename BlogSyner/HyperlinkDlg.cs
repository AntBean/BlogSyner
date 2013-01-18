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
    public partial class HyperlinkDlg : Form
    {
        private String hyperlink;
        private String hypertext;

        public HyperlinkDlg()
        {
            InitializeComponent();
        }

        public String Hyperlink {
            get {
                hyperlink = hyperdest.Text;

                return hyperlink;
            }
        }

        public String HyperText
        {
            get {
                hypertext = hypertitle.Text;

                return hypertext ;
            }
            set {
                hypertext = value;
                hypertitle.Text = hypertext;
            }
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
