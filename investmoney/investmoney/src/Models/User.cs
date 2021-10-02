using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investmoney
{
    /// <summary>
    /// A classe **User** é uma classe Model, responsável por definir o modelo de  User.
    /// </summary>
    public class User
    {
        // Format: id, username, email, password, type,
        /// <summary>
        /// Os metodos pegar e/ou altera a propriedade Id.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        public int id { get; set; }


        /// <summary>
        /// Os metodos pegar e/ou altera a propriedade Username.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        public string Username { get; set; }

        /// <summary>
        /// Os metodos pegar e/ou altera a propriedade Email.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        public string Email { get; set; }

        /// <summary>
        /// Os metodos pegar e/ou altera a propriedade Password.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        public string Password { get; set; }

        /// <summary>
        /// Os metodos pegar e/ou altera a propriedade Type.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        public int Type { get; set; }


        /// <summary>
        /// O pega a propriedade Id.
        /// </summary>
        /// <returns>Retorna o id do usuário.</returns>
        public int getId()
        {
            return this.id;
        }

        /// <summary>
        /// O metodo atribui valor a propriedade Id.
        /// </summary>
        /// <returns>Não há retorno.</returns>
        internal void setId(int v)
        {
            this.id = v;
        }
    }
}
