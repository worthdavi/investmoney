using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investmoney.src.Models
{
    class ActiveModel
    {
        // Format: ticker, amount, price, description
        public string ticker { get; set; }
        public int amount { get; set; }
        public int price { get; set; }
        public string description { get; set; }
    }
}
