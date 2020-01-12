using TechnoForest_Data.Util;

namespace TechnoForest_Data.Entity
{
    public class Fridge : BaseIdEntity
    {
        public string ProductName { get; set; }

        public string Model { get; set; }

        public int TotalCapacity { get; set; }

        public int CapacityRefrigerator { get; set; }

        public int CapacityFreezer { get; set; }

        public double Height { get; set; }

        public double Width { get; set; }

        public string Color { get; set; }

        public decimal Price { get; set; }

        public User User { get; set; }

        public string UserId { get; set; }

        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}

