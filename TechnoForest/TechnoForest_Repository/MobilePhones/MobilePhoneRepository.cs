using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TechnoForest_Data.Context;
using TechnoForest_Data.Entity;

namespace TechnoForest_Repository.MobilePhones
{
    public class MobilePhoneRepository : IMobilePhoneRepository
    {
        private readonly TechnoForestContext context;

        public MobilePhoneRepository(TechnoForestContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<MobilePhone>> GetAllMobilePhoneAsync()
        {
            return await this.context.MobilePhones.ToListAsync();
        }

        public async Task<MobilePhone> GetMobilePhoneById(int id)
        {
            return await this.context.MobilePhones
                 .FirstOrDefaultAsync(phoneId => phoneId.Id == id);
        }
    }
}
