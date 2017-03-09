namespace SalesMIgration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClumnDescriptionToProducts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        CreditCardNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Customers_Id = c.Int(),
                        Products_Id = c.Int(),
                        StoreLocation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customers_Id)
                .ForeignKey("dbo.Products", t => t.Products_Id)
                .ForeignKey("dbo.StoreLocations", t => t.StoreLocation_Id)
                .Index(t => t.Customers_Id)
                .Index(t => t.Products_Id)
                .Index(t => t.StoreLocation_Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Quantity = c.Int(nullable: false,defaultValue:1),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(nullable: false,defaultValue:"No description"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StoreLocations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LocationName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales", "StoreLocation_Id", "dbo.StoreLocations");
            DropForeignKey("dbo.Sales", "Products_Id", "dbo.Products");
            DropForeignKey("dbo.Sales", "Customers_Id", "dbo.Customers");
            DropIndex("dbo.Sales", new[] { "StoreLocation_Id" });
            DropIndex("dbo.Sales", new[] { "Products_Id" });
            DropIndex("dbo.Sales", new[] { "Customers_Id" });
            DropTable("dbo.StoreLocations");
            DropTable("dbo.Products");
            DropTable("dbo.Sales");
            DropTable("dbo.Customers");
        }
    }
}
