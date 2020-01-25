namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a86e3df2-b91c-4558-a4e3-a8bb126f40ee', N'admin@vidly.com', 0, N'AEJAGkIL8BhFbKiP06VEY9JUhei8q062Gl8wmLe5Jgdlzmj/bBxZLLF8QpHdnHa4Hg==', N'ac4929de-e1d6-43f6-8bcc-71ac0a167a52', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cf683045-fb39-4b07-8ea5-9e819eef3e5d', N'guest@vidly.com', 0, N'AM6+13kjk90+EuvAN8i3eB9/YfQj15RpyuQ7kLqyjS8p4+4jgz2NeCzclleXOQybPQ==', N'3715b6bd-e51f-4632-b9be-e0912ce98449', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'68a42b4b-635b-4b0d-982c-20827641e853', N'CanManageMovies')

                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a86e3df2-b91c-4558-a4e3-a8bb126f40ee', N'68a42b4b-635b-4b0d-982c-20827641e853')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
