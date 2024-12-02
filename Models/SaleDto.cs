using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApp3.Models
{
    internal class SaleDto
    {
        public string Product { get; set; }
        public int Count { get; set; }

        public DateTime Datetime { get; set; }

        public SaleDto(string product, int count, DateTime datetime)
        {
            Product = product;
            Count = count;
            Datetime = datetime;
        }
    }
}
