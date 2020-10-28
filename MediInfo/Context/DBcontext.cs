using MediInfo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediInfo.Mapping;

namespace MediInfo.Context
{
    public class DBcontext : DbContext
    {
        public DBcontext () : base("name=DefaultConnection") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MedicineMap());
            modelBuilder.Configurations.Add(new CompanyMap());
            modelBuilder.Configurations.Add(new CompareMap());
            modelBuilder.Configurations.Add(new ConsumerMap());
            modelBuilder.Configurations.Add(new TypeMap());
        }

        public DbSet<Company> Company { get; set; }
        public DbSet<Compare> Compare { get; set; }
        public DbSet<Consumer> Consumer { get; set; }
        public DbSet<Medicine> Medicine { get; set; }
        public DbSet<Models.Type> Type { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<User> User { get; set; }
        public static DBcontext Create()
        {
            return new DBcontext();
        }
    }
}
