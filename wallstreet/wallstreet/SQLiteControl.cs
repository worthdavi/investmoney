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
        public static List<User> LoadUsers()
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
                connection.Execute("insert into user (username, email, password, type, balance) values ('" + user.username + "', '" + user.email + "', '" + user.password + "', '" + user.type + "', '" + user.balance + "')");
            }
        }


        // Vou fazer
        public static bool TryLogin(string username, string password)
        {
            return true;
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
