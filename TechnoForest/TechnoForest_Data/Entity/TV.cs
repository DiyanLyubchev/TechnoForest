using System;
using System.Collections.Generic;
using System.Text;
using TechnoForest_Data.Util;

namespace TechnoForest_Data.Entity
{
    public class TV : BaseIdEntity
    {
        public string ProductName { get; set; }

        public string Model { get; set; }

        public double? Size { get; set; }

        public decimal? Price { get; set; }
        
        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}
