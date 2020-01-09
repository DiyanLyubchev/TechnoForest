using Microsoft.EntityFrameworkCore;
using TechnoForest_Data.Entity;

namespace TechnoForest_Data.Seed
{
    public static class SeedProduct
    {

        public static void SeedMobilePhone(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MobilePhone>().HasData(Seed());

        }

        public static MobilePhone[] Seed()
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
                };

        }
    }
}
