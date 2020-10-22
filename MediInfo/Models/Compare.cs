using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediInfo.Models
{
    public class Compare
    {
        public int Id { get; set; }
        public int Product_Id { get; set; }
        public string Product_Name { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
    }
}
