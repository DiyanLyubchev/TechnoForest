using TechnoForest_Data.Util;

namespace TechnoForest_Data.Entity
{
    public class AirConditioner : BaseIdEntity
    {
        public string ProductName { get; set; }

        public string Model { get; set; }

        public double PowerCooling { get; set; }

        public double PowerHeating { get; set; }

        public int NoiseLevel { get; set; }

        public decimal Price { get; set; }

        public User User { get; set; }

        public string UserId { get; set; }

        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}
