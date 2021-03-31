namespace Licenta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [Phone]) VALUES (N'802e8b32-e427-4a80-a0b1-b5c8b0660664', N'admin@gmail.com', 0, N'AIqPkKf54nSvLbmryH+6Yyfog8ZA9x0pazrEXGTt9Zp1gsN8mubpwo68VyMmssP7Kg==', N'8bfb82ac-15e1-4962-889d-b55a4a85bd31', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com', N'8975', NULL)
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c96b4b66-9536-435c-9205-783e398a890a', N'guest@user.com', 0, N'AK4neEwhiLryK7XStoshP4ztbi70tDWld6LonIXE9dKIIRDidoGF8DxvYWbJbFvEGg==', N'cfc721bd-d4fe-4062-b1c5-1bd3a4e326d6', NULL, 0, 0, NULL, 1, 0, N'guest@user.com')


INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ea54cfc3-64f9-47ce-932a-6c2ecb6e2d78', N'CanManageBooks')


INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'802e8b32-e427-4a80-a0b1-b5c8b0660664', N'ea54cfc3-64f9-47ce-932a-6c2ecb6e2d78')



");
        }
        
        public override void Down()
        {
        }
    }
}
