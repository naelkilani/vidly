namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class UpdateNameMemberships : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Memberships SET Name = 'Pay As You Go' WHERE DurationInMonths = 0");
            Sql("UPDATE Memberships SET Name = 'Monthly' WHERE DurationInMonths = 1");
            Sql("UPDATE Memberships SET Name = 'Quarterly' WHERE DurationInMonths = 3");
            Sql("UPDATE Memberships SET Name = 'Yearly' WHERE DurationInMonths = 12");
        }

        public override void Down()
        {
        }
    }
}
