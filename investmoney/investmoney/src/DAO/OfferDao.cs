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

    class OfferDao
    {
        public List<OfferModel> LoadOffers()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<OfferModel>("select ticker, price, description from active", new DynamicParameters());
                return output.ToList();
            }
        }

        public void BuyActive(double price, int amount, User user, bool isNew, DateTime date, string ticker)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                if (isNew)
                {
                    connection.Execute("insert into wallet (amount, user_id, ticker) values ('" +
                    "" + amount + "', '" + user.getId() + "', '" + ticker + "')");
                }
                else
                {
                    connection.Execute("update wallet set amount = ((select amount from wallet where user_id = " + user.getId() + " and ticker = '" + ticker + "') + " + amount + ")" +
                        "where user_id = " + user.getId() + " and ticker = '" + ticker + "';");
                }

                connection.Execute("insert into transactions (ticker, amount, price, user_id, date) values ('" +
                    "" + ticker + "', '" + amount + "', '" + price + "', '" + user.getId() + "', '" + date.ToString("dd/MM/yyyy HH:mm") + "')");
            }
        }

        public void SellActive(OfferModel offer, User user, DateTime date)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {

                connection.Execute("update wallet set amount = ((select amount from wallet where user_id = " + user.getId() + " and ticker = '" + offer.ticker + "') - " + offer.amount + ")" +
                 "where user_id = " + user.getId() + " and ticker = '" + offer.ticker + "';");
                connection.Execute("insert into transactions (ticker, amount, price, user_id, date) values ('" +
                    "" + offer.ticker + "', '" + offer.amount + "', '" + offer.price * -1 + "', '" + user.getId() + "', '" + date.ToString("dd/MM/yyyy HH:mm") + "')");
                connection.Execute("delete from wallet where user_id = " + user.getId() + " and amount = 0");
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}

