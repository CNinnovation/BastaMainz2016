using System;

namespace UsingUWPCommunityToolkit.Models
{
    public class NavigationMenuItem
    {
        public string Glyph { get; set; }
        public string Name { get; set; }

        public Type DestinationPage { get; set; }
    }
}
