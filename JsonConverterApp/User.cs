using System;

namespace JsonConverterApp
{
    class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }

        public User(string username)
        {
            Username = username;
            Id = Guid.NewGuid();
        }
    }
}
