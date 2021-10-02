using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using investmoney.src.DAO;

namespace investmoney.src.Controllers
{
    /// <summary>
    /// A classe **UserController** é uma classe de controller, responsável por abranger todas a ações referente a User.
    /// </summary>
    class UserController
    {
        /// <summary>
        /// O metodo que que faz registo de active.
        /// </summary>
        /// <param name="nome">O nome do usuario a ser registado</param>
        /// <param name="email">A email do ussuário a ser registado.</param>
        /// <param name="password">A senha do ussuário a ser registado.</param>
        /// <param name="type">O tipo do ussuário a ser registado, podendp ser Admin ou Comum.</param>
        /// <param name="balance">O valor de entrada em que o usuário deseja operar na plataforma.</param>
        /// <returns>Retorna o nome do se o registo for realizado com sucesso ou "false" caso ocorra um erro na operação.</returns>
        public string  create(String nome,String email,String password, int type)
        {
            UserDao userDao = new UserDao();
            var result = userDao.Register(nome, email, password, type);

            if (result == 1) return nome;
            else return "false";

        }
        public int SaveUser(User user)
        {
            int result = UserDao.SaveUser(user);
            if (result == 1) return 1;
            else return 0;
        }

        /// <summary>
        /// O metodo lsita todos os usuários registados.
        /// </summary>
        /// <returns>Retorna uma lista de usuário.</returns>
        public List<User> GetAllUsers()
        {
            return UserDao.GetUserList();
        }

        /// <summary>
        /// O metodo verifica se já existe um email cadastrado ao tentar registrar um novo usuário.
        /// </summary>
        /// <param name="email">O email que do usuario cadastrar na plataforma.</param>
        /// <returns>Retorna true para casa haja um email já cadastrado ou false casa não tenha.</returns>
        public bool IsEmailRepeated(string email)
        {
            return UserDao.IsEmailRepeated(email);
        }

        /// <summary>
        /// O metodo verifica se já existe um nome cadastrado ao tentar registrar um novo usuário.
        /// </summary>
        /// <param name="nome">O nome do usuário a ser registado.</param>
        /// <returns>Retorna true para casa haja um nome já cadastrado ou false casa não tenha.</returns>
        public bool IsUsernameRepeated(string nome)
        {
            return UserDao.IsUsernameRepeated(nome);
        }
    }
}
