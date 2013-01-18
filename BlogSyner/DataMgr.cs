using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SQLite;

namespace BlogSyner
{
    public enum BlogStatus
    {
        New,
        Old,
    };

    public struct AccountInfo
    {
        public String account_id;
        public String blogname;
        public String provider;
        public String username;
        public String password;
        public String url;
    };

    public struct DraftInfo
    {
        public String title;
        public String datetime;
        public String text;
        public String accountid;
        public String blogname;
    };

    public struct RecentInfo
    {
        public String title;
        public String datetime;
        public String accountid;
        public String blogname;
        public String postid;
    };

    //负责数据库操作管理
    public class DataMgr
    {
        static string path = "Data\\ConfigData";

        static string pwd_str = "";

        static String tablename = "BlogAccount";
        static String recenttable = "RecentlyPosted";
        static String drafttable = "Draft";

        //检测DB文件是否存在
        public static bool createDb()
        {
            string conn_str = "Data Source=" + path + pwd_str;

            if (!File.Exists(path))
            {
                System.Data.SQLite.SQLiteConnection.CreateFile(path);

                SQLiteConnection conn = new SQLiteConnection(conn_str);
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand();

                //创建表
                String sql = "Create Table " + tablename + "(id integer primary key autoincrement,BlogUrl text, BlogName text, Provider text, AccountName text, Password text)";

                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                sql = "Create Table " + recenttable + "(PostId text, BlogName text, Title text, Digest text, DateTime text, AccountId text)";

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
               /*
                SQLiteConnection conn = new SQLiteConnection(conn_str);

                conn.Open();

                SQLiteCommand cmd = new SQLiteCommand();

                //查询表
                String sql = "Select id,BlogUrl,Provider,AccountName,Password from " + tablename;

                cmd.CommandText = sql;
                cmd.Connection = conn;
                SQLiteDataReader datareader = cmd.ExecuteReader();

                while (datareader.Read())
                {
                    String url = datareader.GetString(datareader.GetOrdinal("BlogUrl"));

                    String name = datareader.GetString(datareader.GetOrdinal("AccountName"));

                    String pwd = datareader.GetString(datareader.GetOrdinal("Password"));

                    account_url.Add(url);
                    account_pwd.Add(pwd);
                    account_name.Add(name);

                    MessageBox.Show(url + " " + pwd + " " + name);
                }

                conn.Close();*/


                return true;
            }
        }

