using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using TechnoForest.Models.Product;
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

        [Authorize]
        public async Task<IActionResult> ShowMobilePhone()
        {
            var allMobilePhone = await this.service.GetAllMobilePhoneAsync();

            var listPhones = new ListMobilePhoneViewModel(allMobilePhone);

            return View(listPhones);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> AddPhoneToCart(int id)
        {
            var dto = new MobilePhoneDto
            {
                PhoneId = id,
                UserId = User.FindFirstValue(ClaimTypes.NameIdentifier)
            };

            await this.shopping.AddMobilePhoneToCartAsync(dto);

            return RedirectToAction("ShowMobilePhone", "Product");
        }

        [Authorize]
        public async Task<IActionResult> ShowWashingMachine()
        {
            var allWashingMachine = await this.service.GetAllWashingMachineAsync();

            var listWashingMachine = new ListWashingMachineViewModel(allWashingMachine);

            return View(listWashingMachine);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> AddWashingMachineToCart(int id)
        {
            var dto = new WashingMachineDto
            {
                WashingMichineId = id,
                UserId = User.FindFirstValue(ClaimTypes.NameIdentifier)
            };

            await this.shopping.AddWashingMachineToCartAsync(dto);

            return RedirectToAction("ShowWashingMachine", "Product");
        }
    }
}
