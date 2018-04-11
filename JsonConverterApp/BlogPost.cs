using System;

namespace JsonConverterApp
{
    class BlogPost
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public BlogPost(User user, string title, string body)
        {
            User = user;
            Title = title;
            Body = body;
            Id = Guid.NewGuid();
        }
    }
}
