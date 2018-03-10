namespace SilverScreenReviews.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1163b58b-fa84-41a7-8bb7-198c80ed8406', N'admin@silverscreen.com', 0, N'AAhMP7mej0NIfFDwVwt9IoKwMZzPDsLtOKNDII19wO7S10GRyzagaUGCHfUZufUETg==', N'ac5800d5-2e7d-4b94-bb0f-e9a730be194f', NULL, 0, 0, NULL, 1, 0, N'admin@silverscreen.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'33ccc659-afbf-4b20-a20f-2f904a77e331', N'guest@silverscreen.com', 0, N'AKRlM4Qg0Jb9ZegXKCPOu+fsEZyI9bgGBQ6pQyivqnX3T/Rh+k+ErUce8KlvVuhHJQ==', N'd7ce90d7-99d0-44f8-8614-95ccbc4a7a49', NULL, 0, 0, NULL, 1, 0, N'guest@silverscreen.com')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1163b58b-fa84-41a7-8bb7-198c80ed8406', N'd334e510-7740-4c95-903d-715948eb3227')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
