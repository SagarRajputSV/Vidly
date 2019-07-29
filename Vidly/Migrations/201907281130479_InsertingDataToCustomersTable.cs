namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertingDataToCustomersTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers(CustomerName,IsSubscribedToNewsLetter,MembershipId)" +
                "VALUES('Bob','True',1),('Nicholas','True',2),('Marley','False',4)");
        }
        
        public override void Down()
        {
        }
    }
}
