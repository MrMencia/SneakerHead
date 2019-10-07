namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test5 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SneakerBuyers", "UserRoles");
            DropColumn("dbo.SneakerSellers", "UserRoles");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SneakerSellers", "UserRoles", c => c.String());
            AddColumn("dbo.SneakerBuyers", "UserRoles", c => c.String());
        }
    }
}
