using DTS_eShopee.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTS_eShopee.Application.Catalog.Products.Dtos.Manage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public List<int> CategoryID { get; set; }
    }
}