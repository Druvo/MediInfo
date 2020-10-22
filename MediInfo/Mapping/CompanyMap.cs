using MediInfo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediInfo.Mapping
{
    public class CompanyMap : EntityTypeConfiguration<Company>
    {
        public CompanyMap()
        {
            ToTable("Company");
            HasKey(m => m.Id);
            Property(c => c.Name).HasMaxLength(250).IsRequired();
        }
    }
}
