namespace Electronica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ElectronicaV3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductCategories", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "ProductImage", c => c.String());
            AddColumn("dbo.Products", "IsFeatured", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "FName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LName", c => c.String());
            AddColumn("dbo.AspNetUsers", "Address", c => c.String());
            AddColumn("dbo.AspNetUsers", "CreatedOn", c => c.DateTime());
            AddColumn("dbo.AspNetUsers", "ModifiedOn", c => c.DateTime());
            AddColumn("dbo.AspNetUsers", "GenderId", c => c.Int());
            AddColumn("dbo.AspNetUsers", "IsActive", c => c.Boolean());
            AddColumn("dbo.AspNetUsers", "IsDelete", c => c.Boolean());
            AddColumn("dbo.AspNetUsers", "ProfilePicture", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "ProfilePicture");
            DropColumn("dbo.AspNetUsers", "IsDelete");
            DropColumn("dbo.AspNetUsers", "IsActive");
            DropColumn("dbo.AspNetUsers", "GenderId");
            DropColumn("dbo.AspNetUsers", "ModifiedOn");
            DropColumn("dbo.AspNetUsers", "CreatedOn");
            DropColumn("dbo.AspNetUsers", "Address");
            DropColumn("dbo.AspNetUsers", "LName");
            DropColumn("dbo.AspNetUsers", "FName");
            DropColumn("dbo.Products", "IsFeatured");
            DropColumn("dbo.Products", "ProductImage");
            DropColumn("dbo.ProductCategories", "IsActive");
        }
    }
}
