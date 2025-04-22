using InventoryManagementSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace InventoryManagementSystem.Core
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }  
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Serial> Serials { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=InventoryDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base .OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Serial>()
            //    .HasOne(s => s.Product)
            //    .WithMany(p => p.Serials)
            //    .HasForeignKey(s => s.ProductId);

            //modelBuilder.Entity<Product>()
            //    .HasOne(p => p.Category)
            //    .WithMany(c => c.Products)
            //    .HasForeignKey(p => p.CategoryId);

            //modelBuilder.Entity<Order>()
            //    .HasOne(o =>o.User )
            //    .WithMany(u => u.Orders)
            //    .HasForeignKey(o => o.UserId);
            //modelBuilder.Entity<OrderItem>()
            //    .HasOne(oi =>oi.Order)
            //    .WithMany(o => o.OrderItems)
            //    .HasForeignKey(oi => oi.OrderId);
            //modelBuilder.Entity<OrderItem>()
            //    .HasOne(oi => oi.Product )
            //    .WithMany(p => p.OrderItems)
            //    .HasForeignKey(oi => oi.ProductId);

        }
    }
}
