using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investmoney.src.Models
{
    class OfferModel
    {
        // Format: id, amount, price, user_id, ticker_id, description
        public int id { get; set; }
        public int amount { get; set; }
        public int price { get; set; }
        public string ticker { get; set; }

    }
}
