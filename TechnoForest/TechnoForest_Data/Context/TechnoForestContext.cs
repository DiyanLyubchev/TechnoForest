using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TechnoForest_Data.Entity;
using TechnoForest_Data.Seed;

namespace TechnoForest_Data.Context
{
    public class TechnoForestContext : IdentityDbContext<User>
    {
        public TechnoForestContext(DbContextOptions<TechnoForestContext> options) : base(options)
        {
        }

        public DbSet<MobilePhone> MobilePhones { get; set; }
        public DbSet<TV> TVs { get; set; }
        public DbSet<WashingMachine> WashingMachines { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedMobilePhone();
            base.OnModelCreating(modelBuilder);
        }
    }
}