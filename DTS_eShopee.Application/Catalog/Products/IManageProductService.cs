using DTS_eShopee.ViewModels.Catalog.Products;
using DTS_eShopee.ViewModels.Catalog.Products.Manage;
using DTS_eShopee.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DTS_eShopee.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<bool> UpdatePrice(int productId, decimal newpPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task<int> Delete(int productId);

        Task<List<ProductViewModel>> GetAll();

        Task AddViewcount(int productId);

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
    }
}