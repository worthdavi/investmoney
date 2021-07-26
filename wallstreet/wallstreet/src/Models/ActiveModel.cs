using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wallstreet.src.Models
{
    class ActiveModel
    {
        // Format: ticker,share_amount, share_price, description
        public string ticker { get; set; }
        public int share_amount { get; set; }
        public int share_price { get; set; }
        public string description { get; set; }
    }
}
