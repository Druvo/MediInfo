using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using MediInfo.Models;
using System.Threading.Tasks;

namespace MediInfo.Mapping
{
    public class AppointmentMap : EntityTypeConfiguration<Categories>
    {
        public AppointmentMap()
        {
            ToTable("Appointment");
            HasKey(m => m.Id);
        }
    }
}
