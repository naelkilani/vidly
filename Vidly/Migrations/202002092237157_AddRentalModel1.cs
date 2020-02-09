namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddRentalModel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentals", "RentedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Rentals", "ReturnedDate", c => c.DateTime());
        }

        public override void Down()
        {
            DropColumn("dbo.Rentals", "ReturnedDate");
            DropColumn("dbo.Rentals", "RentedDate");
        }
    }
}
