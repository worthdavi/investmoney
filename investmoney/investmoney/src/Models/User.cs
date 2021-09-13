using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investmoney
{
    public class User
    {
        // Format: id, username, email, password, type,
        public int id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Type { get; set; }

        public int getId()
        {
            return this.id;
        }

        internal void setId(int v)
        {
            this.id = v;
        }
    }
}
