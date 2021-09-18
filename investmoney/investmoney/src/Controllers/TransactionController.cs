using investmoney.src.DAO;
using investmoney.src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investmoney.src.Controllers
{
    class TransactionController
    {
        public List<TransactionModel> LoadUserTransactions(User user)
        {
            TransactionDao transactions = new TransactionDao();
            List<TransactionModel> list = transactions.LoadUserTransactions(user);
            return list;
        }

        public int calculateMaked(List<Wallet> wallet, int user,string dia, string mes, string ano)
        {
            TransactionDao transactions = new TransactionDao();
            var list = transactions.calculateMaked(wallet, user, dia, mes, ano);
            return list;
            

        }
        public int calculateMakedNaoRealizado(List<Wallet> wallet, int user, string dia, string mes, string ano)
        {
            TransactionDao transactions = new TransactionDao();
            var list = transactions.calculateMakedNotRealizado(wallet, user, dia,  mes, ano);
            return list;


        }
    }
}
