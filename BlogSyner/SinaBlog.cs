using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace BlogSyner
{
    public class SinaBlog : IBlog
    {
        string user;
        string passwd;
      //  JoeBlogs.IMetaWeblogWrapper metablog;
        JoeBlogs.MetaWeblogWrapper metablog;

        public bool authenticate(string username, string password)
        {
            ResultInfo result = new ResultInfo();

           // metablog = new JoeBlogs.MetaWeblogWrapper()

            metablog = new JoeBlogs.MetaWeblogWrapper
                   ("http://upload.move.blog.sina.com.cn/blog_rebuild/blog/xmlrpc.php", username, password);

            JoeBlogs.Post post = new JoeBlogs.Post();

            post.Title = "This is a Test Blog";

            post.Body = "this is a test body";

      //      post.DateCreated = new DateTime();

        //    try
      //      {

            //利用异常处理 查看出错信息
            string postid = metablog.NewPost(post, true);

            user = username;
            passwd = password;

            return true;

  /*              result.result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("发布日志失败 " + ex.Message);

                result.message = ex.Message;

                result.result = false;
            }

            return result;*/

        }

        //3个以下
        /*public List<AlexJamesBrown.JoeBlogs.Structs.Post> getRecentPosts()
        {
        }*/


        //
        public IEnumerable<JoeBlogs.Post> getPost(int num)
        {
            return metablog.GetRecentPosts(num);
        }

        public JoeBlogs.Post getPostById(string postid)
        {
            return metablog.GetPost(postid);
        }

        public void editPost(string postid, string title, string body)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(body);
            HtmlAgilityPack.HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//img");

            if (nodes != null)
                foreach (HtmlAgilityPack.HtmlNode node in nodes)
                {
                    //获取html源地址
                    HtmlAgilityPack.HtmlAttribute attr = node.Attributes["src"];

                    JoeBlogs.MediaObject mediaObj = new JoeBlogs.MediaObject();

                    mediaObj.Name = "test";
                    mediaObj.Type = "image/jpeg";

                    FileStream file = new FileStream(attr.Value, FileMode.Open);

                    long size = file.Length;

                    byte[] stream = new byte[size];

                    file.Read(stream, 0, (int)size);

                    file.Close();

                    mediaObj.Bits = stream;

                    JoeBlogs.MediaObjectInfo mediainfo = metablog.NewMediaObject(mediaObj);

                    attr.Value = mediainfo.Url;
                }

            JoeBlogs.Post post = new JoeBlogs.Post();
            post.Title = title;

            StringWriter writer = new StringWriter();

            if (nodes != null)
            {
                doc.Save(writer);
                post.Body = writer.ToString();
            }
            else
            {
                post.Body = body;
            }

            metablog.EditPost(postid, post, true);
        }

        public string newPost(string title, string body)
        {
            //check image
           // MatchCollection match = HtmlHelper.findImage(body);
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(body);
            HtmlAgilityPack.HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//img");

            if(nodes != null)
                foreach (HtmlAgilityPack.HtmlNode node in nodes)
                {
                    //获取html源地址
                    HtmlAgilityPack.HtmlAttribute attr = node.Attributes["src"];

                    JoeBlogs.MediaObject mediaObj = new JoeBlogs.MediaObject();

                    mediaObj.Name = "test";
                    mediaObj.Type = "image/jpeg";

                    FileStream file = new FileStream(attr.Value , FileMode.Open);

                    long size = file.Length;

                    byte[] stream = new byte[size];

                    file.Read(stream, 0, (int)size);

                    file.Close();

                    mediaObj.Bits = stream;

                    JoeBlogs.MediaObjectInfo mediainfo = metablog.NewMediaObject(mediaObj);

                    attr.Value = mediainfo.Url;
                }


            JoeBlogs.Post post = new JoeBlogs.Post();
            post.Title = title;

            StringWriter writer = new StringWriter();

            if (nodes != null)
            {
                doc.Save(writer);
                post.Body = writer.ToString();
            }
            else
            {
                post.Body = body;
            }

            return metablog.NewPost(post, true);
        }
    }
}
