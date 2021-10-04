using investmoney.src.DAO;
using investmoney.src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investmoney.src.Controllers
{
    /// <summary>
    /// A classe **WalletController** é uma classe de controller, responsável por abranger todas a ações referente a Wallet.
    /// </summary>
    class WalletController
    {
        /// <summary>
        /// O metodo lista todos os Wallet por usuário.
        /// </summary>
        /// <param name="userId">O id do usuário que deseja buscar os Wallets.</param>
        /// <returns>Retorna uma lista de Wallet por usuário.</returns>
        public List<Wallet> LoadUserWallet(int userId)
        {
            WalletDao wallet = new WalletDao();
            List<Wallet> list = wallet.LoadUserWallet(userId);
            return list;
        }

        /// <summary>
        /// O metodo lista todos os Wallet por usuário.
        /// </summary>
        /// <param name="userId">O id do usuário que deseja buscar os Wallets.</param>
        /// <returns>Retorna uma lista os nome de todos os active por usuário.</returns>
        public List<String> GetActivesByUserId(int userId)
        {
            WalletDao wallet = new WalletDao();
            List<String> list = wallet.GetActivesByUserId(userId);
            return list;
        }

        /// <summary>
        /// O metodo lista todos os valores do Wallet por usuário e ticker especificos.
        /// </summary>
        /// <param name="userId">O id do usuário que deseja buscar os Wallets.</param>
        /// <param name="ticker">O ticker que deseja buscar os Wallets.</param>
        /// <returns>Retorna uma lista com todos os valores de todos os Wallet por usuário e ticker.</returns>
        public int GetActivesAmountByTickerId(int userId, string ticker)
        {
            WalletDao wallet = new WalletDao();
            int amount = wallet.GetActivesAmountByTickerId(userId, ticker);
            return amount;
        }
    }
}
