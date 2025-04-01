using DTS_eShopee.ViewModels.Catalog.Products;
using DTS_eShopee.ViewModels.Utilities.Slides;
using System.Collections.Generic;

namespace DTS_eShopee.WebApp.Models
{
    public class HomeViewModel
    {
        public List<SlideViewModel> Slides { get; set; }

        public List<ProductViewModel> FeaturedProducts { get; set; }

        public List<ProductViewModel> LatestProducts { get; set; }
    }
}