namespace MediInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplicationC4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "Created_at", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Appointments", "Created_at");
        }
    }
}
