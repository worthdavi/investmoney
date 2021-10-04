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
    /// A classe **OfferDao** é uma classe DAO, responsável por abragnder todas a ações referente a Offer que interage com o banco de dados.
    /// </summary>
    class OfferDao
    {
        /// <summary>
        /// O metodo retorna lista todas as operação do usuário relacionado ao actives.
        /// </summary>
        /// <returns>Retorna lista todas as operação do usuário relacionado aos actives.</returns>
        public List<OfferModel> LoadOffers()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<OfferModel>("select ticker, price, description from active", new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// O metodo que faz registo da ccompra do active.
        /// </summary>
        /// <param name="price">O preço do active a ser comprado</param>
        /// <param name="amount">A quantidade do active que deseja comprar.</param>
        /// <param name="user">O usuário que está comprando.</param>
        /// <param name="isNew">Se é uma nova compra.</param>
        /// <param name="localDate">A data da compra.</param>
        /// <param name="ticker">O ativo que desea comprar.</param>
        /// <returns>Não há retorno</returns>
        public void BuyActive(double price, int amount, User user, bool isNew, DateTime date, string ticker, string type)
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

                connection.Execute("insert into transactions (ticker, amount, price, user_id, date, type) values ('" +
                    "" + ticker + "', '" + amount + "', '" + price + "', '" + user.getId() + "', '" + date.ToString("dd/MM/yyyy HH:mm") + "', '" + type + "')");
            }
        }

        /// <summary>
        /// O metodo que faz registo da venda do active.
        /// </summary>
        /// <param name="offer">O oferta de de compra</param>
        /// <param name="user">O usuário que está vendendo.</param>
        /// <param name="date">A data da compra.</param>
        /// <returns>Não há retorno</returns>
        public void SellActive(OfferModel offer, User user, DateTime date, string type)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {

                connection.Execute("update wallet set amount = ((select amount from wallet where user_id = " + user.getId() + " and ticker = '" + offer.ticker + "') - " + offer.amount + ")" +
                 "where user_id = " + user.getId() + " and ticker = '" + offer.ticker + "';");
                connection.Execute("insert into transactions (ticker, amount, price, user_id, date, type) values ('" +
                    "" + offer.ticker + "', '" + offer.amount + "', '" + offer.price * -1 + "', '" + user.getId() + "', '" + date.ToString("dd/MM/yyyy HH:mm") + "' ,'" + type + "')");
                connection.Execute("delete from wallet where user_id = " + user.getId() + " and amount = 0");
            }
        }

        /// <summary>
        /// O metodo que lista os actives vendidos.
        /// </summary>
        /// <returns>Retorna a lista dos actives vendidos</returns>
        public List<TransactionModel> GetActiveSell()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<TransactionModel>("select * from transactions where type = 'V' ", new DynamicParameters());
                
                return output.ToList();
            }

        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}

