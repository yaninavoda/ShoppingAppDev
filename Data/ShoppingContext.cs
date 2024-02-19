using Microsoft.EntityFrameworkCore;
using ShoppingAppDev.Models;

namespace ShoppingAppDev.Data
{
    public class ShoppingContext : DbContext
    {
        public ShoppingContext(DbContextOptions<ShoppingContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supermarket> Supermarkets { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

    }
}