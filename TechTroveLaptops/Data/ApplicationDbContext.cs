using System.Data.Entity;
using TechTroveLaptops.Models;

namespace TechTroveLaptops.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name=DefaultConnection")
        {
        }

        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
