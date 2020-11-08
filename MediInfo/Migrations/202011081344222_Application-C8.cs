namespace MediInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplicationC8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Medicine", "Price", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Medicine", "Price");
        }
    }
}
