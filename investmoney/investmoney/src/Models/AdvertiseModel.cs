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
        private int id { get; set; }
        public int amount { get; set; }
        public int price { get; set; }
        public int type { get; set; }
        public int wallet_id { get; set; }

    }
}
