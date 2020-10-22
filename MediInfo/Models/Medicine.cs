using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediInfo.Models
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int Company { get; set; }
        public string Tags { get; set; }
        public int Image { get; set; }
        public string Code_name { get; set; }
        public string Ingredient { get; set; }
        public int Alternative { get; set; }
        public int Consumer { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
    }
}
