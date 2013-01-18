using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Itenso.Rtf;
using Itenso.Rtf.Converter.Html;
using Itenso.Rtf.Support;
using Itenso.Rtf.Converter.Image;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.IO;
using mshtml;
using System.Data.SQLite;
using System.Net;

namespace BlogSyner
{
    /***
     * @Tofix: 添加 editor的滚动条支持
     * 
     *****/



    public partial class Form1 : Form
    {

        private FreeTextEditor.FreeTextEditor editor;
        private SourceEditor srceditor;

        private String filepath = "Data\\ConfigData";
        private String conn_passwd = "123456";


        private List<String> account_url;
        private List<String> account_pwd;
        private List<String> account_name;

        private IBlog blog;
        private AccountInfo curinfo;
        private PostInfo postinfo;

        private BlogStatus status;

        private String conn_str;

        public Form1()
        {
            InitializeComponent();

            editor = new FreeTextEditor.FreeTextEditor();
            srceditor = new SourceEditor();

            //titlebox.Text = "输入日志标题";

            editor.Size = freeTabCtrl1.Size;
            freeTabCtrl1.addFreeTab(editor, "编辑");

            srceditor.Size = freeTabCtrl1.Size;
            freeTabCtrl1.addFreeTab(srceditor, "源码");

            account_url = new List<string>();
            account_pwd = new List<string>();
            account_name = new List<string>();

            timer1.Start();

            status = BlogStatus.New;

            //+ ";Password=" + conn_passwd
            conn_str = "Data Source=" + filepath ;

            if (!DataMgr.createDb())
            {
                //弹出配置界面

            }
        }

        //读取配置文件 看是否是初次启动 如果是 则要求添加账户
  /*      private bool readConfig()
        { 
            //检查数据库是否存在
            //System.Data.SQLite.SQLiteConnection.
            if (!File.Exists(filepath))
            {
                System.Data.SQLite.SQLiteConnection.CreateFile(filepath);

                SQLiteConnection conn = new SQLiteConnection(conn_str);
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand();

                //创建表
                String sql = "Create Table " + tablename + "(id integer primary key autoincrement,BlogUrl text, BlogName text, Provider text, AccountName text, Password text)";

                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                sql = "Create Table " + recenttable + "(PostId text, Title text, Digest text, DateTime text, AccountId text)";

                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                sql = "Create Table " + drafttable + "(Title text, BlogName text, Body text, DateTime text, AccountId text)";

                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                conn.Close();


                return false;
            }
            else
            {
                //+ ";Password="+passwd
                SQLiteConnection conn = new SQLiteConnection(conn_str );

                conn.Open();

                SQLiteCommand cmd = new SQLiteCommand();

                //查询表
                String sql = "Select id,BlogUrl,Provider,AccountName,Password from " + tablename;

                cmd.CommandText = sql;
                cmd.Connection = conn;
                SQLiteDataReader datareader = cmd.ExecuteReader();

                while(datareader.Read())
                {
                    String url = datareader.GetString(datareader.GetOrdinal("BlogUrl"));

                    String name = datareader.GetString(datareader.GetOrdinal("AccountName"));

                    String pwd = datareader.GetString(datareader.GetOrdinal("Password"));

                    account_url.Add(url);
                    account_pwd.Add(pwd);
                    account_name.Add(name);

                    MessageBox.Show(url+" "+pwd + " "+name);
                }

                conn.Close();

                return true;
            }


        }*/



        public Image resizeImage(string orig_pic, int width)
        {
            Bitmap origBitmap = new System.Drawing.Bitmap(orig_pic);

            int height = (int)((((double)width) / origBitmap.Width) * origBitmap.Height);

            Bitmap newBitmap = new System.Drawing.Bitmap(origBitmap, width, height);

            return newBitmap;
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
          //  e.LinkText;
            MessageBox.Show(e.LinkText);

            String[] url = e.LinkText.Split('#');

            MessageBox.Show(url[1]);

            //System.Diagnostics.Process p = new System.Diagnostics.Process();

            System.Diagnostics.Process.Start("IExplore.exe", url[1]);
        }


        /***
         *    0. wordpress.com站点 http://your_account.wordpress.com/xmlrpc.php
              1. 博客园cnblogs http://www.cnblogs.com/your_account/services/metaweblog.aspx
              2. 新浪博客 http://upload.move.blog.sina.com.cn/blog_rebuild/blog/xmlrpc.php
              3. 网易博客 http://os.blog.163.com/api/xmlrpc/metaweblog/
              4. 自建Wordpress站点 http://your_blog_server/xmlrpc.php
              5. 自建zBlog站点 http://your.zblog.site/xml-rpc/index.asp
         */

