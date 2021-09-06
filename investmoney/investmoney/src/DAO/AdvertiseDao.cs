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
                var output = connection.Query<AdvertiseModel>("select id, amount, price, ticker from advertise where type = 0", new DynamicParameters());
                return output.ToList();
            }
        }

        public void AcceptOffer(AdvertiseModel offer, User user, int amountBought, int totalValue, bool newTicker)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                if (newTicker)
                {
                    Console.WriteLine("Primeiro ativo desse tipo pro usuario");
                    connection.Execute("insert into wallet (amount, user_id, actives_ticker) values ('" +
                     "" + offer.amount + "', '" + user.getId() + "', '" + offer.ticker + "')");
                }
                else if(!newTicker)
                {
                    connection.Execute("update wallet set amount = ((select amount from wallet where actives_ticker = '" +
                        "" + offer.ticker + "' and user_id = " + user.getId() + ") + " + amountBought + ");");
                }
                
                connection.Execute("update advertise set amount = ((select amount from advertise where id = " + offer.id + ") - " + amountBought + ") where id = " + offer.id + "");
                connection.Execute("delete from advertise where amount = 0 and id = " + offer.id);
                connection.Execute("update user set balance = " + user.Balance + " where id = " + user.getId());
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

