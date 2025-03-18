using System;
using System.Collections.Generic;
using System.Text;
using DTS_eShopee.Application.Dtos;

namespace DTS_eShopee.Application.Catalog.Products.Dtos.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}