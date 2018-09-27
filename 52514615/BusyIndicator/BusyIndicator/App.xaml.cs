using BusyIndicator.Services.Fake;
using BusyIndicator.ViewModels;
using BusyIndicator.Views;

using System.Windows;

namespace BusyIndicator
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
            var svc = new FakeFooService();
            var mainVM = new MainViewModel(svc);
            var mainView = new MainWindow()
            {
                DataContext = mainVM,
            };
            MainWindow = mainView;
            mainView.Show();
            await mainVM.InitializeAsync(null);
        }
    }
}
