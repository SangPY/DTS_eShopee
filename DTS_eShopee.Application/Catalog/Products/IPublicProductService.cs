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
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request);

        //Task<List<ProductViewModel>> GetAll(string languageId);
    }
}