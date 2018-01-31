namespace SilverScreenReviews.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths) VALUES (1, 0, 0)"); // free
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths) VALUES (2, 5, 1)"); // monthly membership
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths) VALUES (3, 40, 12)"); // yearly membership
        }

        public override void Down()
        {
        }
    }
}
