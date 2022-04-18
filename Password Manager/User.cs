using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager
{
    public class User
    {
        public string? Title { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }

        public User(string name, string username, string password)
        {
            Title = name;
            Username = username;
            Password = password;
        }
    }
}
