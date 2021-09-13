using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Configuration;
using Dapper;
using investmoney.src.Models;
using System.Data.Common;

namespace investmoney.src.DAO
{
    class ActiveDao
    {
        public int Create(String ticker, int amount, int price, String description)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                return connection.Execute("insert into active (ticker, amount, price, description) values ('" +
                    "" + ticker + "', '" + amount + "', '" + price + "', '" + description + "')");
            }
        }

        public static int SaveActive(ActiveModel active)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                return connection.Execute("update active set ticker = '" + active.ticker + "', amount = " + active.amount + ", price = " + active.price + "," +
                    " description = '" + active.description + "' where ticker = '" + active.ticker + "';");
            }
        }

        public List<String> GetActivesNames()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                //  id, amount, price, user_id, ticker, description
                string query = "select ticker from active";
                var output = connection.Query<String>(query, new DynamicParameters());
                return output.ToList();
            }
        }
        public int GetActiveAmountByTickerId(string ticker)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "select amount from active where ticker = '" + ticker + "'";
                var amount = Convert.ToInt32(connection.ExecuteScalar(query));
                if (amount != 0)
                {
                    return amount;
                }
                return 0;
            }
        }

        public double GetActivePriceByTickerId(string ticker)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "select price from active where ticker = '" + ticker + "'";
                var amount = Convert.ToDouble(connection.ExecuteScalar(query));
                if (amount != 0)
                {
                    return amount;
                }
                return 0;
            }
        }

        public ActiveModel GetActiveByTicker(string ticker)
        {
            ActiveModel active = new ActiveModel();
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "select * from active where ticker = '" + ticker + "'";
                connection.Open();
                DbCommand command = (DbCommand)connection.CreateCommand();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                DbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    active.ticker = Convert.ToString(reader["ticker"]);
                    active.price = Convert.ToInt32(reader["price"]);
                    active.description = Convert.ToString(reader["description"]);
                }
                return active;
            }
        }

        public List<ActiveModel> GetActiveList()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<ActiveModel>("select * from active", new DynamicParameters());
                return output.ToList();
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
