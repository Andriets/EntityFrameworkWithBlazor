using ClassLibrary1;
using ClassLibrary1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ClassLibrary1.Context
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CompanyEFv2;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /*modelBuilder.Entity<Product>()
                .HasOne(p => p.ProductType)
                .WithMany(t => t.Products)
                .HasForeignKey(p => p.ProductTypeId);

            modelBuilder.Entity<Order>()
                .HasOne(p => p.Product)
                .WithMany(t => t.Orders)
                .HasForeignKey(p => p.ProductId);

            modelBuilder.Entity<Order>()
                .HasOne(p => p.User)
                .WithMany(t => t.Orders)
                .HasForeignKey(p => p.UserId);*/
        }
    }
}
