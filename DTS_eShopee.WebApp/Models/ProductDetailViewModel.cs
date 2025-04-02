using DTS_eShopee.ViewModels.Catalog.Categories;
using DTS_eShopee.ViewModels.Catalog.ProductImages;
using DTS_eShopee.ViewModels.Catalog.Products;
using System.Collections.Generic;

namespace DTS_eShopee.WebApp.Models
{
    public class ProductDetailViewModel
    {
        public CategoryViewModel Category { get; set; }

        public ProductViewModel Product { get; set; }

        public List<ProductViewModel> RelatedProducts { get; set; }

        public List<ProductImageViewModel> ProductImages { get; set; }
    }
}