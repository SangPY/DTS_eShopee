using DTS_eShopee.ViewModels.System.Languages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace DTS_eShopee.AdminApp.Models
{
    public class NavigationViewModel
    {
        //public List<LanguageViewModel> Languages { get; set; }
        public List<SelectListItem> Languages { get; set; }

        public string CurrentLanguageId { get; set; }

        public string ReturnUrl { set; get; }
    }
}