using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediInfo.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int product { get; set; }
        public decimal Quantity { get; set; }
        public decimal PerchesPrice { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal CashAmount { get; set; }
        public decimal RetureAmount { get; set; }

        public DateTime Created_at { get; set; }

    }
}
