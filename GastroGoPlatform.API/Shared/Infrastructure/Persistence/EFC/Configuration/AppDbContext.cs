using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using GastroGoPlatform.API.Booking.Domain.Model.Aggregates;
using GastroGoPlatform.API.Booking.Domain.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace GastroGoPlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration
{
    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.AddCreatedUpdatedInterceptor();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Menu
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Menu>().HasKey(m => m.Id);
            modelBuilder.Entity<Menu>().Property(m => m.Id).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Menu>().Property(m => m.Name).IsRequired();
            modelBuilder.Entity<Menu>()
                .HasMany(m => m.Products)
                .WithOne(p => p.Menu)
                .HasForeignKey(p => p.MenuId)
                .OnDelete(DeleteBehavior.Cascade);

            // Product
            modelBuilder.Entity<Product>().HasKey(p => p.Id);
            modelBuilder.Entity<Product>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired();
            modelBuilder.Entity<Product>().Property(p => p.Stock).IsRequired();
            modelBuilder.Entity<Product>().Property(p => p.Category).HasConversion<string>().IsRequired();
            modelBuilder.Entity<Product>()
                .OwnsOne(p => p.Price, price =>
                {
                    price.Property(p => p.Amount)
                         .HasColumnName("Price")
                         .IsRequired();
                });

            // Order
            modelBuilder.Entity<Order>().HasKey(o => o.OrderId);
            modelBuilder.Entity<Order>().Property(o => o.OrderId).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Order>().Property(o => o.Date).IsRequired();
            modelBuilder.Entity<Order>().Property(o => o.Status).HasConversion<string>().IsRequired();
            modelBuilder.Entity<Order>().Property(o => o.DeliveryTime).IsRequired();
            modelBuilder.Entity<Order>().Property(o => o.CustomerId).IsRequired();
            
            // TeamActivity
            modelBuilder.Entity<TeamActivity>().HasKey(t => t.TeamId);
            modelBuilder.Entity<TeamActivity>().Property(t => t.TeamId).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<TeamActivity>().Property(t => t.TeamName).IsRequired();
            modelBuilder.Entity<TeamActivity>().HasMany(t => t.Roles)
                .WithOne(r => r.TeamActivity)
                .HasForeignKey(r => r.TeamId)
                .OnDelete(DeleteBehavior.Cascade);
            
            
            // Role
            modelBuilder.Entity<Role>().HasKey(r => r.RoleId);
            modelBuilder.Entity<Role>()
                .Property(r => r.RoleId).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Role>()
                .Property(r => r.UserId).IsRequired();
            modelBuilder.Entity<Role>()
                .Property(r => r.RoleType).HasConversion<string>().IsRequired();
            modelBuilder.Entity<Role>()
                .Property(r => r.TeamId).IsRequired();

        }
    }
}
