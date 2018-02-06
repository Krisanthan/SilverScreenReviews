namespace SilverScreenReviews.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "genre", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "genre");
        }
    }
}
