namespace VidlyApp_MVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PupulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into dbo.Genres(Name) values('Comedy')");
            Sql("Insert Into dbo.Genres(Name) values('Action')");
            Sql("Insert Into dbo.Genres(Name) values('Family')");
            Sql("Insert Into dbo.Genres(Name) values('Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
