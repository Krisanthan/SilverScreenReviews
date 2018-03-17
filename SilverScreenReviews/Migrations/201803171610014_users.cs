namespace SilverScreenReviews.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class users : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        rating = c.Int(nullable: false),
                        DateReviewed = c.DateTime(nullable: false),
                        Movie_Id = c.Int(nullable: false),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movies", t => t.Movie_Id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.Movie_Id)
                .Index(t => t.User_Id);
            
            AddColumn("dbo.Movies", "averageRating", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Reviews", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.Reviews", new[] { "User_Id" });
            DropIndex("dbo.Reviews", new[] { "Movie_Id" });
            DropColumn("dbo.Movies", "averageRating");
            DropTable("dbo.Reviews");
        }
    }
}
