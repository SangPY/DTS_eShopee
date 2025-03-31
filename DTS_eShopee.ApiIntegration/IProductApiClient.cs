using DTS_eShopee.ViewModels.Catalog.Products;
using DTS_eShopee.ViewModels.Common;
using System.Threading.Tasks;

namespace DTS_eShopee.ApiIntegration
{
    public interface IProductApiClient
    {
        Task<PagedResult<ProductViewModel>> GetPagings(GetManageProductPagingRequest request);

        Task<bool> CreateProduct(ProductCreateRequest request);

        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);

        Task<ProductViewModel> GetById(int id, string languageId);
    }
}