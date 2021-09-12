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
    class TransactionDao
    {
        public List<TransactionModel> LoadUserTransactions(User user)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                //  id, ticker, amount, price, user_id, date
                string query = "select id, ticker, amount, price, user_id, date from transactions where user_id = " + user.getId() + ";";
                var output = connection.Query<TransactionModel>(query, new DynamicParameters());
                return output.ToList();
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
