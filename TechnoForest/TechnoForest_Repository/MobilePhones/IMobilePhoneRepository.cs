using System.Collections.Generic;
using System.Threading.Tasks;
using TechnoForest_Data.Entity;

namespace TechnoForest_Repository.MobilePhones
{
    public interface IMobilePhoneRepository
    {
        Task<IEnumerable<MobilePhone>> GetAllMobilePhoneAsync();
        Task<MobilePhone> GetMobilePhoneById(int id);
    }
}