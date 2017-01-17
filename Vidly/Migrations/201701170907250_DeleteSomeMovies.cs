namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteSomeMovies : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM 'Movies' WHERE ()");
        }
        
        public override void Down()
        {
        }
    }
}
