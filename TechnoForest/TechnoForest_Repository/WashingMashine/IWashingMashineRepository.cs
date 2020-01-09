using System.Collections.Generic;
using System.Threading.Tasks;
using TechnoForest_Data.Entity;

namespace TechnoForest_Repository.WashingMashine
{
    public interface IWashingMashineRepository
    {
        Task<IEnumerable<WashingMachine>> GetAllWashingMachineAsync();
    }
}