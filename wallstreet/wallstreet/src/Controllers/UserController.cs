using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wallstreet.src.DAO;

namespace wallstreet.src.Controllers
{
    class UserController
    {

        public string  create(String nome,String email,String password,String tipo, String balance)
        {
            int tipoParse = Convert.ToInt32(tipo);
            int balanceParse = Convert.ToInt32(balance);
            UserDao userDao = new UserDao();
            var result = userDao.Register(nome, email, password, tipoParse, balanceParse);

            if (result == 1) return nome;
            else return "false";

        }
    }
}
