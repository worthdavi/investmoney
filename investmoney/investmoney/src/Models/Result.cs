using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investmoney.src.DAO
{
    class Result
    {
        // Format: ativo, amount, price, average_price, total_cost, market_value, LP, DN

        public string ativo { get; set; }
        public int amount { get; set; }
        public double price { get; set; }
        public double average_price { get; set; }
        public double total_cost { get; set; }
        public double market_value { get; set; }
        public double LP { get; set; }
        public string DN { get; set; }
    }
}
