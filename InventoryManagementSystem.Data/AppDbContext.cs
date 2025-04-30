using InventoryManagementSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Serial> Serials { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var createdDate = new DateTime(2025, 4, 24, 17, 0, 0); //burada sabir bir tarih girdim çünkü datetime.now da her migration işleminde farklı tarih üretiyordu.
            modelBuilder.Entity<User>().HasData(
                new User
                {   
                    Id = 1,
                    UserName = "admin",
                    PasswordHash = "admin123",
                    Role = "Admin",
                    CreatedOn = createdDate, //sabit tarihi burada kullandım
                    CreatedBy = "YusufC",
                    DeletedBy = ""
                },
                new User
                {
                    Id = 2,
                    UserName = "user",
                    PasswordHash = "user123",
                    Role = "User",
                    CreatedOn = createdDate,
                    CreatedBy = "YusufC",
                    DeletedBy = ""
                }
            );
            
        }
    }
}


