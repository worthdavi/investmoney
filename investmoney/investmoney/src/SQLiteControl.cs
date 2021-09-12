using Dapper;
using investmoney.src.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investmoney
{
    class SQLiteControl
    {
        public static List<User> GetUserList()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<User>("select * from user", new DynamicParameters());
                return output.ToList();
            }
        }

        public static int SaveUser(User user)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                return connection.Execute("insert into user (username, email, password, type) values ('" +
                    "" + user.Username + "', '" + user.Email + "', '" + user.Password + "', '" + user.Type + "')");
                // Console.WriteLine(" aqui {0}", cul);
            }
        }


        public static int SellActive(OfferModel offer, User user, DateTime date)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                return connection.Execute("insert into transactions (ticker, amount, price, user_id , date) values ('" +
                    "" + offer.ticker + "', '" + offer.amount + "', '" + user.getId() + "', '" + date + "')");
            }
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

        public static User LoadUserById(int id)
        {
            User userInfo = new User();
            using (SQLiteConnection sqConnection = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand sqCommand = (SQLiteCommand)sqConnection.CreateCommand();
                sqCommand.CommandText = "select * from user where id = '" + id + "'";
                sqConnection.Open();
                SQLiteDataReader sqReader = sqCommand.ExecuteReader();
                try
                {
                    while (sqReader.Read())
                    {
                        userInfo.setId(sqReader.GetInt32(0));
                        userInfo.Username = sqReader.GetString(1); 
                        userInfo.Email = sqReader.GetString(2);
                        userInfo.Password = sqReader.GetString(3);
                        userInfo.Type = sqReader.GetInt32(4);
                    }
                }
                finally
                {
                    sqReader.Close();
                    sqConnection.Close();
                }
            }
            return userInfo;
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
