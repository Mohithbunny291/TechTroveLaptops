namespace TechTroveLaptops.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSeedData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Laptops",
                c => new
                    {
                        LaptopId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Description = c.String(maxLength: 500),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.LaptopId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        LaptopId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        CustomerName = c.String(nullable: false, maxLength: 100),
                        CustomerEmail = c.String(nullable: false, maxLength: 100),
                        OrderDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Laptops", t => t.LaptopId, cascadeDelete: true)
                .Index(t => t.LaptopId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "LaptopId", "dbo.Laptops");
            DropIndex("dbo.Orders", new[] { "LaptopId" });
            DropTable("dbo.Orders");
            DropTable("dbo.Laptops");
        }
    }
}
