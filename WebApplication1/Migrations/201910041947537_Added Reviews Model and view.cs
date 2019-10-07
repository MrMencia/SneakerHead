namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedReviewsModelandview : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LeaveReviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LeaveReviewsForSeller = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LeaveReviews");
        }
    }
}
