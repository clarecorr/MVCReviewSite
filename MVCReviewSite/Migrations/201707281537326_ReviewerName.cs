namespace MVCReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReviewerName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "ReviewerName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "ReviewerName");
        }
    }
}
