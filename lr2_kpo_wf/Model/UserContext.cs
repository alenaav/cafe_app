﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace lr2_kpo_wf.Model
{
    internal class UserContext : DbContext
    {
        private const string DbFile = @"C:\Users\Yulia\cards.db";

        public UserContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<LoyaltyCard> LoyaltyCards { get; set; }
        public DbSet<LoyaltyPoint> LoyaltyPoints { get; set; }
        public DbSet<PointsHistory> PointsHistories { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Cafe> Cafes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlite($@"Data Source={DbFile}")
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");
                entity.HasIndex(u => u.Email).IsUnique();
                entity.HasIndex(u => u.Phone).IsUnique();
                entity.Property(u => u.CreatedAt)
                      .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<LoyaltyCard>(entity =>
            {
                entity.HasIndex(c => c.UserId).IsUnique();
            });
        }
    }

}
