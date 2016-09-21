using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingUWPCommunityToolkit.Models;
using UsingUWPCommunityToolkit.Views;

namespace UsingUWPCommunityToolkit.Services
{
    public class NavigationMenuService : INavigationMenuService
    {
        public NavigationMenuService()
        {

            _menus = ImmutableList.Create(
                new NavigationMenuItem
                {
                    Glyph = "\uE913",
                    Name = "Manage Images",
                    DestinationPage = typeof(ManageImagesPage)
                }
            );
            _options = ImmutableList.Create(
                new NavigationMenuItem
                {
                    Glyph = "\uE115",
                    Name = "Settings",
                    DestinationPage = typeof(SettingsPage)
                }
            );
        }

        private readonly IEnumerable<NavigationMenuItem> _menus;
        private readonly IEnumerable<NavigationMenuItem> _options;
        public IEnumerable<NavigationMenuItem> GetNavigationMenus() => _menus;
        public IEnumerable<NavigationMenuItem> GetOptions() => _options;
    }
}