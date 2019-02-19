namespace VidlyApp_MVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'57c797ac-06f3-43fd-be25-d150aeec18e5', N'guest@vidly.com', 0, N'AKi3y0bAJvhgoTBdJ9799MXVd4SO0+ga4JyImnSHE5ngDfYrF1cw9qzuk9fe9c8M0Q==', N'd4c45d49-b6d6-4ce7-aafe-c75b9f5bb1ca', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9f2096ee-5c91-4451-8302-4c59dfe3ca6e', N'admin@vidly.com', 0, N'AASugEBabRl3Kjj3vtmBo00AIOzTV9qwH6Gs4WwwarLi5cp75WbGaU1XSs/1y9ovfQ==', N'deccc457-2a88-474b-bcc7-820cbdc1e29f', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'996da7bf-2219-481d-a9be-832863d04e2a', N'CanManageMovies')

                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9f2096ee-5c91-4451-8302-4c59dfe3ca6e', N'996da7bf-2219-481d-a9be-832863d04e2a')


                ");
        }
        
        public override void Down()
        {
        }
    }
}
