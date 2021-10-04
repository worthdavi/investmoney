using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using investmoney.src.DAO;
using investmoney.src.Models;

namespace investmoney.src.Controllers
{
    /// <summary>
    /// A classe **ActiveController** é uma classe de controler, responsável por abragnder todas a ações referente a Active.
    /// </summary>
    class ActiveController
    {
        /// <summary>
        /// O metodo que faz registo de active.
        /// </summary>
        /// <param name="nome">O nome do active a ser registado</param>
        /// <param name="quantidade">A quantidade do active que deseja colocar para vender.</param>
        /// <param name="preco">A preço do active que está cadastrando.</param>
        /// <param name="descricao">Defina uma descrição do activo que está registrando.</param>
        /// <returns>Retorna 1 se o registo do active for realizado com sucesso ou 0 se caso ocorra um erra na operação.</returns>
        public int Register(String nome, String quantidade, String preco, String descricao)
        {
            int quantidadeParse = Convert.ToInt32(quantidade);
            int precoParse = Convert.ToInt32(preco);
            ActiveDao activeDao = new ActiveDao();

            int result = activeDao.Create(nome, quantidadeParse, precoParse, descricao);

            if (result == 1) return 1;
            else return 0;
        }
        /// <summary>
        /// O metodo que atualiza o active.
        /// </summary>
        /// <param name="active">O active a ser atualizado</param>
        /// <returns>Retorna 1 se a operação for realizado com sucesso ou 0 se caso ocorra um erra na operação.</returns>
        public int SaveActive(ActiveModel active)
        {
            int result = ActiveDao.SaveActive(active);
            if (result == 1) return 1;
            else return 0;
        }

        /// <summary>
        /// O metodo lista os nome de todos os Active registrado.
        /// </summary>
        /// <returns>Retorna o nome de todos os Active registrado.</returns>
        public List<String> GetActivesNames()
        {
            ActiveDao active = new ActiveDao();
            List<String> list = active.GetActivesNames();
            return list;
        }

        /// <summary>
        /// O metodo retona a quantidade de um Active.
        /// </summary>
        /// <param name="ticker">O ticker que deseja buscar.</param>
        /// <returns>Retorna a quantidade de um Active a parti de um ticker especifico</returns>
        public int GetActiveAmountByTickerId(string ticker)
        {
            ActiveDao active = new ActiveDao();
            int amount = active.GetActiveAmountByTickerId(ticker);
            return amount;
        }

        /// <summary>
        /// O metodo retorna o preço de um Active.
        /// </summary>
        /// <param name="ticker">O ticker que deseja buscar.</param>
        /// <returns>Retorna o preço de um Active a partir de um ticker especifico</returns>
        public double GetActivePriceByTickerId(string ticker)
        {
            ActiveDao active = new ActiveDao();
            double amount = active.GetActivePriceByTickerId(ticker);
            return amount;
        }

        /// <summary>
        /// O metodo retorna um Active especifico.
        /// </summary>
        /// <param name="ticker">O ticker que deseja buscar.</param>
        /// <returns>Retorna um Active especifico a partir de ticker.</returns>
        public ActiveModel GetActiveByTicker(string ticker)
        {
            ActiveDao dao = new ActiveDao();
            return dao.GetActiveByTicker(ticker);
        }


        /// <summary>
        /// O metodo lista todos os active.
        /// </summary>
        /// <returns>Retorna uma lista actives baseada no modelo de Active.</returns>
        public List<ActiveModel> GetActiveList()
        {
            ActiveDao activeDao = new ActiveDao();
            List<ActiveModel> activeModels = activeDao.GetActiveList();
            return activeModels;
        }
    }
}
