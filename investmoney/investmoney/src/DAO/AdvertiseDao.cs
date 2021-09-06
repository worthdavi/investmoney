using Dapper;
using investmoney.src.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investmoney.src.DAO
{

    class AdvertiseDao
    {
        public int CreateOffer(int amount, int price, int type, int wallet_id, string ticker)
        {
            AdvertiseModel offer = new AdvertiseModel();
            offer.amount = amount;
            offer.price = price;
            offer.setType(type);
            offer.setWalletId(wallet_id);
            offer.ticker = ticker;
            return SQLiteControl.CreateOffer(offer);
        }

        public List<AdvertiseModel> LoadOffers()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<AdvertiseModel>("select ticker, price, description from active", new DynamicParameters());
                return output.ToList();
            }
        }

        public void AcceptOffer(ActiveModel active, int amount, User user, int amountBought, double totalValue, long timeStamp)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("insert into wallet (amount, user_id, boughtdate, boughtvalue, actives_ticker) values ('" +
                    "" + amount + "', '" + user.getId() + "', '" + timeStamp + "', '" + active.price + "', '" + active.ticker + "')");
            }
        }

        public AdvertiseModel GetOfferById(int id)
        {
            AdvertiseModel model = new AdvertiseModel();
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "select * from advertise where id = " + id;
                connection.Open();
                DbCommand command = (DbCommand)connection.CreateCommand();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                DbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    model.id = Convert.ToInt32(reader["id"]);
                    model.amount = Convert.ToInt32(reader["amount"]);
                    model.price = Convert.ToInt32(reader["price"]);
                    model.setType(Convert.ToInt32(reader["type"]));
                    model.setWalletId(Convert.ToInt32(reader["wallet_id"]));
                    model.ticker = Convert.ToString(reader["ticker"]);
                }
                return model;
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}

