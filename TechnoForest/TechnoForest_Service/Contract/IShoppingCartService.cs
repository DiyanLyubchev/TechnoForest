using System.Threading.Tasks;
using TechnoForest_Service.Dto;

namespace TechnoForest_Service.Core
{
    public interface IShoppingCartService
    {
        Task AddMobilePhoneToCartAsync(MobilePhoneDto dto);
        Task AddWashingMachineToCartAsync(WashingMachineDto dto);
    }
}