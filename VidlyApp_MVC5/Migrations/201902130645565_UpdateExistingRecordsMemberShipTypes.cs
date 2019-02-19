namespace VidlyApp_MVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateExistingRecordsMemberShipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.MembershipTypes " +
                "SET Name = " +
                "CASE " +
                "WHEN Id = '1' THEN 'PayasYouGo'" +
                "WHEN Id = '2' THEN 'Monthly'" +
                "WHEN Id = '3' THEN 'Quaterly'" +
                "WHEN Id = '4' THEN 'Yearly'" +
                "ELSE ''" +
                "END" +
                " WHERE Id IN('1', '2', '3', '4')");
        }
        
        public override void Down()
        {
        }
    }
}
