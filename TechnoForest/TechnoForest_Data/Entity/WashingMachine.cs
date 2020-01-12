﻿using TechnoForest_Data.Util;

namespace TechnoForest_Data.Entity
{
    public class WashingMachine : BaseIdEntity
    {
        public string ProductName { get; set; }

        public string Model { get; set; }

        public int? WashingCapacity { get; set; }

        public decimal? Price { get; set; }

        public string Picture { get; set; }

        public User User { get; set; }

        public string UserId { get; set; }

        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}
