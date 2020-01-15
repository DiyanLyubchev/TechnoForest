using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using TechnoForest.Models.Product;
using TechnoForest.Models.Product.AirConditioners;
using TechnoForest.Models.Product.Fridges;
using TechnoForest.Models.Product.TVs;
using TechnoForest.Models.Product.VacuumCleaners;
using TechnoForest.Models.Product.WashingMashines;
using TechnoForest_Service.Core;
using TechnoForest_Service.Dto;

namespace TechnoForest.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService service;
        private readonly IShoppingCartService shopping;
        public ProductController(IProductService service, IShoppingCartService shopping)
        {
            this.service = service;
            this.shopping = shopping;
        }


        public async Task<IActionResult> ShowMobilePhone()
        {
            var allMobilePhone = await this.service.GetAllMobilePhoneAsync();

            var listPhones = new ListMobilePhoneViewModel(allMobilePhone);

            return View(listPhones);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> AddPhoneToCart(string id)
        {
            var dto = new ProductDto
            {
                ProductId = id,
                UserId = User.FindFirstValue(ClaimTypes.NameIdentifier)
            };

            await this.shopping.AddMobilePhoneToCartAsync(dto);

            return RedirectToAction("ShowMobilePhone", "Product");
        }


        public async Task<IActionResult> ShowWashingMachine()
        {
            var allWashingMachine = await this.service.GetAllWashingMachineAsync();

            var listWashingMachine = new ListWashingMachineViewModel(allWashingMachine);

            return View(listWashingMachine);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> AddWashingMachineToCart(string id)
        {
            var dto = new ProductDto
            {
                ProductId = id,
                UserId = User.FindFirstValue(ClaimTypes.NameIdentifier)
            };

            await this.shopping.AddWashingMachineToCartAsync(dto);

            return RedirectToAction("ShowWashingMachine", "Product");
        }

        public async Task<IActionResult> ShowTv()
        {
            var allTvs = await this.service.GetAllTVAsync();

            var listTvs = new ListTvsViewModel(allTvs);

            return View(listTvs);
        }


        [Authorize]
        [HttpGet]
        public async Task<IActionResult> AddTvToCart(string id)
        {
            var dto = new ProductDto
            {
                ProductId = id,
                UserId = User.FindFirstValue(ClaimTypes.NameIdentifier)
            };

            await this.shopping.AddTvToCartAsync(dto);

            return RedirectToAction("ShowTv", "Product");
        }

        public async Task<IActionResult> ShowFridge()
        {
            var allFridges = await this.service.GetAllFridgeAsync();

            var listFridges = new ListFridgeViewModel(allFridges);

            return View(listFridges);
        }


        [Authorize]
        [HttpGet]
        public async Task<IActionResult> AddFridgeToCart(string id)
        {
            var dto = new ProductDto
            {
                ProductId = id,
                UserId = User.FindFirstValue(ClaimTypes.NameIdentifier)
            };

            await this.shopping.AddFridgeToCartAsync(dto);

            return RedirectToAction("ShowFridge", "Product");
        }

        public async Task<IActionResult> ShowVacuumCleaners()
        {
            var allVacuum = await this.service.GetAllVacuumCleanerAsync();

            var listVacuumCleaners = new ListVacuumCleanersViewModel(allVacuum);

            return View(listVacuumCleaners);
        }

        public async Task<IActionResult> ShowAirConditioner()
        {
            var allAirConditioner = await this.service.GetAllAirConditionerAsync();

            var listAirConditioner = new ListAirConditionerViewModel(allAirConditioner);

            return View(listAirConditioner);
        }


        [Authorize]
        [HttpGet]
        public async Task<IActionResult> AddAirConditionerToCart(string id)
        {
            var dto = new ProductDto
            {
                ProductId = id,
                UserId = User.FindFirstValue(ClaimTypes.NameIdentifier)
            };

            await this.shopping.AddAirConditionerToCartAsync(dto);

            return RedirectToAction("ShowAirConditioner", "Product");
        }

    }
}
