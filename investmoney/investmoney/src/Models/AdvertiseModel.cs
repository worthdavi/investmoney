using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investmoney.src.Models
{
    class AdvertiseModel
    {
        // Format: id, amount, price, user_id, ticker_id, description
        public int id { get; set; }
        public int amount { get; set; }
        public int price { get; set; }
        private int type { get; set; }
        private int wallet_id { get; set; }
        public string ticker { get; set; }

        public void setType(int type)
        {
            this.type = type;
        }
        public void setWalletId(int id)
        {
            this.wallet_id = id;
        }

        public int getType()
        {
            return this.type;
        }
        public int getWalletId()
        {
            return this.wallet_id;
        }
    }
}
