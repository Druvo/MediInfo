namespace MediInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplicationC3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.String(),
                        Gender = c.String(),
                        Problem = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Appointments");
        }
    }
}
