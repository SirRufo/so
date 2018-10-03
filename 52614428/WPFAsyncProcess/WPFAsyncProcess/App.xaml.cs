using System.Windows;

namespace WPFAsyncProcess
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        private CompositionRoot _root;

        public App()
        {
            _root = new CompositionRoot(this);
            Startup += App_Startup;
        }

        private async void App_Startup(object sender, StartupEventArgs e)
        {
            await _root.InitializeAsync();
        }
    }
}
