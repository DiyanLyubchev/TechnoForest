﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechnoForest_Data.Context;

namespace TechnoForest_Data.Migrations
{
    [DbContext(typeof(TechnoForestContext))]
    partial class TechnoForestContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TechnoForest_Data.Entity.MobilePhone", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBought")
                        .HasColumnType("bit");

                    b.Property<string>("Memory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("SizeOfDisplay")
                        .HasColumnType("float");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("MobilePhones");

                    b.HasData(
                        new
                        {
                            Id = "17e9c26c-030f-4ee9-8d45-992d78971e1f",
                            Color = "Black",
                            IsBought = false,
                            Memory = "32 GB",
                            Model = "7 Plus",
                            Picture = "~/images/Black7Plus.jpg",
                            Price = 929.36m,
                            ProductName = "Iphone",
                            SizeOfDisplay = 5.5
                        },
                        new
                        {
                            Id = "665d2175-1792-4078-b5ad-a4b7939eeb72",
                            Color = "Pink",
                            IsBought = false,
                            Memory = "32 GB",
                            Model = "7 Plus",
                            Picture = "~/images/Pink7Plus.jpg",
                            Price = 1029.36m,
                            ProductName = "Iphone",
                            SizeOfDisplay = 5.5
                        },
                        new
                        {
                            Id = "1668c2b3-cbf6-4c8e-8f36-cbf600e78610",
                            Color = "Gray",
                            IsBought = false,
                            Memory = "64 GB",
                            Model = " 6S",
                            Picture = "~/images/Gray6s.jpg",
                            Price = 1029.36m,
                            ProductName = "Iphone",
                            SizeOfDisplay = 5.5
                        },
                        new
                        {
                            Id = "00a206e5-c65b-4626-890a-2d39f9687f28",
                            Color = "Gray",
                            IsBought = false,
                            Memory = "64 GB",
                            Model = "X",
                            Picture = "~/images/Xgray.jpg",
                            Price = 1849.99m,
                            ProductName = "Iphone",
                            SizeOfDisplay = 5.7999999999999998
                        },
                        new
                        {
                            Id = "964460f8-fade-4c5d-96ba-9831b7c7185f",
                            Color = "Pink",
                            IsBought = false,
                            Memory = "64 GB",
                            Model = "X",
                            Picture = "~/images/Xgray.jpg",
                            Price = 2049.99m,
                            ProductName = "Iphone",
                            SizeOfDisplay = 5.7999999999999998
                        });
                });

            modelBuilder.Entity("TechnoForest_Data.Entity.ShoppingCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AddTOCart")
                        .HasColumnType("datetime2");

                    b.Property<string>("MobilePhoneId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TVsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal?>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("WashingMachineId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("MobilePhoneId")
                        .IsUnique()
                        .HasFilter("[MobilePhoneId] IS NOT NULL");

                    b.HasIndex("TVsId")
                        .IsUnique()
                        .HasFilter("[TVsId] IS NOT NULL");

                    b.HasIndex("UserId");

                    b.HasIndex("WashingMachineId")
                        .IsUnique()
                        .HasFilter("[WashingMachineId] IS NOT NULL");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("TechnoForest_Data.Entity.TV", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsBought")
                        .HasColumnType("bit");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Size")
                        .HasColumnType("float");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("TVs");

                    b.HasData(
                        new
                        {
                            Id = "3db78497-8adb-4400-8fdc-7d10e0350160",
                            IsBought = false,
                            Model = "KD55XG8196BAEP",
                            Price = 1389m,
                            ProductName = "Sony",
                            Size = 55.0
                        },
                        new
                        {
                            Id = "e99a4a02-b8ab-4d66-b509-4618e66f0b38",
                            IsBought = false,
                            Model = "BRAVIA",
                            Price = 2899m,
                            ProductName = "Sony",
                            Size = 55.0
                        },
                        new
                        {
                            Id = "f27ff3d6-7dda-49eb-9348-c54c3a11cf8b",
                            IsBought = false,
                            Model = "43LK5100PLA",
                            Price = 428m,
                            ProductName = "LG",
                            Size = 43.0
                        },
                        new
                        {
                            Id = "bdaf9613-95b3-4daa-affe-39fab1e1975a",
                            IsBought = false,
                            Model = "70UI9362E",
                            Price = 1449.99m,
                            ProductName = "Sharp",
                            Size = 70.0
                        },
                        new
                        {
                            Id = "6b798382-fab7-4dd8-8824-516ff63c2baf",
                            IsBought = false,
                            Model = "32PFS4132/12",
                            Price = 388m,
                            ProductName = "PHILIPS",
                            Size = 32.0
                        });
                });

            modelBuilder.Entity("TechnoForest_Data.Entity.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BuyProduct")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("TechnoForest_Data.Entity.WashingMachine", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsBought")
                        .HasColumnType("bit");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("WashingCapacity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("WashingMachines");

                    b.HasData(
                        new
                        {
                            Id = "c2a7b1b5-d960-4e0b-87eb-bc65ff48d9e6",
                            IsBought = false,
                            Model = "WW70K44305W",
                            Price = 609m,
                            ProductName = "Samsung",
                            WashingCapacity = 7
                        },
                        new
                        {
                            Id = "7443cad9-1255-4e16-94d6-b8f54b03ba78",
                            IsBought = false,
                            Model = "WMY81483LMB1",
                            Price = 669.99m,
                            ProductName = "Beko",
                            WashingCapacity = 8
                        },
                        new
                        {
                            Id = "ba0e316a-5bce-46dc-abb0-bd0473833558",
                            IsBought = false,
                            Model = "L9WBA61B",
                            Price = 2899.99m,
                            ProductName = "AEG",
                            WashingCapacity = 9
                        },
                        new
                        {
                            Id = "c51ade36-a168-4dbf-813f-61fbcdc36b9a",
                            IsBought = false,
                            Model = "TDLR 70210",
                            Price = 599m,
                            ProductName = "Whirlpool",
                            WashingCapacity = 8
                        },
                        new
                        {
                            Id = "26c4f63d-7cf5-431c-935d-e209cd94865f",
                            IsBought = false,
                            Model = "F2J6HM0W",
                            Price = 799m,
                            ProductName = "LG",
                            WashingCapacity = 7
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TechnoForest_Data.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TechnoForest_Data.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechnoForest_Data.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TechnoForest_Data.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TechnoForest_Data.Entity.MobilePhone", b =>
                {
                    b.HasOne("TechnoForest_Data.Entity.User", null)
                        .WithMany("MobilePhones")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("TechnoForest_Data.Entity.ShoppingCart", b =>
                {
                    b.HasOne("TechnoForest_Data.Entity.MobilePhone", "MobilePhones")
                        .WithOne("ShoppingCart")
                        .HasForeignKey("TechnoForest_Data.Entity.ShoppingCart", "MobilePhoneId");

                    b.HasOne("TechnoForest_Data.Entity.TV", "TVs")
                        .WithOne("ShoppingCart")
                        .HasForeignKey("TechnoForest_Data.Entity.ShoppingCart", "TVsId");

                    b.HasOne("TechnoForest_Data.Entity.User", "User")
                        .WithMany("ShoppingCarts")
                        .HasForeignKey("UserId");

                    b.HasOne("TechnoForest_Data.Entity.WashingMachine", "WashingMachines")
                        .WithOne("ShoppingCart")
                        .HasForeignKey("TechnoForest_Data.Entity.ShoppingCart", "WashingMachineId");
                });

            modelBuilder.Entity("TechnoForest_Data.Entity.TV", b =>
                {
                    b.HasOne("TechnoForest_Data.Entity.User", null)
                        .WithMany("TVs")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("TechnoForest_Data.Entity.WashingMachine", b =>
                {
                    b.HasOne("TechnoForest_Data.Entity.User", null)
                        .WithMany("WashingMachines")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
