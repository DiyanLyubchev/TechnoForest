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
        private readonly IRepositoryForest service;
        public UserService(TechnoForestContext context, IRepositoryForest service)
        {
            this.context = context;
            this.service = service;
        }

        public async Task<IEnumerable<ShoppingCart>> CurrentUserShoppingAsync(UserDto dto)
        {
            var listShopping = await this.context.ShoppingCarts
                 .Include(mobile => mobile.MobilePhones)
                 .Include(tv => tv.TVs)
                 .Include(wash => wash.WashingMachines)
                 .Include(fridge => fridge.Fridge)
                 .Include(air => air.AirConditioner)
                 .Include(vacuum => vacuum.VacuumCleaner)
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

                var tottalPrice =
                  await this.context.ShoppingCarts.Where(userId => userId.UserId == dto.UserId)
                    .Select(price => price.TotalPrice).ToListAsync();

                var cart =
                 await this.context.ShoppingCarts
                 .Where(userId => userId.UserId == dto.UserId)
                 .FirstOrDefaultAsync();

                var item = await this.context.ShoppingCarts.Where(id => id.FridgeId == itemId ||
                id.TVsId == itemId || id.WashingMachineId == itemId || id.MobilePhoneId == itemId 
                || id.AirConditionerId == itemId)
                    .SingleOrDefaultAsync();

                var result = tottalPrice.Last();
                var actualResult = result - itemPrice;
                cart.TotalPrice = actualResult;

                await this.context.SaveChangesAsync();

                this.context.ShoppingCarts.Remove(item);
                await this.context.SaveChangesAsync();
                return true;
            }
            else if (dto.BuyItem != null)
            {
                string[] itemResult = dto.BuyItem.Split(' ');

                var itemId = itemResult[0];
                decimal? itemPrice = decimal.Parse(itemResult[1]);

                var phone = await this.service.SearchMobileById(itemId);
                var tv = await this.service.SearchTvById(itemId);
                var washingMachine = await service.SearchWashingMachineById(itemId);
                var fridge = await this.service.SearchFridgeById(itemId);
                var airConditioner = await this.service.SearchAirConditionerById(itemId);


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

                if (phone != null)
                {
                    phone.IsBought = false;
                }
                else if (tv != null)
                {
                    tv.IsBought = false;
                }
                else if (washingMachine != null)
                {
                    washingMachine.IsBought = false;
                }
                else if (fridge != null)
                {
                    fridge.IsBought = false;
                }
                else if (airConditioner != null)
                {
                    airConditioner.IsBought = false;
                }

                //   await this.context.SaveChangesAsync();

                return true;
            }

            return false;
        }

    }
}
