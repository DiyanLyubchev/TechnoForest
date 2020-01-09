using System.Collections.Generic;
using System.Threading.Tasks;
using TechnoForest_Data.Entity;
using TechnoForest_Service.Dto;

namespace TechnoForest_Service.Core
{
    public interface IUserService
    {
        Task<IEnumerable<ShoppingCart>> CurrentUserShoppingAsync(UserDto dto);
    }
}