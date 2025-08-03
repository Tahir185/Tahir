using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HotelPortal.Models;

namespace HotelPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Hotel entity
            modelBuilder.Entity<Hotel>(entity =>
            {
                entity.HasKey(h => h.Id);
                entity.Property(h => h.Name).IsRequired().HasMaxLength(100);
                entity.Property(h => h.Description).IsRequired().HasMaxLength(500);
                entity.Property(h => h.Address).IsRequired().HasMaxLength(200);
                entity.Property(h => h.City).IsRequired().HasMaxLength(50);
                entity.Property(h => h.Country).IsRequired().HasMaxLength(50);
                entity.Property(h => h.PhoneNumber).IsRequired();
                entity.Property(h => h.Email).IsRequired();
                entity.HasIndex(h => h.Email).IsUnique();
            });

            // Configure MenuItem entity
            modelBuilder.Entity<MenuItem>(entity =>
            {
                entity.HasKey(m => m.Id);
                entity.Property(m => m.Name).IsRequired().HasMaxLength(100);
                entity.Property(m => m.Category).IsRequired().HasMaxLength(50);
                entity.Property(m => m.Price).HasColumnType("decimal(18,2)");
                
                // Configure relationship
                entity.HasOne(m => m.Hotel)
                      .WithMany(h => h.MenuItems)
                      .HasForeignKey(m => m.HotelId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // Seed data
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            // Seed Hotels
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Grand Palace Hotel",
                    Description = "Luxurious 5-star hotel in the heart of the city",
                    Address = "123 Main Street",
                    City = "New York",
                    Country = "USA",
                    PhoneNumber = "+1-555-0123",
                    Email = "info@grandpalace.com",
                    StarRating = 5,
                    Website = "https://grandpalace.com",
                    IsActive = true,
                    CreatedDate = DateTime.Now.AddDays(-30)
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Cozy Inn",
                    Description = "Comfortable budget-friendly accommodation",
                    Address = "456 Oak Avenue",
                    City = "Boston",
                    Country = "USA",
                    PhoneNumber = "+1-555-0456",
                    Email = "contact@cozyinn.com",
                    StarRating = 3,
                    Website = "https://cozyinn.com",
                    IsActive = true,
                    CreatedDate = DateTime.Now.AddDays(-15)
                }
            );

            // Seed Menu Items
            modelBuilder.Entity<MenuItem>().HasData(
                new MenuItem
                {
                    Id = 1,
                    Name = "Grilled Salmon",
                    Description = "Fresh Atlantic salmon with herbs and lemon",
                    Price = 28.99m,
                    Category = "Main Course",
                    IsAvailable = true,
                    IsGlutenFree = true,
                    Calories = 350,
                    PreparationTimeMinutes = 25,
                    HotelId = 1,
                    CreatedDate = DateTime.Now.AddDays(-25)
                },
                new MenuItem
                {
                    Id = 2,
                    Name = "Vegetarian Pasta",
                    Description = "Penne pasta with seasonal vegetables and marinara sauce",
                    Price = 18.50m,
                    Category = "Main Course",
                    IsAvailable = true,
                    IsVegetarian = true,
                    IsVegan = true,
                    Calories = 450,
                    PreparationTimeMinutes = 15,
                    HotelId = 1,
                    CreatedDate = DateTime.Now.AddDays(-20)
                },
                new MenuItem
                {
                    Id = 3,
                    Name = "Classic Burger",
                    Description = "Beef patty with lettuce, tomato, and special sauce",
                    Price = 15.99m,
                    Category = "Main Course",
                    IsAvailable = true,
                    Calories = 580,
                    PreparationTimeMinutes = 20,
                    HotelId = 2,
                    CreatedDate = DateTime.Now.AddDays(-10)
                }
            );
        }
    }
}