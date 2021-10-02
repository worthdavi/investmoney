using investmoney.src.Controllers;
using investmoney.src.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investmoney.src.Models
{
    /// <summary>
    /// A classe **Wallet** é uma classe Model, responsável por definir o modelo de Wallet.
    /// </summary>
    class Wallet
    {
        // Format: id, amount, price, user_id, ticker_id, description

        /// <summary>
        /// Os metodos pegar e/ou altera a propriedade id.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        private int id { get; set; }

        /// <summary>
        /// Os metodos pegar e/ou altera a propriedade ticker.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        public string ticker { get; set; }

        /// <summary>
        /// Os metodos pegar e/ou altera a propriedade amount.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        public int amount { get; set; }

        /// <summary>
        /// Os metodos pegar e/ou altera a propriedade unity.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        public double unity { get; set; }

        /// <summary>
        /// Os metodos pegar e/ou altera a propriedade user_id.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        private int user_id { get; set; }

        /// <summary>
        /// Os metodos pegar e/ou altera a propriedade description.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        public string description { get; set; }

        /// <summary>
        /// O metodos pega a propriedade user_id.
        /// </summary>
        /// <returns>Retorna Id do usuário que fez a compra</returns>
        public int getUserId()
        {
            return this.user_id;
        }


        /// <summary>
        /// O metodos pega a propriedade id.
        /// </summary>
        /// <returns>Retorna Id do wallet</returns>
        public int getId()
        {
            return this.id;
        }
        
    }
}
