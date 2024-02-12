namespace TechTroveLaptops.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TechTroveLaptops.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TechTroveLaptops.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TechTroveLaptops.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            // Seed data for Laptops
            context.Laptops.AddOrUpdate(x => x.LaptopId,
                new Laptop { LaptopId = 1, Name = "Laptop A", Description = "High performance laptop", Price = 1200.00M, ImageUrl = "imageUrl1.jpg" },
                new Laptop { LaptopId = 2, Name = "Laptop B", Description = "Budget friendly laptop", Price = 450.00M, ImageUrl = "imageUrl2.jpg" },
                new Laptop { LaptopId = 3, Name = "Laptop C", Description = "Best for gaming", Price = 2200.00M, ImageUrl = "imageUrl3.jpg" },
                new Laptop { LaptopId = 4, Name = "Laptop D", Description = "Lightweight and powerful", Price = 1500.00M, ImageUrl = "imageUrl4.jpg" },
                new Laptop { LaptopId = 5, Name = "Laptop E", Description = "Ideal for business", Price = 980.00M, ImageUrl = "imageUrl5.jpg" }
            );

            // Seed data for Orders - assuming each laptop has at least one order
            context.Orders.AddOrUpdate(x => x.OrderId,
                new Order { OrderId = 1, LaptopId = 1, Quantity = 1, CustomerName = "John Doe", CustomerEmail = "john.doe@example.com", OrderDate = DateTime.Now },
                new Order { OrderId = 2, LaptopId = 2, Quantity = 2, CustomerName = "Jane Smith", CustomerEmail = "jane.smith@example.com", OrderDate = DateTime.Now.AddDays(-1) },
                new Order { OrderId = 3, LaptopId = 3, Quantity = 1, CustomerName = "William Johnson", CustomerEmail = "william.johnson@example.com", OrderDate = DateTime.Now.AddDays(-2) },
                new Order { OrderId = 4, LaptopId = 4, Quantity = 1, CustomerName = "Patricia Williams", CustomerEmail = "patricia.williams@example.com", OrderDate = DateTime.Now.AddDays(-3) },
                new Order { OrderId = 5, LaptopId = 5, Quantity = 3, CustomerName = "Michael Brown", CustomerEmail = "michael.brown@example.com", OrderDate = DateTime.Now.AddDays(-4) }
            );
        }
    }
}
