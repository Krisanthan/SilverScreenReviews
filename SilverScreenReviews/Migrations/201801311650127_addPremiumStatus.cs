namespace SilverScreenReviews.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPremiumStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "premiumStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "premiumStatus");
        }
    }
}
