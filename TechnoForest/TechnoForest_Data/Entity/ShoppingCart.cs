using System;
using System.Collections.Generic;
using System.Text;
using TechnoForest_Data.Util;

namespace TechnoForest_Data.Entity
{
    public class ShoppingCart : BaseIdEntity
    {
        public string UserId { get; set; }

        public User User { get; set; }

        public virtual TV TVs { get; set; }


        public virtual WashingMachine WashingMachines { get; set; }


        public virtual MobilePhone MobilePhones { get; set; }

        public decimal? TotalPrice { get; set; }

        public DateTime? AddTOCart { get; set; }
       
    }
}
