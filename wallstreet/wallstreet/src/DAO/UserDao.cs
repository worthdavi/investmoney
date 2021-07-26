using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wallstreet.src.DAO
{
    class UserDao
    {

        public int  Register(String nome, String email, String password, int tipo, int balance)
        {
            User UserToSave = new User();
            UserToSave.Username = nome;
            UserToSave.Email = email;
            UserToSave.Password = password;
            UserToSave.Type = Convert.ToInt32(tipo);
            UserToSave.Balance = Convert.ToInt32(balance);
            return SQLiteControl.SaveUser(UserToSave);
        }
    }
}
