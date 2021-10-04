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
    /// <summary>
    /// A classe **OfferController** é uma classe de controler, responsável por abragnder todas a ações referente comprar e vender Actives.
    /// </summary>
    class OfferController
    {
        /// <summary>
        /// O metodo retorna lista todas as operação do usuário relacionado ao actives.
        /// </summary>
        /// <returns>Retorna lista todas as operação do usuário relacionado ao actives.</returns>
        public List<OfferModel> LoadOffers()
        {
            OfferDao dao = new OfferDao();
            return dao.LoadOffers();
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
        public void BuyActive(double price, int amount, User user, bool isNew, DateTime localDate, string ticker)
        {
            OfferDao dao = new OfferDao();
            WalletDao wdao = new WalletDao();
            int currentAmount = wdao.GetActivesAmountByTickerId(user.getId(), ticker);
            if (currentAmount <= 0)
                isNew = true;
            dao.BuyActive(price, amount, user, isNew, localDate, ticker, "C");
        }

        // (OfferModel offer, User user, DateTime date)

        /// <summary>
        /// O metodo que faz registo da venda do active.
        /// </summary>
        /// <param name="offer">O oferta de de compra</param>
        /// <param name="user">O usuário que está vendendo.</param>
        /// <param name="date">A data da compra.</param>
        /// <returns>Não há retorno</returns>
        public void SellActive(OfferModel offer, User user, DateTime date)
        {
            OfferDao dao = new OfferDao();
            dao.SellActive(offer, user, date, "V");
        }


        /// <summary>
        /// O metodo que lista os actives vendidos.
        /// </summary>
        /// <returns>Retorna a lista dos actives vendidos</returns>
        public List<TransactionModel> GetActiveSell()
        {
            OfferDao dao = new OfferDao();
           return dao.GetActiveSell();
        }



    }
}
