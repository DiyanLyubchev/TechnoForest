using System.Collections.Generic;
using System.Threading.Tasks;
using TechnoForest_Data.Entity;

namespace TechnoForest_Service.Core
{
    public interface IProductService
    {
        Task<IEnumerable<MobilePhone>> GetAllMobilePhoneAsync();

        Task<IEnumerable<TV>> GetAllTVAsync();

        Task<IEnumerable<WashingMachine>> GetAllWashingMachineAsync();

        Task<IEnumerable<Fridge>> GetAllFridgeAsync();

        Task<IEnumerable<AirConditioner>> GetAllAirConditionerAsync();

        Task<IEnumerable<VacuumCleaner>> GetAllVacuumCleanerAsync();
    }
}