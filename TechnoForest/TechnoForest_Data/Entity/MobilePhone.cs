using System.ComponentModel.DataAnnotations;
using TechnoForest_Data.Util;

namespace TechnoForest_Data.Entity
{
    public class MobilePhone : BaseIdEntity
    {
        [Required]
        [MinLength(2)]
        public string ProductName { get; set; }

        [Required]
        [MinLength(1)]
        public string Model { get; set; }

        [Required]
        public string Memory { get; set; }

        [Required]
        public double SizeOfDisplay { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Picture { get; set; }

        public User User { get; set; }

        public string UserId { get; set; }

        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}
