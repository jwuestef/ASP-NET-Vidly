namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f099c732-b1e0-4fcc-9cf2-ad0b081ce08e', N'admin@vidly.com', 0, N'AJrPxc8B0Mnep1M4XxJx9baPztorabJSF/rJTGrfuoAj8yKp0d0UHh4mW5NGlAzZ+w==', N'631baeb8-4180-4a41-b2ea-ba613a6d0217', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f8e364d0-eec0-4ca9-8a33-8710233f150c', N'guest@vidly.com', 0, N'ADI8gGn0Pwrz0SesnZTyR32xgkyuFsnPpPD+Wf0BQNJ/lPmZ3eK7pkkBaP8fMMyvkA==', N'11035765-a08f-4dd1-ba2f-07a8f31c7417', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'cf259083-4025-4bc4-8b81-d1cd829e8edd', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f099c732-b1e0-4fcc-9cf2-ad0b081ce08e', N'cf259083-4025-4bc4-8b81-d1cd829e8edd')
");
        }
        
        public override void Down()
        {
        }
    }
}
