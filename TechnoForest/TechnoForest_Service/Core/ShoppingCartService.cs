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

        public async Task AddMobilePhoneToCartAsync(MobilePhoneDto dto)
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

            decimal? newPrice = null;
            if (shoppingPhone.Count() != 0)
            {
                 newPrice = shoppingPhone.Last() + phonePrice;
            }
            else 
            {
                newPrice = phonePrice;
            }

            var cart = new ShoppingCart
            {
                MobilePhones = phone,
                User = currentUser,
                UserId = dto.UserId,
                AddTOCart = DateTime.Now,
                TotalPrice = newPrice
            };

            await this.context.ShoppingCarts.AddAsync(cart);
            await this.context.SaveChangesAsync();
        }
    }
}
