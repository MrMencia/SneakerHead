namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdtop9mostprofitablesneakersmodelandview : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Top9MostProfitable",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SneakerName = c.String(),
                        RetailValue = c.String(),
                        ResaleValue = c.String(),
                        ValueIncrease = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Top9MostProfitable");
        }
    }
}
