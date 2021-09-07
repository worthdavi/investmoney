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
    /// <summary>
    /// A classe **AdvertiseDao** é uma classe DAO, responsável por abragnder todas a ações referente a Advertise que interage com o banco de dados.
    /// </summary>
    class AdvertiseDao
    {
        /// <summary>
        /// O metodo que faz registo de Advertise no banco de dados.
        /// </summary>
        /// <param name="amount">O quantidade que deseja comprar ou vender</param>
        /// <param name="price">O preço  a que deseja comprar ou vender</param>
        /// <param name="type">O tipo de operação: compar ou vender</param>
        /// <param name="wallet_id">A carteira do usuário.</param>
        /// <param name="ticker">O active  que deseja comprar ou vender.</param>
        /// <returns>Retorna 1 se a operaçãofor realizado com sucesso ou 0 se caso ocorra um erra na operação.</returns>
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

        /// <summary>
        /// O metodo retorna as Adverts.
        /// </summary>
        /// <returns>Retorna uma lista de ofertas.</returns>
        public List<AdvertiseModel> LoadOffers()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<AdvertiseModel>("select ticker, price, description from active", new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// O metodo que aceita uma oferta.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        public void AcceptOffer(ActiveModel active, int amount, User user, int amountBought, double totalValue, long timeStamp)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("insert into wallet (amount, user_id, boughtdate, boughtvalue, actives_ticker) values ('" +
                    "" + amount + "', '" + user.getId() + "', '" + timeStamp + "', '" + active.price + "', '" + active.ticker + "')");
            }
        }

        /// <summary>
        /// O busca a oferta por id.
        /// </summary>
        /// <param name="id">A id que deseja buscar.</param>
        /// <returns>Retorna uma oferta por id.</returns>
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

