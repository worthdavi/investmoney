using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wallstreet
{
    class User
    {
        // Format: id, username, email, password, type, balance
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Type { get; set; }
        public double Balance { get; set; }

        public static User Load(string username, string email, string password, int type, double balance)
        {
            User user = new User();
            user.Username = username;
            user.Email = email;
            user.Password = password;
            user.Type = type;
            user.Balance = balance;
            return user;
        }
    }
}
