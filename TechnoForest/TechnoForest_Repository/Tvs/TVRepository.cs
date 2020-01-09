using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechnoForest_Data.Context;
using TechnoForest_Data.Entity;

namespace TechnoForest_Repository.Tvs
{
    public class TVRepository : ITVRepository
    {
        private readonly TechnoForestContext context;

        public TVRepository(TechnoForestContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<TV>> GetAllTVAsync()
        {
            return await this.context.TVs.ToListAsync();
        }
    }
}
