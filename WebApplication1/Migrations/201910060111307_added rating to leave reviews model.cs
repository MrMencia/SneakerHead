namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedratingtoleavereviewsmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LeaveReviews", "RateSellerBasedOnExperience", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.LeaveReviews", "RateSellerBasedOnExperience");
        }
    }
}
