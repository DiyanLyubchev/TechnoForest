using System.Threading.Tasks;
using TechnoForest_Data.Context;
using TechnoForest_Data.Entity;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace TechnoForest_Service.Core
{
    public class RepositoryForest : IRepositoryForest
    {
        private readonly TechnoForestContext context;

        public RepositoryForest(TechnoForestContext context)
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

        public async Task<AirConditioner> SearchAirConditionerById(string id)
        {
            return await this.context.AirConditioners
                .FirstOrDefaultAsync(airConditionerId => airConditionerId.Id == id);
        }

        public async Task<VacuumCleaner> SearchVacuumCleanerById(string id)
        {
            return await this.context.VacuumCleaners
                .FirstOrDefaultAsync(vacuumCleanerId => vacuumCleanerId.Id == id);
        }

        public async Task<User> CurrentUserById(string id)
        {
            return await this.context.Users
                .SingleOrDefaultAsync(userId => userId.Id == id);
        }

        public async Task<decimal?> TVCurrentPriceById(string id)
        {
            return await this.context.TVs
                   .Where(tVId => tVId.Id == id)
                   .Select(price => price.Price)
                   .SingleOrDefaultAsync();
        }

        public async Task<ICollection<decimal?>> GetTotalPriceFromShopingCartByCurrentUser(string id)
        {
            return await this.context.ShoppingCarts
                .Where(user => user.UserId == id)
                .Select(price => price.TotalPrice).ToListAsync();
        }

        public async Task<ShoppingCart> GetShoppingCartUser(string id)
        {
            return await this.context.ShoppingCarts
                   .FirstOrDefaultAsync(user => user.UserId == id);
        }

        public async Task<decimal?> PhoneCurrentPriceById(string id)
        {
            return await this.context.MobilePhones
                  .Where(phoneId => phoneId.Id == id)
                  .Select(price => price.Price)
                  .FirstOrDefaultAsync();
        }

        public async Task<decimal?> WashingMachinesCurrentPriceById(string id)
        {
            return await this.context.WashingMachines
                   .Where(wMachineId => wMachineId.Id == id)
                   .Select(price => price.Price)
                   .FirstOrDefaultAsync();
        }
        public async Task<decimal?> FridgesCurrentPriceById(string id)
        {
            return await this.context.Fridges
                .Where(fridgeId => fridgeId.Id == id)
                .Select(price => price.Price)
                .FirstOrDefaultAsync();

        }
        public async Task<decimal?> AirConditionersCurrentPriceById(string id)
        {
            return await this.context.AirConditioners
              .Where(airId => airId.Id == id)
              .Select(price => price.Price)
              .FirstOrDefaultAsync();
        }
    }
}



