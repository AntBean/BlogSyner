using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogSyner
{
    public class BlogFactory
    {
        public static IBlog createBlogger(String name)  
        {
            IBlog blog;

            switch (name)
            { 
                case "新浪博客":
                    blog = new SinaBlog();
                    break;

                default:
                    throw new Exception("该博客暂不支持");
            }

            return blog;
        }
    }
}
