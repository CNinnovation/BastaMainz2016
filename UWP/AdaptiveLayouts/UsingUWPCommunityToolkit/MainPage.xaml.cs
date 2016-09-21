using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UsingUWPCommunityToolkit.ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Extensions.DependencyInjection;
using UsingUWPCommunityToolkit.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UsingUWPCommunityToolkit
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            ViewModel = (Application.Current as App).Container.GetService<MainPageViewModel>();
            this.InitializeComponent();
        }

        public MainPageViewModel ViewModel { get;  }

        private void OnItemClick(object sender, ItemClickEventArgs e)
        {
            NavigationMenuItem nav = e.ClickedItem as NavigationMenuItem;
            Frame.Navigate(nav.DestinationPage);
        }

        private void OnOptionsItemClick(object sender, ItemClickEventArgs e)
        {
            NavigationMenuItem nav = e.ClickedItem as NavigationMenuItem;
        }
    }
}
