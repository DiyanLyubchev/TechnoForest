using System.Collections.Generic;
using System.Threading.Tasks;
using TechnoForest_Data.Entity;

namespace TechnoForest_Service.Core
{
    public interface IRepositoryForest
    {
        Task<Fridge> SearchFridgeById(string id);
        Task<MobilePhone> SearchMobileById(string id);
        Task<TV> SearchTvById(string id);
        Task<WashingMachine> SearchWashingMachineById(string id);

        Task<AirConditioner> SearchAirConditionerById(string id);

        Task<VacuumCleaner> SearchVacuumCleanerById(string id);

        Task<User> CurrentUserById(string id);

        Task<decimal?> TVCurrentPriceById(string id);

        Task<ICollection<decimal?>> GetTotalPriceFromShopingCartByCurrentUser(string id);

        Task<ShoppingCart> GetShoppingCartUser(string id);

        Task<decimal?> PhoneCurrentPriceById(string id);

        Task<decimal?> WashingMachinesCurrentPriceById(string id);

        Task<decimal?> FridgesCurrentPriceById(string id);

        Task<decimal?> AirConditionersCurrentPriceById(string id);

    }
}