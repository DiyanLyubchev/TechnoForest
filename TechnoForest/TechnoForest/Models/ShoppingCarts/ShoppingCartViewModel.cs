using TechnoForest_Data.Entity;

namespace TechnoForest.Models.ShoppingCarts
{
    public class ShoppingCartViewModel
    {
        public ShoppingCartViewModel(ShoppingCart cart)
        {
            this.UserId = cart.UserId;
            this.MobilePhones = cart.MobilePhones;
            this.TVs = cart.TVs;
            this.WashingMachines = cart.WashingMachines;
            this.TotalPrice = cart.TotalPrice;
        }

        public string UserId { get; set; }

        public TV TVs { get; set; }

        public WashingMachine WashingMachines { get; set; }

        public MobilePhone MobilePhones { get; set; }

        public decimal? TotalPrice { get; set; }
    }
}
