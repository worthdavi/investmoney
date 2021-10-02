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
    /// A classe **TransactionController** é uma classe de controler, responsável por abragnder todas a ações referente as transações.
    /// </summary>
    class TransactionController
    {
        /// <summary>
        /// O metodo que lista o historico de transaçoes por usuário.
        /// </summary>
        /// <param name="user">O nome do active a ser registado</param>
        /// <returns>Retorna a lista do historico de transações por usuário</returns>
        public List<TransactionModel> LoadUserTransactions(User user)
        {
            TransactionDao transactions = new TransactionDao();
            List<TransactionModel> list = transactions.LoadUserTransactions(user);
            return list;
        }


        /// <summary>
        /// O metodo calcula o luco/prehuizo do usuário.
        /// </summary>
        /// <param name="wallet">A carteira de active do usuário</param>
        /// <param name="user">O id do usuário</param>
        /// <param name="dia">A partir de qual dia deseja relaizar o calculo</param>
        /// <param name="mes">O mês referente que deseja obter o relatório</param>
        /// <param name="ano">O ano referente que deseja obter o relatório</param>
        /// <returns>Retorna o resultado já com o imposto de 15% abatido caso o valor total da venda seja acima de 20000 mil.</returns>
        public int calculateMaked(List<Wallet> wallet, int user,string dia, string mes, string ano)
        {
            TransactionDao transactions = new TransactionDao();
            var result = transactions.calculateMaked(wallet, user, dia, mes, ano);
            return result;
            

        }
        /// <summary>
        /// O metodo calcula o luco/prehuizo do usuário.
        /// </summary>
        /// <param name="wallet">A carteira de active do usuário</param>
        /// <param name="user">O id do usuário</param>
        /// <param name="dia">A partir de qual dia deseja relaizar o calculo</param>
        /// <param name="mes">O mês referente que deseja obter o relatório</param>
        /// <param name="ano">O ano referente que deseja obter o relatório</param>
        /// <returns>Retorna valor do lucro ou prejuizo para os activos que não foi vendido pelo usuário</returns>
        public int calculateMakedNaoRealizado(List<Wallet> wallet, int user, string dia, string mes, string ano)
        {
            TransactionDao transactions = new TransactionDao();
            var result = transactions.calculateMakedNotRealizado(wallet, user, dia,  mes, ano);
            return result;


        }
    }
}
