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
    /// <summary>
    /// A classe **ActiveDao** é uma classe DAO, responsável por abragnder todas a ações referente a Active que interage com o banco de dados.
    /// </summary>
    class ActiveDao
    {
        /// <summary>
        /// O metodo que faz registo de active no banco de dados.
        /// </summary>
        /// <param name="ticker">O nome do active a ser registado</param>
        /// <param name="amount">A quantidade do active que deseja colocar para vender.</param>
        /// <param name="price">O preço de venda do active que está cadastrando.</param>
        /// <param name="description">Defina uma descrição do activo que está registrando.</param>
        /// <returns>Retorna 1 se o registo do active for realizado com sucesso ou 0 se caso ocorra um erra na operação.</returns>
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

        /// <summary>
        /// O metodo lista os nome de todos os Active registrado.
        /// </summary>
        /// <returns>Retorna todos os Active registrado.</returns>
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

        /// <summary>
        /// O metodo retona a quantidade de um Active.
        /// </summary>
        /// <param name="ticker">O ticker que deseja buscar.</param>
        /// <returns>Retorna a quantidade de um Active a partir de um ticker especifico</returns>
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

        /// <summary>
        /// O metodo retorna o preço de um Active.
        /// </summary>
        /// <param name="ticker">O ticker que deseja buscar.</param>
        /// <returns>Retorna o preço de um Active a partir de um ticker especifico</returns>
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


        /// <summary>
        /// O metodo retorna um Active especifico.
        /// </summary>
        /// <param name="ticker">O ticker que deseja buscar.</param>
        /// <returns>Retorna um Active especifico a partir de ticker.</returns>
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

        /// <summary>
        /// O metodo lista todos os Actives no banco de dados.
        /// </summary>
        /// <returns>Lista de todos os Actives no banco de dados</returns>
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
