namespace MediInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class applicationc9 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Mobile = c.String(),
                        Adress = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Medicine", "Quantity");
            DropColumn("dbo.Medicine", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Medicine", "Price", c => c.Int());
            AddColumn("dbo.Medicine", "Quantity", c => c.Int());
            DropTable("dbo.Customers");
        }
    }
}
