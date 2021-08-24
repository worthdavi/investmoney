using investmoney.src.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investmoney.src.DAO
{

    class AdvertiseDao
    {
        public int CreateOffer(int amount, int price, int type, int wallet_id)
        {
            AdvertiseModel offer = new AdvertiseModel();
            offer.amount = amount;
            offer.price = price;
            offer.type = type;
            offer.wallet_id = wallet_id;
            return SQLiteControl.CreateOffer(offer);
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
