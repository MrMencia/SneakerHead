namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SneakerBuyers", "UserRoles", c => c.String());
            AddColumn("dbo.SneakerSellers", "UserRoles", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SneakerSellers", "UserRoles");
            DropColumn("dbo.SneakerBuyers", "UserRoles");
        }
    }
}
