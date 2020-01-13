using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TechnoForest_Data.Util;

namespace TechnoForest_Data.Entity
{
    public class TV : BaseIdEntity
    {
        [Required]
        [MinLength(2)]
        public string ProductName { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public double Size { get; set; }

        [Required]
        public decimal Price { get; set; }

        public User User { get; set; }

        public string UserId { get; set; }

        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}
