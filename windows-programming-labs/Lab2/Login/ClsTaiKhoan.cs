using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class ClsTaiKhoan
    {
        private string username;
        private string password;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public ClsTaiKhoan() { }

        public ClsTaiKhoan(string user, string pass)
        {
            this.username = user;
            this.password = pass;
        }
    }
}
