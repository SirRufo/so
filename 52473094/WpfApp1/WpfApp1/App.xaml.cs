﻿using System.Windows;

using WpfApp1.DataServices;
using WpfApp1.DataServices.Impl;
using WpfApp1.ViewModels;

namespace WpfApp1
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Startup += App_Startup;
        }

        private async void App_Startup(object sender, StartupEventArgs e)
        {
            IUnitDataService svc = new FakeUnitDataService();
            var vm = new MainViewModel(svc);
            MainWindow = new Views.MainWindow()
            {
                DataContext = vm,
            };
            MainWindow.Show();
            await vm.InitializeAsync(null);
        }
    }
}
