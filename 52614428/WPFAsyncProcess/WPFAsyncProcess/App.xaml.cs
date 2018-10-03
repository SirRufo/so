using System.Threading.Tasks;
using System.Windows;

using WPFAsyncProcess.ViewModels;
using WPFAsyncProcess.Views;

namespace WPFAsyncProcess
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
            var mainVM = new MainViewModel();
            var mainView = new MainWindow
            {
                DataContext = mainVM,
            };
            MainWindow = mainView;

            await Task.Yield();

            mainView.Show();
            await mainVM.InitializeAsync(null);
        }
    }
}
