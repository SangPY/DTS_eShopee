using DTS_eShopee.ViewModels.Common;
using DTS_eShopee.ViewModels.System.Languages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DTS_eShopee.ApiIntegration
{
    public interface ILanguageApiClient
    {
        Task<ApiResult<List<LanguageViewModel>>> GetAll();
    }
}