using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BlogSyner
{
    public enum OpenCatagory
    { 
        Draft,
        Recently,
        Blog
    };

    public struct PostInfo
    {
        public string title;
        public string text;
        public string postid;
        public BlogStatus status;//说明该blog publish的时候 到底是new呢 还是edit
    };

    public partial class OpenBlogDlg : Form
    {
        private IBlog blog;
        private List<AccountInfo> infolist;
        private List<DraftInfo> draftlist;
        private List<RecentInfo> recentlist;

        IEnumerable<JoeBlogs.Post> posts;
        private OpenCatagory catagory;
        private string accountid;
        private AccountInfo curinfo;
        private PostInfo postinfo;

        public OpenBlogDlg( List<AccountInfo> infos, List<DraftInfo> drafts, List<RecentInfo> recents)
        {
            InitializeComponent();

            infolist = infos;

            draftlist = drafts;

            recentlist = recents;

            InitCatagoryList();
        }

        public void InitCatagoryList()
        {
            if ((infolist == null) || (infolist.Count == 0))
                return;

            for (int i = 0; i <= infolist.Count - 1; i++)
            {
                catagorylist.Items.Add(i+"", infolist[i].blogname, 2);
            }

            catagorylist.Items[0].Selected = true;
        }

        private void catagorylist_SelectedIndexChanged(object sender, EventArgs e)
        {
           // freeWizard1.SelectedIndex = 1;
            if ((catagorylist.FocusedItem != null) && (catagorylist.FocusedItem.Index >= 2))
            {
                freeWizard1.SelectedIndex = 1;

                Thread thread = new Thread(fetchBlogThread);

                thread.Start();
            }
            else if ((catagorylist.FocusedItem != null) && (catagorylist.FocusedItem.Index == 1))
            {
                contentlist.Clear();

                if (recentlist != null && recentlist.Count != 0)
                {
                    for (int i = 0; i <= recentlist.Count - 1; i++)
                    {
                        RecentInfo recent = recentlist[i];

                        contentlist.Items.Add(i + "", recent.title + "  " +
                                recent.blogname + " " + recent.datetime, 0);
                    }
                }
            }
            else if ((catagorylist.FocusedItem != null) && (catagorylist.FocusedItem.Index == 0))
            {
                contentlist.Clear();

                if(draftlist != null && draftlist.Count != 0 )
                {
                    for (int i = 0; i <= draftlist.Count - 1; i++ )
                    {
                        DraftInfo draft = draftlist[i];

                        contentlist.Items.Add(i + "", draft.title + "  " +
                                draft.blogname +" "+ draft.datetime, 0);
                    }
                }
               
            }

        }

        public OpenCatagory Catagory
        {
            get {
                return catagory;
            }
        }

        public IBlog Blog
        {
            get {
                return blog;
            }
        }

        public AccountInfo Account
        {
            get {
                return curinfo;
            }
        }

        public PostInfo Post
        {
            get { 
                return postinfo;
            }
        }


        public void fetchBlogThread()
        {
            //开始获取blog数据
            String key="0";
                //= catagorylist.FocusedItem.Name;

            catagorylist.Invoke(
                (MethodInvoker)delegate {
                    key = catagorylist.FocusedItem.Name;
                }
                );


            int idx = int.Parse(key.Trim());



            blog = BlogFactory.createBlogger(infolist[idx].provider);

            blog.authenticate(infolist[idx].username, infolist[idx].password);

            posts = blog.getPost(20);

            //contentlist.Clear();

            contentlist.Invoke(
                (MethodInvoker)delegate {
                    contentlist.Clear();
                }
                );

            if (posts != null && posts.Count() != 0)
            {

                for (int i = 0; i <= posts.Count() - 1; i++)
                {
                    JoeBlogs.Post p = posts.ElementAt(i);

                    contentlist.Invoke(
                        (MethodInvoker)delegate {
                            contentlist.Items.Add(i + "", p.Title + "  " + p.DateCreated.ToString(), 0);
                        }
                        );

                   // contentlist.Items.Add(i + "", p.title + "  " + p.dateCreated.ToString(), 0);
                }
            }

            freeWizard1.Invoke(
                (MethodInvoker)delegate {
                    freeWizard1.SelectedIndex = 0;
                }
                );

           // freeWizard1.SelectedIndex = 0;
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            String key = contentlist.SelectedItems[0].Name;

            if (catagorylist.SelectedItems[0].Index >= 2)
            {
                //设置当前的Catagory
                catagory = OpenCatagory.Blog;

                String key1 = catagorylist.SelectedItems[0].Name;

                int idx1 = int.Parse(key1.Trim());

                //设置当前的Account
                curinfo = infolist[idx1];

                int idx = int.Parse(key.Trim());

                postinfo = new PostInfo();
                postinfo.title = posts.ElementAt(idx).Title;
                

                JoeBlogs.Post p = blog.getPostById(posts.ElementAt(idx).PostID );

                postinfo.text = p.Body;
                postinfo.postid = posts.ElementAt(idx).PostID;
                postinfo.status = BlogStatus.Old;
            }
            else if (catagorylist.SelectedItems[0].Index == 1)
            {
                catagory = OpenCatagory.Recently;

                int idx = int.Parse(key.Trim());

                RecentInfo recent = recentlist[idx];

                //设置account
                curinfo = DataMgr.getAccountById(recent.accountid);

                //设置当前的PostInfo
                postinfo = new PostInfo();
                postinfo.title = recent.title;

                blog = BlogFactory.createBlogger(curinfo.provider);

                JoeBlogs.Post p = blog.getPostById(recent.postid);

                postinfo.text = p.Body;
                postinfo.postid = recent.postid;
                postinfo.status = BlogStatus.Old;
            }
            else
            {
                catagory = OpenCatagory.Draft;

                int idx = int.Parse(key.Trim());

                DraftInfo draft = draftlist[idx];

                postinfo = new PostInfo();
                postinfo.title = draft.title;
                postinfo.text = draft.text;
                postinfo.status = BlogStatus.New;

                curinfo = DataMgr.getAccountById(draft.accountid);
            }

            this.DialogResult = DialogResult.OK;

            this.Close();
        }


    }
}
