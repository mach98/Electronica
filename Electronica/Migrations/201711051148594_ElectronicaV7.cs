namespace Electronica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ElectronicaV7 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Members");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MemberId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailId = c.String(),
                        Password = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        GenderId = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                        ProfilePicture = c.String(),
                    })
                .PrimaryKey(t => t.MemberId);
            
        }
    }
}
