namespace Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'71673eb6-9020-4445-ad0a-6487399aead6', N'Admin@Store.com', 0, N'AOOo6dDDAWXr1BiDAYv2ZwEZflrIqKyQiPHa5C6NOUnG7WPOhyrmSdALUyS3/cnAtg==', N'f035290c-0c88-4e33-8e2a-26b05fc7ca7e', NULL, 0, 0, NULL, 1, 0, N'Admin@Store.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e656378e-b5aa-4134-926d-82aa6dba4e5e', N'guest@store.com', 0, N'ABYMNud5PsxMHYIHy2/B4q2fSBhO+xzdI7XvdflIoQZ/S5eCW4/ESGoIhYcmeb9drg==', N'89cd8da0-0585-443a-8f8f-afe9a4dd30fc', NULL, 0, 0, NULL, 1, 0, N'guest@store.com')
                
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a2bac421-4597-463e-a5b3-b4edaeb139c2', N'Admin')
              
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'71673eb6-9020-4445-ad0a-6487399aead6', N'a2bac421-4597-463e-a5b3-b4edaeb139c2')

");
        }
        
        public override void Down()
        {
        }
    }
}
