using DTS_eShopee.ViewModels.System.Languages;
using System.Collections.Generic;

namespace DTS_eShopee.AdminApp.Models
{
    public class NavigationViewModel
    {
        public List<LanguageViewModel> Languages { get; set; }

        public string CurrentLanguageId { get; set; }
    }
}