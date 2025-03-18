using System;
using System.Collections.Generic;
using System.Text;

namespace DTS_eShopee.Utilities
{
    public class DTSEShopeeException : Exception
    {
        public DTSEShopeeException()
        {
        }

        public DTSEShopeeException(string message)
            : base(message)
        {
        }

        public DTSEShopeeException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}