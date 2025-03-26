using System;
using System.Collections.Generic;
using System.Text;
using DTS_eShopee.ViewModels.Common;

namespace DTS_eShopee.ViewModels.System.Users
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}