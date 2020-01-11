using System.Threading.Tasks;
using TechnoForest_Service.Dto;

namespace TechnoForest_Service.Core
{
    public interface IShoppingCartService
    {
        Task<bool> AddMobilePhoneToCartAsync(MobilePhoneDto dto);
        Task<bool> AddWashingMachineToCartAsync(WashingMachineDto dto);

        Task<bool> AddTvToCartAsync(TvDto dto);
    }
}