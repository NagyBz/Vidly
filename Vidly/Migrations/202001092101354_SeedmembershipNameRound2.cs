namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedmembershipNameRound2 : DbMigration
    {
        public override void Up()
        {
            Sql("update Membershiptypes set Name='Quarterly' where Id=3");
            Sql("update Membershiptypes set Name='Yearly' where Id=4");
        }
        
        public override void Down()
        {
        }
    }
}
