using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investmoney.src.Models
{
    /// <summary>
    /// A classe **TransactionModel** é uma classe Model, responsável por definir o modelo de  Transaction.
    /// </summary>
    class TransactionModel
    {
        /// <summary>
        /// Os metodos pegar e/ou altera a propriedade Id.
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
        /// Os metodos pegar e/ou altera a propriedade price.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        public double price { get; set; }

        /// <summary>
        /// Os metodos pegar e/ou altera a propriedade price.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        private int user_id { get; set; }

        /// <summary>
        /// Os metodos pegar e/ou altera a propriedade date.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        public string date { get; set; }

        /// <summary>
        /// Os metodos pegar e/ou altera a propriedade totalcost.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        public double totalcost { get; set; }
        /// <summary>
        /// Os metodos pegar e/ou altera a propriedade type.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        public string type { get; set; }

        /// <summary>
        /// O metodo pega a propriedade user_id.
        /// </summary>
        /// <returns>Retorna o user_id.</returns>
        public int getUserId()
        {
            return this.user_id;
        }

        /// <summary>
        /// Os metodos pega a propriedade id.
        /// </summary>
        /// <returns>Retorna o id.</returns>
        public int getId()
        {
            return this.id;
        }
    }
}
