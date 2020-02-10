using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace LoginDriver
{
    public class Login
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public Login() { }

        public Login(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

    }
}
