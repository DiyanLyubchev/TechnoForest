using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnoForest_Data.Context;
using TechnoForest_Data.Entity;
using TechnoForest_Service.Dto;

namespace TechnoForest_Service.Core
{
    public class UserService : IUserService
    {
        private readonly TechnoForestContext context;

        public UserService(TechnoForestContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<ShoppingCart>> CurrentUserShoppingAsync(UserDto dto)
        {
            var listShopping = await this.context.ShoppingCarts
                 .Include(mobile => mobile.MobilePhones)
                 .Include(tv => tv.TVs)
                 .Include(wash  => wash.WashingMachines)
                 .Include(fridge => fridge.Fridge)
                 .Where(userId => userId.UserId == dto.UserId)
                 .ToListAsync();

            return listShopping;
        }
    }
}