        private void publishbtn_Click(object sender, EventArgs e)
        {

            JoeBlogs.MetaWeblogWrapper metablog = new JoeBlogs.MetaWeblogWrapper
                ("http://upload.move.blog.sina.com.cn/blog_rebuild/blog/xmlrpc.php", "wangerwuya@gmail.com", "123456");

            JoeBlogs.Post post = new JoeBlogs.Post();

            //  post.title = "2013";
            post.Title = "2013";

            try
            {
                metablog.NewPost(post, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("发布日志失败 " + ex.Message);
            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            srceditor.SourceText = editor.HtmlText;
        }

        private void blogbtn_Click(object sender, EventArgs e)
        {
            /*UpdateAccoutDlg updateDlg = new UpdateAccoutDlg();

            updateDlg.ShowDialog();*/

            BlogConfigWizard wizard = new BlogConfigWizard();

            if (wizard.ShowDialog() == DialogResult.OK)
            { 

                if (wizard.Auth)
                { 
                    //titlelabel.Text = wizard.u
                    //WebBrowser browser = new WebBrowser();
                    //browser.Navigate(wizard.Url);
                    //browser.Url = new Uri(wizard.Url);
                    blog = wizard.Blog;

                    HttpWebRequest request = WebRequest.Create(wizard.Url) as HttpWebRequest;
                    request.Method = "GET";  

                    HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                    System.IO.Stream respStream = response.GetResponseStream();

                    string htmltext;
                    // Dim reader As StreamReader = New StreamReader(respStream)
                    using (System.IO.StreamReader reader = new System.IO.StreamReader(respStream)
                        )
                    {
                        htmltext = reader.ReadToEnd();
                    }

                    //titlelabel.Text = title;
                    //browser.DocumentText = htmltext;
                    //string title = 
                   // browser.
                    //browser.DocumentText = response.ToString();

                  //  HtmlDocument doc = new HtmlDocument();
                  //  doc.lo
                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(htmltext);
                    HtmlAgilityPack.HtmlNodeCollection nodes =  doc.DocumentNode.SelectNodes("/html/head/title");
                    //string title = browser.DocumentTitle;
                    titlelabel.Text =  nodes[0].InnerText ;

                    //将password account
                    DataMgr.addAccount(wizard.AccountName, wizard.Password, wizard.Url, 
                        wizard.Provider, titlelabel.Text);
                }
            }
        }

        private void publishbtn_Click_1(object sender, EventArgs e)
        {
            if (blog == null)
            {
                MessageBox.Show("请先在博客设置中添加您的博客账户");
            }
            else
            {
                if (status == BlogStatus.New)
                {
                    string content = editor.HtmlText;
                    try
                    {
                        string postid = blog.newPost(titlebox.Text, content);
                        MessageBox.Show("博客发布成功!");

                        //更新Recently Posted
                        string digest = "";
                        digest = getDigest(editor.InnerText);

                        DataMgr.addRecentlyPosted(titlebox.Text, digest, postid+"", 
                            DateTime.Now.ToLocalTime().ToString(), 
                            curinfo.account_id, curinfo.blogname);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("由于以下原因发布博客出错\r\n" + ex.Message);
                    }
                }
                else if (status == BlogStatus.Old)
                {
                    string content = editor.HtmlText;
                    try
                    {
                        blog.editPost(postinfo.postid, titlebox.Text, content);
                       
                        MessageBox.Show("博客修改成功!");

                        //更新Recently Posted
                        string digest = "";
                        digest = getDigest(editor.InnerText);

 //                       DataMgr.addRecentlyPosted(titlebox.Text, digest, postinfo.postid + "",
  //                          DateTime.Now.ToLocalTime().ToString(), curinfo.account_id);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("由于以下原因发布博客修改失败\r\n" + ex.Message);
                    }
                }
            }
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            status = BlogStatus.New;

            editor.HtmlText = "";

        }





        public void changeAccount(String id)
        {

            curinfo = DataMgr.getAccountById(id);

            if (curinfo.provider != "")
            {
                blog = BlogFactory.createBlogger(curinfo.provider);
                blog.authenticate(curinfo.username, curinfo.password);
                titlelabel.Text = curinfo.blogname;
            }
            else
                MessageBox.Show("切换账户出错！\r\n");

        }


        private String getDigest(String body)
        {
            String digest;

            if (body.Length > 10)
                digest = body.Substring(0, 10);
            else
                digest = body;

            return digest;
        }

        private void draftbtn_Click(object sender, EventArgs e)
        {
            //直接保存到数据库
            DataMgr.addDraft(titlebox.Text, titlelabel.Text, editor.HtmlText, 
                DateTime.Now.ToLocalTime().ToString(), curinfo.account_id);
        }

        private void openbtn_Click(object sender, EventArgs e)
        {
            List<AccountInfo> infolist = DataMgr.getAllAccount();
            List<DraftInfo> draftlist = DataMgr.getAllDraft();
            List<RecentInfo> recentlist = DataMgr.getAllRecent();

            if ((infolist == null) || (infolist.Count == 0))
                MessageBox.Show("请先在博客设置中添加博客账户");
            else
            {
                OpenBlogDlg openDlg = new OpenBlogDlg(infolist, draftlist, recentlist);

                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    if (openDlg.Catagory == OpenCatagory.Blog)
                    { 
                        //修改当前的IBlog 和 账户
                        blog = openDlg.Blog;
                        curinfo = openDlg.Account;

                        titlelabel.Text = curinfo.blogname;

                        postinfo = openDlg.Post;

                        titlebox.Text = postinfo.title;
                        editor.HtmlText = postinfo.text;
                        status = postinfo.status;
                    }
                }
            }
        }
    }
}
