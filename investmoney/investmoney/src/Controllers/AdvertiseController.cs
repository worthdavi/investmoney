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
    /// A classe **AdvertiseController** é uma classe de controller, responsável por abranger todas a ações referente a Advertise.
    /// </summary>
    class AdvertiseController
    {

        /// <summary>
        /// O metodo que faz registo de Advertise no banco de dados.
        /// </summary>
        /// <param name="amount">O quantidade que deseja comprar ou vender</param>
        /// <param name="price">O preço a que deseja comprar ou vender</param>
        /// <param name="type">O tipo de operação: compar ou vender</param>
        /// <param name="wallet_id">A carteira do usuário.</param>
        /// <param name="ticker">O active  que deseja comprar ou vender.</param>
        /// <returns>Retorna 1 se a operaçãofor realizado com sucesso ou 0 se caso ocorra um erra na operação.</returns>
        public int CreateOffer(int amount, int price, int type, int wallet_id, string ticker)
        {
            AdvertiseDao advertise = new AdvertiseDao();

            int result = advertise.CreateOffer(amount, price, type, wallet_id, ticker);

            if (result == 1) 
                return 1;
            else 
                return 0;
        }

        /// <summary>
        /// O metodo retorna as Adverts.
        /// </summary>
        /// <returns>Retorna uma lista de ofertas.</returns>
        public List<AdvertiseModel> LoadOffers()
        {
            AdvertiseDao dao = new AdvertiseDao();
            return dao.LoadOffers();
        }

        /// <summary>
        /// O metodo que aceita uma oferta.
        /// </summary>
        /// <param name="active">O Active que deseja aceita a oferta.</param>
        /// <param name="amount">A quantidade a que deseja comprar ou vender.</param>
        /// <param name="user">O usuário que aceitou a oferta.</param>
        /// <param name="amountBought">A quantidade que desejacomprar.</param>
        /// <param name="totalValue">O valor total da oferta.</param>
        /// /// <param name="timeStamp">A data que aceitou a oferta.</param>
        /// <returns>Não há retorno.</returns>
        public void AcceptOffer(ActiveModel active, int amount, User user, int amountBought, double totalValue, long timeStamp)
        {
            AdvertiseDao dao = new AdvertiseDao();
            dao.AcceptOffer(active, amount, user, amountBought, totalValue, timeStamp);
        }

        /// <summary>
        /// O busca a oferta por id.
        /// </summary>
        /// <param name="id">O id que deseja buscar.</param>
        /// <returns>Retorna uma oferta por id.</returns>
        public AdvertiseModel GetOfferById(int id)
        {
            AdvertiseDao dao = new AdvertiseDao();
            return dao.GetOfferById(id);
        }
    }
}
