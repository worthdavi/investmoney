using investmoney.src.DAO;
using investmoney.src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investmoney.src.Controllers
{
    class WalletController
    {
        public List<Wallet> LoadUserWallet(int userId)
        {
            WalletDao wallet = new WalletDao();
            List<Wallet> list = wallet.LoadUserWallet(userId);
            return list;
        }
    }
}
