using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Configuration;
using Dapper;
using wallstreet.src.Models;

namespace wallstreet.src.DAO
{
    class ActiveDao
    {
        public int Create(String ticker, int amount, int price, String description)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                return connection.Execute("insert into active (ticker, amount, price, description) values ('" +
                    "" + ticker + "', '" + amount + "', '" + price + "', '" + description + "')");
                // Console.WriteLine(" aqui {0}", cul);
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
