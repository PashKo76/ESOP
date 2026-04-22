using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    CustomerNumber = "CUST0001",
                    LastName = "Au Yeung",
                    FirstName = "David",
                    Dob = new DateTime(1980, 12, 31, 0, 0, 0, DateTimeKind.Utc),
                    IsDeleted = false,
                    CreateBy = "SYSTEM",
                    CreateDate = DateTime.UtcNow,
                    ModifyBy = "SYSTEM",
                    ModifyDate = DateTime.UtcNow
                },
                new Customer
                {
                    CustomerId = 2,
                    CustomerNumber = "CUST0002",
                    LastName = "Chan",
                    FirstName = "Peter",
                    Dob = new DateTime(1982, 1, 15, 0, 0, 0, DateTimeKind.Utc),
                    IsDeleted = false,
                    CreateBy = "SYSTEM",
                    CreateDate = DateTime.UtcNow,
                    ModifyBy = "SYSTEM",
                    ModifyDate = DateTime.UtcNow
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    ProductName = "Android Phone",
                    ProductCode = "A0001",
                    AvailableQuantity = 100,
                    IsDeleted = false,
                    CreateBy = "SYSTEM",
                    CreateDate = DateTime.UtcNow,
                    ModifyBy = "SYSTEM",
                    ModifyDate = DateTime.UtcNow
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "iPhone",
                    ProductCode = "I0001",
                    AvailableQuantity = 100,
                    IsDeleted = false,
                    CreateBy = "SYSTEM",
                    CreateDate = DateTime.UtcNow,
                    ModifyBy = "SYSTEM",
                    ModifyDate = DateTime.UtcNow
                }
            );

            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    OrderId = 1,
                    CustomerId = 1,
                    OrderNumber = "ORD0001",
                    OrderDate = DateTime.UtcNow,
                    IsDeleted = false,
                    CreateBy = "SYSTEM",
                    CreateDate = DateTime.UtcNow,
                    ModifyBy = "SYSTEM",
                    ModifyDate = DateTime.UtcNow
                }
            );

            modelBuilder.Entity<OrderItem>().HasData(
                new OrderItem
                {
                    OrderItemId = 1,
                    OrderId = 1,
                    ProductId = 2,
                    Quantity = 10,
                    IsDeleted = false,
                    CreateBy = "SYSTEM",
                    CreateDate = DateTime.UtcNow,
                    ModifyBy = "SYSTEM",
                    ModifyDate = DateTime.UtcNow
                }
            );
        }
    }
}