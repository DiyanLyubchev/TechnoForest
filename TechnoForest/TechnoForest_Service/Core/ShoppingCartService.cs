using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TechnoForest_Data.Context;
using TechnoForest_Data.Entity;
using TechnoForest_Service.CustomException;
using TechnoForest_Service.Dto;
using TechnoForest_Service.TechnoForestFactory;

namespace TechnoForest_Service.Core
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly TechnoForestContext context;
        private readonly IFactory factory;
        private readonly IRepositoryForest repository;
        public ShoppingCartService(TechnoForestContext context, IFactory factory , IRepositoryForest repository)
        {
            this.repository = repository;
            this.context = context;
            this.factory = factory;
        }

        public async Task<bool> AddTvToCartAsync(ProductDto dto)
        {
            if (dto.ProductId == null)
            {
                throw new ProductExeption("Tv does not exist!");
            }

            var tv = await this.repository.SearchTvById(dto.ProductId);
            var currentUser = await this.repository.CurrentUserById(dto.UserId);
            var tvPrice = await this.repository.TVCurrentPriceById(dto.ProductId);
            var shoppingTotalPrice = await this.repository.GetTotalPriceFromShopingCartByCurrentUser(dto.UserId);
            var shopping = await this.repository.GetShoppingCartUser(dto.UserId);

            decimal? newPriceTv = null;
            if (shoppingTotalPrice.Count() != 0)
            {
                newPriceTv = shoppingTotalPrice.Last() + tvPrice;

                if (shopping.TVsId == null)
                {
                    var cart = this.factory
                        .FillCartWithTV(dto.ProductId, tv, currentUser, dto.UserId, newPriceTv);

                    tv.IsBought = true;
                    await this.context.ShoppingCarts.AddAsync(cart);
                    await this.context.SaveChangesAsync();

                    return true;
                }
                else if (shopping.TVsId.Contains(dto.ProductId))
                {
                    shopping.TotalPrice = newPriceTv;
                    shopping.AddTOCart = DateTime.Now;
                    tv.IsBought = true;
                    await this.context.SaveChangesAsync();

                    return true;
                }
            }
            else
            {
                newPriceTv = tvPrice;

                var cart = this.factory
                          .FillCartWithTV(dto.ProductId, tv, currentUser, dto.UserId, newPriceTv);

                tv.IsBought = true;

                await this.context.ShoppingCarts.AddAsync(cart);
                await this.context.SaveChangesAsync();
                return true;
            }

            return false;

        }

        public async Task<bool> AddMobilePhoneToCartAsync(ProductDto dto)
        {
            if (dto.ProductId == null)
            {
                throw new ProductExeption("Phone does not exist!");
            }

            var phone = await this.repository.SearchMobileById(dto.ProductId);
            var phonePrice = await this.repository.PhoneCurrentPriceById(dto.ProductId);
            var currentUser = await this.repository.CurrentUserById(dto.UserId);
            var shoppingTotalPrice = await this.repository.GetTotalPriceFromShopingCartByCurrentUser(dto.UserId);
            var shopping = await this.repository.GetShoppingCartUser(dto.UserId);

            decimal? newPricePhone = null;
            if (shoppingTotalPrice.Count() != 0)
            {
                newPricePhone = shoppingTotalPrice.Last() + phonePrice;

                if (shopping.MobilePhoneId == null)
                {
                    var cart = this.factory
                    .FillCartWithPhone(dto.ProductId, phone, currentUser, dto.UserId, newPricePhone);

                    phone.IsBought = true;
                    await this.context.ShoppingCarts.AddAsync(cart);
                    await this.context.SaveChangesAsync();

                    return true;
                }
                else if (shopping.MobilePhoneId.Contains(dto.ProductId))
                {
                    shopping.TotalPrice = newPricePhone;
                    shopping.AddTOCart = DateTime.Now;
                    phone.IsBought = true;
                    await this.context.SaveChangesAsync();

                    return true;
                }
            }
            else
            {
                newPricePhone = phonePrice;
                var cart = this.factory
                        .FillCartWithPhone(dto.ProductId, phone, currentUser, dto.UserId, newPricePhone);

                phone.IsBought = true;
                await this.context.ShoppingCarts.AddAsync(cart);

                await this.context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> AddWashingMachineToCartAsync(ProductDto dto)
        {
            if (dto.ProductId == null)
            {
                throw new ProductExeption("Washing machine does not exist!");
            }

            var washingMachine = await this.repository.SearchWashingMachineById(dto.ProductId);
            var currentUser = await this.repository.CurrentUserById(dto.UserId);
            var washingMachinePrice = await this.repository.WashingMachinesCurrentPriceById(dto.ProductId);
            var shoppingTotalPrice = await this.repository.GetTotalPriceFromShopingCartByCurrentUser(dto.UserId);
            var shopping = await this.repository.GetShoppingCartUser(dto.UserId);

            decimal? newPriceWashingMachine = null;

            if (shoppingTotalPrice.Count() != 0)
            {
                newPriceWashingMachine = shoppingTotalPrice.Last() + washingMachinePrice;

                if (shopping.WashingMachineId == null)
                {
                    var cart = this.factory
                        .FillCartWithWashingMachine(dto.ProductId, washingMachine, currentUser, dto.UserId, newPriceWashingMachine);

                    washingMachine.IsBought = true;
                    await this.context.ShoppingCarts.AddAsync(cart);
                    await this.context.SaveChangesAsync();

                    return true;
                }
                else if (shopping.WashingMachineId.Contains(dto.ProductId))
                {
                    shopping.TotalPrice = newPriceWashingMachine;
                    shopping.AddTOCart = DateTime.Now;
                    washingMachine.IsBought = true;
                    await this.context.SaveChangesAsync();

                    return true;
                }
            }
            else
            {
                newPriceWashingMachine = washingMachinePrice;

                var cart = this.factory
                         .FillCartWithWashingMachine(dto.ProductId, washingMachine, currentUser, dto.UserId, newPriceWashingMachine);
                washingMachine.IsBought = true;

                await this.context.ShoppingCarts.AddAsync(cart);
                await this.context.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<bool> AddFridgeToCartAsync(ProductDto dto)
        {
            if (dto.ProductId == null)
            {
                throw new ProductExeption("Fridge does not exist!");
            }

            var fridge = await this.repository.SearchFridgeById(dto.ProductId);
            var currentUser = await this.repository.CurrentUserById(dto.UserId);
            var fridgePrice = await this.repository.FridgesCurrentPriceById(dto.ProductId);
            var shoppingTotalPrice = await this.repository.GetTotalPriceFromShopingCartByCurrentUser(dto.UserId);
            var shopping = await this.repository.GetShoppingCartUser(dto.UserId);

            decimal? newPriceFridge = null;
            if (shoppingTotalPrice.Count() != 0)
            {
                newPriceFridge = shoppingTotalPrice.Last() + fridgePrice;

                if (shopping.FridgeId == null)
                {
                    var cart = this.factory
                        .FillCartWithFridge(dto.ProductId, fridge, currentUser, dto.UserId, newPriceFridge);

                    fridge.IsBought = true;
                    await this.context.ShoppingCarts.AddAsync(cart);
                    await this.context.SaveChangesAsync();

                    return true;
                }
                else if (shopping.FridgeId.Contains(dto.ProductId))
                {
                    shopping.TotalPrice = newPriceFridge;
                    shopping.AddTOCart = DateTime.Now;
                    fridge.IsBought = true;

                    await this.context.SaveChangesAsync();

                    return true;
                }
            }
            else
            {
                newPriceFridge = fridgePrice;

                var cart = this.factory
                       .FillCartWithFridge(dto.ProductId, fridge, currentUser, dto.UserId, newPriceFridge);

                fridge.IsBought = true;
                await this.context.ShoppingCarts.AddAsync(cart);
                await this.context.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<bool> AddAirConditionerToCartAsync(ProductDto dto)
        {
            if (dto.ProductId == null)
            {
                throw new ProductExeption("Air Conditioner does not exist!");
            }

            var airConditioner = await this.repository.SearchAirConditionerById(dto.ProductId);
            var currentUser = await this.repository.CurrentUserById(dto.UserId);
            var airConditionerPrice = await this.repository.AirConditionersCurrentPriceById(dto.ProductId);
            var shoppingTotalPrice = await this.repository.GetTotalPriceFromShopingCartByCurrentUser(dto.UserId);
            var shopping = await this.repository.GetShoppingCartUser(dto.UserId);

            decimal? newPriceAirConditioner = null;
            if (shoppingTotalPrice.Count() != 0)
            {
                newPriceAirConditioner = shoppingTotalPrice.Last() + airConditionerPrice;

                if (shopping.FridgeId == null)
                {
                    var cart = this.factory
                        .FillCartWithAirConditioner(dto.ProductId, airConditioner, currentUser, dto.UserId, newPriceAirConditioner);

                    airConditioner.IsBought = true;
                    await this.context.ShoppingCarts.AddAsync(cart);
                    await this.context.SaveChangesAsync();

                    return true;
                }
                else if (shopping.AirConditionerId.Contains(dto.ProductId))
                {
                    shopping.TotalPrice = newPriceAirConditioner;
                    shopping.AddTOCart = DateTime.Now;
                    airConditioner.IsBought = true;

                    await this.context.SaveChangesAsync();

                    return true;
                }
            }
            else
            {
                newPriceAirConditioner = airConditionerPrice;

                var cart = this.factory
                        .FillCartWithAirConditioner(dto.ProductId, airConditioner, currentUser, dto.UserId, newPriceAirConditioner);

                airConditioner.IsBought = true;
                await this.context.ShoppingCarts.AddAsync(cart);
                await this.context.SaveChangesAsync();

                return true;
            }

            return false;
        }
    }
}
