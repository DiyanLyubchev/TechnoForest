using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TechnoForest_Data.Context;
using TechnoForest_Data.Entity;
using TechnoForest_Service.CustomException;
using TechnoForest_Service.Dto;

namespace TechnoForest_Service.Core
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly TechnoForestContext context;

        public ShoppingCartService(TechnoForestContext context)
        {
            this.context = context;
        }

        public async Task<bool> AddTvToCartAsync(TvDto dto)
        {
            if (dto.TvId == 0)
            {
                throw new ProductExeption("Tv does not exist!");
            }

            var tv = await this.context.TVs
                 .FirstOrDefaultAsync(tvId => tvId.Id == dto.TvId);

            var currentUser = await this.context.Users
                .FirstOrDefaultAsync(id => id.Id == dto.UserId);

            var tvPrice = await this.context.TVs
                .Where(tVId => tVId.Id == dto.TvId)
                .Select(price => price.Price)
                .SingleOrDefaultAsync();


            var shoppingTv = await this.context.ShoppingCarts
                .Where(user => user.UserId == dto.UserId)
                .Select(price => price.TotalPrice).ToListAsync();

            decimal? newPriceTv = null;
            if (shoppingTv.Count() != 0)
            {
                newPriceTv = shoppingTv.Last() + tvPrice;
            }
            else
            {
                newPriceTv = tvPrice;
            }

            var cart = new ShoppingCart
            {
                TVs = tv,
                User = currentUser,
                UserId = dto.UserId,
                AddTOCart = DateTime.Now,
                TotalPrice = newPriceTv
            };

            await this.context.ShoppingCarts.AddAsync(cart);
            await this.context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> AddMobilePhoneToCartAsync(MobilePhoneDto dto)
        {
            if (dto.PhoneId == 0)
            {
                throw new ProductExeption("Phone does not exist!");
            }

            var phone = await this.context.MobilePhones
                 .FirstOrDefaultAsync(phoneId => phoneId.Id == dto.PhoneId);

            var currentUser = await this.context.Users
                .FirstOrDefaultAsync(id => id.Id == dto.UserId);

            var phonePrice = await this.context.MobilePhones
                .Where(phoneId => phoneId.Id == dto.PhoneId)
                .Select(price => price.Price)
                .SingleOrDefaultAsync();


            var shoppingPhone = await this.context.ShoppingCarts
                .Where(user => user.UserId == dto.UserId)
                .Select(price => price.TotalPrice).ToListAsync();

            decimal? newPricePhone = null;
            if (shoppingPhone.Count() != 0)
            {
                newPricePhone = shoppingPhone.Last() + phonePrice;
            }
            else
            {
                newPricePhone = phonePrice;
            }

            var cart = new ShoppingCart
            {
                MobilePhones = phone,
                User = currentUser,
                UserId = dto.UserId,
                AddTOCart = DateTime.Now,
                TotalPrice = newPricePhone
            };

            await this.context.ShoppingCarts.AddAsync(cart);
            await this.context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> AddWashingMachineToCartAsync(WashingMachineDto dto)
        {
            if (dto.WashingMichineId == 0)
            {
                throw new ProductExeption("Washing machine does not exist!");
            }

            var washingMachine = await this.context.WashingMachines
                 .FirstOrDefaultAsync(wMachineId => wMachineId.Id == dto.WashingMichineId);

            var currentUser = await this.context.Users
                .FirstOrDefaultAsync(id => id.Id == dto.UserId);

            var washingMachinePrice = await this.context.WashingMachines
                .Where(wMachineId => wMachineId.Id == dto.WashingMichineId)
                .Select(price => price.Price)
                .SingleOrDefaultAsync();


            var shoppingWashingMachine = await this.context.ShoppingCarts
                .Where(user => user.UserId == dto.UserId)
                .Select(price => price.TotalPrice).ToListAsync();

            decimal? newPriceWashingMachine = null;
            if (shoppingWashingMachine.Count() != 0)
            {
                newPriceWashingMachine = shoppingWashingMachine.Last() + washingMachinePrice;
            }
            else
            {
                newPriceWashingMachine = washingMachinePrice;
            }

            var cart = new ShoppingCart
            {
                WashingMachines = washingMachine,
                User = currentUser,
                UserId = dto.UserId,
                AddTOCart = DateTime.Now,
                TotalPrice = newPriceWashingMachine
            };

            await this.context.ShoppingCarts.AddAsync(cart);
            await this.context.SaveChangesAsync();

            return true;
        }
    }
}
