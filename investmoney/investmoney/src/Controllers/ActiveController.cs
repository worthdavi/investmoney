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

        public List<ActiveModel> GetActiveList()
        {
            ActiveDao activeDao = new ActiveDao();
            List<ActiveModel> activeModels = activeDao.GetActiveList();
            return activeModels;
        }
    }
}
