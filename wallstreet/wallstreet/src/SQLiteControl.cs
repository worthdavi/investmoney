using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wallstreet
{
    class SQLiteControl
    {
        public static List<User> LoadUser()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<User>("select * from user", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveUser(User user)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("insert into user (username, email, password, type, balance) values ('" +
                    "" + user.username + "', '" + user.email + "', '" + user.password + "', '" + user.type + "', '" + user.balance + "')");
            }
        }

        public static bool TryLogin(string username, string password)
        {

            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "select COUNT(1) from user where user.username = '" + username + "' and user.password = '" + password + "'";
                var result = Convert.ToInt32(connection.ExecuteScalar(query));
                if (result >= 1)
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
