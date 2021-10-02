using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investmoney.src.DAO
{
    /// <summary>
    /// A classe **UserDao** é uma classe DAO, responsável por abragnder todas a ações referente a User que interage com o banco de dados.
    /// </summary>
    class UserDao
    {


        /// <summary>
        /// O metodo que faz registo do usuário no banco de dados.
        /// </summary>
        /// <param name="nome">O nome do usuário a ser registado.</param>
        /// <param name="email">A email do usuário a ser registado.</param>
        /// <param name="password">A senha do usuário a ser registado.</param>
        /// <param name="tipo">A tipo do usuário a ser registado, podendo ser Admin e Comum.</param>
        /// <param name="balance">A valor da carteira que usuário deseja investir na plataforma.</param>
        /// <returns>Retorna 1 se o registo do usuario for realizado com sucesso ou 0 se caso ocorra um erra na operação.</returns>
        public int Register(String nome, String email, String password, int tipo)
        {
            User UserToSave = new User();
            UserToSave.Username = nome;
            UserToSave.Email = email;
            UserToSave.Password = password;
            UserToSave.Type = Convert.ToInt32(tipo);
            return SQLiteControl.CreateUser(UserToSave);
        }

        public static int SaveUser(User user)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                return connection.Execute("update user set username = '" + user.Username + "', email = '" + user.Email + "', password = '" + user.Password + "'," +
                    " type = " + user.Type + " where id = " + user.getId() + ";");
            }
        }

        /// <summary>
        /// O metodo lista todos os usuários no banco de dados.
        /// </summary>
        /// <returns>Retorna uma lista usuários.</returns>
        public static List<User> GetUserList()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<User>("select * from user", new DynamicParameters());
                return output.ToList();
            }
        }
        /// <summary>
        /// O metodo verifica se já existe um email cadastrado ao tentar registrar um novo usuário.
        /// </summary>
        /// <param name="email">O email que do usuario cadastrar na plataforma.</param>
        /// <returns>Retorna true para casa haja um email já cadastrado ou false casa não tenha.</returns>
        public static bool IsEmailRepeated(string email)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "select `id` from `user` where `user`.`email` = '" + email + "'";
                var id = Convert.ToInt32(connection.ExecuteScalar(query));
                if (id != 0)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// O metodo verifica se já existe um nome cadastrado ao tentar registrar um novo usuário.
        /// </summary>
        /// <param name="name">O nome do usuário a ser registado.</param>
        public static bool IsUsernameRepeated(string name)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "select `id` from `user` where `user`.`username` = '" + name + "'";
                var id = Convert.ToInt32(connection.ExecuteScalar(query));
                if (id != 0)
                {
                    return true;
                }
            }
            return false;
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
