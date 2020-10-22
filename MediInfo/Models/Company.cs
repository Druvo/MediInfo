using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediInfo.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
    }
}
