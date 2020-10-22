using MediInfo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediInfo.Mapping
{
    public class ConsumerMap : EntityTypeConfiguration<Consumer>
    {
        public ConsumerMap()
        {
            ToTable("Consumer");
            HasKey(m => m.Id);
        }
    }
}
