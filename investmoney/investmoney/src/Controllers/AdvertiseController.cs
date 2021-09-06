using investmoney.src.DAO;
using investmoney.src.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investmoney.src.Controllers
{
    class AdvertiseController
    {
        public int CreateOffer(int amount, int price, int type, int wallet_id, string ticker)
        {
            AdvertiseDao advertise = new AdvertiseDao();

            int result = advertise.CreateOffer(amount, price, type, wallet_id, ticker);

            if (result == 1) 
                return 1;
            else 
                return 0;
        }
        public List<AdvertiseModel> LoadOffers()
        {
            AdvertiseDao dao = new AdvertiseDao();
            return dao.LoadOffers();
        }

        public void AcceptOffer(AdvertiseModel offer, User user, int amountBought, int totalValue)
        {
            AdvertiseDao dao = new AdvertiseDao();
            WalletController wallet = new WalletController();
            bool newTicker = false;
            user.setBalance(user.Balance - totalValue);
            if (wallet.GetActivesAmountByTickerId(user.getId(), offer.ticker) == 0)
            {
                newTicker = true;
            }

            dao.AcceptOffer(offer, user, amountBought, totalValue, newTicker);
        }

        public AdvertiseModel GetOfferById(int id)
        {
            AdvertiseDao dao = new AdvertiseDao();
            return dao.GetOfferById(id);
        }
    }
}
