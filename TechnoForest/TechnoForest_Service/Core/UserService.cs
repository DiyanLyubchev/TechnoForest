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
                 .Include(wash => wash.WashingMachines)
                 .Include(fridge => fridge.Fridge)
                 .Where(userId => userId.UserId == dto.UserId)
                 .ToListAsync();

            return listShopping;
        }

        public async Task<bool> ProcessesProductAsync(UserDto dto)
        {
            if (dto.RejectItem != null)
            {
                string[] itemResult = dto.RejectItem.Split(' ');

                var itemId = itemResult[0];
                decimal? itemPrice = decimal.Parse(itemResult[1]);

                var item = await this.context.ShoppingCarts
                    .Where(product => product.WashingMachineId == itemId
                    || product.TVsId == itemId || product.MobilePhoneId ==
                    itemId || product.FridgeId == itemId
                    && product.UserId == dto.UserId)
                    .FirstOrDefaultAsync();

                var tottalPrice =
                  await this.context.ShoppingCarts.Where(userId => userId.UserId == dto.UserId)
                    .Select(price => price.TotalPrice).ToListAsync();

                var cart =
                 await this.context.ShoppingCarts
                 .Where(userId => userId.UserId == dto.UserId)
                 .FirstOrDefaultAsync();

                var result = tottalPrice.Last();
                result -= itemPrice;

                cart.TotalPrice = result;

                await this.context.SaveChangesAsync();

            }
            else if (dto.BuyItem != null)
            {
                string[] itemResult = dto.BuyItem.Split(' ');

                var itemId = itemResult[0];
                decimal? itemPrice = decimal.Parse(itemResult[1]);

                var item = await this.context.ShoppingCarts
                    .Where(product => product.WashingMachineId == itemId
                    || product.TVsId == itemId || product.MobilePhoneId == itemId || product.FridgeId == itemId
                    && product.UserId == dto.UserId)
                    .FirstOrDefaultAsync();

                var tottalPrice =
                 await this.context.ShoppingCarts.Where(userId => userId.UserId == dto.UserId)
                   .Select(price => price.TotalPrice).ToListAsync();

                var cart =
                 await this.context.ShoppingCarts
                 .Where(userId => userId.UserId == dto.UserId)
                 .FirstOrDefaultAsync();

                var result = tottalPrice.Last();
                result -= itemPrice;

                cart.TotalPrice = result;

                await this.context.SaveChangesAsync();
            }

            return true;
        }
    }
}
