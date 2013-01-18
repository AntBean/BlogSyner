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
    public partial class BlogConfigWizard : Form
    {
        String[] blogproviders = {"网易博客","新浪博客"};

        bool auth;

        IBlog blog;

        /***
 *    0. wordpress.com站点 http://your_account.wordpress.com/xmlrpc.php
      1. 博客园cnblogs http://www.cnblogs.com/your_account/services/metaweblog.aspx
      2. 新浪博客 http://upload.move.blog.sina.com.cn/blog_rebuild/blog/xmlrpc.php
      3. 网易博客 http://os.blog.163.com/api/xmlrpc/metaweblog/
      4. 自建Wordpress站点 http://your_blog_server/xmlrpc.php
      5. 自建zBlog站点 http://your.zblog.site/xml-rpc/index.asp
 */

        public BlogConfigWizard()
        {
            InitializeComponent();

            blogbox.Items.AddRange(blogproviders);

            blogbox.Text = "新浪博客";
        }

        public int SelectedIndex
        {
            get {
                return this.freeWizard1.SelectedIndex;
            }
            set
            {
                updateSelectedIndex(value);

                this.freeWizard1.SelectedIndex = value;
            }
        }

        public String Provider
        {
            get {
                return blogbox.Text;
            }
        }

        public String AccountName
        {
            get {
                return usernamebox.Text;
            }
        }

        public String Password
        {
            get
            {
                return passwdbox.Text;
            }
        }

        public String Url
        {
            get {
                return urlbox.Text;
            }
        }

        public bool Auth
        {
            get {
                return auth;
            }
        }

        public IBlog Blog
        {
            get {
                return blog;
            }
        }

        private void prevbtn_Click(object sender, EventArgs e)
        {
            if (this.SelectedIndex > 0)
                this.SelectedIndex = this.SelectedIndex - 1;
        }


        private void updateSelectedIndex(int idx)
        {
            if (idx == 0)
                this.prevbtn.Enabled = false;
            else 
                this.prevbtn.Enabled = true;

            if (idx == this.freeWizard1.TabCount - 1)
                this.nextbtn.Text = "确定";
            else
                this.nextbtn.Text = "下一步";

        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            if (this.SelectedIndex < this.freeWizard1.TabCount - 1)
                this.SelectedIndex = this.SelectedIndex + 1;

            else if (this.SelectedIndex == this.freeWizard1.TabCount - 1)
            {
                try
                {
                    blog = BlogFactory.createBlogger(blogbox.Text);

                    auth = blog.authenticate(usernamebox.Text, passwdbox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("博客连接失败 在继续之前请先处理下面的异常\r\n"+ex.Message);

                    auth = false;
                }

                if (auth)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
