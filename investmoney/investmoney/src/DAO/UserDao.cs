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
    class UserDao
    {


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

        public static List<User> GetUserList()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<User>("select * from user", new DynamicParameters());
                return output.ToList();
            }
        }
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
