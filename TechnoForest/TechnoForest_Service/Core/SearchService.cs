using System.Threading.Tasks;
using TechnoForest_Data.Context;
using TechnoForest_Data.Entity;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TechnoForest_Service.Core
{
    public class SearchService : ISearchService
    {
        private readonly TechnoForestContext context;

        public SearchService(TechnoForestContext context)
        {
            this.context = context;
        }

        public async Task<MobilePhone> SearchMobileById(string id)
        {
            return await this.context.MobilePhones
                .FirstOrDefaultAsync(phoneId => phoneId.Id == id);
        }

        public async Task<TV> SearchTvById(string id)
        {
            return await this.context.TVs
                .FirstOrDefaultAsync(tvId => tvId.Id == id);
        }

        public async Task<WashingMachine> SearchWashingMachineById(string id)
        {
            return await this.context.WashingMachines
                .FirstOrDefaultAsync(machineId => machineId.Id == id);
        }

        public async Task<Fridge> SearchFridgeById(string id)
        {
            return await this.context.Fridges
                .FirstOrDefaultAsync(fridgeId => fridgeId.Id == id);
        }

    }
}
