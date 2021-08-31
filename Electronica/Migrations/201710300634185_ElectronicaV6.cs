namespace Electronica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ElectronicaV6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProductTypes", "Type", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductTypes", "Type", c => c.Int(nullable: false));
        }
    }
}
