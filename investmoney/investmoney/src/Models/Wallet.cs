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
        // Format: id, amount, user_id, description
        public string id { get; set; }
        public int amount { get; set; }
        public int user_id { get; set; }
        public string description { get; set; }
    }
}
