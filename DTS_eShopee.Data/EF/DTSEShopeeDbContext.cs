using DTS_eShopee.Data.Configurations;
using DTS_eShopee.Data.Entities;
using DTS_eShopee.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTS_eShopee.Data.EF
{
    public class DTSEShopeeDbContext : DbContext
    {
        public DTSEShopeeDbContext(DbContextOptions options) : base(options)
        {
        }

        protected DTSEShopeeDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure using Fluent API
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new PromotionConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());

            // Data seeding
            //modelBuilder.Entity<AppConfig>().HasData(
            //    new AppConfig() { Key = "HomeTitle", Value ="This is home page of DTS EShopSolution"},
            //    new AppConfig() { Key = "HomeKeyWord", Value = "This is keyword of DTS EShopSolution" },
            //    new AppConfig() { Key = "HomeDescription", Value = "This is description of DTS EShopSolution" }
            //    );
            modelBuilder.Seed();
            //base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<AppConfig> AppConfigs { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<CategoryTranslation> CategoryTranslations { get; set; }

        public DbSet<ProductInCategory> ProductInCategories { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<ProductTranslation> ProductTranslations { get; set; }

        public DbSet<Promotion> Promotions { get; set; }

        public DbSet<Transaction> Transactions { get; set; }
    }
}