namespace VidlyApp_MVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AssIsSubscibedToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubscribedToNewsLetter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSubscribedToNewsLetter");
        }
    }
}
