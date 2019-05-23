namespace VidlyMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBirthday : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday = NULL");
        }
        
        public override void Down()
        {
        }
    }
}
