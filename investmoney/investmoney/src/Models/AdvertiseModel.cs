using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investmoney.src.Models
{
    /// <summary>
    /// A classe **AdvertiseModel** é uma classe Model, responsável por definir o modelo de Advertise.
    /// </summary>
    class AdvertiseModel
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
        private int type { get; set; }

        /// <summary>
        /// Os metodos pegar e/ou altera a propriedade id da carteira.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        private int wallet_id { get; set; }

        /// <summary>
        /// Os metodos pegar e/ou altera a propriedade ticker.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        public string ticker { get; set; }

        /// <summary>
        /// O metodo altera a propriedade type.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        public void setType(int type)
        {
            this.type = type;
        }

        /// <summary>
        /// O metodo altera a propriedade id da carteira.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        public void setWalletId(int id)
        {
            this.wallet_id = id;
        }

        /// <summary>
        /// O metodo pegar a propriedade tipo de operação.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        public int getType()
        {
            return this.type;
        }

        /// <summary>
        /// O metodo pegar a propriedade id da carteira.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        public int getWalletId()
        {
            return this.wallet_id;
        }
    }
}
