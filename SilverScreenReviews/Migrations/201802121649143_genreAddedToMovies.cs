namespace SilverScreenReviews.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class genreAddedToMovies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Genre_name", c => c.String());
            DropColumn("dbo.Movies", "genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "genre", c => c.String());
            DropColumn("dbo.Movies", "Genre_name");
        }
    }
}
