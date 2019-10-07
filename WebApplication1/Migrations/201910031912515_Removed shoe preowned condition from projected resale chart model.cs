namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Removedshoepreownedconditionfromprojectedresalechartmodel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ProjectedResaleValueCharts", "ShoeConditionPreOwned");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProjectedResaleValueCharts", "ShoeConditionPreOwned", c => c.Boolean(nullable: false));
        }
    }
}
