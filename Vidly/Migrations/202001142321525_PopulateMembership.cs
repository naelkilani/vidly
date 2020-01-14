namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateMembership : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Memberships ON");

            Sql("INSERT INTO Memberships (Id, DurationInMonths, SignUpFee, DiscountRate) VALUES (1, 0, 0, 0)");
            Sql("INSERT INTO Memberships (Id, DurationInMonths, SignUpFee, DiscountRate) VALUES (2, 1, 30, .10)");
            Sql("INSERT INTO Memberships (Id, DurationInMonths, SignUpFee, DiscountRate) VALUES (3, 3, 90, .15)");
            Sql("INSERT INTO Memberships (Id, DurationInMonths, SignUpFee, DiscountRate) VALUES (4, 12, 300, .20)");

            Sql("SET IDENTITY_INSERT Memberships OFF");

        }

        public override void Down()
        {
        }
    }
}
