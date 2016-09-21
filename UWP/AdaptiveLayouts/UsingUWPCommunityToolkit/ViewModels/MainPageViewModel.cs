using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingUWPCommunityToolkit.Models;
using UsingUWPCommunityToolkit.Services;

namespace UsingUWPCommunityToolkit.ViewModels
{
    public class MainPageViewModel
    {
        private readonly INavigationMenuService _navigationMenuService;
        public MainPageViewModel(INavigationMenuService navigationMenuService)
        {
            _navigationMenuService = navigationMenuService;
            Menus = _navigationMenuService.GetNavigationMenus();
            Options = _navigationMenuService.GetOptions();
        }

        public IEnumerable<NavigationMenuItem> Menus { get; }
        public IEnumerable<NavigationMenuItem> Options { get; }
    }
}
