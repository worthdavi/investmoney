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
                string query = "select wallet.id, wallet.amount as amount, active.price as unity, active.ticker as ticker, active.description as description from wallet" +
                    " inner join user on wallet.user_id = " + userId +
                    " inner join active on wallet.actives_ticker = active.ticker;";
                var output = connection.Query<Wallet>(query, new DynamicParameters());
                return output.ToList();
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
