namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingMigrationTypeNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET MembershipName = 'Pay As You Go' WHERE SignUpFee=0");
            Sql("UPDATE MembershipTypes SET MembershipName = 'Monthly' WHERE SignUpFee=30");
            Sql("UPDATE MembershipTypes SET MembershipName = 'Quaterly' WHERE SignUpFee=90");
            Sql("UPDATE MembershipTypes SET MembershipName = 'Yearly' WHERE SignUpFee=300");
        }
        
        public override void Down()
        {
        }
    }
}
