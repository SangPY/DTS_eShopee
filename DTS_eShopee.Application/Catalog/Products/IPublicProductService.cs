using DTS_eShopee.ViewModels.Catalog.Products;
using DTS_eShopee.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DTS_eShopee.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        //PagedResult<ProductViewModel> GetAllByCategoryId(int categoryId, int pageIndex, int pageSize);
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}