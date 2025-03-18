using DTS_eShopee.Application.Catalog.Products.Dtos;
using DTS_eShopee.Application.Catalog.Products.Dtos.Public;
using DTS_eShopee.Application.Dtos;
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