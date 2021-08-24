using investmoney.src.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investmoney.src.Controllers
{
    class AdvertiseController
    {
        public int CreateOffer(int amount, int price, int type, int wallet_id)
        {
            AdvertiseDao advertise = new AdvertiseDao();

            int result = advertise.CreateOffer(amount, price, type, wallet_id);

            if (result == 1) 
                return 1;
            else 
                return 0;
        }
    }
}
