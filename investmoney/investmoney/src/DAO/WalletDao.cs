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

namespace investmoney.src.DAO
{
    class WalletDao
    {
        public List<Wallet> LoadUserWallet(int userId)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                //  id, amount, price, user_id, ticker, description
                string query = "select wallet.amount, active.ticker as ticker, active.price as unity, active.description as description from wallet" +
                    " inner join user on wallet.user_id = user.id" +
                    " inner join active on wallet.ticker = active.ticker where user.id = " + userId + "";
                var output = connection.Query<Wallet>(query, new DynamicParameters());
                return output.ToList();
            }
        }

        public List<String> GetActivesByUserId(int userId)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                //  id, amount, price, user_id, ticker, description
                string query = "select wallet.ticker as ticker from wallet inner join user on user.id = wallet.user_id where user.id = " + userId;
                var output = connection.Query<String>(query, new DynamicParameters());
                return output.ToList();
            }
        }

        public int GetActivesAmountByTickerId(int userId, string ticker)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "select wallet.amount as amount from wallet inner join user on user.id = wallet.user_id where wallet.ticker = '" + ticker + "' and user.id = " + userId;
                var amount = Convert.ToInt32(connection.ExecuteScalar(query));
                if (amount != 0)
                {
                    return amount;
                }
                return 0;
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
