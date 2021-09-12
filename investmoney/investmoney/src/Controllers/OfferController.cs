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
    class OfferController
    {
        public List<OfferModel> LoadOffers()
        {
            OfferDao dao = new OfferDao();
            return dao.LoadOffers();
        }

        public void BuyActive(ActiveModel active, int amount, User user, bool isNew, DateTime localDate)
        {
            OfferDao dao = new OfferDao();
            WalletDao wdao = new WalletDao();
            int currentAmount = wdao.GetActivesAmountByTickerId(user.getId(), active.ticker);
            if (currentAmount <= 0)
                isNew = true;
            dao.BuyActive(active, amount, user, isNew, localDate);
        }

        // (OfferModel offer, User user, DateTime date)
        public void SellActive(OfferModel offer, User user, DateTime date)
        {
            OfferDao dao = new OfferDao();
            dao.SellActive(offer, user, date);
        }

    }
}
