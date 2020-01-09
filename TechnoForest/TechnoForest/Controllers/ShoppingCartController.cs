using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TechnoForest.Models.ShopingCarts;
using TechnoForest.Models.ShoppingCarts;
using TechnoForest_Service.Core;
using TechnoForest_Service.Dto;

namespace TechnoForest.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IUserService service;

        public ShoppingCartController(IUserService service)
        {
            this.service = service;
        }

        [Authorize]
        public async Task<IActionResult> CheckMyShopping()
        {
            var user = new UserDto
            {
                UserId = User.FindFirstValue(ClaimTypes.NameIdentifier)
            };

            var myCart = (await this.service.CurrentUserShoppingAsync(user))
              .Select(shopping => new ShoppingCartViewModel(shopping));


            var stop = 0;

            var results = new SearchResultsViewModel(myCart);

            return View("CheckMyShopping", results);
        }
    }
}