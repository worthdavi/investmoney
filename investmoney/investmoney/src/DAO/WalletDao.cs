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
                string query = "select wallet.amount, wallet.boughtdate, wallet.boughtvalue, active.ticker as ticker, active.price as unity, active.description as description from wallet" +
                    " inner join user on wallet.user_id = " + userId +
                    " inner join active on wallet.actives_ticker = active.ticker;";
                var output = connection.Query<Wallet>(query, new DynamicParameters());
                return output.ToList();
            }
        }

        public List<String> GetActivesByUserId(int userId)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                //  id, amount, price, user_id, ticker, description
                string query = "select wallet.actives_ticker as ticker from wallet inner join user on user.id = wallet.user_id where user.id = " + userId;
                var output = connection.Query<String>(query, new DynamicParameters());
                return output.ToList();
            }
        }

        public int GetActivesAmountByTickerId(int userId, string ticker)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "select wallet.amount as amount from wallet inner join user on user.id = wallet.user_id where wallet.actives_ticker = '" + ticker + "' and user.id = " + userId;
                var amount = Convert.ToInt32(connection.ExecuteScalar(query));
                if (amount != 0)
                {
                    return amount;
                }
                return 0;
            }
        }

        public int SetActivesAmountByTickerId(int userId, string ticker, int amount)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "UPDATE wallet SET amount = ((SELECT amount FROM wallet INNER JOIN" +
                    " user ON user.id = wallet.user_id WHERE user.id = "+userId+" AND wallet.actives_ticker = '"+ticker+"') - "+amount+") " +
                    " where wallet.actives_ticker = '"+ticker+"'";
                var result = Convert.ToInt32(connection.ExecuteScalar(query));
                if (result != 0)
                {
                    return result;
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
