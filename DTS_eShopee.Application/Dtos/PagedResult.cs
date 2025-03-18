using System;
using System.Collections.Generic;
using System.Text;

namespace DTS_eShopee.Application.Dtos
{
    public class PagedResult<T>
    {
        private List<T> Items { get; set; }

        public int TotalRecord { get; set; }
    }
}