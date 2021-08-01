using investmoney.src.Controllers;
using investmoney.src.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investmoney.src.Models
{
    class Wallet
    {
        // Format: id, amount, price, user_id, ticker_id, description
        private int id { get; set; }
        public string ticker { get; set; }
        public int amount { get; set; }
        public double unity { get; set; }
        private int user_id { get; set; }
        public string description { get; set; }
        
    }
}
