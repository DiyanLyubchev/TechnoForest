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

        public static void SeedFridge(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Fridge>().HasData(Fridges());

        }

        public static void SeedVacuumCleaners(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<VacuumCleaner>().HasData(VacuumCleaners());

        }
        public static void SeedAirConditioner(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<AirConditioner>().HasData(AirConditioner());

        }

        private static AirConditioner[] AirConditioner()
        {
            return new AirConditioner[]
                {
                     new AirConditioner
                     {
                          Id ="c015da0f-33f9-46d3-85cf-5314e0c76b95",
                          ProductName ="SANG",
                          Model = "TAC-09CHSD",
                          PowerCooling = 2.600,
                          PowerHeating = 2.610,
                          NoiseLevel = 30,
                          Price=639
                     },
                     new AirConditioner
                     {
                          Id ="de59b84d-aeb2-4fa8-9370-89617cc82744",
                          ProductName ="HAIER ",
                          Model = "AS09TA2HRA",
                          PowerCooling = 2.600,
                          PowerHeating = 2.800,
                          NoiseLevel = 40,
                          Price=759
                     },
                     new AirConditioner
                     {
                          Id ="e23eba28-66af-4239-9c66-798a7c956fa0",
                          ProductName ="BEKO  ",
                          Model = "BEVPI 121",
                          PowerCooling = 3.500,
                          PowerHeating = 2.600,
                          NoiseLevel = 43,
                          Price=879
                     },
                };
        }

        private static VacuumCleaner[] VacuumCleaners()
        {
            return new VacuumCleaner[]
                {
                    new VacuumCleaner
                    {
                         Id ="9c21bee7-20fd-46c3-8a23-867fe58e4c2e",
                         ProductName = "GORENJE",
                         Model ="VCEA01GACBUCY",
                         Power = 800,
                         NoiseLevel =85,
                         Color = "Blue",
                         Price=139m
                    },
                    new VacuumCleaner
                    {
                         Id ="1cee3c19-e11b-41a3-bbfb-88951a84c50c",
                         ProductName = "SAMSUNG",
                         Model ="VCC45T0S3R",
                         Power = 850,
                         NoiseLevel =80,
                         Color = "Black",
                         Price=149m
                    },
                    new VacuumCleaner
                    {
                         Id ="803ff24c-4815-485c-8162-29bd1a72c7ec",
                         ProductName = "BOSCH ",
                         Model ="BGS05A220",
                         Power = 700,
                         NoiseLevel =78,
                         Color = "Black",
                         Price=169m
                    },
                    new VacuumCleaner
                    {
                         Id ="5824fa78-1bdb-4196-b4cc-f003dfb291a1",
                         ProductName = "PHILIPS  ",
                         Model ="FC9333",
                         Power = 650,
                         NoiseLevel =76,
                         Color = "Black",
                         Price=219m
                    },
                    new VacuumCleaner
                    {
                         Id ="fccee9db-3fe1-4300-bef7-78cf9a8b68df",
                         ProductName = "ROWENTA  ",
                         Model ="RO3731EACOMPACT",
                         Power = 750,
                         NoiseLevel =79,
                         Color = "Black-blue",
                         Price=189m
                    },
                };
        }

        private static Fridge[] Fridges()
        {
            return new Fridge[]
            {
                new Fridge
                {
                     Id ="42a046da-3717-4c47-88b8-defacf39499e",
                     ProductName = "VESTFROST",
                     Model ="VFD 263",
                     TotalCapacity=213,
                     CapacityRefrigerator=171,
                     CapacityFreezer =42,
                     Height =144.00,
                     Width=54.00,
                     Color = "White",
                     Price=355m
                },
                new Fridge
                {
                     Id ="56780700-4a74-4ce0-bc55-893f5d8cd4ca",
                     ProductName = "SNAIGE",
                     Model ="RF 36SM-Z/P1CB27",
                     TotalCapacity=317,
                     CapacityRefrigerator=229,
                     CapacityFreezer =88,
                     Height =195.00,
                     Width=60.00,
                     Color="Inox",
                     Price=749m
                },
                new Fridge
                {
                     Id ="988e82bc-f781-419d-89fa-9af95eb213d2",
                     ProductName = "SAMSUNG",
                     Model ="RB31FDRNDSA/EF",
                     TotalCapacity=308,
                     CapacityRefrigerator=210,
                     CapacityFreezer =98,
                     Height =185.00,
                     Width=60.00,
                     Color="Inox",
                     Price=949m
                },
                new Fridge
                {
                     Id ="15902133-9037-4541-862c-ec501deafbb5",
                     ProductName = "GORENJE",
                     Model ="NRS9182VX",
                     TotalCapacity=535,
                     CapacityRefrigerator=368,
                     CapacityFreezer=167,
                     Height =179.30,
                     Width=68.70,
                     Color="Inox",
                     Price=1999m
                },
               new Fridge
               {
                    Id ="29faa7a1-b5aa-4bc1-b78e-0c6099009ea1",
                    ProductName = "SAMSUNG ",
                    Model ="RS68N8220B1/EF",
                    TotalCapacity=617,
                    CapacityRefrigerator=407,
                    CapacityFreezer=210,
                    Height =178.00,
                    Width=77.20,
                    Color="Black",
                    Price=2599m
               },
            };
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
