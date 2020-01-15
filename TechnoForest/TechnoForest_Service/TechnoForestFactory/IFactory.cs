using TechnoForest_Data.Entity;

namespace TechnoForest_Service.TechnoForestFactory
{
    public interface IFactory
    {
        ShoppingCart FillCartWithTV(string tvID, TV tv, User currentUser, string userID, decimal? newPriceTv);

        ShoppingCart FillCartWithPhone(string phoneiD, MobilePhone phone, User currentUser, string userId, decimal? newPricePhone);

        ShoppingCart FillCartWithWashingMachine(string washingMichineId, WashingMachine washingMachine, User currentUser,
            string userId, decimal? newPriceWashingMachine);

        ShoppingCart FillCartWithFridge(string fridgeId, Fridge fridge, User currentUser,
           string userId, decimal? newPriceFridge);

        ShoppingCart FillCartWithAirConditioner(string airConditionerId, AirConditioner airConditioner,
            User currentUser, string userId, decimal? newPriceAirConditioner);
    }
}