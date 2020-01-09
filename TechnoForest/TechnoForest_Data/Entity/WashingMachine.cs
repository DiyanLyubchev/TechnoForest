using System;
using System.Collections.Generic;
using System.Text;
using TechnoForest_Data.Util;

namespace TechnoForest_Data.Entity
{
    public class WashingMachine : BaseIdEntity
    {
        public string ProductName { get; set; }

        public string Model { get; set; }

        public int? WashingCapacity { get; set; }

        public decimal? Price { get; set; }

        public bool IsBought { get; set; }

        public int? ShoppingCartId { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}
