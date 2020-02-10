namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAvailableNumberToMovie1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET AvailableNumber = StockNumber");
        }
        
        public override void Down()
        {
        }
    }
}
