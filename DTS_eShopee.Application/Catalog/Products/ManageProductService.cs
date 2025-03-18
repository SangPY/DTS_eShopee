using DTS_eShopee.Application.Catalog.Products.Dtos;
using DTS_eShopee.Application.Dtos;
using DTS_eShopee.Data.EF;
using DTS_eShopee.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DTS_eShopee.Application.Catalog.Products
{
    public class ManageProductService : IManageProductService
    {
        private readonly DTSEShopeeDbContext _context;

        public ManageProductService(DTSEShopeeDbContext context)
        {
            _context = context;
        }

        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price,
            };
            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
        }

        public Task<int> Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PagedViewModel<ProductViewModel>> GetAllPaging(string keyword, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(ProductEditRequest request)
        {
            throw new NotImplementedException();
        }
    }
}