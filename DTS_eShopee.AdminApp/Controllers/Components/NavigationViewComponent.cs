using DTS_eShopee.Utilities.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DTS_eShopee.AdminApp.Services;
using DTS_eShopee.AdminApp.Models;
using System.Threading.Tasks;

namespace DTS_eShopee.AdminApp.Controllers.Components
{
    public class NavigationViewComponent : ViewComponent
    {
        private readonly ILanguageApiClient _languageApiClient;

        public NavigationViewComponent(ILanguageApiClient languageApiClient)
        {
            _languageApiClient = languageApiClient;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var languages = await _languageApiClient.GetAll();
            var navigationViewModel = new NavigationViewModel()
            {
                Languages = languages.ResultObj,
                CurrentLanguageId = HttpContext.Session.GetString(SystemConstants.AppSettings.DefaultLanguageId)
            };

            return View("Default", navigationViewModel);
        }
    }
}