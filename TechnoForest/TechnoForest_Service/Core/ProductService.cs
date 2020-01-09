using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnoForest_Data.Context;
using TechnoForest_Data.Entity;

namespace TechnoForest_Service.Core
{
    public class ProductService : IProductService
    {
        private readonly TechnoForestContext context;

        public ProductService(TechnoForestContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<MobilePhone>> GetAllMobilePhoneAsync()
        {
            return await this.context.MobilePhones.ToListAsync();
        }

        public async Task<IEnumerable<TV>> GetAllTVAsync()
        {
            return await this.context.TVs.ToListAsync();
        }

        public async Task<IEnumerable<WashingMachine>> GetAllWashingMachineAsync()
        {
            return await this.context.WashingMachines.ToListAsync();
        }
    }
}
