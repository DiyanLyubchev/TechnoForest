﻿using System;
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
            this.FridgeId = cart.FridgeId;
            this.Fridge = cart.Fridge;
            this.TotalPrice = cart.TotalPrice;
            this.AirConditionerId = cart.AirConditionerId;
            this.AirConditioner = cart.AirConditioner;
            this.VacuumCleanerId = cart.VacuumCleanerId;
            this.VacuumCleaner = cart.VacuumCleaner;
        }
        public int Id { get; set; }

        public string UserId { get; set; }

        public string TVsId { get; set; }

        public TV TVs { get; set; }

        public string WashingMachineId { get; set; }

        public WashingMachine WashingMachines { get; set; }

        public string MobilePhonesId { get; set; }

        public MobilePhone MobilePhones { get; set; }

        public string FridgeId { get; set; }

        public Fridge Fridge { get; set; }

        public string AirConditionerId { get; set; }

        public virtual AirConditioner AirConditioner { get; set; }

        public string VacuumCleanerId { get; set; }

        public virtual VacuumCleaner VacuumCleaner { get; set; }

        public decimal? TotalPrice { get; set; }
    }
}
