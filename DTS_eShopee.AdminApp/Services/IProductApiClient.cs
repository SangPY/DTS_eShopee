using DTS_eShopee.ViewModels.Catalog.Products;
using DTS_eShopee.ViewModels.Common;
using System.Threading.Tasks;

namespace DTS_eShopee.AdminApp.Services
{
    public interface IProductApiClient
    {
        Task<PagedResult<ProductViewModel>> GetPagings(GetManageProductPagingRequest request);
    }
}