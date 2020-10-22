using MediInfo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediInfo.Mapping
{
    public class CompareMap : EntityTypeConfiguration<Compare>
    {
        public CompareMap()
        {
            ToTable("Compare");
            HasKey(m => m.Id);
        }
    }
}
