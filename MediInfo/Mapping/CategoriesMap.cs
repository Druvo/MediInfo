using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using MediInfo.Models;
using System.Threading.Tasks;

namespace MediInfo.Mapping
{
    public class CategoriesMap : EntityTypeConfiguration<Categories>
    {
        public CategoriesMap()
        {
            ToTable("Categories");
            HasKey(m => m.Id);
        }
    }
}
