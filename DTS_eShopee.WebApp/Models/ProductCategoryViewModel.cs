using DTS_eShopee.ViewModels.Catalog.Categories;
using DTS_eShopee.ViewModels.Catalog.Products;
using DTS_eShopee.ViewModels.Common;

namespace DTS_eShopee.WebApp.Models
{
    public class ProductCategoryViewModel
    {
        public CategoryViewModel Category { get; set; }

        public PagedResult<ProductViewModel> Products { get; set; }
    }
}