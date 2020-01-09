using System;
using System.Collections.Generic;
using System.Text;
using TechnoForest_Data.Util;

namespace TechnoForest_Data.Entity
{
    public class MobilePhone : BaseIdEntity
    {
        public string ProductName { get; set; }

        public string Model { get; set; }

        public string Memory { get; set; }

        public double? SizeOfDisplay { get; set; }

        public string Color { get; set; }

        public decimal? Price { get; set; }

        public string Picture { get; set; }


        public bool IsBought { get; set; }

        public int? ShoppingCartId { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}
