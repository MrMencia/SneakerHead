namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShoesForSales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BrandofShoeForSale = c.Int(nullable: false),
                        NameOfShoe = c.String(),
                        CondiciondeZapatos = c.Int(nullable: false),
                        GetShoeSizeForSale = c.Int(nullable: false),
                        ApplicationId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationId)
                .Index(t => t.ApplicationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShoesForSales", "ApplicationId", "dbo.AspNetUsers");
            DropIndex("dbo.ShoesForSales", new[] { "ApplicationId" });
            DropTable("dbo.ShoesForSales");
        }
    }
}
