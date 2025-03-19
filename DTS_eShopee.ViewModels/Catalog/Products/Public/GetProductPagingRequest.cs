using System;
using System.Collections.Generic;
using System.Text;
using DTS_eShopee.ViewModels.Common;

namespace DTS_eShopee.ViewModels.Catalog.Products.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}