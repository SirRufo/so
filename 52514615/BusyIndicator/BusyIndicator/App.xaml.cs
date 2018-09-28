using BusyIndicator.Services.Fake;
using BusyIndicator.ViewModels;
using BusyIndicator.Views;

using System.Threading.Tasks;
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
            await Task.Yield();

            var svc = new FakeFooService();
            await svc.InitializeAsync(null);

            var mainVM = new MainViewModel(svc);
            var mainView = new MainWindow()
            {
                DataContext = mainVM,
            };
            MainWindow = mainView;
            var task = mainVM.InitializeAsync(null);
            mainView.Show();
            await task;
        }
    }
}
