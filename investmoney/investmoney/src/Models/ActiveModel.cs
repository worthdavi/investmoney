using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investmoney.src.Models
{
    /// <summary>
    /// A classe **ActiveModel** é uma classe Model, responsável por definir o modelo de Active.
    /// </summary>
    class ActiveModel
    {
        // Format: ticker, amount, price, description
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
        /// Os metodos pegar e/ou altera a propriedade price.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        public decimal price { get; set; }

        /// <summary>
        /// Os metodos pegar e/ou altera a propriedade description.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        public string description { get; set; }
    }
}
