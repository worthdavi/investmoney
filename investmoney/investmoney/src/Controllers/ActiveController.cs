using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using investmoney.src.DAO;
using investmoney.src.Models;

namespace investmoney.src.Controllers
{
    class ActiveController
    {
        public int Register(String nome, String quantidade, String preco, String descricao)
        {
            int quantidadeParse = Convert.ToInt32(quantidade);
            int precoParse = Convert.ToInt32(preco);
            ActiveDao activeDao = new ActiveDao();

            int result = activeDao.Create(nome, quantidadeParse, precoParse, descricao);

            if (result == 1) return 1;
            else return 0;
        }

        public List<String> GetActivesNames()
        {
            ActiveDao active = new ActiveDao();
            List<String> list = active.GetActivesNames();
            return list;
        }

        public int GetActiveAmountByTickerId(string ticker)
        {
            ActiveDao active = new ActiveDao();
            int amount = active.GetActiveAmountByTickerId(ticker);
            return amount;
        }

        public double GetActivePriceByTickerId(string ticker)
        {
            ActiveDao active = new ActiveDao();
            double amount = active.GetActivePriceByTickerId(ticker);
            return amount;
        }

        public ActiveModel GetActiveByTicker(string ticker)
        {
            ActiveDao dao = new ActiveDao();
            return dao.GetActiveByTicker(ticker);
        }

        public List<ActiveModel> GetActiveList()
        {
            ActiveDao activeDao = new ActiveDao();
            List<ActiveModel> activeModels = activeDao.GetActiveList();
            return activeModels;
        }
    }
}
