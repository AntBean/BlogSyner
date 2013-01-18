using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogSyner
{
    public interface IBlog
    {
        bool authenticate(String username, String password);
        string newPost(string title, string body);
        void editPost(string postid, string title, string body);
      //  List<AlexJamesBrown.JoeBlogs.Structs.Post> getRecentPosts();
   //     IList<AlexJamesBrown.JoeBlogs.Structs.Post> getPost(int num);
        IEnumerable<JoeBlogs.Post> getPost(int num);
        JoeBlogs.Post getPostById(string postid);
        //bool editPost();
    }

    public class ResultInfo
    {
        public bool result;
        public string message;
    }

    
}
