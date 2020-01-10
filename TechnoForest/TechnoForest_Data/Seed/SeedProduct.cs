using Microsoft.EntityFrameworkCore;
using TechnoForest_Data.Entity;

namespace TechnoForest_Data.Seed
{
    public static class SeedProduct
    {
        public static void SeedMobilePhone(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MobilePhone>().HasData(MobilePhone());


        }
        public static void SeedWhashingMachine(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<WashingMachine>().HasData(WashingMachine());

        }
        public static void SeedTv(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<TV>().HasData(TV());

        }

        private static TV[] TV()
        {
            return new TV[]
            {
                new TV
                {
                   Id=1,
                   ProductName= "Sony",
                   Model= "KD55XG8196BAEP",
                   Size= 55,
                   Price= 1389m
                },
                new TV
                {
                   Id=2,
                   ProductName= "Sony",
                   Model= "BRAVIA",
                   Size= 55,
                   Price= 2899m
                },
                new TV
                {
                   Id=3,
                   ProductName ="LG",
                   Model= "43LK5100PLA",
                   Size= 43,
                   Price= 428m
                },
                new TV
                {
                   Id=4,
                   ProductName ="Sharp",
                   Model= "70UI9362E",
                   Size= 70,
                   Price= 1449.99m
                },
                new TV
                {
                   Id=5,
                   ProductName ="PHILIPS",
                   Model= "32PFS4132/12",
                   Size= 32,
                   Price= 388m
                },
            };
        }

        private static WashingMachine[] WashingMachine()
        {
            return new WashingMachine[]
                {
                    new WashingMachine
                    {
                        Id=1,
                        ProductName = "Samsung",
                        Model = "WW70K44305W",
                        WashingCapacity=7,
                        Price= 609m
                    },
                    new WashingMachine
                    {
                        Id=2,
                        ProductName = "Beko",
                        Model = "WMY81483LMB1",
                        WashingCapacity=8,
                        Price= 669.99m
                    },
                    new WashingMachine
                    {
                        Id=3,
                        ProductName = "AEG",
                        Model = "L9WBA61B",
                        WashingCapacity=9,
                        Price= 2899.99m
                    },
                    new WashingMachine
                    {
                        Id=4,
                        ProductName = "Whirlpool",
                        Model = "TDLR 70210",
                        WashingCapacity=8,
                        Price= 599m
                    },
                    new WashingMachine
                    {
                        Id=5,
                        ProductName = "LG",
                        Model = "F2J6HM0W",
                        WashingCapacity=7,
                        Price= 799m
                    },
                };
        }
        private static MobilePhone[] MobilePhone()
        {
            return new MobilePhone[]
                {
                     new MobilePhone
                     {
                         Id = 1,
                         ProductName = "Iphone",
                         Model = "7 Plus",
                         Color = "Black",
                         Memory= "32 GB",
                         SizeOfDisplay =5.5 ,
                         Price = 929.36m,
                         Picture="~/images/Black7Plus.jpg"
                     },
                     new MobilePhone
                     {
                        Id = 2,
                        ProductName = "Iphone",
                        Model = "7 Plus",
                        Color = "Pink",
                        Memory= "32 GB",
                        SizeOfDisplay = 5.5 ,
                        Price = 1029.36m,
                        Picture="~/images/Pink7Plus.jpg"

                     },
                     new MobilePhone
                     {
                        Id = 3,
                        ProductName = "Iphone",
                        Model = " 6S",
                        Color = "Gray",
                        Memory= "64 GB",
                        SizeOfDisplay = 5.5 ,
                        Price = 1029.36m ,
                        Picture = "~/images/Gray6s.jpg",
                     },
                     new MobilePhone
                     {
                        Id = 4,
                        ProductName = "Iphone",
                        Model = "X",
                        Color = "Gray",
                        Memory= "64 GB",
                        SizeOfDisplay = 5.8 ,
                        Price = 1849.99m ,
                        Picture = "~/images/Xgray.jpg",
                     },
                      new MobilePhone
                     {
                        Id = 5,
                        ProductName = "Iphone",
                        Model = "X",
                        Color = "Pink",
                        Memory= "64 GB",
                        SizeOfDisplay = 5.8 ,
                        Price = 2049.99m ,
                        Picture = "~/images/Xgray.jpg",
                     },
                };

        }
    }
}
