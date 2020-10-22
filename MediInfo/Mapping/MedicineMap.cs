using MediInfo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace MediInfo.Mapping
{
    public class MedicineMap : EntityTypeConfiguration<Medicine>
    {
        public MedicineMap()
        {
            ToTable("Medicine");
            HasKey(m => m.Id);
            Property(c => c.Name).HasMaxLength(250).IsRequired();
        }
    }
}