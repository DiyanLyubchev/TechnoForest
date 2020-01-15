using System.Threading.Tasks;
using TechnoForest_Service.Dto;

namespace TechnoForest_Service.Core
{
    public interface IShoppingCartService
    {
        Task<bool> AddMobilePhoneToCartAsync(ProductDto dto);

        Task<bool> AddWashingMachineToCartAsync(ProductDto dto);

        Task<bool> AddTvToCartAsync(ProductDto dto);

        Task<bool> AddFridgeToCartAsync(ProductDto dto);

        Task<bool> AddAirConditionerToCartAsync(ProductDto dto);
    }
}