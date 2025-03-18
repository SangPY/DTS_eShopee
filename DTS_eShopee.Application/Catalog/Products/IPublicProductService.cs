using DTS_eShopee.Application.Catalog.Products.Dtos.Manage;
using DTS_eShopee.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTS_eShopee.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PagedResult<ProductViewModel> GetAllByCategoryId(int categoryId, int pageIndex, int pageSize);
    }
}