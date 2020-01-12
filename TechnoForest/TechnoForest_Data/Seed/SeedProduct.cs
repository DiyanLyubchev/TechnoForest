using Microsoft.EntityFrameworkCore;
using System;
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
                   Id="3db78497-8adb-4400-8fdc-7d10e0350160",
                   ProductName= "Sony",
                   Model= "KD55XG8196BAEP",
                   Size= 55,
                   Price= 1389m
                },
                new TV
                {
                   Id="e99a4a02-b8ab-4d66-b509-4618e66f0b38",
                   ProductName= "Sony",
                   Model= "BRAVIA",
                   Size= 55,
                   Price= 2899m
                },
                new TV
                {
                   Id="f27ff3d6-7dda-49eb-9348-c54c3a11cf8b",
                   ProductName ="LG",
                   Model= "43LK5100PLA",
                   Size= 43,
                   Price= 428m
                },
                new TV
                {
                   Id="bdaf9613-95b3-4daa-affe-39fab1e1975a",
                   ProductName ="Sharp",
                   Model= "70UI9362E",
                   Size= 70,
                   Price= 1449.99m
                },
                new TV
                {
                   Id="6b798382-fab7-4dd8-8824-516ff63c2baf",
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
                        Id="c2a7b1b5-d960-4e0b-87eb-bc65ff48d9e6",
                        ProductName = "Samsung",
                        Model = "WW70K44305W",
                        WashingCapacity=7,
                        Price= 609m
                    },
                    new WashingMachine
                    {
                        Id="7443cad9-1255-4e16-94d6-b8f54b03ba78",
                        ProductName = "Beko",
                        Model = "WMY81483LMB1",
                        WashingCapacity=8,
                        Price= 669.99m
                    },
                    new WashingMachine
                    {
                         Id="ba0e316a-5bce-46dc-abb0-bd0473833558",
                        ProductName = "AEG",
                        Model = "L9WBA61B",
                        WashingCapacity=9,
                        Price= 2899.99m
                    },
                    new WashingMachine
                    {
                        Id="c51ade36-a168-4dbf-813f-61fbcdc36b9a",
                        ProductName = "Whirlpool",
                        Model = "TDLR 70210",
                        WashingCapacity=8,
                        Price= 599m
                    },
                    new WashingMachine
                    {
                        Id="26c4f63d-7cf5-431c-935d-e209cd94865f",
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
                         Id="17e9c26c-030f-4ee9-8d45-992d78971e1f",
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
                        Id="665d2175-1792-4078-b5ad-a4b7939eeb72",
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
                        Id="1668c2b3-cbf6-4c8e-8f36-cbf600e78610",
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
                        Id="00a206e5-c65b-4626-890a-2d39f9687f28",
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
                        Id="964460f8-fade-4c5d-96ba-9831b7c7185f",
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
