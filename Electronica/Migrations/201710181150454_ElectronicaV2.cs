namespace Electronica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ElectronicaV2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactUs",
                c => new
                    {
                        VisitorId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        PhoneNumber = c.String(),
                        Message = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.VisitorId);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        ProductTypeId = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductTypeId);
            
            AddColumn("dbo.Products", "CategoryId", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "ProductTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "CategoryId");
            CreateIndex("dbo.Products", "ProductTypeId");
            AddForeignKey("dbo.Products", "CategoryId", "dbo.ProductCategories", "CategoryId", cascadeDelete: true);
            AddForeignKey("dbo.Products", "ProductTypeId", "dbo.ProductTypes", "ProductTypeId", cascadeDelete: true);
            DropColumn("dbo.Products", "Category");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Category", c => c.String());
            DropForeignKey("dbo.Products", "ProductTypeId", "dbo.ProductTypes");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.ProductCategories");
            DropIndex("dbo.Products", new[] { "ProductTypeId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropColumn("dbo.Products", "ProductTypeId");
            DropColumn("dbo.Products", "CategoryId");
            DropTable("dbo.ProductTypes");
            DropTable("dbo.ProductCategories");
            DropTable("dbo.ContactUs");
        }
    }
}
