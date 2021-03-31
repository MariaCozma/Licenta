namespace Licenta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers1 : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [Phone]) VALUES (N'45070655-e3de-42b4-a3b5-523ca7969fbe', N'admin@gmail.com', 0, N'ALhD4e/aZVtskSnMVaByf2KznXZE/fk4ka9U8w9d6X3eEXylhlxy7zJTeOEe7jKgUw==', N'0672bef8-ce0f-47fe-802f-ed6dbed7cbeb', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com', N'12345', NULL)
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [Phone]) VALUES (N'9878b5c9-6bb0-47cf-9afc-68845ffc5b30', N'admin1@gmail.com', 0, N'AOp+tbQv9seU1Sme8SwzhIT73EfUVhj0kvBPM8d0Es4tbUfbtAphNR6a2EgpqAFCsw==', N'10cb8dab-bbea-40a3-a996-3d5fe7a6b34c', NULL, 0, 0, NULL, 1, 0, N'admin1@gmail.com', N'123456', NULL)
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [Phone]) VALUES (N'b8032a4e-4e9f-4e85-9c35-171314b06efd', N'admin2@gmail.com', 0, N'ACcW/Z50PzamDxkpXBIn00H45dP/7zyC5PaIrizGxdjEuEHO42PBF3KAmArWBoB99Q==', N'48d4da62-df55-49c6-aefd-1455a09308e7', NULL, 0, 0, NULL, 1, 0, N'admin2@gmail.com', N'1235', NULL)
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [Phone]) VALUES (N'ee3c809e-c3ff-444b-afb6-4f0979767057', N'guest@user.com', 0, N'ADdxIGuAL+eecoAvm15aJldkBn5BxcMxFyH/l9y1o8/K+/ea6xFZv5soZs+Q23FdLg==', N'57af9c5b-84b7-4cb8-91e3-346a6774e9cc', NULL, 0, 0, NULL, 1, 0, N'guest@user.com', N'123456', NULL)

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'49f51476-f5ab-4978-b9ef-5e1481b56732', N'CanManageBooks')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ddc47e82-626f-4beb-8c78-66097133ad0b', N'CanManageCustomer')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'45070655-e3de-42b4-a3b5-523ca7969fbe', N'49f51476-f5ab-4978-b9ef-5e1481b56732')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9878b5c9-6bb0-47cf-9afc-68845ffc5b30', N'49f51476-f5ab-4978-b9ef-5e1481b56732')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b8032a4e-4e9f-4e85-9c35-171314b06efd', N'49f51476-f5ab-4978-b9ef-5e1481b56732')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'45070655-e3de-42b4-a3b5-523ca7969fbe', N'ddc47e82-626f-4beb-8c78-66097133ad0b')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9878b5c9-6bb0-47cf-9afc-68845ffc5b30', N'ddc47e82-626f-4beb-8c78-66097133ad0b')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b8032a4e-4e9f-4e85-9c35-171314b06efd', N'ddc47e82-626f-4beb-8c78-66097133ad0b')

");
        }
        
        public override void Down()
        {
        }
    }
}
