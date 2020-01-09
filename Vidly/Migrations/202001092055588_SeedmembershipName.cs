namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedmembershipName : DbMigration
    {
        public override void Up()
        {
            Sql("update Membershiptypes set Name='Pay as You Go' where Id=1");
            Sql("update Membershiptypes set Name='Monthly' where Id=2");
            Sql("update Membershiptypes set Name='Yearly' where Id=3");
        }
        
        public override void Down()
        {
        }
    }
}
