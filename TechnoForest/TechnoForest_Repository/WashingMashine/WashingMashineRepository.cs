using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechnoForest_Data.Context;
using TechnoForest_Data.Entity;

namespace TechnoForest_Repository.WashingMashine
{
    public class WashingMashineRepository : IWashingMashineRepository
    {
        private readonly TechnoForestContext context;

        public WashingMashineRepository(TechnoForestContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<WashingMachine>> GetAllWashingMachineAsync()
        {
            return await this.context.WashingMachines.ToListAsync();
        }
    }
}
