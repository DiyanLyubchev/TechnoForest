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
        public TechnoForestContext(DbContextOptions<TechnoForestContext> options) 
            : base(options)
        {
        }

        public TechnoForestContext()
        {
        }

        public DbSet<MobilePhone> MobilePhones { get; set; }

        public DbSet<TV> TVs { get; set; }

        public DbSet<WashingMachine> WashingMachines { get; set; }

        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        public DbSet<Fridge> Fridges { get; set; }

        public DbSet<AirConditioner> AirConditioners { get; set; }

        public DbSet<VacuumCleaner> VacuumCleaners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //fridge 
            modelBuilder.Entity<Fridge>()
                .HasOne(shopping => shopping.ShoppingCart)
                .WithOne(fridge => fridge.Fridge);

            //mobile phone 
            modelBuilder.Entity<MobilePhone>()
                .HasOne(shopping => shopping.ShoppingCart)
                .WithOne(mobilePhone => mobilePhone.MobilePhones);

            //tv
            modelBuilder.Entity<TV>()
                .HasOne(shopping => shopping.ShoppingCart)
                .WithOne(tv => tv.TVs);
            
            //washing machine 
            modelBuilder.Entity<WashingMachine>()
                .HasOne(shopping => shopping.ShoppingCart)
                .WithOne(washingMachine => washingMachine.WashingMachines);


            modelBuilder.SeedMobilePhone();
            modelBuilder.SeedWhashingMachine();
            modelBuilder.SeedTv();
            modelBuilder.SeedFridge();
            modelBuilder.SeedVacuumCleaners();
            modelBuilder.SeedAirConditioner();


            base.OnModelCreating(modelBuilder);
        }
    }
}