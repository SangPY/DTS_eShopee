using System;
using System.Collections.Generic;
using System.Text;
using DTS_eShopee.ViewModels.Common;

namespace DTS_eShopee.ViewModels.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}