namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'65cd46e2-22e7-4e1a-91e1-d0653ef4b1d0', N'admin@gmail.com', 0, N'ALuyip1+KIpycw54ddpgYVdN+46JbsBbYg+Z3eL2wX1dcQEDddFTpYXQrEf0otbQOw==', N'54f864b9-5cc0-4779-bc7d-5d9d0b1c1975', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'79129138-028b-43f1-9f24-1386107480a9', N'Nazar@gmail.com', 0, N'AFc0ZsCbjelaK2zJMtaz1XLL/Ir2FRR4yj7WzBHvk9p2kyqCfwGHJBjK/8WMszz/ug==', N'aaef1a79-5594-49b3-b825-017f8ca3f1fd', NULL, 0, 0, NULL, 1, 0, N'Nazar@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'dff3bde2-4e96-4210-ae4a-14cc22f85fff', N'grthggtr@gmail.com', 0, N'ANAS9/zp2BTPNwjupkWwZCNiIg+8yu5X3QMrZcSSkmqH9YP5rDtH2z23KJ0JsgjYIg==', N'8ce6dd1d-5877-416f-a1b3-57ef016de285', NULL, 0, 0, NULL, 1, 0, N'grthggtr@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'22b1e773-469b-4ac9-baba-76c9d78b9576', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'65cd46e2-22e7-4e1a-91e1-d0653ef4b1d0', N'22b1e773-469b-4ac9-baba-76c9d78b9576')

");
        }
        
        public override void Down()
        {
        }
    }
}
