namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class TryFixRentedDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rentals", "RentedDate", c => c.DateTime(nullable: false));
        }

        public override void Down()
        {
            AlterColumn("dbo.Rentals", "RentedDate", c => c.DateTime(nullable: false));
        }
    }
}
