namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES (Name) VALUES ('Comedy'), ('Action'), ('Family'), ('Romance')");
        }

        public override void Down()
        {
        }
    }
}
