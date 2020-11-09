using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediInfo.Models
{
    public class SalesDetails
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int product { get; set; }
        public decimal StockId { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal Total { get; set; }

    }
}
