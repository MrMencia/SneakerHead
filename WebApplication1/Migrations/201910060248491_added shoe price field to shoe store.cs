namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedshoepricefieldtoshoestore : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ShoesForSales", "ShoePrice", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ShoesForSales", "ShoePrice");
        }
    }
}
