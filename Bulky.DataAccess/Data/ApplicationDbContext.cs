using Beautique.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Beautique.DataAcess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Shampoos & Conditioners", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Body Washes & Soaps", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Facial Care", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Body Care", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Deodorants & Antiperspirants", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Shaving Products", DisplayOrder = 6 },
                new Category { Id = 7, Name = "Nail Care", DisplayOrder = 7 },
                new Category { Id = 8, Name = "Perfumes & Fragrances", DisplayOrder = 8 },
                new Category { Id = 9, Name = "Lip Care", DisplayOrder = 9 },
                new Category { Id = 10, Name = "Hand Care", DisplayOrder = 10 },
                new Category { Id = 11, Name = "Hair Care", DisplayOrder = 11 },
                new Category { Id = 12, Name = "Eye & Eyelid Care", DisplayOrder = 12 },
                new Category { Id = 13, Name = "Cleansing & Makeup Removal", DisplayOrder = 13 },
                new Category { Id = 14, Name = "Organic & Bio Cosmetics", DisplayOrder = 14 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "ShineWave",
                    Maker = "SparkLife",
                    Description = "A premium shampoo that provides ultimate shine and smoothness.",
                    ISBN = "SW123456789",
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 45,
                    Price100 = 40,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "PureGlow",
                    Maker = "CleanseCo",
                    Description = "A gentle body wash that leaves your skin refreshed and hydrated.",
                    ISBN = "PG987654321",
                    ListPrice = 40,
                    Price = 35,
                    Price50 = 30,
                    Price100 = 25,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "SoftTouch",
                    Maker = "VelvetSkin",
                    Description = "A soft and nourishing facial cream for smooth and glowing skin.",
                    ISBN = "ST111223344",
                    ListPrice = 65,
                    Price = 60,
                    Price50 = 55,
                    Price100 = 50,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Title = "ClearSpark",
                    Maker = "LushCare",
                    Description = "A refreshing deodorant spray that keeps you fresh all day long.",
                    ISBN = "CS554433221",
                    ListPrice = 20,
                    Price = 18,
                    Price50 = 16,
                    Price100 = 14,
                    CategoryId = 5,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Title = "FreshCut",
                    Maker = "SharpEdge",
                    Description = "A shaving gel that provides a smooth and irritation-free shave.",
                    ISBN = "FC998877665",
                    ListPrice = 35,
                    Price = 30,
                    Price50 = 28,
                    Price100 = 25,
                    CategoryId = 6,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    Title = "GlowNail",
                    Maker = "NailArt",
                    Description = "A long-lasting nail polish with vibrant colors and a glossy finish.",
                    ISBN = "GN332211445",
                    ListPrice = 15,
                    Price = 13,
                    Price50 = 12,
                    Price100 = 10,
                    CategoryId = 7,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 7,
                    Title = "EauVibe",
                    Maker = "ScentAura",
                    Description = "A fresh and uplifting fragrance that is perfect for daily wear.",
                    ISBN = "EV776655443",
                    ListPrice = 50,
                    Price = 45,
                    Price50 = 40,
                    Price100 = 35,
                    CategoryId = 8,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 8,
                    Title = "SoftKiss",
                    Maker = "LipsCare",
                    Description = "A hydrating lip balm with a smooth texture and subtle scent.",
                    ISBN = "SK223344556",
                    ListPrice = 10,
                    Price = 9,
                    Price50 = 8,
                    Price100 = 7,
                    CategoryId = 9,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 9,
                    Title = "HandHeal",
                    Maker = "SkinGuard",
                    Description = "A nourishing hand cream that keeps your skin soft and hydrated.",
                    ISBN = "HH556677889",
                    ListPrice = 18,
                    Price = 16,
                    Price50 = 14,
                    Price100 = 12,
                    CategoryId = 10,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 10,
                    Title = "EyeLuxe",
                    Maker = "VisionGlow",
                    Description = "A rejuvenating eye cream that targets puffiness and dark circles.",
                    ISBN = "EL998877665",
                    ListPrice = 45,
                    Price = 40,
                    Price50 = 35,
                    Price100 = 30,
                    CategoryId = 12,
                    ImageUrl = ""
                }
                );
        }
    }
}
