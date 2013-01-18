using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlogSyner
{
    public partial class SourceEditor : UserControl
    {
       // private String text;

        public SourceEditor()
        {
            InitializeComponent();

         //   textBox1.Enabled = false;
        }

        protected override void OnResize(EventArgs e)
        {
            textBox1.Size = this.Size;

            base.OnResize(e);
        }

        public String SourceText
        {
            get {
                return textBox1.Text;
            }

            set
            {
                textBox1.Text = value; 
            }
        }
    }
}
