namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changednameinProjectedResaleValueChartmodelclass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProjectedResaleValueCharts", "RetroedOften", c => c.Boolean(nullable: false));
            DropColumn("dbo.ProjectedResaleValueCharts", "ShoeBeenReleasedWithinLastFewYears");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProjectedResaleValueCharts", "ShoeBeenReleasedWithinLastFewYears", c => c.Boolean(nullable: false));
            DropColumn("dbo.ProjectedResaleValueCharts", "RetroedOften");
        }
    }
}
