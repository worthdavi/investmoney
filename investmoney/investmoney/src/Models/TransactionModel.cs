using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investmoney.src.Models
{
    class TransactionModel
    {
        private int id { get; set; }
        public string ticker { get; set; }

        public int amount { get; set; }
        public double price { get; set; }
        private int user_id { get; set; }
        public string date { get; set; }

        public int getUserId()
        {
            return this.user_id;
        }

        public int getId()
        {
            return this.id;
        }
    }
}
