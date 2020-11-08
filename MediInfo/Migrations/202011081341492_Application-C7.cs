namespace MediInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplicationC7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Medicine", "Quantity", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Medicine", "Quantity");
        }
    }
}
