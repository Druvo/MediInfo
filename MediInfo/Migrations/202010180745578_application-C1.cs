namespace MediInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class applicationC1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        Location = c.String(),
                        Created_at = c.DateTime(nullable: false),
                        Updated_at = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Compare",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Product_Id = c.Int(nullable: false),
                        Product_Name = c.String(),
                        Created_at = c.DateTime(nullable: false),
                        Updated_at = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Consumer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Created_at = c.DateTime(nullable: false),
                        Updated_at = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Medicine",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        Type = c.Int(nullable: false),
                        Company = c.Int(nullable: false),
                        Tags = c.String(),
                        Image = c.Int(nullable: false),
                        Code_name = c.String(),
                        Ingredient = c.String(),
                        Alternative = c.Int(nullable: false),
                        Consumer = c.Int(nullable: false),
                        Created_at = c.DateTime(nullable: false),
                        Updated_at = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Type",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Created_at = c.DateTime(nullable: false),
                        Updated_at = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Type");
            DropTable("dbo.Medicine");
            DropTable("dbo.Consumer");
            DropTable("dbo.Compare");
            DropTable("dbo.Company");
        }
    }
}
