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
    }
}