using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace investmoney.src.DAO
{
    /// <summary>
    /// A classe **Auth** é uma classe responsável por gerenciar a autenticação do usuário.
    /// </summary>
    class Auth
    {

        /// <summary>
        /// O metodo que faz login do usuario na plataforma.s.
        /// </summary>
        /// <param name="username">O nome do cadatrado na plataforma</param>
        /// <param name="password">A senha que foi cadastrado ao realizar o cadastro na plataforma.</param>
        /// <returns>Retorna true caso o login for realizado com sucesso ou false caso ocorra um erro na operação.</returns>
        public static bool Login(string username, string password)
        {

            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "select `id` from `user` where `user`.`username` = '" + username + "' and `user`.`password` = '" + password + "'";
                var id = Convert.ToInt32(connection.ExecuteScalar(query));
                if (id != 0)
                {
                    // Setting global userId to load the user on other screens
                    LoginInfo.UserId = id;
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
