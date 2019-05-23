namespace VidlyMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNameInMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Annually' WHERE MembershipTypeId = 4");
            Sql("UPDATE MembershipTypes SET Name = 'Pay as you go' WHERE MembershipTypeId = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE MembershipTypeId = 2");
            Sql("UPDATE MembershipTypes SET Name = 'Quarterly' WHERE MembershipTypeId = 3");
            
        }
        
        public override void Down()
        {
        }
    }
}
