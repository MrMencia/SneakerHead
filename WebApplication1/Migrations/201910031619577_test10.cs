namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProjectedResaleValueCharts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RetailValueOfShoe = c.Int(nullable: false),
                        ProjectedResaleValue = c.Int(nullable: false),
                        LimitedShoe = c.Boolean(nullable: false),
                        ShoeConditionNew = c.Boolean(nullable: false),
                        ShoeConditionPreOwned = c.Boolean(nullable: false),
                        ShoeBeenReleasedWithinLastFewYears = c.Boolean(nullable: false),
                        HolidayShoe = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProjectedResaleValueCharts");
        }
    }
}
