using System;
using System.Collections.Generic;

namespace JsonConverterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\n\tHi! Give me your name please.\n\n\tName: ");
            User newUser = new User(Console.ReadLine());

            Console.Clear();
            Console.Write($"\n\n\tHi! {newUser.Username} You are about to " +
                "write a blog and I will convert it to JSON.\n\n\tNow give me the title please" +
                "\n\n\tTitle: ");
            string title = Console.ReadLine();
            Console.Clear();
            Console.Write("\n\n\tNow write the body!\n\n\tBody: ");
            BlogPost usersPost = new BlogPost(newUser, title, Console.ReadLine());

            List<BlogPost> blogs = new List<BlogPost> { usersPost };
            Console.Clear();
            Console.WriteLine("\n\n\tThis is your blog post information in JSON! ;-)\n");
            Console.WriteLine(BlogManager.ConvertToJSON(blogs));
            Console.ReadKey();
        }
    }
}
