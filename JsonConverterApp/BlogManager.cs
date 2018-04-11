using System;
using System.Collections.Generic;
using System.Text;

namespace JsonConverterApp
{
    class BlogManager
    {
        public static List<Guid> GetBlogIDs(List<BlogPost> blogPosts, User writer)
        {
            List<Guid> wantedBlogPostsIds = new List<Guid>();
            foreach (BlogPost post in blogPosts)
            {
                wantedBlogPostsIds.Add(post.Id);
            }
            return wantedBlogPostsIds;
        }

        public static List<BlogPost> GetBlogsFromWriter(List<BlogPost> blogPosts, User writer)
        {
            List<BlogPost> wantedBlogPosts = new List<BlogPost>();
            foreach (BlogPost post in blogPosts)
            {
                if (post.User.Id == writer.Id)
                {
                    wantedBlogPosts.Add(post);
                }
            }
            return wantedBlogPosts;
        }

        public static List<BlogPost> GetBlogsWithLongTitles(List<BlogPost> blogPosts)
        {
            List<BlogPost> wantedBlogPosts = new List<BlogPost>();
            foreach (BlogPost post in blogPosts)
            {
                if (post.Title.Split(' ').Length >= 2)
                {
                    wantedBlogPosts.Add(post);
                }
            }
            return wantedBlogPosts;
        }

        public static List<BlogPost> GetBlogsWithKeyword(List<BlogPost> blogPosts, string wordSearched)
        {
            List<BlogPost> wantedBlogPosts = new List<BlogPost>();
            foreach (BlogPost post in blogPosts)
            {
                if (post.Body.Contains(wordSearched))
                {
                    wantedBlogPosts.Add(post);
                }
            }
            return wantedBlogPosts;
        }

        public static BlogPost FindBlogWithID(List<BlogPost> blogPosts, string ID)
        {
            foreach (BlogPost post in blogPosts)
            {
                if (post.Id.ToString() == ID)
                {
                    return post;
                }
            }
            return null;
        }

        public static string ConvertToJSON(List<BlogPost> BlogListToConvert)
        {
            StringBuilder JsonResult = new StringBuilder();
            foreach(BlogPost post in BlogListToConvert)
            {
                JsonResult.Append("{\n  \"id\": " + $"\"{post.Id}\",");
                JsonResult.Append("\n  \"user\": \n  {");
                JsonResult.Append("\n    \"id\": " + $"\"{post.User.Id}\",");
                JsonResult.Append("\n    \"username\": " + $"\"{post.User.Username}\",");
                JsonResult.Append("\n  },\n  \"title\": " + $"\"{post.Title}\",");
                JsonResult.Append("\n  \"body\": " + $"\"{post.Body}\"" + "\n}");
            }
            return JsonResult.ToString();
        }
    }
}