        public static void addRecentlyPosted(string title, string digest, string postid, 
                        string datetime, string account_id, string blogname)
        {
            string conn_str = "Data Source=" + path + pwd_str;

            SQLiteConnection conn = new SQLiteConnection(conn_str);

            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand();

            String sql = "Insert INTO RecentlyPosted(PostId,Title,Digest,AccountId,DateTime,BlogName) Values(@postid,@title,@digest,@accountid,@datetime,@blogname)";

            cmd.CommandText = sql;
            cmd.Connection = conn;

            cmd.Parameters.Add(new SQLiteParameter("postid", postid));
            cmd.Parameters.Add(new SQLiteParameter("title", title));
            cmd.Parameters.Add(new SQLiteParameter("digest", digest));
            cmd.Parameters.Add(new SQLiteParameter("accountid", account_id));
            cmd.Parameters.Add(new SQLiteParameter("datetime", datetime));
            cmd.Parameters.Add(new SQLiteParameter("blogname", blogname));

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static List<RecentInfo> getAllRecent()
        {
            string conn_str = "Data Source=" + path + pwd_str;

            List<RecentInfo> recentlist = new List<RecentInfo>();

            SQLiteConnection conn = new SQLiteConnection(conn_str);

            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand();

            //查询表
            String sql = "Select PostId,Title,Digest,BlogName,DateTime,AccountId from " + recenttable;

            cmd.CommandText = sql;
            cmd.Connection = conn;
            SQLiteDataReader datareader = cmd.ExecuteReader();

            while (datareader.Read())
            {
                RecentInfo info = new RecentInfo();

                info.postid = datareader.GetString(datareader.GetOrdinal("PostId"));

                info.title = datareader.GetString(datareader.GetOrdinal("Title"));

                info.datetime = datareader.GetString(datareader.GetOrdinal("DateTime"));

                info.accountid = datareader.GetString(datareader.GetOrdinal("AccountId"));

                info.blogname = datareader.GetString(datareader.GetOrdinal("BlogName"));

                recentlist.Add(info);
            }

            conn.Close();

            return recentlist;
        }

        public static void addAccount(string name, string passwd, string url, string provider, string blogname)
        {
            string conn_str = "Data Source=" + path + pwd_str;

            SQLiteConnection conn = new SQLiteConnection(conn_str);

            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand();

            String sql = "Insert INTO BlogAccount(BlogUrl,BlogName,Provider,AccountName,Password) Values(@url,@blogname,@provider,@name,@password)";

            cmd.CommandText = sql;
            cmd.Connection = conn;

            cmd.Parameters.Add(new SQLiteParameter("url", url));
            cmd.Parameters.Add(new SQLiteParameter("blogname", blogname));
            cmd.Parameters.Add(new SQLiteParameter("provider", provider));
            cmd.Parameters.Add(new SQLiteParameter("name", name));
            cmd.Parameters.Add(new SQLiteParameter("password", passwd));

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static List<AccountInfo> getAllAccount()
        {
            string conn_str = "Data Source=" + path + pwd_str;

            List<AccountInfo> infolist = new List<AccountInfo>();

            SQLiteConnection conn = new SQLiteConnection(conn_str);

            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand();

            //查询表
            String sql = "Select id,BlogUrl,Provider,BlogName,AccountName,Password from " + tablename;

            cmd.CommandText = sql;
            cmd.Connection = conn;
            SQLiteDataReader datareader = cmd.ExecuteReader();

            while (datareader.Read())
            {
                AccountInfo info = new AccountInfo();

                info.url = datareader.GetString(datareader.GetOrdinal("BlogUrl"));

                info.username = datareader.GetString(datareader.GetOrdinal("AccountName"));

                info.password = datareader.GetString(datareader.GetOrdinal("Password"));

                info.provider = datareader.GetString(datareader.GetOrdinal("Provider"));

                info.account_id = datareader.GetInt32(datareader.GetOrdinal("id")) + "";

                info.blogname = datareader.GetString(datareader.GetOrdinal("BlogName"));

                infolist.Add(info);
            }

            conn.Close();

            return infolist;
        }

        public static AccountInfo getAccountById(string account_id)
        {
            string conn_str = "Data Source=" + path + pwd_str;

            SQLiteConnection conn = new SQLiteConnection(conn_str);

            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand();
            
            String sql = "Select Provider,BlogName,AccountName,Password from " + tablename +" where id="+account_id;

            cmd.CommandText = sql;
            cmd.Connection = conn;
            SQLiteDataReader datareader = cmd.ExecuteReader();

            AccountInfo account = new AccountInfo();

            while (datareader.Read())
            {
                account.provider = datareader.GetString(datareader.GetOrdinal("Provider"));
                account.username = datareader.GetString(datareader.GetOrdinal("AccountName"));
                account.password = datareader.GetString(datareader.GetOrdinal("Password"));
                account.blogname = datareader.GetString(datareader.GetOrdinal("BlogName"));
                account.account_id = account_id;
            }

            return account;
        }

        public static List<DraftInfo> getAllDraft()
        {
            string conn_str = "Data Source=" + path + pwd_str;

            List<DraftInfo> infolist = new List<DraftInfo>();

            SQLiteConnection conn = new SQLiteConnection(conn_str);

            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand();

            //查询表
            String sql = "Select Title,Body,DateTime,AccountId from Draft";

            cmd.CommandText = sql;
            cmd.Connection = conn;
            SQLiteDataReader datareader = cmd.ExecuteReader();

            while (datareader.Read())
            {
                DraftInfo info = new DraftInfo();

                info.title = datareader.GetString(datareader.GetOrdinal("Title"));

                info.text = datareader.GetString(datareader.GetOrdinal("Body"));

                info.datetime = datareader.GetString(datareader.GetOrdinal("DateTime"));

                info.accountid = datareader.GetString(datareader.GetOrdinal("AccountId"));

                info.blogname = datareader.GetString(datareader.GetOrdinal("BlogName"));

                infolist.Add(info);
            }

            conn.Close();

            return infolist;
        }

        public static void addDraft(String title, String blogname, String body, String datetime, String account_id)
        {
            string conn_str = "Data Source=" + path + pwd_str;

            SQLiteConnection conn = new SQLiteConnection(conn_str);

            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand();

            String sql = "Insert INTO Draft(Title,BlogName,Body,DateTime,AccountId) Values(@title,@blogname,@body,@datetime,@accountid)";

            cmd.CommandText = sql;
            cmd.Connection = conn;

            cmd.Parameters.Add(new SQLiteParameter("title", title));
            cmd.Parameters.Add(new SQLiteParameter("blogname", blogname));
            cmd.Parameters.Add(new SQLiteParameter("body", body));
            cmd.Parameters.Add(new SQLiteParameter("datetime", datetime));
            cmd.Parameters.Add(new SQLiteParameter("accountid", account_id));

            cmd.ExecuteNonQuery();

            conn.Close();
        }



    }
}
