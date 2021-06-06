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

namespace wallstreet.src.DAO
{
    class Auth
    {
        public static bool Login(string username, string password)
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
