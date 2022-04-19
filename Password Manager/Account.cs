using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager
{
    public class Account
    {

        string name;
        string username;
        string password;

        public string Name
        {
            get { return name; }
            set { name = value;  }
        }
        public string Password
        {
            get { return password; }
            set { password = value;  }
        }
        public string Username
        {
            get { return username; }
                set { username = value; }
        }

        public Account(string name, string username, string password)
        {
            this.name = name;
            this.username = username;
            this.password = password;
        }
    }
}
