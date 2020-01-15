using System;
using System.Collections.Generic;
using System.Text;
using TechnoForest_Data.Entity;

namespace TechnoForest_Service.TechnoForestFactory
{
    public class Factory : IFactory
    {
        public ShoppingCart FillCartWithTV(string tvID, TV tv, User currentUser, string userID, decimal? newPriceTv)
        {
            return new ShoppingCart
            {
                TVsId = tvID,
                TVs = tv,
                User = currentUser,
                UserId = userID,
                AddTOCart = DateTime.Now,
                TotalPrice = newPriceTv
            };
        }

        public ShoppingCart FillCartWithPhone(string phoneiD, MobilePhone phone, User currentUser, string userId,
            decimal? newPricePhone)
        {
            return new ShoppingCart
            {
                MobilePhoneId = phoneiD,
                MobilePhones = phone,
                User = currentUser,
                UserId = userId,
                AddTOCart = DateTime.Now,
                TotalPrice = newPricePhone,
            };
        }
        public ShoppingCart FillCartWithWashingMachine(string washingMichineId, WashingMachine washingMachine, User currentUser,
            string userId, decimal? newPriceWashingMachine)
        {
            return new ShoppingCart
            {
                WashingMachineId = washingMichineId,
                WashingMachines = washingMachine,
                User = currentUser,
                UserId = userId,
                AddTOCart = DateTime.Now,
                TotalPrice = newPriceWashingMachine,
            };
        }

        public ShoppingCart FillCartWithFridge(string fridgeId, Fridge fridge, User currentUser,
           string userId, decimal? newPriceFridge)
        {
            return new ShoppingCart
            {
                FridgeId = fridgeId,
                Fridge = fridge,
                User = currentUser,
                UserId = userId,
                AddTOCart = DateTime.Now,
                TotalPrice = newPriceFridge,
            };
        }

        public ShoppingCart FillCartWithAirConditioner(string airConditionerId, AirConditioner airConditioner,
            User currentUser, string userId, decimal? newPriceAirConditioner)
        {
            return new ShoppingCart
            {
                AirConditionerId = airConditionerId,
                AirConditioner = airConditioner,
                User = currentUser,
                UserId = userId,
                TotalPrice = newPriceAirConditioner,
            };
        }

    }
}
