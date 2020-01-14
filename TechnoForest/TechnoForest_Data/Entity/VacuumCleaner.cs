using TechnoForest_Data.Util;

namespace TechnoForest_Data.Entity
{
    public class VacuumCleaner : BaseIdEntity
    {
        public string ProductName { get; set; }

        public string Model { get; set; }

        public int Power { get; set; }

        public int NoiseLevel { get; set; }

        public string Color { get; set; }

        public decimal Price { get; set; }

        public User User { get; set; }

        public string UserId { get; set; }

        public virtual ShoppingCart ShoppingCart { get; set; }

    }
}
