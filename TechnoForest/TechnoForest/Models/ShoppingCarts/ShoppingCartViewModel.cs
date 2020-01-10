using TechnoForest_Data.Entity;

namespace TechnoForest.Models.ShoppingCarts
{
    public class ShoppingCartViewModel
    {
        public ShoppingCartViewModel(ShoppingCart cart)
        {
            this.Id = cart.Id;
            this.UserId = cart.UserId;
            this.MobilePhonesId = cart.MobilePhoneId;
            this.MobilePhones = cart.MobilePhones;
            this.TVs = cart.TVs;
            this.TVsId = cart.TVsId;
            this.WashingMachines = cart.WashingMachines;
            this.WashingMachineId = cart.WashingMachineId;
            this.TotalPrice = cart.TotalPrice;
        }
        public int Id { get; set; }

        public string UserId { get; set; }

        public int? TVsId { get; set; }
        public TV TVs { get; set; }
        public int? WashingMachineId { get; set; }

        public WashingMachine WashingMachines { get; set; }

        public int? MobilePhonesId { get; set; }
        public MobilePhone MobilePhones { get; set; }

        public decimal? TotalPrice { get; set; }
    }
}
