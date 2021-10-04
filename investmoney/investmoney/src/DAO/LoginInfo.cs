using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investmoney.src.DAO
{
    /// <summary>
    /// A classe **LoginInfo** é uma classe DAO referente a User responsável por pegar dados do usuário logado.
    /// </summary>
    public static class LoginInfo
    {
        /// <summary>
        /// Atributo que guarda valor do id do usuário.
        /// </summary>
        /// 
        public static int UserId;
        /// <summary>
        /// Atributo que guarda todos o dados do usuário para ser usado de forma global na aplicação.
        /// </summary>
        public static User GlobalUser = new User();

    }
}
