using System.ComponentModel.DataAnnotations;
using TechnoForest_Data.Util;

namespace TechnoForest_Data.Entity
{
    public class WashingMachine : BaseIdEntity
    {
        [Required]
        [MinLength(2)]
        public string ProductName { get; set; }

        [Required]
        [MinLength(3)]
        public string Model { get; set; }

        [Required]
        public int WashingCapacity { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string Picture { get; set; }

        public User User { get; set; }

        public string UserId { get; set; }

        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}
