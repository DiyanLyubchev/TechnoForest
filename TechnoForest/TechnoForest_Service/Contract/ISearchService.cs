using System.Threading.Tasks;
using TechnoForest_Data.Entity;

namespace TechnoForest_Service.Core
{
    public interface ISearchService
    {
        Task<Fridge> SearchFridgeById(string id);
        Task<MobilePhone> SearchMobileById(string id);
        Task<TV> SearchTvById(string id);
        Task<WashingMachine> SearchWashingMachineById(string id);
    }
}