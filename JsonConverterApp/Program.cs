using System;
using System.Collections.Generic;

namespace JsonConverterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User george = new User("George");
            BlogPost georgePost = new BlogPost(george, "Hi everybody!", "This is Goerge!");

            List<BlogPost> blogs = new List<BlogPost> { georgePost };

            Console.WriteLine(Converter.ConvertToJSON(blogs));
            Console.ReadKey();
        }
    }
}
