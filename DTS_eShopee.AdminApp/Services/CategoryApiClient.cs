using DTS_eShopee.ViewModels.Catalog.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DTS_eShopee.AdminApp.Services
{
    public class CategoryApiClient : BaseApiClient, ICategoryApiClient
    {
        public CategoryApiClient(IHttpClientFactory httpClientFactory,
                    IHttpContextAccessor httpContextAccessor,
                     IConfiguration configuration)
             : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<List<CategoryViewModel>> GetAll(string languageId)
        {
            return await GetListAsync<CategoryViewModel>("/api/categories?languageId=" + languageId);
        }
    }
}
