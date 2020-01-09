using System.Collections.Generic;
using System.Threading.Tasks;
using TechnoForest_Data.Entity;

namespace TechnoForest_Repository.Tvs
{
    public interface ITVRepository
    {
        Task<IEnumerable<TV>> GetAllTVAsync();
    }
}