using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investmoney.src.Models
{
    /// <summary>
    /// A classe **OfferModel** é uma classe Model, responsável por definir o modelo de  Offer.
    /// </summary>
    class OfferModel
    {
        // Format: id, amount, price, user_id, ticker_id, description

        /// <summary>
        /// Os metodos pegar e/ou altera a propriedade id.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        public int id { get; set; }

        /// <summary>
        /// Os metodos pegar e/ou altera a propriedade amount.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        public int amount { get; set; }

        /// <summary>
        /// Os metodos pegar e/ou altera a propriedade price.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        public int price { get; set; }

        /// <summary>
        /// Os metodos pegar e/ou altera a propriedade ticker.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        public string ticker { get; set; }

    }
}
