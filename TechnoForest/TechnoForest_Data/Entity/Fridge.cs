using System.ComponentModel.DataAnnotations;
using TechnoForest_Data.Util;

namespace TechnoForest_Data.Entity
{
    public class Fridge : BaseIdEntity
    {
        [Required]
        [MinLength(2)]
        public string ProductName { get; set; }

        [Required]
        [MinLength(4)]
        public string Model { get; set; }

        [Required]
        public int TotalCapacity { get; set; }

        [Required]
        public int CapacityRefrigerator { get; set; }

        [Required]
        public int CapacityFreezer { get; set; }

        [Required]
        public double Height { get; set; }

        [Required]
        public double Width { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public decimal Price { get; set; }

        public User User { get; set; }

        public string UserId { get; set; }

        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}

