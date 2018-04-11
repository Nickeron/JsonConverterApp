using System.Collections.Generic;
using System.Text;

namespace JsonConverterApp
{
    class Converter
    {
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
