using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp
{
    class User
    {
        public int id { get; set; }
        private string login;
        private string email;
        private string password;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Email
        {
            get { return email; }
            set { login = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public User() { }
        public User(string login, string email, string password)
        {
            this.login = login;
            this.password = password;
            this.email = email;
        }

        //public override string ToString()
        //{
        //    return "User: " + Login + ". Email: " + Email;
        //}


    }
}
