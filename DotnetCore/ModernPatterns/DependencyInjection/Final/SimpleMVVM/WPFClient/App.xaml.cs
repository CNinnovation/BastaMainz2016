using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using PortableLibrary.Services;
using WPFClient.LocalServices;
using PortableLibrary.ViewModels;

namespace WPFClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            RegisterServices();
        }

        public void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IMessageService, WPFMessageService>();
            services.AddSingleton<IBooksService, SampleBooksService>();

            services.AddTransient<MainViewModel>();
            Container = services.BuildServiceProvider();
        }

        public IServiceProvider Container { get; private set; }
    }
}
