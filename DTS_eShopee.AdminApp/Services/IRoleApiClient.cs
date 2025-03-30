using DTS_eShopee.ViewModels.Common;
using DTS_eShopee.ViewModels.System.Roles;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DTS_eShopee.AdminApp.Services
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RoleViewModel>>> GetAll();
    }
}