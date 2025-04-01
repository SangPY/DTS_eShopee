using System;
using System.Collections.Generic;
using System.Text;

namespace DTS_eShopee.Utilities.Constants
{
    public class SystemConstants
    {
        public const string MainConnectionString = "DTS_eShopeeDatabase";

        public class AppSettings
        {
            public const string DefaultLanguageId = "DefaultLanguageId";
            public const string Token = "Token";
            public const string BaseAddress = "BaseAddress";
        }

        public class ProductSettings
        {
            public const int NumberOfFeaturedProducts = 4;
        }
    }
}