using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace TechnoForest_Data.Entity
{
    public class User : IdentityUser
    {
        public ICollection<TV> TVs { get; set; }

        public ICollection<WashingMachine> WashingMachines { get; set; }

        public ICollection<MobilePhone> MobilePhones { get; set; }

        public DateTime? BuyProduct { get; set; }

        public ICollection<ShoppingCart> ShoppingCarts { get; set; }
    }
}
