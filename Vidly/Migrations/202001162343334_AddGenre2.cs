namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenre2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Movies");
            AlterColumn("dbo.Movies", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "AddedDate", c => c.DateTime(nullable: false));
            AddPrimaryKey("dbo.Movies", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Movies");
            AlterColumn("dbo.Movies", "AddedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Movies", "Id");
        }
    }
}
