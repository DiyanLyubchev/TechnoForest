using System;
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
            this.TVsId = cart.TVsId;
            this.TVs = cart.TVs;
            this.WashingMachineId = cart.WashingMachineId;
            this.WashingMachines = cart.WashingMachines;
            this.TotalPrice = cart.TotalPrice;
        }
        public int Id { get; set; }

        public string UserId { get; set; }

        public string TVsId { get; set; }

        public TV TVs { get; set; }

        public string WashingMachineId { get; set; }

        public WashingMachine WashingMachines { get; set; }

        public string MobilePhonesId { get; set; }

        public MobilePhone MobilePhones { get; set; }

        public decimal? TotalPrice { get; set; }
    }
}
