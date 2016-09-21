using System.Collections.Generic;
using UsingUWPCommunityToolkit.Models;

namespace UsingUWPCommunityToolkit.Services
{
    public interface INavigationMenuService
    {
        IEnumerable<NavigationMenuItem> GetNavigationMenus();
        IEnumerable<NavigationMenuItem> GetOptions();
    }
}