namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomersTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsLetter, MembershipTypeId) VALUES ('Keil Carpenter', 'True', 1)");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsLetter, MembershipTypeId) VALUES ('Clarissa Walsh', 'False', 2)");
        }
        
        public override void Down()
        {
        }
    }
}
