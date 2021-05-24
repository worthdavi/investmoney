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
        public int id;
        public string username;
        public string email;
        public string password;
        public int type;
        public double balance;

        public User(string Username, string Email, string Password, int Type, double Balance)
        {
            username = Username;
            email = Email;
            password = Password;
            type = Type;
            balance = Balance;
        }

    }
}
