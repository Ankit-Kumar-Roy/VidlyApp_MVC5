namespace VidlyApp_MVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMemberShipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) values(1, 0, 0, 0)");
            Sql("Insert Into MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) values(2, 30, 1, 10)");
            Sql("Insert Into MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) values(3, 90, 4, 15)");
            Sql("Insert Into MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) values(4, 300, 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}