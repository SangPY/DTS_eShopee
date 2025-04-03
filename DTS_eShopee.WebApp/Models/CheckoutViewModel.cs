using DTS_eShopee.ViewModels.Sales;
using System.Collections.Generic;

namespace DTS_eShopee.WebApp.Models
{
    public class CheckoutViewModel
    {
        public List<CartItemViewModel> CartItems { get; set; }

        public CheckoutRequest CheckoutModel { get; set; }
    }
}