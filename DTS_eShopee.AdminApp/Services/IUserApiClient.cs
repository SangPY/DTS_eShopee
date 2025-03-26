using DTS_eShopee.ViewModels.Common;
using DTS_eShopee.ViewModels.System.Users;
using System.Threading.Tasks;

namespace DTS_eShopee.AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);

        Task<PagedResult<UserViewModel>> GetUsersPagings(GetUserPagingRequest request);
    }
}