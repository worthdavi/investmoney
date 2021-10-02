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
    /// <summary>
    /// A classe **WalletDao** é uma classe DAO, responsável por abragnder todas a ações referente a Waller que interage com o banco de dados.
    /// </summary>
    class WalletDao
    {
        /// <summary>
        /// O metodo carregar todos os Wallet do usuário no banco de dados.
        /// </summary>
        /// <param name="userId">O id do usuário</param>
        /// <returns>Retorna uma lista de Wallet por usuário.</returns>
        public List<Wallet> LoadUserWallet(int userId)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                //  id, amount, price, user_id, ticker, description
                string query = "select wallet.amount, active.ticker as ticker, active.price as unity, active.description as description from wallet" +
                    " inner join user on wallet.user_id = " + userId +
                    " inner join active on wallet.ticker = active.ticker;";
                var output = connection.Query<Wallet>(query, new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// O metodo carregar todos os Wallet por usuário no banco de dados.
        /// </summary>
        /// <param name="userId">O id do usuário</param>
        /// <returns>Retorna uma lista de Wallet por usuário.</returns>
        public List<String> GetActivesByUserId(int userId)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                //  id, amount, price, user_id, ticker, description
                string query = "select wallet.ticker as ticker from wallet inner join user on user.id = wallet.user_id where user.id = " + userId;
                var output = connection.Query<String>(query, new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// O metodo retorna a quantidade dos actives do Wallet por usuário e ticker especificos.
        /// </summary>
        /// <param name="userId">O id do usuário que deseja buscar os Wallets.</param>
        /// <param name="ticker">O ticker que deseja buscar os Wallets.</param>
        /// <returns>Retorna a quantidade dos actives de todos os Wallet por usuário e ticker caso a operação seja sucesso ou 0 caso ocorra erro na operação.</returns>
        public int GetActivesAmountByTickerId(int userId, string ticker)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "select wallet.amount as amount from wallet inner join user on user.id = wallet.user_id where wallet.ticker = '" + ticker + "' and user.id = " + userId;
                var amount = Convert.ToInt32(connection.ExecuteScalar(query));
                if (amount != 0)
                {
                    return amount;
                }
                return 0;
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
